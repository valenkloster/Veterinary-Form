using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Repo
{
    public class repoServicio
    {

        public static List<Enti.entiServicio> Traer()
        {
            List<Enti.entiServicio> lista = new List<Enti.entiServicio>();
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Servicio where Estado=@Estado";
            
            //crear parametro
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@Estado";
            q.Value = true;
            q.SqlDbType = SqlDbType.Bit;

            cmd.Parameters.Add(q);

            lista = LlenarLista(sql.EjecutarSQL(cmd), lista);
            sql.Cerrar();


            return lista;
        }

        public static Enti.entiServicio Traer(int ID)
        {
            Enti.entiServicio l = new Enti.entiServicio();
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Servicio where ID=@ID";

            //crear parametro
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@ID";
            q.Value = ID;
            q.SqlDbType = SqlDbType.Int;

            cmd.Parameters.Add(q);

            l = LlenarObjeto(sql.EjecutarSQL(cmd));
            sql.Cerrar();


            return l;
        } 

        private static List<Enti.entiServicio> LlenarLista(SqlDataReader DR, List<Enti.entiServicio> l)
        {
            while (DR.Read())
            {
                Enti.entiServicio s = new Enti.entiServicio();
               
                    s.ID = int.Parse(DR["ID"].ToString());
                    s.Nombre = DR["Nombre"].ToString();
                    s.Precio = float.Parse(DR["Precio"].ToString());
                    s.Detalle = DR["Detalle"].ToString();
                    s.Estado = true;
                    s.Fecha_ingreso = DateTime.Parse(DR["Fecha_ingreso"].ToString());
                    s.Fecha_mod = DateTime.Parse(DR["Fecha_Modificar"].ToString());

                l.Add(s);
                   
                   
                
            }
            return l;
        }

        private static Enti.entiServicio LlenarObjeto(SqlDataReader DR)
        {
            Enti.entiServicio s = new Enti.entiServicio();

            while (DR.Read())
            {
                if (s.Estado == true)
                {
                    s.ID = int.Parse(DR["ID"].ToString());
                    s.Nombre = DR["Nombre"].ToString();
                    s.Precio = float.Parse(DR["Precio"].ToString());
                    s.Detalle = DR["Detalle"].ToString();
                    s.Fecha_ingreso= DateTime.Parse(DR["Fecha_ingreso"].ToString());
                    s.Fecha_mod= DateTime.Parse(DR["Fecha_Modificar"].ToString());

                    s.Estado = true;

                }
            }
            return s;
        }
    }
}
