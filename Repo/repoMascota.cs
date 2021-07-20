using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Repo
{
    public class repoMascota
    {
        public static int Actualizar(Enti.entiMascota m)
        {
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [dbo].[Mascota] SET [Nombre] = @Nombre,[TipoAnimal] = @TipoAnimal,[Raza] = @Raza,[DetalleMascota] = @DetalleMascota,[Fecha_Modificar] = @Fecha_Modificar WHERE ID_Mascota=@ID_Mascota ";


            #region Parametros
            //crear parametro

            SqlParameter q = new SqlParameter();
            q.ParameterName = "@ID_Mascota";
            q.Value = m.ID_Mascota;
            q.SqlDbType = SqlDbType.Int;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Nombre";
            q1.Value  = m.Nombre ;
            q1.SqlDbType = SqlDbType.VarChar;

            SqlParameter q2 = new SqlParameter();
            q2.ParameterName = "@TipoAnimal";
            q2.Value = m.TipoAnimal ;
            q2.SqlDbType = SqlDbType.VarChar;


            SqlParameter q3 = new SqlParameter();
            q3.ParameterName = "@Raza";
            q3.Value = m.Raza;
            q3.SqlDbType = SqlDbType.VarChar;

            SqlParameter q4 = new SqlParameter();
            q4.ParameterName = "@DetalleMascota";
            q4.Value = m.Detalle;
            q4.SqlDbType = SqlDbType.VarChar;

            SqlParameter q5 = new SqlParameter();
            q5.ParameterName = "@Fecha_Modificar";
            q5.Value = DateTime.Now;
            q5.SqlDbType = SqlDbType.DateTime;
            #endregion

            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q1);
            cmd.Parameters.Add(q2);
            cmd.Parameters.Add(q3);
            cmd.Parameters.Add(q4);
            cmd.Parameters.Add(q5);
            sql.EjecutarSQL(cmd);
            sql.Cerrar();

            return 0;

        }
        
        public static int Borrar(int ID_Mascota)
        {
            int error = 0;
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [dbo].[Mascota] SET [Estado] = @Estado, [Fecha_Modificar] = @Fecha_Modificar WHERE ID_Mascota=@ID_Mascota"; 

            SqlParameter q = new SqlParameter();
            q.ParameterName = "@ID_Mascota";
            q.Value = ID_Mascota;
            q.SqlDbType = SqlDbType.Int;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Estado";
            q1.Value = 0;
            q1.SqlDbType = SqlDbType.Bit;
            
            SqlParameter q2 = new SqlParameter();
            q2.ParameterName = "@Fecha_Modificar";
            q2.Value = DateTime.Now;
            q2.SqlDbType = SqlDbType.DateTime;

            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q1);
            cmd.Parameters.Add(q2);
            try
            {
                sql.EjecutarSQL(cmd);
            }
            catch (Exception)
            {
                error = -1;
            }
            sql.Cerrar();
            return error;

        }
        
        public static int Agregar(Enti.entiMascota m)
        {
            int error = 0;
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [dbo].[Mascota] ([ID_Cliente],[Nombre],[Estado],[TipoAnimal],[Raza],[DetalleMascota],[Fecha_ingreso],[Fecha_Modificar]) VALUES (@ID_Cliente,@Nombre,@Estado,@TipoAnimal,@Raza,@DetalleMascota,@Fecha_ingreso,@Fecha_Modificar)";

            ////uso parametros:
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@Nombre";
            q.Value = m.Nombre;
            q.SqlDbType = SqlDbType.VarChar;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Estado";
            q1.Value = 1;
            q1.SqlDbType = SqlDbType.Bit;

            SqlParameter q2 = new SqlParameter();
            q2.ParameterName = "@TipoAnimal";
            q2.Value = m.TipoAnimal;
            q2.SqlDbType = SqlDbType.VarChar;

            SqlParameter q3 = new SqlParameter();
            q3.ParameterName = "@Raza";
            q3.Value = m.Raza;
            q3.SqlDbType = SqlDbType.VarChar;

            SqlParameter q4 = new SqlParameter();
            q4.ParameterName = "@DetalleMascota";
            q4.Value = m.Detalle;
            q4.SqlDbType = SqlDbType.VarChar;

            SqlParameter q5 = new SqlParameter();
            q5.ParameterName = "@Fecha_ingreso";
            q5.Value = DateTime.Now;
            q5.SqlDbType = SqlDbType.DateTime;

            SqlParameter q6 = new SqlParameter();
            q6.ParameterName = "@Fecha_Modificar";
            q6.Value = DateTime.Now;
            q6.SqlDbType = SqlDbType.DateTime;

            SqlParameter q7 = new SqlParameter();
            q7.ParameterName = "@ID_Cliente";
            q7.Value = m.ID_Cliente;
            q7.SqlDbType = SqlDbType.Int;

            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q1);
            cmd.Parameters.Add(q2);
            cmd.Parameters.Add(q3);
            cmd.Parameters.Add(q4);
            cmd.Parameters.Add(q5);
            cmd.Parameters.Add(q6);
            cmd.Parameters.Add(q7);

            sql.EjecutarSQL(cmd);
            sql.Cerrar(); //cierro
            return error;
        }

        public static Enti.entiMascota Traer(int ID)
        {
            Enti.entiMascota l = new Enti.entiMascota();
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Mascota where ID_Mascota=@ID AND Estado=@Estado";

            //crear parametro
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@ID";
            q.Value = ID;
            q.SqlDbType = SqlDbType.Int;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Estado";
            q1.Value = true;
            q1.SqlDbType = SqlDbType.Bit;

            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q1);

            l = LlenarObjeto(sql.EjecutarSQL(cmd));
            sql.Cerrar();


            return l;
        }
        
        public static List<Enti.entiMascota> Traer_mascota(int ID_Cliente)
        {

            List<Enti.entiMascota> lista = new List<Enti.entiMascota>();
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Mascota where ID_Cliente=@ID_Cliente AND Estado=@Estado";

            //crear parametro
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@ID_Cliente";
            q.Value = ID_Cliente;
            q.SqlDbType = SqlDbType.Int;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Estado";
            q1.Value = true;
            q1.SqlDbType = SqlDbType.Bit;

            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q1);

            lista = LlenarLista(sql.EjecutarSQL(cmd), lista);
            sql.Cerrar();
            return lista;
        }

        private static List<Enti.entiMascota> LlenarLista(SqlDataReader DR, List<Enti.entiMascota> l)
        {
            while (DR.Read())
            {
                Enti.entiMascota m = new Enti.entiMascota();

                    m.ID_Mascota = int.Parse(DR["ID_Mascota"].ToString());
                    m.ID_Cliente = int.Parse(DR["ID_Cliente"].ToString());
                    m.Nombre = DR["Nombre"].ToString();
                    m.Raza = DR["Raza"].ToString();
                    m.TipoAnimal= DR["TipoAnimal"].ToString();
                    m.Detalle= DR["DetalleMascota"].ToString();
                    m.Fecha_ingreso = DateTime.Parse(DR["Fecha_ingreso"].ToString());
                    m.Fecha_mod = DateTime.Parse(DR["Fecha_Modificar"].ToString());
                    m.Estado = bool.Parse(DR["Estado"].ToString());

                l.Add(m);
               
            }
            return l;
        }

        private static Enti.entiMascota LlenarObjeto(SqlDataReader DR)
        {
            Enti.entiMascota m = new Enti.entiMascota();

            while (DR.Read())
            {
                m.ID_Mascota = int.Parse(DR["ID_Mascota"].ToString());
                m.ID_Cliente = int.Parse(DR["ID_Cliente"].ToString());
                m.Nombre = DR["Nombre"].ToString();
                m.Raza = DR["Raza"].ToString();
                m.TipoAnimal = DR["TipoAnimal"].ToString();
                m.Detalle = DR["DetalleMascota"].ToString();
                m.Fecha_ingreso = DateTime.Parse(DR["Fecha_ingreso"].ToString());
                m.Fecha_mod = DateTime.Parse(DR["Fecha_Modificar"].ToString());
                m.Estado = bool.Parse(DR["Estado"].ToString());
            }
            return m;
        }
    }
}
