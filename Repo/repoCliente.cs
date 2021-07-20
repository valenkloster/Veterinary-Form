using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Repo
{
    public class repoCliente
    {
        public static int Actualizar(Enti.entiCliente c)
        {
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [dbo].[Cliente] SET [Email] = @Email,[Clave] = @Clave,[Fecha_Modificar] = @FechaModificacion WHERE ID=@ID";


            #region Parametros
            //crear parametro

            SqlParameter q = new SqlParameter();
            q.ParameterName = "@ID";
            q.Value = c.ID;
            q.SqlDbType = SqlDbType.Int;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Email";
            q1.Value = c.Email;
            q1.SqlDbType = SqlDbType.VarChar;

            SqlParameter q2 = new SqlParameter();
            q2.ParameterName = "@Clave";
            q2.Value = c.Clave;
            q2.SqlDbType = SqlDbType.VarChar;

            SqlParameter q3 = new SqlParameter();
            q3.ParameterName = "@FechaModificacion";
            q3.Value = DateTime.Now;
            q3.SqlDbType = SqlDbType.DateTime;

            #endregion

            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q1);
            cmd.Parameters.Add(q2);
            cmd.Parameters.Add(q3);
            sql.EjecutarSQL(cmd);
            sql.Cerrar();

            return 0;

        }

        public static int CambiarClave(Enti.entiCliente c)
        {
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE [dbo].[Cliente] SET [Clave] = @Clave,[Fecha_Modificar] = @FechaModificacion WHERE ID=@ID";

            //crear parametro

            SqlParameter q = new SqlParameter();
            q.ParameterName = "@ID";
            q.Value = c.ID;
            q.SqlDbType = SqlDbType.Int;


            SqlParameter q2 = new SqlParameter();
            q2.ParameterName = "@Clave";
            q2.Value = c.Clave;
            q2.SqlDbType = SqlDbType.VarChar;

            SqlParameter q3 = new SqlParameter();
            q3.ParameterName = "@FechaModificacion";
            q3.Value = DateTime.Now;
            q3.SqlDbType = SqlDbType.DateTime;


            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q2);
            cmd.Parameters.Add(q3);

            sql.EjecutarSQL(cmd);
            sql.Cerrar();

            return 0;

        }

        public static int Borrar(int ID)
        {
            int error = 0;
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE[dbo].[Cliente] SET[Estado] = @Estado, [Fecha_Modificar] = @Fecha_Modificar WHERE ID=@ID";

            #region Parametros
            //crear parametro
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@ID";
            q.Value = ID;
            q.SqlDbType = SqlDbType.Int;

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

        public static int Agregar(Enti.entiCliente c)
        {
            int error = 0;
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [dbo].[Cliente] ([Apellido],[Nombre],[Email],[Estado],[Clave],[Fecha_ingreso],[Fecha_Modificar]) VALUES(@Apellido, @Nombre, @Email, @Estado, @Clave, @FechaIngreso, @FechaModificacion)";

            ////uso parametros:
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@Nombre";
            q.Value = c.Nombre;
            q.SqlDbType = SqlDbType.VarChar;

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Apellido";
            q1.Value = c.Apellido;
            q1.SqlDbType = SqlDbType.VarChar;

            SqlParameter q2 = new SqlParameter();
            q2.ParameterName = "@Email";
            q2.Value = c.Email;
            q2.SqlDbType = SqlDbType.VarChar;

            SqlParameter q3 = new SqlParameter();
            q3.ParameterName = "@Estado";
            q3.Value = 1;
            q3.SqlDbType = SqlDbType.Bit;

            SqlParameter q4 = new SqlParameter();
            q4.ParameterName = "@Clave";
            q4.Value = c.Clave;
            q4.SqlDbType = SqlDbType.VarChar;

            SqlParameter q5 = new SqlParameter();
            q5.ParameterName = "@FechaIngreso";
            q5.Value = c.Fecha_ingreso;
            q5.SqlDbType = SqlDbType.DateTime;

            SqlParameter q6 = new SqlParameter();
            q6.ParameterName = "@FechaModificacion";
            q6.Value = c.Fecha_mod;
            q6.SqlDbType = SqlDbType.DateTime;


            cmd.Parameters.Add(q);
            cmd.Parameters.Add(q1);
            cmd.Parameters.Add(q2);
            cmd.Parameters.Add(q3);
            cmd.Parameters.Add(q4);
            cmd.Parameters.Add(q5);
            cmd.Parameters.Add(q6);
            try //atrapo errores
            {
                sql.EjecutarSQL(cmd); //ejecuto el comando
            }
            catch (Exception ex)
            {
                error = -1; 
                return error;
            }

            sql.Cerrar(); //cierro
            return error;

        }

        public static Enti.entiCliente Traer(string Email)
        {

            Enti.entiCliente client = new Enti.entiCliente();
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Cliente where Email=@Email";

            //crear parametro
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@Email";
            q.Value = Email;
            q.SqlDbType = SqlDbType.VarChar;

            cmd.Parameters.Add(q);



            client = LLenarObjeto(sql.EjecutarSQL(cmd));
            sql.Cerrar();
            return client;
        }
        
        public static Enti.entiCliente Traer(string Email, string Clave)
        {

            Enti.entiCliente client = new Enti.entiCliente();
            context.AccesoSqlServer sql = new context.AccesoSqlServer();
            SqlConnection con = sql.Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Cliente where Email=@Email";

            //crear parametro
            SqlParameter q = new SqlParameter();
            q.ParameterName = "@Email";
            q.Value = Email;
            q.SqlDbType = SqlDbType.VarChar;

            cmd.Parameters.Add(q);

            SqlParameter q1 = new SqlParameter();
            q1.ParameterName = "@Clave";
            q1.Value = Clave;
            q1.SqlDbType = SqlDbType.VarChar;

            cmd.Parameters.Add(q1);


            client = LLenarObjeto(sql.EjecutarSQL(cmd));
            sql.Cerrar();
            return client;
        }
        
        private static Enti.entiCliente LLenarObjeto(SqlDataReader dr)
        {
            Enti.entiCliente c = new Enti.entiCliente();

             while (dr.Read())
            {
                c.ID = int.Parse(dr["ID"].ToString());
                c.Nombre = dr["Nombre"].ToString();
                c.Clave = dr["Clave"].ToString();
                c.Apellido = dr["Apellido"].ToString();
                c.Email = dr["Email"].ToString();
                c.Estado = bool.Parse(dr["Estado"].ToString());
                c.Fecha_mod = DateTime.Parse(dr["Fecha_Modificar"].ToString());
                c.Fecha_ingreso = DateTime.Parse(dr["Fecha_ingreso"].ToString());

            } 

            return c;
        }
    }
}
