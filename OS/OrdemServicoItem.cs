//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class OrdemServicoItem
    {
        public int ID { get; set; }
        public int OrdemServicoID { get; set; }
        public int MercadoriaID { get; set; }
        public decimal Preco { get; set; }
        public decimal Qtde { get; set; }
        public string Observacao { get; set; }
    
        public virtual Mercadoria Mercadoria { get; set; }
        public virtual OrdemServico OrdemServico { get; set; }
    }
}
