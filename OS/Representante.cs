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
    
    public partial class Representante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Representante()
        {
            this.Mercadoria = new HashSet<Mercadoria>();
        }
    
        public int ID { get; set; }
        public int FornecedorID { get; set; }
        public string Nome { get; set; }
        public string TelefoneCel { get; set; }
    
        public virtual Fornecedor Fornecedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mercadoria> Mercadoria { get; set; }
    }
}