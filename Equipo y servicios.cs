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
    public partial class Equipo_y_servicios : Form
    {

        ConexionSQL conexion = new ConexionSQL();
        String Si_No;
        String True_False;
        public Equipo_y_servicios()
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
                conexion.consultar("Select Id_Equipo_servicio AS ID, Descripcion_Equipo AS Descripción, Precio_Equipo AS Precio, tipo_Equipo AS Tipo, Disponibilidad_Equipo AS Disponible, Equipo_Servicio AS Servicio From Equipos_servcios", "Equipos_servcios");
                this.dgvEquipos.DataSource = conexion.ds.Tables["Equipos_servcios"];
                this.dgvEquipos.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Equipo_y_servicios_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
            gbxListadoEquipos.Visible = false;
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
                SqlDataReader LectorEquipos;

                //Abrimos la conexion hacia la BD
                conexion.cn.Open();

                //Creamos una instruccion o comando SQL
                SqlCommand Comando = new SqlCommand();

                //Le asignamos la conexion actual
                Comando.Connection = conexion.cn;

                //Enviamos el parametro o la consulta que se desea realizar en SQL
                Comando.CommandText = "Select * From Equipos_servcios where Id_Equipo_servicio=" + this.txtID.Text;

                //Ejecutamos el comando y almacenamos el resultado en el Lector de datos.
                LectorEquipos = Comando.ExecuteReader();

                //Si se encontró un registro, entonces mostramos los datos de este registro en el formulario.
                if (LectorEquipos.Read() == true)
                {
                    //Asignando el valor de cada campo al objeto correspondiente
                    this.txtID.Text = LectorEquipos.GetInt32(0).ToString();  //Text Box
                    this.txtDescripcion.Text = LectorEquipos.GetString(1);
                    this.txtprecio.Text = LectorEquipos.GetSqlMoney(2).ToString();
                    this.txtTipo.Text = LectorEquipos.GetString(3);
                    this.chkDiponibilidad.Checked = LectorEquipos.GetBoolean(4);      //Check Box
                    this.chkServicio.Checked = LectorEquipos.GetBoolean(5);  //Combo Box
                   

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
                LectorEquipos.Close();
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
                this.txtDescripcion.Text = this.txtprecio.Text = this.txtprecio.Text =this.txtTipo.Text =  "";
                this.chkDiponibilidad.Checked = false;
                this.chkServicio.Checked = false;


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
            if (this.txtDescripcion.Text.Length > 0 && this.txtprecio.Text.Length > 0 && this.txtTipo.Text.Length > 0 )
            {
                this.btnGuardar.Enabled = true;
            }
            else
            {
                this.btnGuardar.Enabled = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
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
            this.txtID.Text = this.txtDescripcion.Text = this.txtprecio.Text = this.txtTipo.Text =  "";
            this.chkDiponibilidad.Checked = false;
            this.chkServicio.Checked = false;
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

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericosDecimales(e.KeyChar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.eliminar("Equipos_servcios", "Id_Equipo_servicio=" + this.txtID.Text);
                MessageBox.Show("Registro Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Este Equipo no puede ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
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

                    string sql = "insert into Equipos_servcios (Descripcion_Equipo, Precio_Equipo, tipo_Equipo, Disponibilidad_Equipo, Equipo_Servicio, Cantida_Equipo) values ('" + this.txtDescripcion.Text.Trim() + "', '" + this.txtprecio.Text.Trim() + "', '" + this.txtTipo.Text.Trim() + "','" + Si_No + "','" + True_False + "')";
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
                    string campos = "Descripcion_Equipo ='" + this.txtDescripcion.Text.Trim() + "', Precio_Equipo ='" + this.txtprecio.Text.Trim() + "', tipo_Equipo ='" + this.txtTipo.Text.Trim() + "',  Disponibilidad_Equipo ='" + Si_No + "',  Equipo_Servicio='" + True_False  + "'";
                    string tabla = "Equipos_servcios";
                    string condicion = " Id_Equipo_servicio =" + this.txtID.Text;
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

        private void chkDiponibilidad_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkDiponibilidad.Checked == true)
            {

                Si_No = "1";
            }
            else
            {
                Si_No = "0";
            }
        }
        private void chkServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkServicio.Checked == true)
            {

                True_False = "1";
            }
            else
            {
                True_False = "0";
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.gbxListadoEquipos.Visible == false)
            {
                this.gbxListadoEquipos.Visible = true;
                this.rdbID.Checked = true;
            }
            else
            {
                this.gbxListadoEquipos.Visible = false;
            }
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
        }

        private void rdbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
        }

        private void rdbDisponibilidad_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
        }

        private void rdbServicio_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
        }

        private void rdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (this.rdbID.Checked == true)
            {
                try
                {
                    string SQL = "Select * From Equipos_servcios where Id_Equipo_servicio like '%" + this.txtBusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Equipos_servcios");
                    this.dgvEquipos.DataSource = conexion.ds.Tables["Equipos_servcios"];
                    this.dgvEquipos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbDescripcion.Checked == true)
            {
                try
                {
                    conexion.consultar("Select * From Equipos_servcios where Descripcion_Equipo like '%" + this.txtBusqueda.Text.Trim() + "%'", "Equipos_servcios");
                    this.dgvEquipos.DataSource = conexion.ds.Tables["Equipos_servcios"];
                    this.dgvEquipos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbDisponibilidad.Checked == true)
            {
                try
                {
                    conexion.consultar("Select * From Equipos_servcios where Disponibilidad_Equipo like '%" + this.txtBusqueda.Text.Trim() + "%'", "Equipos_servcios");
                    this.dgvEquipos.DataSource = conexion.ds.Tables["Equipos_servcios"];
                    this.dgvEquipos.Refresh();
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
                    conexion.consultar("Select * From Equipos_servcios where tipo_Equipo like '%" + this.txtBusqueda.Text.Trim() + "%'", "Equipos_servcios");
                    this.dgvEquipos.DataSource = conexion.ds.Tables["Equipos_servcios"];
                    this.dgvEquipos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbServicio.Checked == true)
            {
                try
                {
                    conexion.consultar("Select * From Equipos_servcios where Equipo_Servicio like '%" + this.txtBusqueda.Text.Trim() + "%'", "Equipos_servcios");
                    this.dgvEquipos.DataSource = conexion.ds.Tables["Equipos_servcios"];
                    this.dgvEquipos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

            else if (this.rdbCantidad.Checked == true)
            {
                try
                {
                    conexion.consultar("Select * From Equipos_servcios where Cantida_Equipo like '%" + this.txtBusqueda.Text.Trim() + "%'", "Equipos_servcios");
                    this.dgvEquipos.DataSource = conexion.ds.Tables["Equipos_servcios"];
                    this.dgvEquipos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }

        private void dgvEquipos_Click(object sender, EventArgs e)
        {
            if (this.dgvEquipos[0, this.dgvEquipos.SelectedCells[0].RowIndex].Value.ToString() != "")
            {
                //Paso los datos del datagridview a los objtos arriba
                this.txtID.Text = this.dgvEquipos[0, this.dgvEquipos.SelectedCells[0].RowIndex].Value.ToString();
                this.txtID.Enabled = true;
            }
        }

        private void rdbCantidad_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardar();
        }

        
    }

 }
    