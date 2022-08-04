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


namespace Trabajo_final
{
    public partial class ConsultaHistorial : Form
    {
        public ConsultaHistorial()
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
                SQL = "SELECT Id_Historial_Acceso AS ID, Id_Usuario AS [ID Usuario], Fecha_Acceso AS Fecha FROM Historial_Acceso_Usuario";
                conexion.consultar(SQL, "Historial_Acceso_Usuario");
                this.dgvHistorial.DataSource = conexion.ds.Tables["Historial_Acceso_Usuario"];
                this.dgvHistorial.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void ConsultaHistorial_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
            this.gbxFormato.Visible = false;
            this.gbxDetalles.Visible = false;
        }

        private void RdbIdHistorial_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
            this.gbxRango.Visible = false;

        }

        private void RdbIDUsuario_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
            this.gbxRango.Visible = false;
        }

        private void RdbFecha_CheckedChanged(object sender, EventArgs e)
        {
            this.gbxRango.Visible = true;
            this.txtDesde.Text = "";
            this.txtHasta.Text = "";
            this.txtBusqueda.Visible = false;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            this.gbxFormato.Visible = true;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvHistorial_Click(object sender, EventArgs e)
        {
            this.gbxDetalles.Visible= true;
            try
            {
                SQL = "SELECT Usuarios.Nombre_Usuario AS Nombre, Usuarios.Contraseña_Usuario AS Contraseña, Usuarios.Habilitado_Usuario AS Habilitado, Usuarios.Tipo_Usuario AS Tipo FROM Historial_Acceso_Usuario INNER JOIN Usuarios ON Historial_Acceso_Usuario.Id_Usuario = Usuarios.Id_Usuarios WHERE Usuarios.Id_Usuarios ='" + this.dgvHistorial[1, this.dgvHistorial.SelectedCells[0].RowIndex].Value.ToString() + " '";
                conexion.consultar(SQL, "Usuarios");
                this.dgvDetalles.DataSource = conexion.ds.Tables["Usuarios"];
                this.dgvDetalles.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if(rdbIdHistorial.Checked == true)
            {
                try
                {
                    SQL = "SELECT Id_Historial_Acceso AS ID, Id_Usuario AS [ID Usuario], Fecha_Acceso AS Fecha"
                        + " FROM Historial_Acceso_Usuario"
                        + " WHERE Id_Historial_Acceso like '%" + this.txtBusqueda.Text + "%'";
                    conexion.consultar(SQL, "Historial_Acceso_Usuario");
                    this.dgvHistorial.DataSource = conexion.ds.Tables["Historial_Acceso_Usuario"];
                    this.dgvHistorial.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbIDUsuario.Checked == true)
            {
                try
                {
                    SQL = "SELECT Id_Historial_Acceso AS ID, Id_Usuario AS [ID Usuario], Fecha_Acceso AS Fecha"
                        + " FROM Historial_Acceso_Usuario"
                        + " WHERE Id_Usuario like '%" + this.txtBusqueda.Text + "%'";
                    conexion.consultar(SQL, "Historial_Acceso_Usuario");
                    this.dgvHistorial.DataSource = conexion.ds.Tables["Historial_Acceso_Usuario"];
                    this.dgvHistorial.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtDesde.Text == "" || this.txtHasta.Text == "")
            {
                MessageBox.Show("Debe indicar el rango inicial y final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.txtDesde.Focus();
                return;
            }
            try
            {
                SQL = "SELECT Id_Historial_Acceso AS ID, Id_Usuario AS [ID Usuario], Fecha_Acceso AS Fecha"
                    + " FROM Historial_Acceso_Usuario"
                    + " WHERE Fecha_Acceso between '" + this.txtDesde.Text + "' and '"+ this.txtHasta.Text + "'";
                conexion.consultar(SQL, "Historial_Acceso_Usuario");
                this.dgvHistorial.DataSource = conexion.ds.Tables["Historial_Acceso_Usuario"];
                this.dgvHistorial.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
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
                    foreach (DataGridViewColumn item in dgvHistorial.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }


                    //se crean las filas de la tabla
                    foreach (DataGridViewRow item in dgvHistorial.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }

                    //se pasan los datos del datagridview a la tabla
                    foreach (DataGridViewColumn item in dgvHistorial.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgvHistorial.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgvHistorial[item.Index, itemx.Index].Value;
                        }
                    }

                    //Exportamos el archivo
                    OF.Export(titulos, datosTabla);
                    MessageBox.Show("Archivo Generado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnWord_Click(object sender, EventArgs e)
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

                    //Especificamos ruta donde se guardará el archivo con extensión de EXCEL.
                    Exportar OF = new Exportar(ruta);

                    //obtenemos los titulos del datagridview y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgvHistorial.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }


                    //se crean las filas de la tabla
                    foreach (DataGridViewRow item in dgvHistorial.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }

                    //se pasan los datos del datagridview a la tabla
                    foreach (DataGridViewColumn item in dgvHistorial.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgvHistorial.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgvHistorial[item.Index, itemx.Index].Value;
                        }
                    }

                    //Exportamos el archivo
                    OF.Export(titulos, datosTabla);
                    MessageBox.Show("Archivo Generado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnPDF_Click(object sender, EventArgs e)
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
                    OF.GenerarDocumentoPDF(doc, dgvHistorial);
                    doc.Close();
                    MessageBox.Show("Archivo Generado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

