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
    public partial class ConsultaPagos : Form
    {
        public ConsultaPagos()
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
                SQL = "SELECT Id_Pago AS ID, Id_Suplidor AS Suplidor, Fecha_Pago AS Fecha, Id_Usuario AS [ID Usuario], Monto_Pago AS Monto, Concepto_Pago AS Concepto FROM Pagos";
                conexion.consultar(SQL, "Pagos");
                this.dgvPagos.DataSource = conexion.ds.Tables["Pagos"];
                this.dgvPagos.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void ConsultaPagos_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
            gbxFormato.Visible = false;
            gbxDetalles.Visible = false;
        }

        private void RdbID_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
            this.gbxRango.Visible = false;

        }

        private void RdbSuplidor_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
            this.gbxRango.Visible = false;
        }

        private void RdbIdUsuario_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
            this.gbxRango.Visible = false;
        }

        private void RdbConcepto_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
            this.gbxRango.Visible = false;
        }

        private void RdbFecha_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = false;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
            this.gbxRango.Visible = true;
            this.txtDesde.Text = string.Empty;
            this.txtHasta.Text = string.Empty;
            this.txtDesde.Focus();

        }

        private void RdbMonto_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = false;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
            this.gbxRango.Visible = true;
            this.txtDesde.Text = string.Empty;
            this.txtHasta.Text = string.Empty;
            this.txtDesde.Focus();

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            gbxFormato.Visible = true;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvPagos_Click(object sender, EventArgs e)
        {
            gbxDetalles.Visible = true;
            try
            {
                SQL = "SELECT Suplidores.Nombre_Suplidor AS Nombre, Suplidores.Contacto_Suplidor AS Contacto, Suplidores.Telefono_Suplidor AS Teléfono, Suplidores.Celular_Suplidor AS Celular, Suplidores.Email_Suplidor AS Email, Suplidores.Direccion_Suplidor AS Dirección, Suplidores.RNC_Suplidor AS RNC, Suplidores.Balance_Suplidor AS Balance FROM Pagos INNER JOIN Suplidores ON Pagos.Id_Suplidor = Suplidores.Id_Suplidor where Suplidores.Id_Suplidor ='" + this.dgvPagos[1, this.dgvPagos.SelectedCells[0].RowIndex].Value.ToString() + "'";
                conexion.consultar(SQL, "Suplidores");
                this.dgvDetalles.DataSource = conexion.ds.Tables["Suplidores"];
                this.dgvDetalles.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if(this.rdbID.Checked == true)
            {
                try
                {
                    SQL = "SELECT Id_Pago AS ID, Id_Suplidor AS Suplidor, Fecha_Pago AS Fecha, Id_Usuario AS [ID Usuario], Monto_Pago AS Monto, Concepto_Pago AS Concepto"
                        + " FROM Pagos"
                        + " WHERE Id_Pago like '%" + this.txtBusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Pagos");
                    this.dgvPagos.DataSource = conexion.ds.Tables["Pagos"];
                    this.dgvPagos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbSuplidor.Checked == true)
            {
                try
                {
                    SQL = "SELECT Id_Pago AS ID, Id_Suplidor AS Suplidor, Fecha_Pago AS Fecha, Id_Usuario AS [ID Usuario], Monto_Pago AS Monto, Concepto_Pago AS Concepto"
                        + " FROM Pagos"
                        + " WHERE Id_Suplidor like '%" + this.txtBusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Pagos");
                    this.dgvPagos.DataSource = conexion.ds.Tables["Pagos"];
                    this.dgvPagos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbIdUsuario.Checked == true)
            {
                try
                {
                    SQL = "SELECT Id_Pago AS ID, Id_Suplidor AS Suplidor, Fecha_Pago AS Fecha, Id_Usuario AS [ID Usuario], Monto_Pago AS Monto, Concepto_Pago AS Concepto"
                        + " FROM Pagos"
                        + " WHERE Id_Usuario like '%" + this.txtBusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Pagos");
                    this.dgvPagos.DataSource = conexion.ds.Tables["Pagos"];
                    this.dgvPagos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbConcepto.Checked == true)
            {
                try
                {
                    SQL = "SELECT Id_Pago AS ID, Id_Suplidor AS Suplidor, Fecha_Pago AS Fecha, Id_Usuario AS [ID Usuario], Monto_Pago AS Monto, Concepto_Pago AS Concepto"
                        + " FROM Pagos"
                        + " WHERE Concepto_Pago like '%" + this.txtBusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Pagos");
                    this.dgvPagos.DataSource = conexion.ds.Tables["Pagos"];
                    this.dgvPagos.Refresh();
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
            
            if(this.rdbFecha.Checked == true)
            {
                try
                {
                    SQL = "SELECT Id_Pago AS ID, Id_Suplidor AS Suplidor, Fecha_Pago AS Fecha, Id_Usuario AS[ID Usuario], Monto_Pago AS Monto, Concepto_Pago AS Concepto"
                           + " FROM Pagos"
                           + " WHERE Fecha_Pago Between '" + this.txtDesde.Text + "'  And '" + this.txtHasta.Text + "'";
                    conexion.consultar(SQL, "Pagos");
                    this.dgvPagos.DataSource = conexion.ds.Tables["Pagos"];
                    this.dgvPagos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbMonto.Checked == true)
            {
                try
                {
                    SQL = "SELECT Id_Pago AS ID, Id_Suplidor AS Suplidor, Fecha_Pago AS Fecha, Id_Usuario AS[ID Usuario], Monto_Pago AS Monto, Concepto_Pago AS Concepto"
                           + " FROM Pagos"
                           + " WHERE Monto_Pago Between '" + this.txtDesde.Text + "'  And '" + this.txtHasta.Text + "'";
                    conexion.consultar(SQL, "Pagos");
                    this.dgvPagos.DataSource = conexion.ds.Tables["Pagos"];
                    this.dgvPagos.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

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
                    foreach (DataGridViewColumn item in dgvPagos.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }


                    //se crean las filas de la tabla
                    foreach (DataGridViewRow item in dgvPagos.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }

                    //se pasan los datos del datagridview a la tabla
                    foreach (DataGridViewColumn item in dgvPagos.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgvPagos.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgvPagos[item.Index, itemx.Index].Value;
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
                    foreach (DataGridViewColumn item in dgvPagos.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }


                    //se crean las filas de la tabla
                    foreach (DataGridViewRow item in dgvPagos.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }

                    //se pasan los datos del datagridview a la tabla
                    foreach (DataGridViewColumn item in dgvPagos.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgvPagos.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgvPagos[item.Index, itemx.Index].Value;
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
                    OF.GenerarDocumentoPDF(doc, dgvPagos);
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
