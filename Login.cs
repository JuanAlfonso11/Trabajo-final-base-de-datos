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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ConexionSQL conexion = new ConexionSQL();

        int Id_Usuario = 0;

        //Si el campo Tipo_Usuario es Varchar en la BD, se declara como String
        int Tipo_Usuario = 0;

        int contador = 3;
        bool Habilitado;
        bool Actualizar;



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (this.txtnombreusuario.Text == "")
            {
                MessageBox.Show("Debe Indicar El Nombre de Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (this.txtcontrasenausuario.Text == "")
            {
                MessageBox.Show("Debe Indicar La Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                try
                {
                    SqlDataReader LectorUsuario;  // para leer en la base de datos
                    conexion.cn.Open();
                    SqlCommand Comando = new SqlCommand();
                    Comando.Connection = conexion.cn;
                    Comando.CommandText = "Select * From Usuarios where Nombre_Usuario='" + this.txtnombreusuario.Text.Trim() + "' and Contraseña_Usuario = '" + this.txtcontrasenausuario.Text.Trim() + "'";
                    LectorUsuario = Comando.ExecuteReader();
                    if (LectorUsuario.Read() == true)
                    {
                        Id_Usuario = LectorUsuario.GetInt32(0);
                        Habilitado = LectorUsuario.GetBoolean(3);
                        conexion.cn.Close();
                    }
                    else
                    {
                        if (contador > 0)
                        {
                            MessageBox.Show("No existe un usuario con estos datos, verifique el nombre de usuario o la contraseña digitada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            contador--;
                            this.txtcontrasenausuario.Focus();
                            return;
                        }
                        else
                        {
                            string campos = "Habilitado_Usuario='False'";
                            string tabla = "Usuarios";
                            string condicion = " Nombre_Usuario ='" + this.txtnombreusuario.Text.Trim() + "'";
                            conexion.cn.Close();
                            Actualizar = conexion.actualizar(tabla, campos, condicion);
                            if (Actualizar == true)
                            {
                                MessageBox.Show("Ha superado el limite de intentos de inicio de sesión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    LectorUsuario.Close();
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
                if (Habilitado == false)
                {
                    MessageBox.Show("Este Usuario Esta Deshabilitado, Comuniquese con el Administrador del Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    string sql = "insert into Historial_Acceso_Usuario (ID_Usuario, Fecha_Acceso) values ('" + Id_Usuario + "', getDate())";
                    if (conexion.insertar(sql))
                    {
                        //Si el Tipo_Usuario es Varchar las siguientes condiciones se cambiarian por los tipos de usuarios que //hay en su sistema
                        Form1 m = new Form1();
                        m.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult X = MessageBox.Show("¿Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (X == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtcontrasenausuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)
            { this.btnEntrar.PerformClick(); }
        }

        private void Lblacceso_Click(object sender, EventArgs e)
        {

        }
    }

}
    

