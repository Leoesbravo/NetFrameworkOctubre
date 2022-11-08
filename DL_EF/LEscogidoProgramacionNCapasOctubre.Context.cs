﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL_EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LEscogidoProgramacionNCapasOctubreEntities : DbContext
    {
        public LEscogidoProgramacionNCapasOctubreEntities()
            : base("name=LEscogidoProgramacionNCapasOctubreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumno> Alumnoes { get; set; }
        public virtual DbSet<Materia> Materias { get; set; }
        public virtual DbSet<Semestre> Semestres { get; set; }
        public virtual DbSet<Grupo> Grupoes { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }
        public virtual DbSet<Plantel> Plantels { get; set; }
    
        public virtual int AlumnoAdd(string nombre, string apellidoPaterno, string apellidoMaterno, Nullable<System.DateTime> fechaNacimiento, string sexo, Nullable<int> idSemestre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var idSemestreParameter = idSemestre.HasValue ?
                new ObjectParameter("IdSemestre", idSemestre) :
                new ObjectParameter("IdSemestre", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AlumnoAdd", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, fechaNacimientoParameter, sexoParameter, idSemestreParameter);
        }
    
        public virtual int MateriaAdd(string nombre, Nullable<byte> creditos, Nullable<int> idSemestre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var creditosParameter = creditos.HasValue ?
                new ObjectParameter("Creditos", creditos) :
                new ObjectParameter("Creditos", typeof(byte));
    
            var idSemestreParameter = idSemestre.HasValue ?
                new ObjectParameter("IdSemestre", idSemestre) :
                new ObjectParameter("IdSemestre", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MateriaAdd", nombreParameter, creditosParameter, idSemestreParameter);
        }
    
        public virtual int MateriaUpdate(Nullable<int> idMateria, string nombre, Nullable<byte> creditos, Nullable<int> idSemestre)
        {
            var idMateriaParameter = idMateria.HasValue ?
                new ObjectParameter("IdMateria", idMateria) :
                new ObjectParameter("IdMateria", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var creditosParameter = creditos.HasValue ?
                new ObjectParameter("Creditos", creditos) :
                new ObjectParameter("Creditos", typeof(byte));
    
            var idSemestreParameter = idSemestre.HasValue ?
                new ObjectParameter("IdSemestre", idSemestre) :
                new ObjectParameter("IdSemestre", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MateriaUpdate", idMateriaParameter, nombreParameter, creditosParameter, idSemestreParameter);
        }
    
        public virtual ObjectResult<SemestreGetAll_Result> SemestreGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SemestreGetAll_Result>("SemestreGetAll");
        }
    
        public virtual ObjectResult<AlumnoGetAll_Result> AlumnoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AlumnoGetAll_Result>("AlumnoGetAll");
        }
    
        public virtual ObjectResult<PlantelGetAll_Result> PlantelGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PlantelGetAll_Result>("PlantelGetAll");
        }
    
        public virtual ObjectResult<GrupoGetByIdPlantel_Result> GrupoGetByIdPlantel(Nullable<int> idPlantel)
        {
            var idPlantelParameter = idPlantel.HasValue ?
                new ObjectParameter("IdPlantel", idPlantel) :
                new ObjectParameter("IdPlantel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GrupoGetByIdPlantel_Result>("GrupoGetByIdPlantel", idPlantelParameter);
        }
    
        public virtual ObjectResult<AlumnoGetById_Result> AlumnoGetById(Nullable<int> idAlumno)
        {
            var idAlumnoParameter = idAlumno.HasValue ?
                new ObjectParameter("IdAlumno", idAlumno) :
                new ObjectParameter("IdAlumno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AlumnoGetById_Result>("AlumnoGetById", idAlumnoParameter);
        }
    }
}
