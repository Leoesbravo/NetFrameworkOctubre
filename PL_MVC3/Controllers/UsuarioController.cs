using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC3.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Result result = new ML.Result();
            result = BL.Alumno.GetAll();

            if (result.Correct)
            {
                ML.Alumno alumno = new ML.Alumno();
                alumno.Alumnos = result.Objects;
                return View(alumno);
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error al consultar los alumnos";
                return View();
            }
        }
        [HttpGet]
        public ActionResult Form(int? idAlumno)
        {
            ML.Alumno alumno = new ML.Alumno();
            alumno.Semestre = new ML.Semestre();

            ML.Result resultSemestre = new ML.Result();
            resultSemestre = BL.Semestre.GetAll();

            alumno.Semestre.Semestres = resultSemestre.Objects;
            if (idAlumno == null)
            {
                //

                return View(alumno);
            }
            else
            {

                //GetbyId
                ML.Result result = BL.Alumno.GetAll();

                if (result.Correct)
                {
                    alumno = (ML.Alumno)result.Object;

                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al consultar el alummno seleccionado";
                }
                return View(alumno);
            }
        }

            [HttpPost]
            public ActionResult Form(ML.Alumno alumno)
            {
                return View();
            }
        }
    }
