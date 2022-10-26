using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Materia
    {
        public static ML.Result Add(ML.Materia materia)
        {
            ML.Result result = new ML.Result();
            try
            {   //instancia de Result


                //SqlConnection es para conexión a sql server
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    //almacenar querys de sql y ejercutarlos 
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.CommandText = "MateriaAdd";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = context;
                        // ya tiene la sentencia y la conexión, hacen falta los parametros


                        //agregar parametros 
                        SqlParameter[] collection = new SqlParameter[3];

                        collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        collection[0].Value = materia.Nombre;

                        collection[1] = new SqlParameter("@Creditos", System.Data.SqlDbType.TinyInt);
                        collection[1].Value = materia.Creditos;

                        collection[2] = new SqlParameter("@IdSemestre", System.Data.SqlDbType.Int);
                        collection[2].Value = materia.Semestre.IdSemestre;

                        //pasarle a mi command los parametros
                        cmd.Parameters.AddRange(collection);

                        //Abrir la conexión
                        cmd.Connection.Open();

                        //ejecutando nuestra sentencia
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result Update(ML.Materia materia)
        {
            ML.Result result = new ML.Result();
            try
            {   //instancia de Result


                //SqlConnection es para conexión a sql server
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    //almacenar querys de sql y ejercutarlos 
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.CommandText = "MateriaUpdate";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = context;
                        // ya tiene la sentencia y la conexión, hacen falta los parametros


                        //agregar parametros 
                        SqlParameter[] collection = new SqlParameter[4];

                        collection[0] = new SqlParameter("@IdMateria", SqlDbType.Int);
                        collection[0].Value = materia.IdMateria;

                        collection[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        collection[1].Value = materia.Nombre;

                        collection[2] = new SqlParameter("@Creditos", System.Data.SqlDbType.TinyInt);
                        collection[2].Value = materia.Creditos;

                        collection[3] = new SqlParameter("@IdSemestre", System.Data.SqlDbType.Int);
                        collection[3].Value = materia.Semestre.IdSemestre;

                        //pasarle a mi command los parametros
                        cmd.Parameters.AddRange(collection);

                        //Abrir la conexión
                        cmd.Connection.Open();

                        //ejecutando nuestra sentencia
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static void Delete()
        {

        }
        public static void GetAll()
        {

        }
        public static void GetById()
        {

        }
    }
}
