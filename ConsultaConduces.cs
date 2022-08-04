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
    public partial class ConsultaConduces : Form
    {
        public ConsultaConduces()
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
                SQL = "SELECT Id_Conduce AS ID, Id_Cliente AS Cliente, Fecha_Conduce AS Fecha, Id_Usuario AS [ID Usuario] FROM Conduces";
                conexion.consultar(SQL, "Conduces");
                this.dgvConduces.DataSource = conexion.ds.Tables["Conduces"];
                this.dgvConduces.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }


        private void ConsultaConduces_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
            this.gbxformato.Visible = false;
            this.gbxdetalles.Visible = false;
        }

        private void RdbID_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
            this.gbxRango.Visible = false;
        }

        private void RdbIDCliente_CheckedChanged(object sender, EventArgs e)
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

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            this.gbxformato.Visible = true;
        }

        private void DgvConduces_Click(object sender, EventArgs e)
        {
            this.gbxdetalles.Visible = true;
            try
            {
                SQL = "SELECT Clientes.Nombre_Cliente AS Nombre, Clientes.Telefono_Cliente AS Teléfono, Clientes.Celular_Cliente AS Celular, Clientes.Email_Cliente AS Email, Clientes.Direccion_Cliente AS Dirección, Clientes.Cedula_Rnc_Cliente AS [Cédula/RNC], Clientes.Balance_Cliente AS Balance FROM Clientes INNER JOIN Conduces ON Clientes.Id_Cliente = Conduces.Id_Cliente WHERE Clientes.Id_Cliente ='" + this.dgvConduces[1, this.dgvConduces.SelectedCells[0].RowIndex].Value.ToString() + "'";
                conexion.consultar(SQL, "Clientes");
                this.dgvDetalles.DataSource = conexion.ds.Tables["Clientes"];
                this.dgvDetalles.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if  (rdbID.Checked ==true)
            {
                try
                {
                    SQL = "SELECT Id_Conduce AS ID, Id_Cliente AS Cliente, Fecha_Conduce AS Fecha, Id_Usuario AS [ID Usuario]"
                        + " FROM Conduces"
                        + " WHERE Id_Conduce like '%" + this.txtBusqueda.Text + "%'";
                    conexion.consultar(SQL, "Conduces");
                    this.dgvConduces.DataSource = conexion.ds.Tables["Conduces"];
                    this.dgvConduces.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (rdbIDCliente.Checked ==true)
            {
                try
                {
                    SQL = "SELECT Id_Conduce AS ID, Id_Cliente AS Cliente, Fecha_Conduce AS Fecha, Id_Usuario AS [ID Usuario]"
                        + " FROM Conduces"
                        + " WHERE Id_Cliente like '%" + this.txtBusqueda.Text + "%'";
                    conexion.consultar(SQL, "Conduces");
                    this.dgvConduces.DataSource = conexion.ds.Tables["Conduces"];
                    this.dgvConduces.Refresh();
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
                SQL = "SELECT Id_Conduce AS ID, Id_Cliente AS Cliente, Fecha_Conduce AS Fecha, Id_Usuario AS [ID Usuario]"
                    + " FROM Conduces"
                    + " WHERE Fecha_Conduce Between '" + this.txtDesde.Text + "' AND '" + this.txtHasta.Text + "'";
                conexion.consultar(SQL, "Conduces");
                this.dgvConduces.DataSource = conexion.ds.Tables["Conduces"];
                this.dgvConduces.Refresh();
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
                    foreach (DataGridViewColumn item in dgvConduces.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }


                    //se crean las filas de la tabla
                    foreach (DataGridViewRow item in dgvConduces.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }

                    //se pasan los datos del datagridview a la tabla
                    foreach (DataGridViewColumn item in dgvConduces.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgvConduces.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgvConduces[item.Index, itemx.Index].Value;
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
                this.gbxformato.Visible = false;
                return;
            }
            this.gbxformato.Visible = false;

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
                    foreach (DataGridViewColumn item in dgvConduces.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }


                    //se crean las filas de la tabla
                    foreach (DataGridViewRow item in dgvConduces.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }

                    //se pasan los datos del datagridview a la tabla
                    foreach (DataGridViewColumn item in dgvConduces.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgvConduces.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgvConduces[item.Index, itemx.Index].Value;
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
                this.gbxformato.Visible = false;
                return;
            }
            this.gbxformato.Visible = false;
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
                    OF.GenerarDocumentoPDF(doc, dgvConduces);
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
                this.gbxformato.Visible = false;
                return;
            }
            this.gbxformato.Visible = false;

        }
    }
}
