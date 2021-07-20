using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace context
{
    public class AccesoSqlServer
    {

        private SqlConnection con;

        public AccesoSqlServer() {
            con = new SqlConnection();
        }
        private string ArmarConnectionString() {
            return @"Data Source=DESKTOP-2ETJA7N;Initial Catalog=Veterinaria;User ID=UCEMA;Password=1";
        }
        public SqlConnection Abrir() {
            con.ConnectionString = ArmarConnectionString();
            con.Open();
            return con;
        }
        public void Cerrar() {
            con.Close();
        }

        public SqlDataReader EjecutarSQL(SqlCommand cmd) {

            SqlDataReader dr;                        
            dr = cmd.ExecuteReader();           
            return dr;

        }
        public void EjecutarSQLScalar(SqlCommand cmd)
        {
            cmd.ExecuteNonQuery();
        }
    }
}
