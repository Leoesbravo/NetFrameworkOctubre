using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BL
{
    public class Alumno
    {
        //Add sin Result
        //public static void Add(ML.Alumno alumno)
        //{
        //    try
        //    {           //SqlConnection es para conexión a sql server
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            //almacenar querys de sql y ejercutarlos 
        //            using (SqlCommand cmd = new SqlCommand())
        //            {

        //                cmd.CommandText = "INSERT INTO Alumno (Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Sexo) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @Sexo)";
        //                cmd.Connection = context;
        //                // ya tiene la sentencia y la conexión, hacen falta los parametros


        //                //agregar parametros 
        //                SqlParameter[] collection = new SqlParameter[5];

        //                collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
        //                collection[0].Value = alumno.Nombre;

        //                collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
        //                collection[1].Value = alumno.ApellidoPaterno;

        //                collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
        //                collection[2].Value = alumno.ApellidoMaterno;

        //                collection[3] = new SqlParameter("@FechaNacimiento", System.Data.SqlDbType.Date);
        //                collection[3].Value = alumno.FechaNacimiento;

        //                collection[4] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
        //                collection[4].Value = alumno.Sexo;

        //                //pasarle a mi command los parametros
        //                cmd.Parameters.AddRange(collection);

        //                //Abrir la conexión
        //                cmd.Connection.Open();

        //                //ejecutando nuestra sentencia
        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                if (rowsAffected > 0)
        //                {
        //                    Console.WriteLine("El alumno se ha agregado");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("El alumno no se registro ");
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //Add con Result
        public static ML.Result Add(ML.Alumno alumno)
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

                        cmd.CommandText = "INSERT INTO Alumno (Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Sexo) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @Sexo)";
                        cmd.Connection = context;
                        // ya tiene la sentencia y la conexión, hacen falta los parametros


                        //agregar parametros 
                        SqlParameter[] collection = new SqlParameter[5];

                        collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        collection[0].Value = alumno.Nombre;

                        collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                        collection[1].Value = alumno.ApellidoPaterno;

                        collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                        collection[2].Value = alumno.ApellidoMaterno;

                        collection[3] = new SqlParameter("@FechaNacimiento", System.Data.SqlDbType.Date);
                        collection[3].Value = alumno.FechaNacimiento;

                        collection[4] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                        collection[4].Value = alumno.Sexo;

                        //pasarle a mi command los parametros
                        cmd.Parameters.AddRange(collection);

                        //Abrir la conexión
                        cmd.Connection.Open();

                        //ejecutando nuestra sentencia
                        int rowsAffected = cmd.ExecuteNonQuery();

                        //cmd.Connection.Close();
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
        public static ML.Result AddSP(ML.Alumno alumno)
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

                        cmd.CommandText = "AlumnoAdd";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = context;
                        // ya tiene la sentencia y la conexión, hacen falta los parametros


                        //agregar parametros 
                        SqlParameter[] collection = new SqlParameter[6];

                        collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        collection[0].Value = alumno.Nombre;

                        collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                        collection[1].Value = alumno.ApellidoPaterno;

                        collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                        collection[2].Value = alumno.ApellidoMaterno;

                        collection[3] = new SqlParameter("@FechaNacimiento", System.Data.SqlDbType.VarChar);
                        collection[3].Value = alumno.FechaNacimiento;

                        collection[4] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                        collection[4].Value = alumno.Sexo;

                        collection[5] = new SqlParameter("@IdSemestre", System.Data.SqlDbType.Int);
                        collection[5].Value = alumno.Semestre.IdSemestre;

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
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "AlumnoGetAll";
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        //aqui voy a almacenar la información
                        DataTable tableAlumno = new DataTable();

                        //me permite llenar un data table
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        //adapter.SelectCommand = cmd;

                        //Llenar el datable tableAlumno
                        adapter.Fill(tableAlumno);

                        if (tableAlumno.Rows.Count > 0)
                        {
                            //mi lista
                            result.Objects = new List<object>();
                            foreach (DataRow row in tableAlumno.Rows)
                            {
                                ML.Alumno alumno = new ML.Alumno();
                                alumno.IdAlumno = int.Parse(row[0].ToString());
                                alumno.Nombre = row[1].ToString();
                                alumno.ApellidoPaterno = row[2].ToString();
                                alumno.ApellidoMaterno = row[3].ToString();
                                alumno.FechaNacimiento = row[4].ToString();
                                alumno.Sexo = row[5].ToString();

                                alumno.Semestre = new ML.Semestre();
                                alumno.Semestre.IdSemestre = int.Parse(row[6].ToString());
                                alumno.Semestre.Nombre = row[7].ToString();

                                result.Objects.Add(alumno);
                            }
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

            }
            return result;
        }
        public static ML.Result GetById(int idAlumno)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "AlumnoGetById";
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("@IdAlumno", SqlDbType.Int);
                        collection[0].Value = idAlumno;

                        cmd.Parameters.AddRange(collection);

                        //aqui voy a almacenar la información
                        DataTable tableAlumno = new DataTable();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        //adapter.SelectCommand = cmd;
                        adapter.Fill(tableAlumno);

                        if (tableAlumno.Rows.Count > 0)
                        {
                            DataRow row = tableAlumno.Rows[0];

                            ML.Alumno alumno = new ML.Alumno();
                            alumno.IdAlumno = int.Parse(row[0].ToString());
                            alumno.Nombre = row[1].ToString();
                            alumno.ApellidoPaterno = row[2].ToString();
                            alumno.ApellidoMaterno = row[3].ToString();
                            alumno.FechaNacimiento = row[4].ToString();
                            alumno.Sexo = row[5].ToString();

                            alumno.Semestre = new ML.Semestre();
                            alumno.Semestre.IdSemestre = int.Parse(row[6].ToString());

                            //boxing
                            //Almacenar cualquier tipo de dato en un dato object
                            result.Object = alumno;
                            //}
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

            }
            return result;
        }
        public static ML.Result AddLinq(ML.Alumno alumno)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LEscogidoProgramacionNCapasOctubreEntities context = new DL_EF.LEscogidoProgramacionNCapasOctubreEntities())
                {
                    DL_EF.Alumno alumnoDL = new DL_EF.Alumno();

                    alumnoDL.Nombre = alumno.Nombre;
                    alumnoDL.ApellidoPaterno = alumno.ApellidoPaterno;
                    alumnoDL.ApellidoMaterno = alumno.ApellidoMaterno;
                    alumnoDL.Sexo = alumno.Sexo;
                    alumnoDL.IdSemestre = alumno.Semestre.IdSemestre;

                    context.Alumnoes.Add(alumnoDL);

                    var query = context.SaveChanges();

                    if(query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result GetByIdLINQ(int idAlumno)
        {
            ML.Result Result = new ML.Result();

            try
            {
                using (DL_EF.LEscogidoProgramacionNCapasOctubreEntities Context = new DL_EF.LEscogidoProgramacionNCapasOctubreEntities())
                {
                    var ResultQuery = (from alumno in Context.Alumnoes
                                       where alumno.IdAlumno == idAlumno
                                       select new
                                       {
                                           alumno.IdAlumno,
                                           alumno.Nombre,
                                           alumno.IdSemestre,
                                           alumno.Sexo,
                                           alumno.FechaNacimiento,
                                           alumno.ApellidoPaterno,
                                           alumno.ApellidoMaterno
                                       }).FirstOrDefault();

                    if (ResultQuery != null)
                    {

                        ML.Alumno alumno = new ML.Alumno();
                        alumno.IdAlumno = ResultQuery.IdAlumno;
                        alumno.Nombre = ResultQuery.Nombre;
                        alumno.FechaNacimiento = ResultQuery.FechaNacimiento.ToString();
                        //DateTime.ParseExact(usuario.FechaNacimiento, "dd-MM-yyyy", null);
                        alumno.ApellidoMaterno = ResultQuery.ApellidoMaterno;

                        alumno.Semestre = new ML.Semestre();
                        alumno.Semestre.IdSemestre = ResultQuery.IdSemestre.Value;

                        Result.Object = alumno;
                        Result.Correct = true;
                    }
                    else
                    {
                        Result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Result.Correct = false;
                Result.ErrorMessage = ex.Message;
                Result.Ex = ex;
            }
            return Result;
        }
        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LEscogidoProgramacionNCapasOctubreEntities context = new DL_EF.LEscogidoProgramacionNCapasOctubreEntities())
                {
                    var usuarios = context.AlumnoGetAll().ToList();
                    result.Objects = new List<object>();
                    if (usuarios != null)
                    {
                        foreach (var objAlumno in usuarios)
                        {

                            ML.Alumno alumno = new ML.Alumno();
                            alumno.IdAlumno = objAlumno.IdAlumno;
                            alumno.Nombre = objAlumno.Nombre;
                            alumno.ApellidoPaterno = objAlumno.ApellidoPaterno;
                            alumno.ApellidoMaterno = objAlumno.ApellidoMaterno;
                            alumno.FechaNacimiento = objAlumno.FechaNacimiento.Value.ToString("dd-MM-yyyy");
                            alumno.Sexo = objAlumno.Sexo;

                            alumno.Semestre = new ML.Semestre();
                            alumno.Semestre.IdSemestre = objAlumno.IdSemestre.Value;
                            alumno.Semestre.Nombre = objAlumno.Semestre;                          

                            result.Objects.Add(alumno);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se ha podido realizar la consulta";

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
