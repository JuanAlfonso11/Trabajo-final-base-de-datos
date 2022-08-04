using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Collections;
using System.IO;


namespace Trabajo_final
{
    public partial class BackUp : Form
    {
        public BackUp()
        {
            InitializeComponent();
        }

        ConexionSQL cnn = new ConexionSQL();

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            if (this.txtnombre.Text == string.Empty)
            {
                MessageBox.Show("Debes indicar el nombre del backup", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtnombre.Focus();
                return;
            }

            string fecha = Convert.ToString(DateTime.Today);
            fecha = fecha.Replace("/", "");
            fecha = fecha.Substring(0, 8);

            DirectoryInfo dir = new DirectoryInfo(@"C:\Backups");
            if (!dir.Exists)
            {
                dir.Create();
                DirectoryInfo dirbackup = new DirectoryInfo(@"C:\Backups\" + fecha + "");
                if (!dirbackup.Exists)
                {
                    dirbackup.Create();
                }
            }
            else
            {
                DirectoryInfo dirbackup = new DirectoryInfo(@"C:\Backups\" + fecha + "");
                if (!dirbackup.Exists)
                {
                    dirbackup.Create();
                }
            }

            string ruta = "C:\\Backups\\" + fecha + "\\" + this.txtnombre.Text + ".bak";
            string Backup = "BACKUP DATABASE [Alquiler de servicios] TO DISK = '" + ruta + "' WITH FORMAT, NAME = 'Full Backup of Database [Alquiler de servicios] '";

            try
            {
                cnn.cn.Open();
                SqlCommand comando = new SqlCommand(Backup, cnn.cn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Copia realizada exitosamente", "Backup de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.cn.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Se ha encontrado un error al hacer el backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.cn.Close();
            }
        }

        private void btncancelarbackup_Click(object sender, EventArgs e)
        {
            DialogResult X = MessageBox.Show("¿Está seguro que desea cancelar el BACKUP?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (X == DialogResult.Yes)
            {
                MessageBox.Show("La operación de realizar el Backup fue CANCELADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void BackUp_Load(object sender, EventArgs e)
        {

        }
    }
}


