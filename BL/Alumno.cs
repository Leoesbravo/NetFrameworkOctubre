﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //                   //almacenar querys de sql y ejercutarlos 
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
    }
}