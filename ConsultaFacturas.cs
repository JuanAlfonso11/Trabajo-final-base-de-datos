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
    public partial class ConsultaFacturas : Form
    {
        public ConsultaFacturas()
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
                SQL = "SELECT Id_Factura AS ID, Fecha_Factura AS Fecha, Id_Cliente AS [ID Cliente], Id_Usuario AS [ID Usuario], Monto_Factura AS Monto, NCF_Factura AS [NCF Factura], Tipo_Factura AS [Tipo Factura]" 
                    + " FROM Facturas";
                conexion.consultar(SQL, "Facturas");
                this.dgvFacturas.DataSource = conexion.ds.Tables["Facturas"];
                this.dgvFacturas.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void ConsultaFacturas_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
            this.gbxDetalles.Visible = false;
            this.gbxFormato.Visible = false;
        }

        private void RdbID_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
            this.gbxRango.Visible = false;
        }

        private void RdbIdCliente_CheckedChanged(object sender, EventArgs e)
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

        private void RdbNCF_CheckedChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Visible = true;
            this.txtBusqueda.Text = "";
            this.txtBusqueda.Focus();
            this.gbxRango.Visible = false;
        }

        private void RdbTipo_CheckedChanged(object sender, EventArgs e)
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

        private void DgvFacturas_Click(object sender, EventArgs e)
        {
            gbxDetalles.Visible = true;
            try
            {
                SQL = "SELECT Clientes.Nombre_Cliente AS Nombre, Clientes.Telefono_Cliente AS Teléfono, Clientes.Celular_Cliente AS Celular, Clientes.Email_Cliente AS [E-mail], Clientes.Direccion_Cliente AS Dirección, Clientes.Cedula_Rnc_Cliente AS [Cédula/RNC], Clientes.Balance_Cliente AS Balance FROM Facturas INNER JOIN Clientes ON Facturas.Id_Cliente = Clientes.Id_Cliente where Clientes.Id_Cliente ='" + this.dgvFacturas[2, this.dgvFacturas.SelectedCells[0].RowIndex].Value.ToString() + "'";
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
            if (this.rdbID.Checked == true)
            {
                try
                {
                    SQL = "SELECT Id_Factura AS ID, Fecha_Factura AS Fecha, Id_Cliente AS [ID Cliente], Id_Usuario AS [ID Usuario], Monto_Factura AS Monto, NCF_Factura AS [NCF Factura], Tipo_Factura AS [Tipo Factura]"
                        + " FROM Facturas"
                        + " WHERE Id_Factura like '%" + this.txtBusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Facturas");
                    this.dgvFacturas.DataSource = conexion.ds.Tables["Facturas"];
                    this.dgvFacturas.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbIdCliente.Checked == true)
            {
                try
                {
                    SQL = "SELECT Id_Factura AS ID, Fecha_Factura AS Fecha, Id_Cliente AS [ID Cliente], Id_Usuario AS [ID Usuario], Monto_Factura AS Monto, NCF_Factura AS [NCF Factura], Tipo_Factura AS [Tipo Factura]"
                        + " FROM Facturas"
                        + " WHERE Id_Cliente like '%" + this.txtBusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Facturas");
                    this.dgvFacturas.DataSource = conexion.ds.Tables["Facturas"];
                    this.dgvFacturas.Refresh();
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
                    SQL = "SELECT Id_Factura AS ID, Fecha_Factura AS Fecha, Id_Cliente AS [ID Cliente], Id_Usuario AS [ID Usuario], Monto_Factura AS Monto, NCF_Factura AS [NCF Factura], Tipo_Factura AS [Tipo Factura]"
                        + " FROM Facturas"
                        + " WHERE Id_Usuario like '%" + this.txtBusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Facturas");
                    this.dgvFacturas.DataSource = conexion.ds.Tables["Facturas"];
                    this.dgvFacturas.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else if (this.rdbNCF.Checked == true)
            {
                try
                {
                    SQL = "SELECT Id_Factura AS ID, Fecha_Factura AS Fecha, Id_Cliente AS [ID Cliente], Id_Usuario AS [ID Usuario], Monto_Factura AS Monto, NCF_Factura AS [NCF Factura], Tipo_Factura AS [Tipo Factura]"
                        + " FROM Facturas"
                        + " WHERE NCF_Factura like '%" + this.txtBusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Facturas");
                    this.dgvFacturas.DataSource = conexion.ds.Tables["Facturas"];
                    this.dgvFacturas.Refresh();
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
                    SQL = "SELECT Id_Factura AS ID, Fecha_Factura AS Fecha, Id_Cliente AS [ID Cliente], Id_Usuario AS [ID Usuario], Monto_Factura AS Monto, NCF_Factura AS [NCF Factura], Tipo_Factura AS [Tipo Factura]"
                        + " FROM Facturas"
                        + " WHERE Tipo_Factura like '%" + this.txtBusqueda.Text.Trim() + "%'";
                    conexion.consultar(SQL, "Facturas");
                    this.dgvFacturas.DataSource = conexion.ds.Tables["Facturas"];
                    this.dgvFacturas.Refresh();
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
                    SQL = "SELECT Id_Factura AS ID, Fecha_Factura AS Fecha, Id_Cliente AS [ID Cliente], Id_Usuario AS [ID Usuario], Monto_Factura AS Monto, NCF_Factura AS [NCF Factura], Tipo_Factura AS [Tipo Factura]"
                        + " FROM Facturas"
                        + " WHERE Fecha_Factura BETWEEN '" + this.txtDesde.Text + "'  AND '" + this.txtHasta.Text + "'";
                    conexion.consultar(SQL, "Facturas");
                    this.dgvFacturas.DataSource = conexion.ds.Tables["Facturas"];
                    this.dgvFacturas.Refresh();
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
                    SQL = "SELECT Id_Factura AS ID, Fecha_Factura AS Fecha, Id_Cliente AS [ID Cliente], Id_Usuario AS [ID Usuario], Monto_Factura AS Monto, NCF_Factura AS [NCF Factura], Tipo_Factura AS [Tipo Factura]"
                        + " FROM Facturas"
                        + " WHERE Monto_Factura Between '" + this.txtDesde.Text + "'  And '" + this.txtHasta.Text + "'";
                    conexion.consultar(SQL, "Facturas");
                    this.dgvFacturas.DataSource = conexion.ds.Tables["Facturas"];
                    this.dgvFacturas.Refresh();
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
                    foreach (DataGridViewColumn item in dgvFacturas.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }


                    //se crean las filas de la tabla
                    foreach (DataGridViewRow item in dgvFacturas.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }

                    //se pasan los datos del datagridview a la tabla
                    foreach (DataGridViewColumn item in dgvFacturas.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgvFacturas.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgvFacturas[item.Index, itemx.Index].Value;
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
                    foreach (DataGridViewColumn item in dgvFacturas.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }


                    //se crean las filas de la tabla
                    foreach (DataGridViewRow item in dgvFacturas.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }

                    //se pasan los datos del datagridview a la tabla
                    foreach (DataGridViewColumn item in dgvFacturas.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgvFacturas.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgvFacturas[item.Index, itemx.Index].Value;
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
                    OF.GenerarDocumentoPDF(doc, dgvFacturas);
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
