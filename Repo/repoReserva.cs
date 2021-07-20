using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Repo
{
    public class repoReserva
    {
        public static int Actualizar(Enti.entiReserva r)
        {
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [dbo].[Reserva] SET [ID_Servicio] = @ID_Servicio ,[Detalle] = @Detalle,[Fecha_Reserva] = @Fecha_Reserva ,[Fecha_Modificar] = @Fecha_Modificar  WHERE ID_Reserva =@ID_Reserva ";

            #region Parametros
            //crear parametro
            SqlParameter q4 = new SqlParameter();
            q4.ParameterName = "@ID_Reserva";
            q4.Value = r.ID_Reserva;
            q4.SqlDbType = SqlDbType.Int;

            SqlParameter q = new SqlParameter();
            q.ParameterName = "@Fecha_Reserva";
            q.Value = r.Fecha_reserva;
            q.SqlDbType = SqlDbType.Date;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Fecha_Modificar";
            q1.Value = DateTime.Now;
            q1.SqlDbType = SqlDbType.DateTime;

            SqlParameter q2 = new SqlParameter();
            q2.ParameterName = "@ID_Servicio";
            q2.Value = r.ID_Servicio;
            q2.SqlDbType = SqlDbType.Int;

            SqlParameter q3 = new SqlParameter();
            q3.ParameterName = "@Detalle";
            q3.Value = r.Detalle;
            q3.SqlDbType = SqlDbType.VarChar;
           
           

            #endregion

            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q1);
            cmd.Parameters.Add(q2);
            cmd.Parameters.Add(q3);
            cmd.Parameters.Add(q4);
            sql.EjecutarSQL(cmd);
            sql.Cerrar();

            return 0;

        }
        
        public static int Borrar(DateTime Fecha_Reserva)
        {
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [dbo].[Reserva] SET [Estado] = @Estado, [Fecha_Modificar] = @Fecha_Modificar WHERE Fecha_Reserva=@Fecha_Reserva";

            #region Parametros
            //crear parametro
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@Fecha_Reserva";
            q.Value = Fecha_Reserva;
            q.SqlDbType = SqlDbType.Date;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Estado";
            q1.Value = 0;
            q1.SqlDbType = SqlDbType.Bit;

            SqlParameter q2 = new SqlParameter();
            q2.ParameterName = "@Fecha_Modificar";
            q2.Value = DateTime.Now;
            q2.SqlDbType = SqlDbType.DateTime;
            #endregion

            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q1);
            cmd.Parameters.Add(q2);
            sql.EjecutarSQL(cmd);
            sql.Cerrar();

            return 0;

        }
        
        public static int Agregar(Enti.entiReserva r)
        {
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [dbo].[Reserva] ([ID_Cliente],[ID_Servicio],[Estado],[Detalle],[Fecha_Reserva],[Fecha_Modificar])VALUES(@ID_Cliente,@ID_Servicio,@Estado,@Detalle,@Fecha_Reserva,@Fecha_Modificar)";

            #region Parametros
            //crear parametro
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@ID_Cliente";
            q.Value = r.ID_Cliente;
            q.SqlDbType = SqlDbType.Int;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@ID_Servicio";
            q1.Value = r.ID_Servicio;
            q1.SqlDbType = SqlDbType.Int;

            SqlParameter q2 = new SqlParameter();
            q2.ParameterName = "@Estado";
            q2.Value = 1;
            q2.SqlDbType = SqlDbType.Int;

            SqlParameter q3 = new SqlParameter();
            q3.ParameterName = "@Detalle";
            q3.Value = r.Detalle;
            q3.SqlDbType = SqlDbType.VarChar;

            SqlParameter q4 = new SqlParameter();
            q4.ParameterName = "@Fecha_Reserva";
            q4.Value = r.Fecha_reserva;
            q4.SqlDbType = SqlDbType.Date;

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
        
        public static Enti.entiReserva Traer(int ID_Reserva)
        {
            Enti.entiReserva l = new Enti.entiReserva();
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Reserva where ID_Reserva=@ID_Reserva AND Estado=@Estado";

            //crear parametro
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@ID_Reserva";
            q.Value = ID_Reserva;
            q.SqlDbType = SqlDbType.Int;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Estado";
            q1.Value = true;
            q1.SqlDbType = SqlDbType.Bit;

            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q1);

            l = LLenarObjeto1(sql.EjecutarSQL(cmd));
            sql.Cerrar();
            return l;
        }
        
        public static List<Enti.entiReserva> Traer_reserva(int ID_Cliente)
        {

            List<Enti.entiReserva> lista = new List<Enti.entiReserva>();
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Reserva where ID_Cliente=@ID_Cliente AND Estado=@Estado";

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

            lista = LLenarLista(sql.EjecutarSQL(cmd), lista);
            sql.Cerrar();
            return lista;
        }

        public static Enti.entiReserva Traer(DateTime Fecha_Reserva)
        {

            Enti.entiReserva lista = new Enti.entiReserva();
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
           
            cmd.CommandText = "Select * from [dbo].[Reserva] where Fecha_Reserva = @Fecha_Reserva AND Estado = @Estado";
            
            //crear parametro
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@Fecha_Reserva";
            q.Value = Fecha_Reserva;
            q.SqlDbType = SqlDbType.DateTime;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Estado";
            q1.Value = true;
            q1.SqlDbType = SqlDbType.Bit;

            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q1);

            lista = LLenarObjeto(sql.EjecutarSQL(cmd));
            sql.Cerrar();
            return lista;
        }

        private static List<Enti.entiReserva> LLenarLista(SqlDataReader dr, List<Enti.entiReserva> l)
        {
            while (dr.Read())
            {
                Enti.entiReserva r = new Enti.entiReserva();
                
                 r.ID_Reserva = int.Parse(dr["ID_Reserva"].ToString());
                r.Estado = bool.Parse(dr["Estado"].ToString());
                r.Detalle = dr["Detalle"].ToString();
                r.Fecha_mod = DateTime.Parse(dr["Fecha_Modificar"].ToString());
                r.ID_Cliente = int.Parse(dr["ID_Cliente"].ToString());
                r.ID_Servicio = int.Parse(dr["ID_Servicio"].ToString());
                r.Fecha_reserva = DateTime.Parse(dr["Fecha_Reserva"].ToString());
                        l.Add(r);
                
            }

            return l;
        }

        private static Enti.entiReserva LLenarObjeto(SqlDataReader dr)
        {
            Enti.entiReserva r = new Enti.entiReserva();           
           
               while (dr.Read())
                {
                    r.Detalle = (dr["Detalle"].ToString());
                    r.ID_Servicio = int.Parse(dr["ID_Servicio"].ToString());
                    r.Fecha_reserva = DateTime.Parse(dr["Fecha_Reserva"].ToString());
               
                }


             


                return r;
        }
        
        private static Enti.entiReserva LLenarObjeto1(SqlDataReader dr)
        {
            Enti.entiReserva r = new Enti.entiReserva();
            dr.Read();

            

               r.ID_Reserva = int.Parse(dr["ID_Reserva"].ToString());
                r.Detalle =(dr["Detalle"].ToString());
                r.ID_Servicio = int.Parse(dr["ID_Servicio"].ToString());
                r.Fecha_reserva = DateTime.Parse(dr["Fecha_Reserva"].ToString());
           
           


            return r;
        }
    }
}

