using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Plantel
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LEscogidoProgramacionNCapasOctubreEntities context = new DL_EF.LEscogidoProgramacionNCapasOctubreEntities())
                {
                    var planteles = context.PlantelGetAll().ToList();
                    result.Objects = new List<object>();
                    if (planteles != null)
                    {
                        foreach (var objSemestre in planteles)
                        {

                            ML.Plantel plantel = new ML.Plantel();
                            plantel.IdPlantel = objSemestre.IdPlantel;
                            plantel.Nombre = objSemestre.Nombre;

                            result.Objects.Add(plantel);

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
