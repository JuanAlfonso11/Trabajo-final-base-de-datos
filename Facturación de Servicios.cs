using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing.Printing;

namespace Trabajo_final
{
    public partial class Facturación_de_Servicios : Form
    {
        public Facturación_de_Servicios()
        {
            InitializeComponent();
        }

        private void Facturación_de_Servicios_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewClientes();
            LlenarDataGridViewEquipos();
            this.gbxBuscarCliente.Visible = false;
            this.gbxEquipo.Visible = false;
            try
            {
                cbxTipoNCF.DataSource = cnn.LllenarComboBox("Secuencias_NCF");
                cbxTipoNCF.DisplayMember = "Descripcion_NCF";
                cbxTipoNCF.ValueMember = "Id_Secuencia";
                cbxTipoNCF.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            lblSubtotal.Text = lblITBISTOTAL.Text = lblDescuentoTOTAL.Text = lblTOTALcompleto.Text = String.Format("{0:C}", 0).ToString();
            ObtenerUsuario();

            cbxTipoNCF.SelectedIndex = 1;
            cbxTipoNCF_SelectionChangeCommitted(null, null);
            rdbContado.Checked = true;
            rdbContado_CheckedChanged(null, null);



        }
        ConexionSQL cnn = new ConexionSQL();
        /********************************************************************************
         *                   Declaracion de Variables Globales                          *
         ********************************************************************************/
        double subtotal = 0;
        double total = 0;
        double itbis = 0;
        double descuento = 0;
        string instruccion_sql;
        int secuencia_ncf = 0;
        int secuencia_facturas = 0;
        int id_usuario = 0;
   
    
        /********************************************************************************
  *                       Funcion para buscar los productos                      *
         ********************************************************************************/
        private void BuscarEquipo()
        {
            try
            {
                SqlDataReader LectorEquipo;
                cnn.cn.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = cnn.cn;
                Comando.CommandText = "Select Id_Equipo_servicio AS [ID Equipo], Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios where Id_Equipo_servicio=" + txtIdEqui.Text;
                LectorEquipo = Comando.ExecuteReader();
                if (LectorEquipo.Read() == true)
                {
                    txtDecrip.Text = LectorEquipo.GetString(1);
                    txtPrecio.Text = LectorEquipo.GetSqlMoney(2).ToString();
                }
                else
                {
                    MessageBox.Show("No existe un registro con este codigo, verifique y trate de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                LectorEquipo.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            finally
            {
                cnn.cn.Close();
            }
        }

        /********************************************************************************
         *                       Funcion para buscar clientes                           *
         ********************************************************************************/
        private void BuscarCliente()
        {
            try
            {
                SqlDataReader LectorCliente;

                cnn.cn.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = cnn.cn;
                Comando.CommandText = "Select Id_Cliente AS [ID Cliente], Nombre_Cliente AS Nombre, Telefono_Cliente AS Teléfono, Celular_Cliente AS Celular, Email_Cliente AS [E-mail], Direccion_Cliente AS Dirección, Cedula_Rnc_Cliente AS [Cédula/RNC], Balance_Cliente AS Balance From Clientes where Id_Cliente=" + txtIdCliente.Text;
                LectorCliente = Comando.ExecuteReader();

                if (LectorCliente.Read() == true)
                {
                    txtNombre.Text = LectorCliente.GetString(1);
                    txtDireccion.Text = LectorCliente.GetString(5);
                    txtTelefono.Text = LectorCliente.GetString(3);
                    txtTelefono.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("No existe un registro con este codigo, verifique y trate de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                LectorCliente.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            finally
            {
                cnn.cn.Close();
            }
        }

        /********************************************************************************
         *          Funcion para buscar secuencia de comprobantes fiscales              *
         ********************************************************************************/
        private void BuscarSecuenciaNCF()
        {
            try
            {
                SqlDataReader LectorSecuencia;

                cnn.cn.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = cnn.cn;
                Comando.CommandText = "Select * From Secuencias_NCF where Id_Secuencia=" + cbxTipoNCF.SelectedValue;
                LectorSecuencia = Comando.ExecuteReader();

                if (LectorSecuencia.Read() == true)
                {

                    txtNCF.Text = LectorSecuencia.GetString(2);
                    secuencia_ncf = LectorSecuencia.GetInt32(3) + 1;
                    txtNCF.Text = txtNCF.Text + secuencia_ncf.ToString("00000000");
                }
                else
                {
                    MessageBox.Show("No existe un registro con este codigo, verifique y trate de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                LectorSecuencia.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            finally
            {
                cnn.cn.Close();
            }
        }


        /********************************************************************************
          *               Funcion para buscar secuencia de facturas                      *
          ********************************************************************************/
        private void BuscarSecuenciaFacturas(int secuencia)
        {
            try
            {
                SqlDataReader LectorSecuenciaFacturas;

                cnn.cn.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = cnn.cn;
                Comando.CommandText = "Select * From Secuencias_Facturas where Id_Secuencia=" + secuencia;
                LectorSecuenciaFacturas = Comando.ExecuteReader();

                if (LectorSecuenciaFacturas.Read() == true)
                {
                    if (secuencia == 1)
                    {
                        secuencia_facturas = LectorSecuenciaFacturas.GetInt32(2) + 1;
                        txtFactura.Text = secuencia_facturas.ToString("CR00000000");
                    }
                    if (secuencia == 2)
                    {
                        secuencia_facturas = LectorSecuenciaFacturas.GetInt32(2) + 1;
                        txtFactura.Text = secuencia_facturas.ToString("CN00000000");
                    }
                }
                else
                {
                    MessageBox.Show("No existe un registro con este codigo, verifique y trate de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                LectorSecuenciaFacturas.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            finally
            {
                cnn.cn.Close();
            }
        }

        /********************************************************************************
         *              Funcion para Mostrar en el Grid todos los productos             *
         ********************************************************************************/
        private void LlenarDataGridViewEquipos()
        {
            try
            {
                cnn.consultar("Select Id_Equipo_servicio AS [ID Equipo], Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios", "Equipos_servcios");
                dgvEquipo.DataSource = cnn.ds.Tables["Equipos_servcios"];
                dgvEquipo.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        /********************************************************************************
         *              Funcion para Mostrar en el Grid todos los Clientes              *
         ********************************************************************************/
        private void LlenarDataGridViewClientes()
        {
            try
            {
                cnn.consultar("Select Id_Cliente AS [ID Cliente], Nombre_Cliente AS Nombre, Telefono_Cliente AS Teléfono, Celular_Cliente AS Celular, Email_Cliente AS [E-mail], Direccion_Cliente AS Dirección, Cedula_Rnc_Cliente AS [Cédula/RNC], Balance_Cliente AS Balance From Clientes", "Clientes");
                dgvClientes.DataSource = cnn.ds.Tables["Clientes"];
                dgvClientes.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgvEquipo_Click(object sender, EventArgs e)
        {

            if (dgvEquipo[0, dgvEquipo.SelectedCells[0].RowIndex].Value.ToString() != "")
            {
                txtIdEqui.Text = dgvEquipo[0, dgvEquipo.SelectedCells[0].RowIndex].Value.ToString();
                gbxEquipo.Visible = false;
            }

        }

        private void txtIdEqui_TextChanged(object sender, EventArgs e)
        {
            if (txtIdEqui.Text.Length >= 3)
            {
                BuscarEquipo();
            }
            else
            {
                txtDecrip.Text = txtPrecio.Text = txtDescuento.Text = "";
                txtCanitdad.Text = "0";

            }

        }

        private void dgvClientes_Click(object sender, EventArgs e)
        {
            if (dgvClientes[0, dgvClientes.SelectedCells[0].RowIndex].Value.ToString() != "")
            {
                txtIdCliente.Text = dgvClientes[0, dgvClientes.SelectedCells[0].RowIndex].Value.ToString();
                gbxBuscarCliente.Visible = false;
            }
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length >= 3)
            {
                BuscarCliente();
            }
            else
            {
                txtNombre.Text = txtDireccion.Text = txtTelefono.Text = "";
                txtTelefono.ReadOnly = false;
            }

        }
        /********************************************************************************
 *                    Funcion para Limpiar todos los objetos                    *
 ********************************************************************************/
        private void Limpiar()
        {
            LimpiarCliente();
            LimpiarEquipo();

            dgvDetalleFactura.Rows.Clear();
            cbxTipoNCF.SelectedIndex = 1;
            rdbContado.Checked = true;

            subtotal = total = itbis = descuento = 0;
            lblSubtotal.Text = lblITBISTOTAL.Text = lblDescuentoTOTAL.Text = lblTOTALcompleto.Text = String.Format("{0:C}", 0).ToString();
        }
        /********************************************************************************
         *              Funcion para Limpiar los objetos del producto                   *
         ********************************************************************************/
        private void LimpiarEquipo()
        {
            txtIdEqui.Text = txtDecrip.Text = txtPrecio.Text = txtDescuento.Text = "";
            txtCanitdad.Text = "0";
        }
        /********************************************************************************
         *                       Funcion para Limpiar los objetos del cliente           *
         ********************************************************************************/
        private void LimpiarCliente()
        {
            txtIdCliente.Text = txtNombre.Text = txtDireccion.Text = txtTelefono.Text = "";
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.gbxBuscarCliente.Visible = true;
            this.txtBusquedaClientes.Text = "";
            this.txtBusquedaClientes.Focus();

        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            gbxEquipo.Visible = true;
            txtBusquedaEquipo.Text = "";
            txtBusquedaEquipo.Focus();

        }
        private bool ValidarCamposNumericos(char caracter)
        {
            if ((caracter >= 48 && caracter <= 57) || (caracter == 8))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        private void txtIdEqui_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        /********************************************************************************
         *              Funcion para Buscar el Numero de Factura Insertado              *
         ********************************************************************************/

        public int ObtenerNumeroFactura()
        {
            try
            {
                cnn.cn.Open();
                SqlDataReader LectorFacturas;
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = cnn.cn;
                Comando.CommandText = "Select Max(Id_Factura) as Factura_Actual From Facturas";
                LectorFacturas = Comando.ExecuteReader();
                if (LectorFacturas.Read() == true)
                {
                    return LectorFacturas.GetInt32(0);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return 0;
            }
            finally
            {
                cnn.cn.Close();
            }
        }

        /********************************************************************************
         *              Funcion para Buscar el Ultimo Usuario Logueado                  *
         ********************************************************************************/

        private void ObtenerUsuario()
        {
            try
            {
                SqlDataReader LectorHistorial;  // para leer en la base de datos
                cnn.cn.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = cnn.cn;
                Comando.CommandText = "Select Id_Usuarios,Nombre_Usuario From Usuarios Where Id_Usuarios = (select id_usuario from Historial_Acceso_Usuario Where Fecha_Acceso= (SELECT Max(Fecha_Acceso) From Historial_Acceso_Usuario))";
                LectorHistorial = Comando.ExecuteReader();
                if (LectorHistorial.Read() == true)
                {
                    id_usuario = LectorHistorial.GetInt32(0);
                    lblusuario.Text = LectorHistorial.GetString(1);
                    cnn.cn.Close();
                }
                else
                {
                    MessageBox.Show("No Data");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            finally
            {
                cnn.cn.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Declaramos las variables para los calculos
            double cantidad = 0;
            double precio = 0;
            double descuento_Equipo = 0;
            double importe_Equipo = 0;
            double itbis_Equipo = 0;
            double subtotal_Equipo = 0;
            if (txtIdEqui.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCanitdad.Focus();
                return;
            }
            else if (txtCanitdad.Text == "" || txtCanitdad.Text == "0")
            {
                MessageBox.Show("Debe indicar la cantidad a facturar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCanitdad.Focus();
                return;
            }
            //else
            //{
            //    //Verificamos que la cantidad a facturar no supere la existencia
            //    SqlDataReader LectorArticulos;
            //    cnn.cn.Open();
            //    SqlCommand Comando = new SqlCommand();
            //    Comando.Connection = cnn.cn;
            //    Comando.CommandText = "Select Cantida_Equipo From Equipos_servcios where Id_Equipo_servicio=" + txtIdEqui.Text;
            //    LectorArticulos = Comando.ExecuteReader();
            //    try
            //    {
            //        if (LectorArticulos.Read() == true && LectorArticulos.GetInt32(0) < Convert.ToInt64(txtCanitdad.Text))
            //        {
            //            MessageBox.Show("No se puede facturar más de la existencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //            LectorArticulos.Close();
            //            cnn.cn.Close();
            //            txtCanitdad.Text = "";
            //            txtCanitdad.BackColor = Color.MistyRose;
            //            txtCanitdad.Focus();
            //            return;
            //        }
            //    }
            //    catch (Exception Error)
            //    {
            //        MessageBox.Show("Ha ocurrido un error" + Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //        return;
            //    }
            //    finally
            //    {
            //        cnn.cn.Close();
            //    }
            //}


            //obtenemos la cantidad y el precio del producto a insertar
            cantidad = int.Parse(txtCanitdad.Text.Trim());
            precio = double.Parse(txtPrecio.Text.Trim());

            //si el producto tiene descuento obtenemos el total a descontar
            if (txtDescuento.Text.Length > 0)
            {
                descuento_Equipo = cantidad * precio * (double.Parse(txtDescuento.Text.Trim()) / 100);
            }

            //obtenemos el subtotal
            subtotal_Equipo = cantidad * precio - descuento_Equipo;

            //obtenemos el ITBIS del producto
            
            
                itbis_Equipo = subtotal_Equipo * 0.18;
            

            //obtenemos el importe del producto
            importe_Equipo = subtotal_Equipo - itbis_Equipo;

            //Agregamos al DatagridView los datos del producto
            dgvDetalleFactura.Rows.Add(txtIdEqui.Text, txtDecrip.Text.Trim(), txtCanitdad.Text, txtPrecio.Text, String.Format("{0:0.00}", importe_Equipo), String.Format("{0:0.00}", itbis_Equipo), String.Format("{0:0.00}", descuento_Equipo), String.Format("{0:0.00}", subtotal_Equipo));

            LimpiarEquipo();

            //Actualizamos los variables de los totales 
            subtotal = subtotal + importe_Equipo;
            itbis = itbis + itbis_Equipo;
            descuento = descuento + descuento_Equipo;
            total = total + importe_Equipo + subtotal_Equipo;

            //Actualizamos las etiquetas del GroupBox Totales
            lblSubtotal.Text = String.Format("{0:C}", subtotal).ToString();
            lblITBISTOTAL.Text = String.Format("{0:C}", itbis).ToString();
            lblDescuentoTOTAL.Text = String.Format("{0:C}", descuento).ToString();
            lblTOTALcompleto.Text = String.Format("{0:C}", total).ToString();

        }

        private void dgvDetalleFactura_DoubleClick(object sender, EventArgs e)
        {
            {
                int fila = dgvDetalleFactura.CurrentRow.Index;
                if (dgvDetalleFactura.Rows.Count >= 1)
                {
                    //Obtenemos los valores de la fila a eliminar
                    int id_Equipo = int.Parse(dgvDetalleFactura[0, fila].Value.ToString());
                    int cantidad_Equipo = int.Parse(dgvDetalleFactura[2, fila].Value.ToString());
                    double precio_Equipo = double.Parse(dgvDetalleFactura[3, fila].Value.ToString());
                    double importe_Equipo = double.Parse(dgvDetalleFactura[4, fila].Value.ToString());
                    double itbis_Equipo = double.Parse(dgvDetalleFactura[5, fila].Value.ToString());
                    double descuento_Equipo = double.Parse(dgvDetalleFactura[6, fila].Value.ToString());
                    double subtotal_Equipo = double.Parse(dgvDetalleFactura[7, fila].Value.ToString());
                    //Asignamos los valores a los cuadros de texto correspondinetes
                    txtIdEqui.Text = id_Equipo.ToString();
                    txtCanitdad.Text = cantidad_Equipo.ToString();
                    txtDescuento.Text = (descuento_Equipo / (cantidad_Equipo * precio_Equipo) * 10).ToString();



                    //Restamos estos valores a las variables globales
                    subtotal = subtotal - importe_Equipo;
                    itbis = itbis - itbis_Equipo;
                    descuento = descuento - descuento_Equipo;
                    total = total - subtotal_Equipo;



                    //Imprimimos el resultado en los labels correspondientes
                    lblSubtotal.Text = String.Format("{0:C}", subtotal).ToString();
                    lblITBISTOTAL.Text = String.Format("{0:C}", itbis).ToString();
                    lblDescuentoTOTAL.Text = String.Format("{0:C}", descuento).ToString();
                    lblTOTALcompleto.Text = String.Format("{0:C}", total).ToString();

                    //Eliminamos la fila
                    dgvDetalleFactura.Rows.RemoveAt(fila);


                }
            }
        }

        private void txtBusquedaClientes_TextChanged(object sender, EventArgs e)
        {
            if (rdbIdCliente.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Cliente AS [ID Cliente], Nombre_Cliente AS Nombre, Telefono_Cliente AS Teléfono, Celular_Cliente AS Celular, Email_Cliente AS [E-mail], Direccion_Cliente AS Dirección, Cedula_Rnc_Cliente AS [Cédula/RNC], Balance_Cliente AS Balance From Clientes where Id_Cliente like '%" + txtBusquedaClientes.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Clientes");
                    dgvClientes.DataSource = cnn.ds.Tables["Clientes"];
                    dgvClientes.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbNombre.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Cliente AS [ID Cliente], Nombre_Cliente AS Nombre, Telefono_Cliente AS Teléfono, Celular_Cliente AS Celular, Email_Cliente AS [E-mail], Direccion_Cliente AS Dirección, Cedula_Rnc_Cliente AS [Cédula/RNC], Balance_Cliente AS Balance From Clientes where Nombre_Cliente like '%" + txtBusquedaClientes.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Clientes");
                    dgvClientes.DataSource = cnn.ds.Tables["Clientes"];
                    dgvClientes.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbTelefono.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Cliente AS [ID Cliente], Nombre_Cliente AS Nombre, Telefono_Cliente AS Teléfono, Celular_Cliente AS Celular, Email_Cliente AS [E-mail], Direccion_Cliente AS Dirección, Cedula_Rnc_Cliente AS [Cédula/RNC], Balance_Cliente AS Balance From Clientes where Telefono_Cliente like '%" + txtBusquedaClientes.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Clientes");
                    dgvClientes.DataSource = cnn.ds.Tables["Clientes"];
                    dgvClientes.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbDireccion.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Cliente AS [ID Cliente], Nombre_Cliente AS Nombre, Telefono_Cliente AS Teléfono, Celular_Cliente AS Celular, Email_Cliente AS [E-mail], Direccion_Cliente AS Dirección, Cedula_Rnc_Cliente AS [Cédula/RNC], Balance_Cliente AS Balance From Clientes where Direccion_Cliente like '%" + txtBusquedaClientes.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Clientes");
                    dgvClientes.DataSource = cnn.ds.Tables["Clientes"];
                    dgvClientes.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }

        private void txtBusquedaEquipo_TextChanged(object sender, EventArgs e)
        {
            if (rdbEquipo.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Equipo_servicio AS [ID Equipo], Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios where Id_Equipo_servicio like '%" + txtBusquedaEquipo.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Equipos_servcios");
                    dgvEquipo.DataSource = cnn.ds.Tables["Equipos_servcios"];
                    dgvEquipo.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbDescripcion.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Equipo_servicio AS [ID Equipo], Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios where Descripcion_Equipo like '%" + txtBusquedaEquipo.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Equipos_servcios");
                    dgvEquipo.DataSource = cnn.ds.Tables["Equipos_servcios"];
                    dgvEquipo.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbtipo.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Equipo_servicio AS [ID Equipo], Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios where tipo_Equipo like '%" + txtBusquedaEquipo.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Equipos_servcios");
                    dgvEquipo.DataSource = cnn.ds.Tables["Equipos_servcios"];
                    dgvEquipo.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }


        }

        private void rdbIdCliente_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusquedaClientes.Text = "";
            this.txtBusquedaClientes.Focus();
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusquedaClientes.Text = "";
            this.txtBusquedaClientes.Focus();
        }

        private void rdbTelefono_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusquedaClientes.Text = "";
            this.txtBusquedaClientes.Focus();
        }

        private void rdbDireccion_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusquedaClientes.Text = "";
            this.txtBusquedaClientes.Focus();
        }

        private void rdbEquipo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusquedaEquipo.Text = "";
            this.txtBusquedaEquipo.Focus();
        }

        private void rdbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusquedaEquipo.Text = "";
            this.txtBusquedaEquipo.Focus();
        }

        private void rdbtipo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusquedaEquipo.Text = "";
            this.txtBusquedaEquipo.Focus();
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCredito.Checked == true)
            {
                BuscarSecuenciaFacturas(1);
            }

        }

        private void rdbContado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbContado.Checked == true)
            {
                BuscarSecuenciaFacturas(2);
            }

        }

        private void cbxTipoNCF_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarSecuenciaNCF();
        }

        private void btnNuevaFact_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length > 0 || txtIdEqui.Text.Length > 0 || dgvDetalleFactura.Rows.Count > 0)
            {
                DialogResult X = MessageBox.Show("En este momento se esta procesando una factura \n ¿Está seguro que desea cancelar este proceso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (X == DialogResult.Yes)
                {
                    Limpiar();
                }
            }
            else
            {
                Limpiar();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult X = MessageBox.Show("¿Está seguro que desea cancelar el Proceso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (X == DialogResult.Yes)
            {
                Limpiar();
            }

        }

        private void btnPocesarFactura_Click(object sender, EventArgs e)
        {
            if (dgvDetalleFactura.Rows.Count < 1)
            {
                MessageBox.Show("Debe indicar al menos un equipo a facturar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdEqui.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtIdCliente.Text))
            {
                MessageBox.Show("Debe indicar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdCliente.Focus();
                return;
            }
            else
            {
                //Declaramos las variables necesarias
                int NumeroFactura;

                string tipo_factura = "Contado";

                string fecha_vencimiento = DateTime.Now.ToShortDateString();

                if (rdbContado.Checked == true)
                {
                    fecha_vencimiento = DateTime.Now.ToShortDateString();
                }
                if (rdbCredito.Checked == true)
                {
                    fecha_vencimiento = DateTime.Now.ToShortDateString();
                }

                if (rdbContado.Checked == true)
                {
                    tipo_factura = "Contado";
                }
                if (rdbCredito.Checked == true)
                {
                    tipo_factura = "Credito";
                }

                //Guardamos en la tabla de Factura
                string sql = "insert into Facturas (Fecha_Factura, Id_Cliente,Monto_Factura,Id_Usuario,Tipo_Factura,NCF_Factura,Fecha_Vencimiento)" + " values ('" + DateTime.Now.ToShortDateString() + "', '" + txtIdCliente.Text.Trim() + "','" + total.ToString()  + "','" + id_usuario + "', '" + tipo_factura + "', '" + txtNCF.Text.Trim() + "', '" + fecha_vencimiento + "')";
                try
                {
                    cnn.insertar(sql);
                    NumeroFactura = ObtenerNumeroFactura();
                    if (NumeroFactura == 0)
                    {
                        MessageBox.Show("Error al Procesar Factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }

                //Guardamos en la tabla detalle de Factura y actualizamos el inventario
                try
                {
                    foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
                    {
                        //Insertamos lo registros en la tabla de Detalles
                        sql = "insert into Detalle_Facturas (Id_Factura, Id_Equipo, Cantidad_Equipo,Precio_Equipo, ITBIS_Equipo, Subtotal_Equipo) values ('"+ NumeroFactura + "' , " + fila.Cells[0].Value.ToString() + ", " + fila.Cells[2].Value.ToString() + ", " + fila.Cells[3].Value.ToString() + ", " + fila.Cells[5].Value.ToString() + ", " + fila.Cells[7].Value.ToString() + ")";
                        try
                        {
                            cnn.insertar(sql);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        }

                        //Actualizamos el Inventario
                        string campos = "Disponibilidad_Equipo = '1'";
                        string tabla = "Equipos_servcios";
                        string condicion = " Id_Equipo_servicio =" + fila.Cells[0].Value.ToString() + "";

                        try
                        {
                            cnn.actualizar(tabla, campos, condicion);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }

                //Si la Factura es a Credito Actualizamos el Balance del Cliente
                if (rdbCredito.Checked == true)
                {
                    //Actualizamos el Inventario
                    string campos = "Balance_Cliente = Balance_Cliente + " + total + "";
                    string tabla = "Clientes";
                    string condicion = " Id_Cliente =" + txtIdCliente.Text + "";

                    try
                    {
                        cnn.actualizar(tabla, campos, condicion);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }

                //Actualizamos la secuencia de las Facturas
                if (rdbContado.Checked == true)
                {
                    //Actualizamos el Inventario
                    string campos = "Secuencia = Secuencia + 1";
                    string tabla = "Secuencias_Facturas";
                    string condicion = " Id_Secuencia = 2";



                    try
                    {
                        cnn.actualizar(tabla, campos, condicion);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                else
                {
                    //Actualizamos el Inventario
                    string campos = "Secuencia = Secuencia + 1";
                    string tabla = "Secuencias_Facturas";
                    string condicion = " Id_Secuencia = 1";

                    try
                    {
                        cnn.actualizar(tabla, campos, condicion);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                //Actualizamos la secuencia de los NCF
                if (cbxTipoNCF.SelectedIndex >= 0)
                {
                    //Actualizamos el Inventario
                    string campos = "Secuencia = Secuencia + 1";
                    string tabla = "Secuencias_NCF";
                    string condicion = " Id_Secuencia =" + cbxTipoNCF.SelectedValue + "";
                    try
                    {
                        cnn.actualizar(tabla, campos, condicion);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }

                MessageBox.Show("Factura Procesada Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                Facturación_de_Servicios_Load(null, null);



            }
        }

        private void cbxTipoNCF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCanitdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }
    }
}
