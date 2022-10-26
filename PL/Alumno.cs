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

            //Console.WriteLine("Inserte el semestre del alumno");
            //alumno.IdSemestre = int.Parse(Console.ReadLine());

            alumno.Semestre = new ML.Semestre();
            Console.WriteLine("Inserte el semestre del alumno");
            alumno.Semestre.IdSemestre = int.Parse(Console.ReadLine());



            ML.Result result = new ML.Result();
            //mandar la información al BL 
            result = BL.Alumno.AddSP(alumno);

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
        public static void Update()
        {

        }
        public static void Delete()
        {

        }
        public static void GetAll()
        {
            ML.Result result = BL.Alumno.GetAll();

            if (result.Correct)
            {
                foreach (ML.Alumno alumno in result.Objects)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("El id del alumno es:" + alumno.IdAlumno);
                    Console.WriteLine("El nombre del alumno es:" + alumno.Nombre);
                    Console.WriteLine("El apellido paterno del alumno es:" + alumno.ApellidoPaterno);
                    Console.WriteLine("El semestre del alumno es: " + alumno.Semestre.IdSemestre);
                    Console.WriteLine("-----------------------------------");
                }

            }
            else
            {
                Console.WriteLine("Ocurrio un error " + result.ErrorMessage);
            }
        }
        public static void GetById()
        {
            Console.WriteLine("Ingrese el id del alumno que desea consultar");
            int idAlumno = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            //result = BL.Alumno.GetById(idAlumno);

            if (result.Correct)
            {
                ML.Alumno alumno = new ML.Alumno();

                //unboxing
                alumno = (ML.Alumno)result.Object;

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("El id del alumno es: " + alumno.IdAlumno);
                Console.WriteLine("El nombre del alumno es: " + alumno.Nombre);
                Console.WriteLine("El apellido paterno del alumno es: " + alumno.ApellidoPaterno);
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("Ocurrio un error " + result.ErrorMessage);
            }
        }

    }
}
