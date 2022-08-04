using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Trabajo_final
{
    class Exportar
    {
        StreamWriter w;


        string ruta;


        public string xpath { get { return ruta; } set { value = ruta; } }

        /// <summary>


        /// Constructor que establece el path del archivo


        /// </summary>


        /// <param name="path"></param>


        public Exportar(string path)
        {
            ruta = @path;
        }

        /// <summary>
        /// Exporta datos a un archivo
        /// </summary>
        /// <param name="titulos"></param>
        /// <param name="datos"></param>


        public void Export(ArrayList titulos, DataTable datos)
        {
            try
            {
                FileStream fs = new FileStream(ruta, FileMode.Create,FileAccess.ReadWrite);
                w = new StreamWriter(fs);
                string comillas = char.ConvertFromUtf32(34);
                StringBuilder html = new StringBuilder();
                html.Append(@"<!DOCTYPE html PUBLIC" + "-//W3C//DTD XHTML 1.0 Transitional//EN" + " http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd  " + ">");
                html.Append(@"<html xmlns=" + " http://www.w3.org/1999/xhtml " + ">");
                html.Append(@"<head>");
                html.Append(@"<meta http-equiv=" + comillas + "Content-Type" + comillas + "content=" + comillas + "text/html; charset=utf-8" + comillas + "/>");
                html.Append(@"<title>Untitled Document</title>");
                html.Append(@"</head>");
                html.Append(@"<body>");

                //Generando encabezados del archivo 
                //(aquí podemos dar el formato como a una tabla de HTML)

                html.Append(@"<table WIDTH=730 CELLSPACING=0 CELLPADDING=10 border=8 BORDERCOLOR=" + comillas + "#333366" + comillas + " bgcolor=" + comillas + "#FFFFFF" + comillas + ">");
                html.Append(@"<tr> <b>");

                foreach (object item in titulos)
                {
                    html.Append(@"<th>" + item.ToString() + "</th>");
                }

                html.Append(@"</b> </tr>");

                //Generando datos del archivo
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    html.Append(@"<tr>");

                    for (int j = 0; j < datos.Columns.Count; j++)
                    {
                        html.Append(@"<td>" + datos.Rows[i][j].ToString() + "</td>");
                    }

                    html.Append(@"</tr>");
                }

                html.Append(@"</body>");
                html.Append(@"</html>");
                w.Write(html.ToString());
                w.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } //Fin de la Función Export

        /// <summary>
        /// Genera un archivo CSV
        /// </summary>
        /// <param name="titulos"></param>
        /// <param name="datos"></param>
        public void ExportCSV(ArrayList titulos, DataTable datos)
        {
            try
            {
                FileStream fs = new FileStream(ruta, FileMode.Create, FileAccess.ReadWrite);
                w = new StreamWriter(fs);
                string comillas = char.ConvertFromUtf32(34);
                StringBuilder CSV = new StringBuilder();

                //Encabezados
                for (int i = 0; i < titulos.Count; i++)
                {


                    if (i != (titulos.Count - 1))


                        CSV.Append(comillas + titulos[i].ToString() + comillas + ",");


                    else


                        CSV.Append(comillas + titulos[i].ToString() + comillas


                                   + Environment.NewLine);


                }





                // se generan datos

                for (int i = 0; i < datos.Rows.Count; i++)
                {


                    for (int j = 0; j < datos.Columns.Count; j++)
                    {


                        if (j != (titulos.Count - 1))


                            CSV.Append(comillas + datos.Rows[i][j].ToString()


                                       + comillas + ",");


                        else


                            CSV.Append(comillas + datos.Rows[i][j].ToString()


                                       + comillas + Environment.NewLine);


                    }


                }


                w.Write(CSV.ToString()); //se escribe la cadena en el archivo


                w.Close();


            }


            catch (Exception ex)
            {


                throw ex;


            }


        } //Fin de ExportCSV


        //Función que genera el documento Pdf


        public void GenerarDocumentoPDF(Document document, DataGridView dg)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView
            PdfPTable datatable = new PdfPTable(dg.ColumnCount);

            //asignamos algunas propiedades para el diseño del pdf
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dg);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                datatable.AddCell(dg.Columns[i].HeaderText);
            }

            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < dg.RowCount; i++)
            {
                for (int j = 0; j < dg.ColumnCount; j++)
                {
                    datatable.AddCell(dg[j, i].Value.ToString());
                }
                datatable.CompleteRow();
            }

            //SE AGREGAR LA PDFPTABLE AL DOCUMENTO
            document.Add(datatable);
        }

        //Función que obtiene los tamaños de las columnas del grid

        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
    }
} // Fin de Clase Exportar



