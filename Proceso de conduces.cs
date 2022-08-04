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
    public partial class Proceso_de_conduces : Form
    {
        public Proceso_de_conduces()
        {
            InitializeComponent();
        }
        ConexionSQL cnn = new ConexionSQL();
        int id_usuario = 0;
        String instruccion_sql;
        bool EquipoServicio = false;

        private void Proceso_de_conduces_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewClientes();
            LlenarDataGridViewEquipos();
            this.gbxBuscarCliente.Visible = false;
            this.gbxEquipo.Visible = false;
            try
            {
                cbxEmpleado.DataSource = cnn.LllenarComboBox("Empleados");
                cbxEmpleado.DisplayMember = "Nombre_Empleado";
                cbxEmpleado.ValueMember = "Id_Empleado";
                cbxEmpleado.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            ObtenerUsuario();

        }

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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.gbxBuscarCliente.Visible = true;
            this.txtBusquedaClientes.Text = "";
            this.txtBusquedaClientes.Focus();
        }
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
        *          Funcion para buscar secuencia de comprobantes fiscales              *
        ********************************************************************************/
        private void BuscarEmpleado()
        {
            try
            {
                SqlDataReader LectorSecuencia;

                cnn.cn.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = cnn.cn;
                Comando.CommandText = "Select * From Empleados where Id_Empleado=" + cbxEmpleado.SelectedValue;
                LectorSecuencia = Comando.ExecuteReader();


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
                cnn.consultar("Select Id_Equipo_servicio AS [ID Equipo], Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios Where Disponibilidad_Equipo = 1", "Equipos_servcios");
                dgvEquipo.DataSource = cnn.ds.Tables["Equipos_servcios"];
                dgvEquipo.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                txtDecrip.Text = "";
                txtCanitdad.Text = "0";

            }
        }

        private void Limpiar()
        {
            LimpiarCliente();
            LimpiarEquipo();

            dgvDetalleFactura.Rows.Clear();
            cbxEmpleado.SelectedIndex = 1;



        }
        /********************************************************************************
        *              Funcion para Limpiar los objetos del producto                   *
        ********************************************************************************/
        private void LimpiarEquipo()
        {
            txtIdEqui.Text = txtDecrip.Text = "";
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

        private void txtCanitdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
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

        /********************************************************************************
        *              Funcion para Buscar el Ultimo Usuario Logueado                  *
        ********************************************************************************/

        private bool ObtenerEquipoServicio(int IdEquipoSevicio)
        {
            try
            {
                SqlDataReader LectorHistorial;  // para leer en la base de datos
                cnn.cn.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = cnn.cn;
                Comando.CommandText = "Select Equipo_Servicio from Equipos_servcios Where Id_Equipo_Servicio = " + IdEquipoSevicio;
                LectorHistorial = Comando.ExecuteReader();
                if (LectorHistorial.Read() == true)
                {
                    EquipoServicio = LectorHistorial.GetBoolean(0);
                    cnn.cn.Close();
                }
                else
                {
                    MessageBox.Show("No Data");
                }
                return EquipoServicio;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return EquipoServicio;
            }
            finally
            {
                cnn.cn.Close();
            }
        }

        /********************************************************************************
       *              Funcion para Buscar el Numero de Factura Insertado              *
       ********************************************************************************/

        public int ObtenerNumeroConduce()
        {
            try
            {
                cnn.cn.Open();
                SqlDataReader LectorFacturas;
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = cnn.cn;
                Comando.CommandText = "Select Max(Id_Conduce) as Conduce_Actual From conduces";
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
                MessageBox.Show(error.Message, "Aviso - ObtenerNumeroConduce ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return 0;
            }
            finally
            {
                cnn.cn.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Declaramos las variables para los calculos
            
           
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
            else if(cbxEmpleado.SelectedIndex < 0)
            {
                MessageBox.Show("Debe indicar el empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxEmpleado.Focus();
                return;
            }
            
            //Agregamos al DatagridView los datos del producto
            dgvDetalleFactura.Rows.Add(txtIdEqui.Text, txtDecrip.Text.Trim(), txtCanitdad.Text, cbxEmpleado.SelectedValue);

            LimpiarEquipo();

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
                    
                    //Eliminamos la fila
                    dgvDetalleFactura.Rows.RemoveAt(fila);


                }
            }
        }

        private void btnNuevaCond_Click(object sender, EventArgs e)
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

        private void cbxEmpleado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void btnPocesarConduce_Click(object sender, EventArgs e)
        {
            if (dgvDetalleFactura.Rows.Count < 1)
            {
                MessageBox.Show("Debe indicar al menos un servicio/equipo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                int NumeroConduce;

                //Guardamos en la tabla de Factura
                string sql = "insert into conduces (Fecha_Conduce, Id_Cliente,Id_Usuario)" + " values ('" + DateTime.Now.ToShortDateString() + "', '" + txtIdCliente.Text.Trim() + "','" + id_usuario + "')";
                try
                {
                    cnn.insertar(sql);
                    NumeroConduce = ObtenerNumeroConduce();
                    if (NumeroConduce == 0)
                    {
                        MessageBox.Show("Error al Procesar Conduce", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso - Conduce", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }

                //Guardamos en la tabla detalle de Factura y actualizamos el inventario
                try
                {
                    foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
                    {
                        //Insertamos lo registros en la tabla de Detalles
                        sql = "insert into Detalle_Conduces (Id_Conduce, Id_Equipo, Cantidad_Horas, Id_Empleado) values ('" + NumeroConduce + "' , " + fila.Cells[0].Value.ToString() + ", " + fila.Cells[2].Value.ToString() + ", " + fila.Cells[3].Value.ToString() + ")";
                        try
                        {
                            cnn.insertar(sql);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso - Detalle_Conduce", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        }
                        ObtenerEquipoServicio(int.Parse(fila.Cells[0].Value.ToString()));
                        if (!EquipoServicio)
                        {
                            //Actualizamos el Inventario
                            string campos = "Disponibilidad_Equipo = '0'";
                            string tabla = "Equipos_servcios";
                            string condicion = " Id_Equipo_servicio =" + fila.Cells[0].Value.ToString() + "";

                            try
                            {
                                cnn.actualizar(tabla, campos, condicion);
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso - Disponibilidad_Equipo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                return; 
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                
              
                MessageBox.Show("Conduce Procesado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                Proceso_de_conduces_Load(null, null);



            }
        }
    }
}
