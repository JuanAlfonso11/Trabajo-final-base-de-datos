using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trabajo_final
{
    public partial class MantenimientoEmpleados : Form
    {

        ConexionSQL conexion = new ConexionSQL();
        DataRow dr;

        private void LlenarDataGridView()
        {
            try
            {
                conexion.consultar("Select Id_Empleado AS ID, Nombre_Empleado AS Nombre , apellido_empleados as Apellidos , Telefono_Empleado AS Teléfono, Celular_Empleado AS Celular, Email_Empleado AS [E-mail], Direccion_Empleado AS Dirección From Empleados", "Empleados");
                this.dgvEmpleados.DataSource = conexion.ds.Tables["Empleados"];
                this.dgvEmpleados.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public MantenimientoEmpleados()
        {
            InitializeComponent();
            refreshdata();
        }

        private void MantenimientoEmpleados_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
            gbxListado.Visible = false;
        }

        private void BuscarRegistro()
        {
            try
            {
                //Para extraer los datos del registro seleccionado en la base de datos
                SqlDataReader LectorEmpleados;

                //Abrimos la conexion hacia la BD
                conexion.cn.Open();

                //Creamos una instruccion o comando SQL
                SqlCommand Comando = new SqlCommand();

                //Le asignamos la conexion actual
                Comando.Connection = conexion.cn;

                //Enviamos el parametro o la consulta que se desea realizar en SQL
                Comando.CommandText = "Select * From Empleados where Id_Empleado=" + this.txtID.Text;

                //Ejecutamos el comando y almacenamos el resultado en el Lector de datos.
                LectorEmpleados = Comando.ExecuteReader();

                //Si se encontró un registro, entonces mostramos los datos de este registro en el formulario.
                if (LectorEmpleados.Read() == true)
                {
                    //Asignando el valor de cada campo al objeto correspondiente
                    this.txtID.Text = LectorEmpleados.GetInt32(0).ToString();  //Text Box
                    this.txtNombre.Text = LectorEmpleados.GetString(1);
                    this.txtTelefono.Text = LectorEmpleados.GetString(2);
                    this.txtCelular.Text = LectorEmpleados.GetString(3);
                    this.txtEmail.Text = LectorEmpleados.GetString(4);
                    this.txtDireccion.Text = LectorEmpleados.GetString(5);
                    this.txtApellido.Text = LectorEmpleados.GetString(6);
                    this.cbxProvincia.SelectedItem = LectorEmpleados.GetString(7);
                    this.cbxMunicipio.SelectedItem = LectorEmpleados.GetString(8);

                    //Habilitamos el boton eliminar y el boton Guardar
                    this.btnEliminar.Enabled = true;
                    this.btnGuardar.Enabled = false;
                }
                //De lo contrario, si no se encontró ningun registro, Enviamos un mensaje al usuario.
                else
                {
                    MessageBox.Show("No existe un registro con este ID, verifique y trate de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }

                //Borramos el lector que almacena el registro, para poder utilizarlo nuevamente
                LectorEmpleados.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            finally
            {
                conexion.cn.Close();
            }
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            // Si el usuario digitó 3 o más caracteres en el txtID, ejecutamos el Metodo BuscarRegistro()
            if (txtID.Text.Length >= 3)
            {
                BuscarRegistro();
            }
            //De lo contrario, limpiamos todos los campos, excepto el txtID.
            else
            {
                this.txtNombre.Text = this.txtTelefono.Text = this.txtCelular.Text = this.txtEmail.Text = this.txtDireccion.Text = this.txtApellido.Text="";
                this.cbxProvincia.SelectedValue = 0;
                this.cbxMunicipio.SelectedValue = 0;

                //Deshabilitamos los botones guardar y eliminar
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
            }
        }

        private void HabilitarGuardar()
        {
            if (this.txtNombre.Text.Length > 0 && this.txtTelefono.MaskFull == true && this.txtCelular.MaskFull == true && this.txtEmail.Text.Length > 0 && this.txtDireccion.Text.Length > 0 && this.txtApellido.Text.Length>0 && this.cbxMunicipio.SelectedIndex >= 0 && this.cbxProvincia.SelectedIndex >= 0) 
            {
                this.btnGuardar.Enabled = true;
            }
            else
            {
                this.btnGuardar.Enabled = false;
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.rdbID.Checked == true)
            {
                try
                {
                    string SQL = "Select * From Empleados where Id_Empleado like '%" + this.txtBuscar.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Empleados");
                    this.dgvEmpleados.DataSource = conexion.ds.Tables["Empleados"];
                    this.dgvEmpleados.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbNombre.Checked == true)
            {
                try
                {
                    conexion.consultar("Select * From Empleados where Nombre_Empleado like '%" + this.txtBuscar.Text.Trim() + "%'", "Empleados");
                    this.dgvEmpleados.DataSource = conexion.ds.Tables["Empleados"];
                    this.dgvEmpleados.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbTelefono.Checked == true)
            {
                try
                {
                    conexion.consultar("Select * From Empleados where Telefono_Empleado like '%" + this.txtBuscar.Text.Trim() + "%'", "Empleados");
                    this.dgvEmpleados.DataSource = conexion.ds.Tables["Empleados"];
                    this.dgvEmpleados.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        private void Limpiar()
        {
            this.txtID.Text = this.txtNombre.Text = this.txtTelefono.Text = this.txtCelular.Text = this.txtEmail.Text = this.txtDireccion.Text =this.txtApellido.Text= "";
            this.cbxProvincia.SelectedValue = 0;
            this.cbxMunicipio.SelectedValue = 0;
            this.btnEliminar.Enabled = false;
            this.btnGuardar.Enabled = false;
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

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtID.Enabled = false;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.eliminar("Empleados", "Id_Empleado=" + this.txtID.Text);
                MessageBox.Show("Registro Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Este Empleado no puede ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conexion.cn.Close();
            }

            Limpiar();
            LlenarDataGridView();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.txtID.Text))
            {

                string sql = "insert into Empleados (Nombre_Empleado, Telefono_Empleado, Celular_Empleado, Email_Empleado, Direccion_Empleado, apellido_empleados, id_municipio) values ('" + txtNombre.Text.Trim() + "', '" + this.txtTelefono.Text.Trim() + "', '" + this.txtCelular.Text.Trim() + "','" + this.txtEmail.Text.Trim() + "','" + this.txtDireccion.Text.Trim()+"','"+this.txtApellido.Text.Trim() + "','" + this.cbxMunicipio.SelectedItem + "')";
                if (conexion.insertar(sql))
                {
                    MessageBox.Show("Registro Insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    LlenarDataGridView();
                }
                else
                {
                    MessageBox.Show("Error al insertar registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            else
            {
                string campos = "Nombre_Empleado ='" + this.txtNombre.Text.Trim() + "', Telefono_Empleado ='" + this.txtTelefono.Text.Trim() + "', Celular_Empleado ='" + this.txtCelular.Text.Trim() + "', Email_Empleado='" + this.txtEmail.Text.Trim() + "', Direccion_Empleado='" + this.txtDireccion.Text.Trim()+"', apellido_empleados='"+this.txtApellido.Text.Trim() + "',id_municipio='" + this.cbxMunicipio.SelectedValue + "'";
                string tabla = "Empleados";
                string condicion = " Id_Empleado =" + this.txtID.Text;
                if (conexion.actualizar(tabla, campos, condicion))
                {
                    MessageBox.Show("Registro Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    LlenarDataGridView();

                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (this.gbxListado.Visible == false)
            {
                this.gbxListado.Visible = true;
                this.rdbID.Checked = true;
            }
            else
            {
                this.gbxListado.Visible = false;
            }
        }

        private void RdbID_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBuscar.Visible = true;
            this.txtBuscar.Text = "";
            this.txtBuscar.Focus();
        }

        private void RdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBuscar.Visible = true;
            this.txtBuscar.Text = "";
            this.txtBuscar.Focus();
        }

        private void RdbTelefono_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBuscar.Visible = true;
            this.txtBuscar.Text = "";
            this.txtBuscar.Focus();
        }

        private void DgvEmpleados_Click(object sender, EventArgs e)
        {
            if (this.dgvEmpleados[0, this.dgvEmpleados.SelectedCells[0].RowIndex].Value.ToString() != "")
            {
                //Paso los datos del datagridview a los objtos arriba
                this.txtID.Text = this.dgvEmpleados[0, this.dgvEmpleados.SelectedCells[0].RowIndex].Value.ToString();
                this.txtID.Enabled = true;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            HabilitarGuardar();
        }

        private void txtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            HabilitarGuardar();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        public void refreshdata()
        {



            conexion.cn.Open();
            SqlCommand cmd = new SqlCommand("select * from provincia", conexion.cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conexion.cn.Close();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Provincia--" };
            dt.Rows.InsertAt(dr, 0);
            cbxProvincia.ValueMember = "ID_provincia";
            cbxProvincia.DisplayMember = "Nombre_provincia";
            cbxProvincia.DataSource = dt;

        }

       
        public void refreshstate(int ID_provincia)
        {

            conexion.cn.Open();
            SqlCommand cmd = new SqlCommand("select * from municipio where ID_provincia= @ID_provincia", conexion.cn);
            cmd.Parameters.AddWithValue("ID_provincia", ID_provincia);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conexion.cn.Close();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Municipio--" };
            dt.Rows.InsertAt(dr, 0);

            cbxMunicipio.ValueMember = "ID_municipio";
            cbxMunicipio.DisplayMember = "nombre_municipio";
            cbxMunicipio.DataSource = dt;



        }

        private void cbxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        private void cbxProvincia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxProvincia.SelectedValue.ToString() != null)
            {
                int ID_provincia = Convert.ToInt32(cbxProvincia.SelectedValue.ToString());
                refreshstate(ID_provincia);


            }
        }
    }
}
