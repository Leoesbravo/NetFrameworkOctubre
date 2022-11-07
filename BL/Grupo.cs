using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Grupo
    {
        public static ML.Result GetByIdPlantel(int idPlantel)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.IEspinozaProgramacionNCapasGenOctubreEntities1 context = new DL_EF.IEspinozaProgramacionNCapasGenOctubreEntities1())
                {
                    var usuarios = context.GrupoGetByIdPlantel(idPlantel).ToList();
                    result.Objects = new List<object>();
                    if (usuarios != null)
                    {
                        foreach (var objSemestre in usuarios)
                        {

                            ML.Grupo grupo = new ML.Grupo();
                            grupo.IdGrupo = objSemestre.IdGrupo;
                            grupo.Nombre = objSemestre.Nombre;
                        
                            grupo.Plantel = new ML.Plantel();
                            grupo.Plantel.IdPlantel = idPlantel;

                            result.Objects.Add(grupo);

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
