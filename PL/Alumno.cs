﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Alumno //solicitar información, recompilar información, capturar información 
    {
        public static void Add()
        {
            //Instancia de un objeto 
            ML.Alumno alumno = new ML.Alumno();

            Console.WriteLine("Inserte el nombre del alumno");
            alumno.Nombre = Console.ReadLine();
            
            Console.WriteLine("Inserte el apellido paterno del alumno");
            alumno.ApellidoPaterno = Console.ReadLine();
            
            Console.WriteLine("Inserte el apellido materno del alumno");
            alumno.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Inserte la fecha de nacimiento del alumno");
            alumno.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Inserte el sexo del alumno");
            alumno.Sexo = Console.ReadLine();

            
            ML.Result result = new ML.Result();
            //mandar la información al BL 
            result = BL.Alumno.Add(alumno);

            if (result.Correct == true)
            {
                Console.WriteLine("El alumno se registro correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El alumno no se registro" + result.ErrorMessage);
                Console.ReadKey();
            }

        }
    
    }
}