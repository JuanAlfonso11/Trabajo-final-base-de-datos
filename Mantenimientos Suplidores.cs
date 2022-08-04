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
    public partial class MantenimientosSuplidores : Form
    {
        DataRow dr;




        ConexionSQL conexion = new ConexionSQL();
        string Si_No;
        
        

        public MantenimientosSuplidores()
        {
            InitializeComponent();
            refreshdata();
        }

        private void LlenarDataGridView()
        {
            try
            {
                conexion.consultar("Select Id_Suplidor AS ID, Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores", "Suplidores");
                this.dgvSuplidores.DataSource = conexion.ds.Tables["Suplidores"];
                this.dgvSuplidores.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void MantenimientosSuplidores_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
        }


        /********************************************************************************
         *                              BuscarRegistro()                                *
         *                                     -                                        *
         *     Metodo para seleccionar y extraer los datos de un registro de la BD      *
         ********************************************************************************/
        private void BuscarRegistro()
        {
            try
            {
                //Para extraer los datos del registro seleccionado en la base de datos
                SqlDataReader LectorSuplidores;

                //Abrimos la conexion hacia la BD
                conexion.cn.Open();

                //Creamos una instruccion o comando SQL
                SqlCommand Comando = new SqlCommand();

                //Le asignamos la conexion actual
                Comando.Connection = conexion.cn;

                //Enviamos el parametro o la consulta que se desea realizar en SQL
                Comando.CommandText = "Select * From Suplidores where Id_Suplidor=" + this.txtID.Text;

                //Ejecutamos el comando y almacenamos el resultado en el Lector de datos.
                LectorSuplidores = Comando.ExecuteReader();

                //Si se encontró un registro, entonces mostramos los datos de este registro en el formulario.
                if (LectorSuplidores.Read() == true)
                {
                    //Asignando el valor de cada campo al objeto correspondiente
                    this.txtID.Text = LectorSuplidores.GetInt32(0).ToString();
                    this.txtNombre.Text = LectorSuplidores.GetString(1);
                    this.txtContacto.Text = LectorSuplidores.GetString(2);
                    this.txtTelefono.Text = LectorSuplidores.GetString(3);
                    this.txtCelular.Text = LectorSuplidores.GetString(4);
                    this.txtEmail.Text = LectorSuplidores.GetString(5);
                    this.txtDireccion.Text = LectorSuplidores.GetString(6);
                    this.txtRNC.Text = LectorSuplidores.GetString(7);
                    this.txtBalance.Text = LectorSuplidores.GetSqlMoney(8).ToString();
                    this.cbxProvincia.SelectedItem = LectorSuplidores.GetString(9);
                    this.cbxMunicipio.SelectedItem = LectorSuplidores.GetString(10);

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
                LectorSuplidores.Close();
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

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            // Si el usuario digitó 3 o más caracteres en el txtID, ejecutamos el Metodo BuscarRegistro()
            if (txtID.Text.Length >= 3)
            {
                BuscarRegistro();
            }
            //De lo contrario, limpiamos todos los campos, excepto el txtID.
            else
            {
                this.txtNombre.Text= this.txtContacto.Text = this.txtTelefono.Text = this.txtBalance.Text = this.txtCelular.Text = this.txtDireccion.Text = this.txtEmail.Text = this.txtRNC.Text = "";
                this.cbxProvincia.SelectedValue = 0;
                this.cbxMunicipio.SelectedValue = 0;


                //Deshabilitamos los botones guardar y eliminar
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
            }

        }

        /********************************************************************************
         *                              HabilitarGuardar()                              *
         *                                     -                                        *
         *        Metodo que habilita/deshabilita el Boton Guardar dependiendo de       *
         *     si los campos requeridos para guardar un registro han sido rellenados    *
         ********************************************************************************/
        private void HabilitarGuardar()
        {
            if (this.txtNombre.Text.Length > 0 && this.txtContacto.MaskFull == true &&this.txtDireccion.Text.Length > 0 && this.txtRNC.Text.Length > 0 && this.txtTelefono.MaskFull == true && this.txtCelular.MaskFull == true && this.txtEmail.Text.Length > 0 && this.cbxMunicipio.SelectedIndex >= 0 && this.cbxProvincia.SelectedIndex >= 0)
            {
                this.btnGuardar.Enabled = true;
            }
            else
            {
                this.btnGuardar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            HabilitarGuardar();
        }

        private void txtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            HabilitarGuardar();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        private void txtRNC_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        /********************************************************************************
 *                                  Limpiar()                                   *
 *                                     -                                        *
 *        Metodo para borrar valores almacenados en los objetos del Form        *
 ********************************************************************************/
        private void Limpiar()
        {

            this.txtID.Text = this.txtNombre.Text = this.txtContacto.Text = this.txtTelefono.Text = this.txtBalance.Text = this.txtCelular.Text = this.txtDireccion.Text = this.txtEmail.Text = this.txtRNC.Text = "";
            this.cbxProvincia.SelectedValue = 0;
            this.cbxMunicipio.SelectedValue = 0;
            this.btnEliminar.Enabled = false;
            this.btnGuardar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtID.Enabled = false;
        }

        /********************************************************************************
         *                              ValidarCamposNumericos()                        *
         *                                        -                                     *
         *       Metodo que permite validar si la tecla pulsada es un numero o no       *
         ********************************************************************************/
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

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericosDecimales(e.KeyChar);
        }

        private void btnREgresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.eliminar("Suplidores", "Id_Suplidor=" + this.txtID.Text);
                MessageBox.Show("Registro Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Este Suplidor no puede ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conexion.cn.Close();
            }

            Limpiar();
            LlenarDataGridView();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(this.txtID.Text))
                {

                    string sql = "insert into Suplidores (Nombre_Suplidor, Contacto_Suplidor, Telefono_Suplidor, Celular_Suplidor, Email_Suplidor, Direccion_Suplidor, Rnc_Suplidor, Balance_Suplidor, id_municipio) values " +
                        "('" + this.txtNombre.Text.Trim() + "','" + this.txtContacto.Text.Trim() + "', '" + this.txtTelefono.Text.Trim() + "', '" + this.txtCelular.Text.Trim() + "','" + this.txtEmail.Text.Trim() + "','"
                        + this.txtDireccion.Text.Trim() + "','" + this.txtRNC.Text.Trim() + "','" + this.txtBalance.Text.Trim() +"','"+ this.cbxMunicipio.SelectedItem+ "')";
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
                    string campos = "Nombre_Suplidor ='" + this.txtNombre.Text.Trim() + "',Contacto_Suplidor ='" + this.txtContacto.Text.Trim() + "', Telefono_Suplidor ='" + this.txtTelefono.Text.Trim() + "', Celular_Suplidor ='" + this.txtCelular.Text.Trim() + "', Email_Suplidor='" + this.txtEmail.Text.Trim() + "', Direccion_Suplidor='" + this.txtDireccion.Text.Trim() + "', Rnc_Suplidor= '" + this.txtRNC.Text.Trim() + "', Balance_Suplidor = '" + this.txtBalance.Text.Trim() +"',id_municipio='"+ this.cbxMunicipio.SelectedValue + "'";
                    Console.WriteLine(this.cbxMunicipio.SelectedItem);
                    string tabla = "Suplidores";
                    string condicion = " Id_Suplidor =" + this.txtID.Text;
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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.gbxListadoSuplidores.Visible == false)
            {
                this.gbxListadoSuplidores.Visible = true;
                this.rdbID.Checked = true;
            }
            else
            {
                this.gbxListadoSuplidores.Visible = false;
            }


        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            this.txtbusqueda.Visible = true;
            this.txtbusqueda.Text = "";
            this.txtbusqueda.Focus();

        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.txtbusqueda.Visible = true;
            this.txtbusqueda.Text = "";
            this.txtbusqueda.Focus();

        }

        private void rdbTelefono_CheckedChanged(object sender, EventArgs e)
        {
            this.txtbusqueda.Visible = true;
            this.txtbusqueda.Text = "";
            this.txtbusqueda.Focus();

        }

        private void rdbRNC_CheckedChanged(object sender, EventArgs e)
        {
            this.txtbusqueda.Visible = true;
            this.txtbusqueda.Text = "";
            this.txtbusqueda.Focus();

        }
        private void rdcContacto_CheckedChanged(object sender, EventArgs e)
        {
            this.txtbusqueda.Visible = true;
            this.txtbusqueda.Text = "";
            this.txtbusqueda.Focus();

        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            if (this.rdbID.Checked == true)
            {
                try
                {
                    string SQL = "Select * From Suplidores where Id_Suplidor like '%" + this.txtbusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Suplidores");
                    this.dgvSuplidores.DataSource = conexion.ds.Tables["Suplidores"];
                    this.dgvSuplidores.Refresh();
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
                    conexion.consultar("Select * From Suplidores where Nombre_Suplidor like '%" + this.txtbusqueda.Text.Trim() + "%'", "Suplidores");
                    this.dgvSuplidores.DataSource = conexion.ds.Tables["Suplidores"];
                    this.dgvSuplidores.Refresh();
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
                    conexion.consultar("Select * From Suplidores where Telefono_Suplidor like '%" + this.txtbusqueda.Text.Trim() + "%'", "Suplidores");
                    this.dgvSuplidores.DataSource = conexion.ds.Tables["Suplidores"];
                    this.dgvSuplidores.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbRNC.Checked == true)
            {
                try
                {
                    conexion.consultar("Select * From Suplidores where RNC_Suplidor like '%" + this.txtbusqueda.Text.Trim() + "%'", "Suplidores");
                    this.dgvSuplidores.DataSource = conexion.ds.Tables["Suplidores"];
                    this.dgvSuplidores.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbContacto.Checked == true)
            {
                try
                {
                    conexion.consultar("Select * From Suplidores where Contacto_Suplidor like '%" + this.txtbusqueda.Text.Trim() + "%'", "Suplidores");
                    this.dgvSuplidores.DataSource = conexion.ds.Tables["Suplidores"];
                    this.dgvSuplidores.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }

        private void dgvSuplidores_Click(object sender, EventArgs e)
        {

            if (this.dgvSuplidores[0, this.dgvSuplidores.SelectedCells[0].RowIndex].Value.ToString() != "")
            {
                //Paso los datos del datagridview a los objtos arriba
                this.txtID.Text = this.dgvSuplidores[0, this.dgvSuplidores.SelectedCells[0].RowIndex].Value.ToString();
                this.txtID.Enabled = true;
            }



        }

        private void GbxOpciones_Enter(object sender, EventArgs e)
        {

        }

        private void GbxListadoSuplidores_Enter(object sender, EventArgs e)
        {

        }

        private void txtContacto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void cbxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
                if (cbxProvincia.SelectedValue.ToString() != null)
                {
                    int ID_provincia = Convert.ToInt32(cbxProvincia.SelectedValue.ToString());
                    refreshsta(ID_provincia);


                }

        }
        public void refreshsta(int ID_provincia)
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
    }
}

