using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Alumno
    {
        public static void Add(ML.Alumno alumno)
        {
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "INSERT INTO Alumno (Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Sexo) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @Sexo)";
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[5];

                        collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        collection[0].Value = alumno.Nombre;

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
