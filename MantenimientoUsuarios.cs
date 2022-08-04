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
    public partial class MantenimientoUsuarios : Form
    {
        ConexionSQL conexion = new ConexionSQL();
        String Si_No;


        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }


        /********************************************************************************
         *                              LlenarDatagridView()                            *
         *                                       -                                      *
         * Metodo para seleccionar y mostrar los datos de una tabla de la BD en un DGV  *
         ********************************************************************************/
        private void LlenarDataGridView()
        {
            try
            {
                conexion.consultar("Select Id_Usuarios AS ID, Nombre_Usuario AS Nombre, Contraseña_Usuario AS Contraseña, Habilitado_Usuario AS Habilitado, Tipo_Usuario AS Tipo From Usuarios", "Usuarios");
                this.dgvUsuarios.DataSource = conexion.ds.Tables["Usuarios"];
                this.dgvUsuarios.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
            gbxListadoUsuarios.Visible = false;

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
                SqlDataReader LectorUsuarios;

                //Abrimos la conexion hacia la BD
                conexion.cn.Open();

                //Creamos una instruccion o comando SQL
                SqlCommand Comando = new SqlCommand();

                //Le asignamos la conexion actual
                Comando.Connection = conexion.cn;

                //Enviamos el parametro o la consulta que se desea realizar en SQL
                Comando.CommandText = "Select * From Usuarios where Id_Usuarios=" + this.txtID.Text;

                //Ejecutamos el comando y almacenamos el resultado en el Lector de datos.
                LectorUsuarios = Comando.ExecuteReader();

                //Si se encontró un registro, entonces mostramos los datos de este registro en el formulario.
                if (LectorUsuarios.Read() == true)
                {
                    //Asignando el valor de cada campo al objeto correspondiente
                    this.txtID.Text = LectorUsuarios.GetInt32(0).ToString();  //Text Box
                    this.txtNombre.Text = LectorUsuarios.GetString(1);
                    this.txtContra.Text = LectorUsuarios.GetString(2);
                    this.chkSiNo.Checked = LectorUsuarios.GetBoolean(3);      //Check Box
                    this.cbxTipo.SelectedItem = LectorUsuarios.GetString(4);  //Combo Box


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
                LectorUsuarios.Close();
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
                this.txtNombre.Text = this.txtContra.Text = "";
                this.cbxTipo.SelectedValue = 0;
                this.chkSiNo.Checked = false;


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
            if (this.txtNombre.Text.Length > 0 && this.txtContra.Text.Length > 0 && this.cbxTipo.SelectedIndex >= 0)
            {
                this.btnGuardar.Enabled = true;
            }
            else
            {
                this.btnGuardar.Enabled = false;
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (this.rdbID.Checked == true)
            {
                try
                {
                    string SQL = "Select * From Usuarios where Id_Usuarios like '%" + this.txtBusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Usuarios");
                    this.dgvUsuarios.DataSource = conexion.ds.Tables["Usuarios"];
                    this.dgvUsuarios.Refresh();
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
                    conexion.consultar("Select * From Usuarios where Nombre_Usuario like '%" + this.txtBusqueda.Text.Trim() + "%'", "Usuarios");
                    this.dgvUsuarios.DataSource = conexion.ds.Tables["Usuarios"];
                    this.dgvUsuarios.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbTipo.Checked == true)
            {
                try
                {
                    conexion.consultar("Select * From Usuarios where Tipo_Usuario like '%" + this.txtBusqueda.Text.Trim() + "%'", "Usuarios");
                    this.dgvUsuarios.DataSource = conexion.ds.Tables["Usuarios"];
                    this.dgvUsuarios.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbHabilitado.Checked == true)
            {
                try
                {
                    conexion.consultar("Select * From Usuarios where Habilitado_Usuario like '%" + this.txtBusqueda.Text.Trim() + "%'", "Usuarios");
                    this.dgvUsuarios.DataSource = conexion.ds.Tables["Usuarios"];
                    this.dgvUsuarios.Refresh();
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

        private void TxtContra_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        private void CbxTipo_SelectedIndexChanged(object sender, EventArgs e)
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
            this.txtID.Text = this.txtNombre.Text = this.txtContra.Text = "";
            this.cbxTipo.SelectedValue = 0;
            this.chkSiNo.Checked = false;
            this.btnEliminar.Enabled = false;
            this.btnGuardar.Enabled = false;
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

        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            txtID.Enabled = false;
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        private void ChkSiNo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkSiNo.Checked == true)
            {
                Si_No = "1";
            }
            else
            {
                Si_No = "0";
            }

        }

        //propiedad para ocultar la contraseña y centralizar la ventana

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.eliminar("Usuarios", "Id_Usuarios=" + this.txtID.Text);
                MessageBox.Show("Registro Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Este Usuario no puede ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
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

            if (string.IsNullOrEmpty(this.txtID.Text))
            {

                string sql = "insert into Usuarios (Nombre_Usuario, Contraseña_Usuario, Habilitado_Usuario, Tipo_Usuario) values ('" + txtNombre.Text.Trim() + "', '" + this.txtContra.Text.Trim() + "', '" + Si_No + "','" + this.cbxTipo.SelectedItem + "')";
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
                string campos = "Nombre_Usuario ='" + this.txtNombre.Text.Trim() + "', Contraseña_Usuario ='" + this.txtContra.Text.Trim() + "', Habilitado_Usuario ='" + Si_No + "', Tipo_Usuario='" + this.cbxTipo.SelectedItem + "'";
                string tabla = "Usuarios";
                string condicion = " Id_Usuarios =" + this.txtID.Text;
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
            if (this.gbxListadoUsuarios.Visible == false)
            {
                this.gbxListadoUsuarios.Visible = true;
                this.rdbID.Checked = true;
            }
            else
            {
                this.gbxListadoUsuarios.Visible = false;
            }

        }

        private void RdbID_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();

        }

        private void RdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
        }

        private void RdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
        }

        private void RdbHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvUsuarios_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios[0, this.dgvUsuarios.SelectedCells[0].RowIndex].Value.ToString() != "")
            {
                //Paso los datos del datagridview a los objtos arriba
                this.txtID.Text = this.dgvUsuarios[0, this.dgvUsuarios.SelectedCells[0].RowIndex].Value.ToString();
                this.txtID.Enabled = true;
            }

        }

        private void GbxOpciones_Enter(object sender, EventArgs e)
        {

        }
    }
}
