//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class IEspinozaGMayoEntities : DbContext
    {
        public IEspinozaGMayoEntities()
            : base("name=IEspinozaGMayoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Materia> Materias { get; set; }
    
        public virtual int MateriaAdd(string nombre, Nullable<decimal> costo, Nullable<byte> creditos, string descripcion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var costoParameter = costo.HasValue ?
                new ObjectParameter("Costo", costo) :
                new ObjectParameter("Costo", typeof(decimal));
    
            var creditosParameter = creditos.HasValue ?
                new ObjectParameter("Creditos", creditos) :
                new ObjectParameter("Creditos", typeof(byte));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MateriaAdd", nombreParameter, costoParameter, creditosParameter, descripcionParameter);
        }
    
        public virtual int MateriaDelete(Nullable<int> idMateria)
        {
            var idMateriaParameter = idMateria.HasValue ?
                new ObjectParameter("IdMateria", idMateria) :
                new ObjectParameter("IdMateria", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MateriaDelete", idMateriaParameter);
        }
    
        public virtual ObjectResult<MateriaGetAll_Result> MateriaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MateriaGetAll_Result>("MateriaGetAll");
        }
    
        public virtual ObjectResult<MateriaGetById_Result> MateriaGetById(Nullable<int> idMateria)
        {
            var idMateriaParameter = idMateria.HasValue ?
                new ObjectParameter("IdMateria", idMateria) :
                new ObjectParameter("IdMateria", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MateriaGetById_Result>("MateriaGetById", idMateriaParameter);
        }
    
        public virtual int MateriaUpdate(Nullable<int> idMateria, string nombre, Nullable<decimal> costo, Nullable<byte> creditos, string descripcion)
        {
            var idMateriaParameter = idMateria.HasValue ?
                new ObjectParameter("IdMateria", idMateria) :
                new ObjectParameter("IdMateria", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var costoParameter = costo.HasValue ?
                new ObjectParameter("Costo", costo) :
                new ObjectParameter("Costo", typeof(decimal));
    
            var creditosParameter = creditos.HasValue ?
                new ObjectParameter("Creditos", creditos) :
                new ObjectParameter("Creditos", typeof(byte));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MateriaUpdate", idMateriaParameter, nombreParameter, costoParameter, creditosParameter, descripcionParameter);
        }
    }
}
