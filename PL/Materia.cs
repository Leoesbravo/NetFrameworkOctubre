using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Materia
    {
        public static void Add()
        {
            //Instancia de un objeto 
            ML.Materia materia = new ML.Materia();

            Console.WriteLine("Inserte el nombre de la materia");
            materia.Nombre = Console.ReadLine();

            Console.WriteLine("Inserte los creditos de la materia");
            materia.Creditos = byte.Parse(Console.ReadLine());

            materia.Semestre = new ML.Semestre();
            Console.WriteLine("Inserte el semestre de la materia");
            materia.Semestre.IdSemestre = int.Parse(Console.ReadLine());



            ML.Result result = new ML.Result();
            //mandar la información al BL 
            result = BL.Materia.Add(materia);

            if (result.Correct == true)
            {
                Console.WriteLine("La materia se registro correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La materia no se registro" + result.ErrorMessage);
                Console.ReadKey();
            }

        }
        public static void Update()
        {
            //Instancia de un objeto 
            ML.Materia materia = new ML.Materia();

            Console.WriteLine("Inserte el Id de la materia ha modificar");
            materia.IdMateria = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el nombre de la materia");
            materia.Nombre = Console.ReadLine();

            Console.WriteLine("Inserte los creditos de la materia");
            materia.Creditos = byte.Parse(Console.ReadLine());

            materia.Semestre = new ML.Semestre();
            Console.WriteLine("Inserte el semestre de la materia");
            materia.Semestre.IdSemestre = int.Parse(Console.ReadLine());



            ML.Result result = new ML.Result();
            //mandar la información al BL 
            result = BL.Materia.Update(materia);

            if (result.Correct == true)
            {
                Console.WriteLine("La materia se actualizo correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La materia no se actualizo" + result.ErrorMessage);
                Console.ReadKey();
            }

        }
    }
}
