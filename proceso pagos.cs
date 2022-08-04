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
    public partial class proceso_pagos : Form
    {
        public proceso_pagos()
        {
            InitializeComponent();
        }

        ConexionSQL conexion = new ConexionSQL();

        int id_usuario = 0;
        string instruccion_sql;

        /********************************************************************************
         *              Funcion para Mostrar en el Grid todos los Clientes              *
         ********************************************************************************/
        private void LlenarDataGridViewSuplidores()
        {
            try
            {
                conexion.consultar("Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores", "Suplidores");
                dgvsuplidores.DataSource = conexion.ds.Tables["Suplidores"];
                dgvsuplidores.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /********************************************************************************
         *                       Funcion para buscar clientes                           *
         ********************************************************************************/
        private void BuscarSuplidor()
        {
            try
            {
                SqlDataReader LectorSuplidor;

                conexion.cn.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conexion.cn;
                Comando.CommandText = "Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Id_Suplidor=" + txtIDsuplidor.Text;
                LectorSuplidor = Comando.ExecuteReader();

                if (LectorSuplidor.Read() == true)
                {
                    txtNombreSuplidor.Text = LectorSuplidor.GetString(1);
                    txtdireccion.Text = LectorSuplidor.GetString(6);
                    txttelefono.Text = LectorSuplidor.GetString(3);
                    txtbalance.Text = LectorSuplidor.GetSqlMoney(8).ToString();
                    txttelefono.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("No existe un registro con este codigo, verifique y trate de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                LectorSuplidor.Close();
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

        /********************************************************************************
         *              Funcion para Limpiar los datos del suplidor                     *
         ********************************************************************************/
        private void LimpiarSuplidor()
        {
            txtIDsuplidor.Text = txtNombreSuplidor.Text = txttelefono.Text = txtdireccion.Text =  "";
            txtbalance.Text ="0";
        }

        /********************************************************************************
         *              Funcion para Limpiar los datos del pago                         *
         ********************************************************************************/
        private void LimpiarPagos()
        {
            txtMonto.Text = "0";
            txtconcepto.Text = "";
        }

        /********************************************************************************
         *              Funcion para Buscar el Ultimo Usuario Logueado                  *
         ********************************************************************************/
        private void ObtenerUsuario()
        {
            try
            {
                SqlDataReader LectorHistorial;  // para leer en la base de datos
                conexion.cn.Open();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conexion.cn;
                Comando.CommandText = "Select Id_Usuarios,Nombre_Usuario From Usuarios Where Id_Usuarios = (select id_usuario from Historial_Acceso_Usuario Where Fecha_Acceso= (SELECT Max(Fecha_Acceso) From Historial_Acceso_Usuario))";
                LectorHistorial = Comando.ExecuteReader();
                if (LectorHistorial.Read() == true)
                {
                    id_usuario = LectorHistorial.GetInt32(0);
                    txtusuario.Text = LectorHistorial.GetString(1);
                    conexion.cn.Close();
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
                conexion.cn.Close();
            }
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

        private void proceso_pagos_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewSuplidores();
            ObtenerUsuario();
            this.gbxBuscarSuplidor.Visible = false;
        }

        private void txtIDsuplidor_TextChanged(object sender, EventArgs e)
        {
            if (txtIDsuplidor.Text.Length >= 3)
            {
                BuscarSuplidor();
            }
            else
            {
                txtNombreSuplidor.Text = txtdireccion.Text = txttelefono.Text = "";
                txttelefono.ReadOnly = false;
            }
        }

        private void txtIDsuplidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericos(e.KeyChar);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCamposNumericosDecimales(e.KeyChar);
        }

        private void btnNuevoPago_Click(object sender, EventArgs e)
        {
            if (txtIDsuplidor.Text.Length > 0 || txtBuscarSuplidor.Text.Length > 0)
            {
                DialogResult X = MessageBox.Show("En este momento se esta procesando un pago \n ¿Está seguro que desea cancelar este proceso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (X == DialogResult.Yes)
                {
                    LimpiarSuplidor();
                    LimpiarPagos();
                    txtBuscarSuplidor.Text = "";
                }
            }
            else
            {
                LimpiarSuplidor();
                LimpiarPagos();
                txtBuscarSuplidor.Text = "";
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProcesarPago_Click(object sender, EventArgs e)
        {
            if (txtIDsuplidor.Text == "")
            {
                MessageBox.Show("Debe indicar un suplidor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIDsuplidor.Focus();
                return;
            }
            else if (txtMonto.Text == "")
            {
                MessageBox.Show("Debe indicar un Monto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMonto.Focus();
                return;
            }
            else if (txtconcepto.Text == "")
            {
                MessageBox.Show("Debe indicar un Concepto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtconcepto.Focus();
                return;
            }
            else if (double.Parse(txtMonto.Text) > double.Parse(txtbalance.Text))
            {
                MessageBox.Show("El monto a pagar debe ser menor o igual que el balance pendiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMonto.Focus();
                return;
            }
            else
            {
                //Guardamos en la tabla de Pagos
                string sql = "insert into Pagos (Id_Suplidor, Fecha_Pago, Id_Usuario, Monto_Pago, Concepto_Pago) values ('" + txtIDsuplidor.Text.Trim() + "', '" + DateTime.Now.ToShortDateString() + "','" + id_usuario + "','" + txtMonto.Text.Trim() + "', '" + txtconcepto.Text.Trim() + "')";
                try
                {
                    conexion.insertar(sql);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }

                //Actualizamos el Balance del Cliente
                string campos = "Balance_Suplidor = Balance_Suplidor - " + txtMonto.Text + "";
                string tabla = "Suplidores";
                string condicion = " Id_Suplidor =" + txtIDsuplidor.Text + "";

                try
                {
                    conexion.actualizar(tabla, campos, condicion);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }

            }

            MessageBox.Show("Pago Procesado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnNuevoPago_Click(sender, e);
            proceso_pagos_Load(null, null);
            LimpiarPagos();
            LimpiarSuplidor();
            txtBuscarSuplidor.Text = "";

        }

        private void dgvsuplidores_Click(object sender, EventArgs e)
        {
            if (this.dgvsuplidores[0, this.dgvsuplidores.SelectedCells[0].RowIndex].Value.ToString() != "")
            {
                this.txtIDsuplidor.Text = this.dgvsuplidores[0, this.dgvsuplidores.SelectedCells[0].RowIndex].Value.ToString();
                this.txtIDsuplidor.Enabled = true;
                this.gbxBuscarSuplidor.Visible = false;
            }

        }

        private void txtBuscarSuplidor_TextChanged(object sender, EventArgs e)
        {
            if (rdbIDsuplidor.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Id_Suplidor like '%" + txtBuscarSuplidor.Text.Trim() + "%'";
                    conexion.consultar(instruccion_sql, "Suplidores");
                    dgvsuplidores.DataSource = conexion.ds.Tables["Suplidores"];
                    dgvsuplidores.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbNombreSuplidor.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Nombre_Suplidor like '%" + txtBuscarSuplidor.Text.Trim() + "%'";
                    conexion.consultar(instruccion_sql, "Suplidores");
                    dgvsuplidores.DataSource = conexion.ds.Tables["Suplidores"];
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
                    conexion.consultar(instruccion_sql, "Suplidores");
                    dgvsuplidores.DataSource = conexion.ds.Tables["Suplidores"];
                    dgvsuplidores.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbdireccion.Checked == true)
            {
                try
                {
                    instruccion_sql = "Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Direccion_Suplidor like '%" + txtBuscarSuplidor.Text.Trim() + "%'";
                    conexion.consultar(instruccion_sql, "Suplidores");
                    dgvsuplidores.DataSource = conexion.ds.Tables["Suplidores"];
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
                    conexion.consultar(instruccion_sql, "Suplidores");
                    dgvsuplidores.DataSource = conexion.ds.Tables["Suplidores"];
                    dgvsuplidores.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.gbxBuscarSuplidor.Visible = true;
            this.txtBuscarSuplidor.Text = "";
            this.txtBuscarSuplidor.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult X = MessageBox.Show("¿Está seguro que desea cancelar el Proceso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (X == DialogResult.Yes)
            {
                LimpiarPagos();
                LimpiarSuplidor();
            }
        }
    }
}
