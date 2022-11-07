using Microsoft.Ajax.Utilities;
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
            result = BL.Alumno.GetAllEF();

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
        [HttpGet]//muestra las vistas
        public ActionResult Form(int? idAlumno)
        {
            ML.Alumno alumno = new ML.Alumno();
            alumno.Semestre = new ML.Semestre();
            alumno.Horario = new ML.Horario();
            alumno.Horario.Grupo = new ML.Grupo();
            alumno.Horario.Grupo.Plantel = new ML.Plantel();

            ML.Result resultPlanteles = BL.Plantel.GetAll();
            ML.Result resultSemestre = BL.Semestre.GetAll();

            if (idAlumno == null)
            {
                alumno.Semestre.Semestres = resultSemestre.Objects;
                alumno.Horario.Grupo.Plantel.Planteles = resultPlanteles.Objects;
                return View(alumno);
            }
            else
            {

                //GetbyId
                ML.Result result = BL.Alumno.GetById(idAlumno.Value);

                if (result.Correct)
                {
                    alumno = (ML.Alumno)result.Object;
                    alumno.Semestre.Semestres = resultSemestre.Objects;

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
            ML.Result result = new ML.Result();
            if(alumno.IdAlumno == 0)
            {
                result = BL.Alumno.AddSP(alumno);
                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se ha registrado el alumno";
                    return PartialView("Modal");
                }
                else
                {
                    ViewBag.Mensaje = "No ha registrado el alumno" + result.ErrorMessage;
                    return PartialView("Modal");
                }
            }
            else
            {
                //result = BL.Alumno.UpdateEF(alumno);
                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se ha registrado el alumno";
                    return PartialView("Modal");
                }
                else
                {
                    ViewBag.Mensaje = "No ha registrado el alumno" + result.ErrorMessage;
                    return PartialView("Modal");
                }
            }
        }
        [HttpGet]
        public ActionResult Delete(int IdAlumno)
        {
            ML.Result result = new ML.Result();
            //result = BL.Alumno.DeleteEF(IdAlumno);
            if (result.Correct)
            {
                ViewBag.Mensaje = "Se ha elimnado el registro";
                return PartialView("Modal");
            }
            else
            {
                ViewBag.Mensaje = "No see ha elimnado el registro" + result.ErrorMessage;
                return PartialView("Modal");
            }
        }

        public JsonResult GetGrupo(int IdPlantel)
        {
            var result = BL.Grupo.GetByIdPlantel(IdPlantel);

            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetHorario(int IdPlantel)
        {
            var result = BL.Grupo.GetByIdPlantel(IdPlantel);

            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }
    }
}
