using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;



namespace Trabajo_final
{
    public partial class ConsultaUsuario : Form
    {
        public ConsultaUsuario()
        {
            InitializeComponent();
        }
        ConexionSQL conexion = new ConexionSQL();
        string SQL;
        string ruta;

        private void LlenarDataGridView()
        {
            try
            {
                SQL = "SELECT Usuarios.Id_Usuarios AS ID,Usuarios.Nombre_Usuario As Nombre,Usuarios.Contraseña_Usuario AS Contraseña, Usuarios.Habilitado_Usuario AS Habilitado, Usuarios.Tipo_Usuario AS Tipo FROM Usuarios where Usuarios.Id_Usuarios like '%" + this.txtCriterio.Text.Trim() + "%'";
                conexion.consultar(SQL, "Usuarios");
                this.dgvRegistros.DataSource = conexion.ds.Tables["Usuarios"];
                this.dgvRegistros.Refresh();
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
            this.gbxDetalles.Visible = false;
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCriterio.Visible = true;
            this.txtCriterio.Text = "";
            this.txtCriterio.Focus();
            this.gbxRango.Visible = false;

        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCriterio.Visible = true;
            this.txtCriterio.Text = "";
            this.txtCriterio.Focus();
            this.gbxRango.Visible = false;

        }

        private void rdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCriterio.Visible = true;
            this.txtCriterio.Text = "";
            this.txtCriterio.Focus();
            this.gbxRango.Visible = false;

        }

        private void rdbHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCriterio.Visible = true;
            this.txtCriterio.Text = "";
            this.txtCriterio.Focus();
            this.gbxRango.Visible = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gbxForm.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvRegistros_Click(object sender, EventArgs e)
        {
            this.gbxDetalles.Visible = true;
            try
            {
                SQL = "Select Id_Historial_Acceso AS [ID Acceso], Id_Usuario AS [ID Usuario], Fecha_Acceso AS [Fecha de Acceso] From Historial_Acceso_Usuario where Id_Usuario ='" + this.dgvRegistros[0, this.dgvRegistros.SelectedCells[0].RowIndex].Value.ToString() + "'";
                conexion.consultar(SQL, "Historial_Acceso_Usuario");
                this.dgvDetalles.DataSource = conexion.ds.Tables["Historial_Acceso_Usuario"];
                this.dgvDetalles.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            if (this.rdbID.Checked == true)
            {
                try
                {
                    SQL = "SELECT Usuarios.Id_Usuarios AS ID,Usuarios.Nombre_Usuario As Nombre,Usuarios.Contraseña_Usuario AS Contraseña, Usuarios.Habilitado_Usuario AS Habilitado, Usuarios.Tipo_Usuario AS Tipo FROM Usuarios where Usuarios.Id_Usuarios like '%" + this.txtCriterio.Text.Trim() +"%'";
                    conexion.consultar(SQL, "Usuarios");
                    this.dgvRegistros.DataSource = conexion.ds.Tables["Usuarios"];
                    this.dgvRegistros.Refresh();
                }

                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
            if (this.rdbNombre.Checked == true)
            {
                try
                {
                    SQL = "SELECT Usuarios.Id_Usuarios AS ID,Usuarios.Nombre_Usuario As Nombre,Usuarios.Contraseña_Usuario AS Contraseña, Usuarios.Habilitado_Usuario AS Habilitado, Usuarios.Tipo_Usuario AS Tipo FROM Usuarios where Usuarios.Nombre_Usuario like '%" + this.txtCriterio.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Usuarios");
                    this.dgvRegistros.DataSource = conexion.ds.Tables["Usuarios"];
                    this.dgvRegistros.Refresh();
                }

                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            if (this.rdbTipo.Checked == true)
            {
                try
                {
                    SQL = "SELECT Usuarios.Id_Usuarios AS ID,Usuarios.Nombre_Usuario As Nombre,Usuarios.Contraseña_Usuario AS Contraseña, Usuarios.Habilitado_Usuario AS Habilitado, Usuarios.Tipo_Usuario AS Tipo FROM Usuarios where Usuarios.Tipo_Usuario like '%" + this.txtCriterio.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Usuarios");
                    this.dgvRegistros.DataSource = conexion.ds.Tables["Usuarios"];
                    this.dgvRegistros.Refresh();
                }

                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
            if (this.rdbHabilitado.Checked == true)
            {
                try
                {
                    SQL = "SELECT Usuarios.Id_Usuarios AS ID,Usuarios.Nombre_Usuario As Nombre,Usuarios.Contraseña_Usuario AS Contraseña, Usuarios.Habilitado_Usuario AS Habilitado, Usuarios.Tipo_Usuario AS Tipo FROM Usuarios where Usuarios.Habilitado_Usuario like '%" + this.txtCriterio.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Usuarios");
                    this.dgvRegistros.DataSource = conexion.ds.Tables["Usuarios"];
                    this.dgvRegistros.Refresh();
                }

                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
        }

        private void btnBuscarRango_Click(object sender, EventArgs e)
        {
            if (this.txtDesde.Text == "" || this.txtHasta.Text == "")
            {
                MessageBox.Show("Debe indicar el rango inicial y final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.txtDesde.Focus();
                return;

            }
            try
            {
                SQL = "SELECT Usuarios.Id_Usuarios AS ID,Usuarios.Nombre_Usuario As Nombre,Usuarios.Contraseña_Usuario AS Contraseña, Usuarios.Habilitado_Usuario AS Habilitado, Usuarios.Tipo_Usuario AS Tipo FROM Usuarios where Usuario.Id_Usuarios like '%" + this.txtCriterio.Text.Trim() + "%'";
                conexion.consultar(SQL, "Usuarios");
                this.dgvRegistros.DataSource = conexion.ds.Tables["Usuarios"];
                this.dgvRegistros.Refresh();
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivos de Excel|*.xls";
            dialog.FileName = "";
            dialog.Title = "Guardar Reporte en Excel";
            dialog.InitialDirectory = "C:\\";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ruta = dialog.FileName;
                try
                {
                    ArrayList titulos = new ArrayList();
                    DataTable datosTabla = new DataTable();

                    //Especificamos ruta donde se guardará el archivo con extensión de EXCEL.
                    Exportar OF = new Exportar(ruta);

                    //obtenemos los titulos del datagridview y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgvRegistros.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }


                    //se crean las filas de la tabla
                    foreach (DataGridViewRow item in dgvRegistros.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }

                    //se pasan los datos del datagridview a la tabla
                    foreach (DataGridViewColumn item in dgvRegistros.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgvRegistros.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgvRegistros[item.Index, itemx.Index].Value;
                        }
                    }

                    //Exportamos el archivo
                    OF.Export(titulos, datosTabla);
                    MessageBox.Show("Archivo Generado Correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(OF.xpath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (result == DialogResult.Cancel)
            {
                this.gbxFormato.Visible = false;
                return;
            }
            this.gbxFormato.Visible = false;

        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivos de Word|*.doc";
            dialog.FileName = "";
            dialog.Title = "Guardar Reporte en Word";
            dialog.InitialDirectory = "C:\\";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ruta = dialog.FileName;
                try
                {
                    ArrayList titulos = new ArrayList();
                    DataTable datosTabla = new DataTable();

                    //Especificamos ruta donde se guardará el archivo con extensión de WORD.
                    Exportar OF = new Exportar(ruta);

                    //obtenemos los titulos del datagridview y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgvRegistros.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }


                    //se crean las filas de la tabla
                    foreach (DataGridViewRow item in dgvRegistros.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }

                    //se pasan los datos del datagridview a la tabla
                    foreach (DataGridViewColumn item in dgvRegistros.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgvRegistros.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgvRegistros[item.Index, itemx.Index].Value;
                        }
                    }

                    //Exportamos el archivo
                    OF.Export(titulos, datosTabla);
                    MessageBox.Show("Archivo Generado Correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(OF.xpath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (result == DialogResult.Cancel)
            {
                this.gbxFormato.Visible = false;
                return;
            }
            this.gbxFormato.Visible = false;

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivos de PDF|*.pdf";
            dialog.FileName = "";
            dialog.Title = "Guardar Reporte en PDF";
            dialog.InitialDirectory = "C:\\";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ruta = dialog.FileName;
                try
                {
                    Document doc = new Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10);
                    string filename = ruta;
                    FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, file);
                    doc.Open();
                    Exportar OF = new Exportar(ruta);
                    OF.GenerarDocumentoPDF(doc, dgvRegistros);
                    doc.Close();
                    MessageBox.Show("Archivo Generado Correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (result == DialogResult.Cancel)
            {
                this.gbxFormato.Visible = false;
                return;
            }
            this.gbxFormato.Visible = false;
        }

















    }


}
    

