﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Banco : DbContext
    {
        public Banco()
            : base("name=Banco")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Mercadoria> Mercadoria { get; set; }
        public virtual DbSet<OrdemServico> OrdemServico { get; set; }
        public virtual DbSet<OrdemServicoItem> OrdemServicoItem { get; set; }
    
        public virtual ObjectResult<SpAnaliseVendasReport_Result> SpAnaliseVendasReport(Nullable<System.DateTime> dtInicial, Nullable<System.DateTime> dtFinal)
        {
            var dtInicialParameter = dtInicial.HasValue ?
                new ObjectParameter("dtInicial", dtInicial) :
                new ObjectParameter("dtInicial", typeof(System.DateTime));
    
            var dtFinalParameter = dtFinal.HasValue ?
                new ObjectParameter("dtFinal", dtFinal) :
                new ObjectParameter("dtFinal", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpAnaliseVendasReport_Result>("SpAnaliseVendasReport", dtInicialParameter, dtFinalParameter);
        }
    
        public virtual ObjectResult<Nullable<bool>> SpVerificaEstoque(Nullable<int> mercadoriaID, Nullable<decimal> qtdeDesejada)
        {
            var mercadoriaIDParameter = mercadoriaID.HasValue ?
                new ObjectParameter("MercadoriaID", mercadoriaID) :
                new ObjectParameter("MercadoriaID", typeof(int));
    
            var qtdeDesejadaParameter = qtdeDesejada.HasValue ?
                new ObjectParameter("QtdeDesejada", qtdeDesejada) :
                new ObjectParameter("QtdeDesejada", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("SpVerificaEstoque", mercadoriaIDParameter, qtdeDesejadaParameter);
        }
    }
}
