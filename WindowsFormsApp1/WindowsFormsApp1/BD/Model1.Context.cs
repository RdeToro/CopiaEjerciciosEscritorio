﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.BD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CURSO_LOGISTICAEntities : DbContext
    {
        public CURSO_LOGISTICAEntities()
            : base("name=CURSO_LOGISTICAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AVISO_RECEPCIONES_CAB> AVISO_RECEPCIONES_CAB { get; set; }
        public virtual DbSet<AVISO_RECEPCIONES_LIN> AVISO_RECEPCIONES_LIN { get; set; }
    
        public virtual int PA_INSERTAR_AVISO_RECEPCION(Nullable<byte> eSTADO_AVISO, string cOD_PEDIDO, Nullable<int> iD_PROVEEDOR, Nullable<byte> tIPO_AVISO, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var eSTADO_AVISOParameter = eSTADO_AVISO.HasValue ?
                new ObjectParameter("ESTADO_AVISO", eSTADO_AVISO) :
                new ObjectParameter("ESTADO_AVISO", typeof(byte));
    
            var cOD_PEDIDOParameter = cOD_PEDIDO != null ?
                new ObjectParameter("COD_PEDIDO", cOD_PEDIDO) :
                new ObjectParameter("COD_PEDIDO", typeof(string));
    
            var iD_PROVEEDORParameter = iD_PROVEEDOR.HasValue ?
                new ObjectParameter("ID_PROVEEDOR", iD_PROVEEDOR) :
                new ObjectParameter("ID_PROVEEDOR", typeof(int));
    
            var tIPO_AVISOParameter = tIPO_AVISO.HasValue ?
                new ObjectParameter("TIPO_AVISO", tIPO_AVISO) :
                new ObjectParameter("TIPO_AVISO", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_INSERTAR_AVISO_RECEPCION", eSTADO_AVISOParameter, cOD_PEDIDOParameter, iD_PROVEEDORParameter, tIPO_AVISOParameter, rETCODE, mENSAJE);
        }
    }
}