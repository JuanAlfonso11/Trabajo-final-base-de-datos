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
using System.Runtime.CompilerServices;

namespace Trabajo_final
{
    public partial class Proceso_compras : Form
    {
        public Proceso_compras()
        {
            InitializeComponent();
        }

        private void Proceso_compras_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewEquipos();
            LlenarDataGridViewSuplidores();
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
            lblcantidadsubtotal.Text = lblcantidaditbis.Text = lblcantidadDescuento.Text = lbltotalcompra.Text = String.Format("{0:C}", 0).ToString();
            ObtenerUsuario();

            this.gbxbuscarEquipo.Visible = false;
            this.gbxbuscarSuplidor.Visible = false;
        }

        ConexionSQL cnn = new ConexionSQL();
        double subtotales = 0;
        double total = 0;
        double itbiss = 0;
        double descuentos = 0;
        string instruccion_sql;
        int secuencia_ncf = 0;
        int secuencia_facturas = 0;
        int id_usuario = 0;
        bool paga_itbis;

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
                Comando.CommandText = "Select Id_Equipo_servicio AS [ID Equipo], Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios where Id_Equipo_servicio=" + txtID.Text;
                LectorEquipo = Comando.ExecuteReader();
                if (LectorEquipo.Read() == true)
                {
                    txtdescripcion.Text = LectorEquipo.GetString(1);
                    txtprecio.Text = LectorEquipo.GetSqlMoney(2).ToString();
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
        private void BuscarSuplidor()
        {
            try
            {
                SqlDataReader LectorSuplidores;

                cnn.cn.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = cnn.cn;
                Comando.CommandText = "Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Id_Suplidor=" + txtIDsuplidor.Text;
                LectorSuplidores = Comando.ExecuteReader();

                if (LectorSuplidores.Read() == true)
                {
                    txtnombreSuplidor.Text = LectorSuplidores.GetString(1);
                    txtTelefono.Text = LectorSuplidores.GetString(3);
                    txtdireccion.Text = LectorSuplidores.GetString(6);
                    txtTelefono.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("No existe un registro con este codigo, verifique y trate de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                LectorSuplidores.Close();
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

        //secuencia de comprobantes fiscales

        //secuencia de facturas

        /********************************************************************************
         *              Funcion para Mostrar en el Grid todos los productos             *
         ********************************************************************************/
        private void LlenarDataGridViewEquipos()
        {
            try
            {
                cnn.consultar("Select Id_Equipo_servicio AS [ID Equipo], Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios", "Equipos_servcios");
                dgvEquipos.DataSource = cnn.ds.Tables["Equipos_servcios"];
                dgvEquipos.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /********************************************************************************
         *              Funcion para Mostrar en el Grid todos los Clientes              *
         ********************************************************************************/
        private void LlenarDataGridViewSuplidores()
        {
            try
            {
                cnn.consultar("Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores", "Suplidores");
                dgvsuplidores.DataSource = cnn.ds.Tables["Suplidores"];
                dgvsuplidores.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgvEquipos_Click(object sender, EventArgs e)
        {
            if (dgvEquipos[0, dgvEquipos.SelectedCells[0].RowIndex].Value.ToString() != "")
            {
                txtID.Text = dgvEquipos[0, dgvEquipos.SelectedCells[0].RowIndex].Value.ToString();
                gbxbuscarEquipo.Visible = false;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 3)
            {
                BuscarEquipo();
            }
            else
            {
                txtdescripcion.Text = txtprecio.Text = txtdescuento.Text = "";
                txtCantidad.Text = "0";
            }
        }

        private void dgvsuplidores_Click(object sender, EventArgs e)
        {
            if (dgvsuplidores[0, dgvsuplidores.SelectedCells[0].RowIndex].Value.ToString() != "")
            {
                txtIDsuplidor.Text = dgvsuplidores[0, dgvsuplidores.SelectedCells[0].RowIndex].Value.ToString();
                gbxbuscarSuplidor.Visible = false;
            }
        }

        private void txtIDsuplidor_TextChanged(object sender, EventArgs e)
        {
            if (txtIDsuplidor.Text.Length >= 3)
            {
                BuscarSuplidor();
            }
            else
            {
                txtnombreSuplidor.Text = txtdireccion.Text = txtTelefono.Text = "";
                txtTelefono.ReadOnly = false;
            }
        }

        /********************************************************************************
         *              Funcion para Limpiar los objetos del producto                   *
         ********************************************************************************/
        private void LimpiarEquipo()
        {
            txtID.Text = txtdescripcion.Text = txtprecio.Text = txtdescuento.Text = "";
            txtCantidad.Text = "0";
        }
        /********************************************************************************
         *                       Funcion para Limpiar los objetos del cliente           *
         ********************************************************************************/
        private void LimpiarSuplidor()
        {
            txtIDsuplidor.Text = txtnombreSuplidor.Text = txtdireccion.Text = txtTelefono.Text = "";
        }

        /********************************************************************************
         *                    Funcion para Limpiar todos los objetos                    *
         ********************************************************************************/
        private void Limpiar()
        {
            LimpiarSuplidor();
            LimpiarEquipo();
            txtFactura.Text = txtncf.Text = "";
            dgvdetalles.Rows.Clear();
            cbxTipoNCF.SelectedIndex = 1;
            rdbcontado.Checked = true;

            subtotales = total = itbiss = descuentos = 0;
            lblcantidadsubtotal.Text = lblcantidaditbis.Text = lblcantidadDescuento.Text = lbltotalcompra.Text = String.Format("{0:C}", 0).ToString();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbuscarSuplidor_Click(object sender, EventArgs e)
        {
            this.gbxbuscarSuplidor.Visible = true;
            this.txtBuscarSuplidor.Text = "";
            this.txtBuscarSuplidor.Focus();
        }

        private void btnbuscarEquipo_Click(object sender, EventArgs e)
        {
            this.gbxbuscarEquipo.Visible = true;
            this.txtBuscarEquipo.Text = "";
            this.txtBuscarEquipo.Focus();
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

        /********************************************************************************
         *                     ValidarCamposNumericosDecimales()                        *
         *                                     -                                        *
         *    Metodo que permite validar si la tecla pulsada es un numero/punto o no    *
         ********************************************************************************/
        private bool ValidarCamposNumericosDecimales(char caracter)
        {
            if ((caracter >= 48 && caracter <= 57) || (caracter == 8) || caracter == 46)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void txtIDsuplidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        private void txtdescuento_KeyPress(object sender, KeyPressEventArgs e)
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
                Comando.CommandText = "Select Max(Id_Compra) From Compras";
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
            if (txtID.Text == "")
            {
                MessageBox.Show("Debe seleccionar un equipo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
            }
            else if (txtCantidad.Text == "" || txtCantidad.Text == "0")
            {
                MessageBox.Show("Debe indicar la cantidad a facturar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
            }

            //obtenemos la cantidad y el precio del producto a insertar
            cantidad = int.Parse(txtCantidad.Text.Trim());
            precio = double.Parse(txtprecio.Text.Trim());

            //si el producto tiene descuento obtenemos el total a descontar
            if (txtdescuento.Text.Length > 0)
            {
                descuento_Equipo = cantidad * precio * (double.Parse(txtdescuento.Text.Trim()) / 100);
            }

            //obtenemos el subtotal
            subtotal_Equipo = cantidad * precio - descuento_Equipo;

            //obtenemos el ITBIS del producto
            itbis_Equipo = subtotal_Equipo * 0.18;

            //obtenemos el importe del producto
            importe_Equipo = subtotal_Equipo - itbis_Equipo;

            //Agregamos al DatagridView los datos del producto
            dgvdetalles.Rows.Add(txtID.Text, txtdescripcion.Text.Trim(), txtCantidad.Text, txtprecio.Text, String.Format("{0:0.00}", importe_Equipo), String.Format("{0:0.00}", itbis_Equipo), String.Format("{0:0.00}", descuento_Equipo), String.Format("{0:0.00}", subtotal_Equipo));

            LimpiarEquipo();

            //Actualizamos los variables de los totales 
            subtotales = subtotales + importe_Equipo;
            itbiss = itbiss + itbis_Equipo;
            descuentos = descuentos + descuento_Equipo;
            total = total + importe_Equipo + subtotal_Equipo;

            //Actualizamos las etiquetas del GroupBox Totales
            lblcantidadsubtotal.Text = String.Format("{0:C}", subtotales).ToString();
            lblcantidaditbis.Text = String.Format("{0:C}", itbiss).ToString();
            lblcantidadDescuento.Text = String.Format("{0:C}", descuentos).ToString();
            lbltotalcompra.Text = String.Format("{0:C}", total).ToString();
        }

        private void dgvdetalles_DoubleClick(object sender, EventArgs e)
        {
            int fila = dgvdetalles.CurrentRow.Index;
            if (dgvdetalles.Rows.Count >= 1)
            {
                //Obtenemos los valores de la fila a eliminar
                int id_Equipo = int.Parse(dgvdetalles[0, fila].Value.ToString());
                int cantidad_Equipo = int.Parse(dgvdetalles[2, fila].Value.ToString());
                double precio_Equipo = double.Parse(dgvdetalles[3, fila].Value.ToString());
                double importe_Equipo = double.Parse(dgvdetalles[4, fila].Value.ToString());
                double itbis_Equipo = double.Parse(dgvdetalles[5, fila].Value.ToString());
                double descuento_Equipo = double.Parse(dgvdetalles[6, fila].Value.ToString());
                double subtotal_Equipo = double.Parse(dgvdetalles[7, fila].Value.ToString());

                //Asignamos los valores a los cuadros de texto correspondinetes
                txtID.Text = id_Equipo.ToString();
                txtCantidad.Text = cantidad_Equipo.ToString();
                txtdescuento.Text = (descuento_Equipo / (cantidad_Equipo * precio_Equipo) * 10).ToString();



                //Restamos estos valores a las variables globales
                subtotales = subtotales - importe_Equipo;
                itbiss = itbiss - itbis_Equipo;
                descuentos = descuentos - descuento_Equipo;
                total = total - subtotal_Equipo;



                //Imprimimos el resultado en los labels correspondientes
                lblcantidadsubtotal.Text = String.Format("{0:C}", subtotal).ToString();
                lblcantidaditbis.Text = String.Format("{0:C}", itbis).ToString();
                lblcantidadDescuento.Text = String.Format("{0:C}", descuento).ToString();
                lbltotalcompra.Text = String.Format("{0:C}", total).ToString();

                //Eliminamos la fila
                dgvdetalles.Rows.RemoveAt(fila);
            }
        }

        private void txtBuscarSuplidor_TextChanged(object sender, EventArgs e)
        {
            if (rdbIdSuplidor.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Id_Suplidor like '%" + txtBuscarSuplidor.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Suplidores");
                    dgvsuplidores.DataSource = cnn.ds.Tables["Suplidores"];
                    dgvsuplidores.Refresh();
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
                    instruccion_sql = "Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Nombre_Suplidor like '%" + txtBuscarSuplidor.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Suplidores");
                    dgvsuplidores.DataSource = cnn.ds.Tables["Suplidores"];
                    dgvsuplidores.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbtelefono.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Telefono_Suplidor like '%" + txtBuscarSuplidor.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Suplidores");
                    dgvsuplidores.DataSource = cnn.ds.Tables["Suplidores"];
                    dgvsuplidores.Refresh();
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
                    instruccion_sql = "Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Direccion_Suplidor like '%" + txtBuscarSuplidor.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Suplidores");
                    dgvsuplidores.DataSource = cnn.ds.Tables["Suplidores"];
                    dgvsuplidores.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbRNC.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where RNC_Suplidor like '%" + txtBuscarSuplidor.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Suplidores");
                    dgvsuplidores.DataSource = cnn.ds.Tables["Suplidores"];
                    dgvsuplidores.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void txtBuscarEquipo_TextChanged(object sender, EventArgs e)
        {
            if (rdbidEquipo.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Equipo_servicio AS [ID Equipo], Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios where Id_Equipo_servicio like '%" + txtBuscarEquipo.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Equipos_servcios");
                    dgvEquipos.DataSource = cnn.ds.Tables["Equipos_servcios"];
                    dgvEquipos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbdescripcion.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Equipo_servicio AS [ID Equipo], Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios where Descripcion_Equipo like '%" + txtBuscarEquipo.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Equipos_servcios");
                    dgvEquipos.DataSource = cnn.ds.Tables["Equipos_servcios"];
                    dgvEquipos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbTipo.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Equipo_servicio AS [ID Equipo], Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios where tipo_Equipo like '%" + txtBuscarEquipo.Text.Trim() + "%'";
                    cnn.consultar(instruccion_sql, "Equipos_servcios");
                    dgvEquipos.DataSource = cnn.ds.Tables["Equipos_servcios"];
                    dgvEquipos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void rdbIdSuplidor_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBuscarSuplidor.Text = "";
            this.txtBuscarSuplidor.Focus();
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBuscarSuplidor.Text = "";
            this.txtBuscarSuplidor.Focus();
        }

        private void rdbtelefono_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBuscarSuplidor.Text = "";
            this.txtBuscarSuplidor.Focus();
        }

        private void rdbRNC_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBuscarSuplidor.Text = "";
            this.txtBuscarSuplidor.Focus();
        }

        private void rdbDireccion_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBuscarSuplidor.Text = "";
            this.txtBuscarSuplidor.Focus();
        }

        private void rdbidEquipo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBuscarEquipo.Text = "";
            this.txtBuscarEquipo.Focus();
        }

        private void rdbdescripcion_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBuscarEquipo.Text = "";
            this.txtBuscarEquipo.Focus();
        }

        private void rdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBuscarEquipo.Text = "";
            this.txtBuscarEquipo.Focus();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            if (txtIDsuplidor.Text.Length > 0 || txtID.Text.Length > 0 || dgvdetalles.Rows.Count > 0)
            {
                DialogResult X = MessageBox.Show("En este momento se esta procesando una compra \n ¿Está seguro que desea cancelar este proceso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult X = MessageBox.Show("¿Está seguro que desea cancelar el Proceso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (X == DialogResult.Yes)
            {
                Limpiar();
            }
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            if (dgvdetalles.Rows.Count < 1)
            {
                MessageBox.Show("Debe indicar al menos un equipo a facturar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtIDsuplidor.Text))
            {
                MessageBox.Show("Debe indicar un suplidor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIDsuplidor.Focus();
                return;
            }
            else
            {
                //Declaramos las variables necesarias
                int Numero_Factura_Compra = 0;

                string tipo_factura_compra = "Contado";

                if (rdbcontado.Checked == true)
                {
                    tipo_factura_compra = "Contado";
                }
                if (rdbcredito.Checked == true)
                {
                    tipo_factura_compra = "Credito";
                }

                //Guardamos en la tabla de Compras
                string sql = "insert into Compras (Numero_Factura, Fecha_Compra, Id_Suplidor, Monto_Compra,Id_Usuario, Tipo_Factura_Compra, NCF_Compra, Cantidad_Compra)" + " values ('" + Numero_Factura_Compra + "', '" + DateTime.Now.ToShortDateString() + "', '" + txtIDsuplidor.Text.Trim() + "','" + total.ToString() + "','" + id_usuario + "', '" + tipo_factura_compra + "', '" + txtncf.Text.Trim() + "', '" + txtCantidad.Text.Trim() + "')";
                try
                {
                    cnn.insertar(sql);
                    Numero_Factura_Compra = ObtenerNumeroFactura();
                    if (Numero_Factura_Compra == 0)
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
                    foreach (DataGridViewRow fila in dgvdetalles.Rows)
                    {
                        //Insertamos lo registros en la tabla de Detalles
                        sql = "insert into Detalle_Compras (Id_Compra, Id_Equipo, Cantidad_Equipo,Precio_Equipo, ITBIS_Equipo, Subtotal_Equipo) values ('" + Numero_Factura_Compra + "' , " + fila.Cells[0].Value.ToString() + ", " + fila.Cells[2].Value.ToString() + ", " + fila.Cells[3].Value.ToString() + ", " + fila.Cells[5].Value.ToString() + ", " + fila.Cells[7].Value.ToString() + ")";
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
                if (rdbcredito.Checked == true)
                {
                    //Actualizamos el Inventario
                    string campos = "Balance_Suplidor = Balance_Suplidor + " + total + "";
                    string tabla = "Suplidores";
                    string condicion = " Id_Suplidor =" + txtIDsuplidor.Text + "";

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

                MessageBox.Show("Compra Registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                Proceso_compras_Load(null, null);

            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        private void Txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericosDecimales(e.KeyChar);
        }
    }
}
