using System;
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

            //mandar la información al BL 
            BL.Alumno.Add(alumno);

        }
    
    }
}
