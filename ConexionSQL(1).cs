using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Trabajo_final
{
    class ConexionSQL
    {
        private string ServidorSQL = "Data source=.\\MSSQLSERVER01; initial catalog=Alquiler de servicios; trusted_connection=yes";
        public SqlConnection cn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        DataRow dr;

        public ConexionSQL()
        {
            conectar();
        }

        private void conectar()
        {
            cn = new SqlConnection(ServidorSQL);
        }

        //Consultar Registros SQL
        public void consultar(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        //Insertar Registros SQL
        public bool insertar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;                           
            }
        
        }

        //Eliminar Registros SQL
        public bool eliminar(string tabla, string condicion)
        {
            cn.Open();
            string sql = "delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Actualizar Registros SQL
        public bool actualizar(string tabla, string campos, string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + " set " + campos + " where " + condicion;
            Console.WriteLine(sql);
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable LllenarComboBox(string tabla)
        {
            string sql = "select * from " + tabla;
            da = new SqlDataAdapter(sql,cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }
    }
}
