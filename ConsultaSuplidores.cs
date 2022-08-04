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
    public partial class ConsultaSuplidores : Form
    {
        ConexionSQL conexion = new ConexionSQL();
        string SQL;
        string ruta;

        public ConsultaSuplidores()
        {
            InitializeComponent();
        }
        private void LlenarDataGridView()
        {
            try
            {

                conexion.consultar("Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Suplidores.Id_Suplidor like '%" + this.txtCriterio.Text.Trim() + "%'" , "Suplidores");
                this.dgvRegistros.DataSource = conexion.ds.Tables["Suplidores"];
                this.dgvRegistros.Refresh();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void ConsultaSuplidores_Load(object sender, EventArgs e)
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

        private void rdbCelular_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCriterio.Visible = true;
            this.txtCriterio.Text = "";
            this.txtCriterio.Focus();
            this.gbxRango.Visible = false;
        }

        private void rdbTelefono_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCriterio.Visible = true;
            this.txtCriterio.Text = "";
            this.txtCriterio.Focus();
            this.gbxRango.Visible = false;
        }

        private void rdbRnc_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCriterio.Visible = true;
            this.txtCriterio.Text = "";
            this.txtCriterio.Focus();
            this.gbxRango.Visible = false;
        }

        private void rdbBalance_CheckedChanged(object sender, EventArgs e)
        {
            txtDesde.Text = "";
            txtHasta.Text = "";
            gbxRango.Visible = true;
            txtCriterio.Visible = false;
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
                SQL = "Select Id_Compra AS [ID Compra], Numero_Factura AS [Número Factura], Fecha_Compra AS [Fecha Compra], Id_Suplidor AS [ID Suplidor], Monto_Compra AS Monto, Id_Usuario AS [ID Usuario], Tipo_Factura_Compra AS Tipo, NCF_Compra AS NCF, Cantidad_Compra AS Cantidad From Compras where Id_Compra ='" + this.dgvRegistros[0, this.dgvRegistros.SelectedCells[0].RowIndex].Value.ToString() + "'";
                conexion.consultar(SQL, "Compras");
                this.dgvDetalles.DataSource = conexion.ds.Tables["Compras"];
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

                    conexion.consultar("Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Suplidores.Id_Suplidor like '%" + this.txtCriterio.Text.Trim() + "%'", "Suplidores");
                    this.dgvRegistros.DataSource = conexion.ds.Tables["Suplidores"];
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

                    conexion.consultar("Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Suplidores.Nombre_Suplidor like '%" + this.txtCriterio.Text.Trim() + "%'", "Suplidores");
                    this.dgvRegistros.DataSource = conexion.ds.Tables["Suplidores"];
                    this.dgvRegistros.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            if (this.rdbTelefono.Checked == true)
            {


                try
                {

                    conexion.consultar("Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Suplidores.Telefono_Suplidor like '%" + this.txtCriterio.Text.Trim() + "%'", "Suplidores");
                    this.dgvRegistros.DataSource = conexion.ds.Tables["Suplidores"];
                    this.dgvRegistros.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            if (this.rdbCelular.Checked == true)
            {


                try
                {

                    conexion.consultar("Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Suplidores.Celular_Suplidor like '%" + this.txtCriterio.Text.Trim() + "%'", "Suplidores");
                    this.dgvRegistros.DataSource = conexion.ds.Tables["Suplidores"];
                    this.dgvRegistros.Refresh();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            if (this.rdbRnc.Checked == true)
            {

                try
                {

                    conexion.consultar("Select Id_Suplidor AS [ID Suplidor], Nombre_Suplidor AS Nombre, Contacto_Suplidor AS Contacto, Telefono_Suplidor AS Teléfono, Celular_Suplidor AS Celular, Email_Suplidor AS [E-mail], Direccion_Suplidor AS Dirección, RNC_Suplidor AS RNC, Balance_Suplidor AS Balance From Suplidores where Suplidores.RNC_Suplidor like '%" + this.txtCriterio.Text.Trim() + "%'", "Suplidores");
                    this.dgvRegistros.DataSource = conexion.ds.Tables["Suplidores"];
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

                SQL = "SELECT Suplidores.Id_Suplidor AS Id,Suplidores.Nombre_Suplidor As Nombre,Suplidores.Telefono_Suplidor AS Teléfono, Suplidores.Celular_Suplidor AS Celular, Suplidores.Email_Suplidor  AS Email,Suplidores.Direccion_Suplidor AS Dirección,Suplidores.RNC_Suplidor AS RNC,Suplidores.Balance_Suplidor AS Balance FROM Suplidores where Suplidores.Balance_Suplidor Between '" + this.txtDesde.Text + "'  And '" + this.txtHasta.Text + "'";
                conexion.consultar(SQL, "Suplidores");
                this.dgvRegistros.DataSource = conexion.ds.Tables["Suplidores"];
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
