//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoParcial2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        public int Fact_id { get; set; }
        public string DESCRIPcion { get; set; }
        public Nullable<int> comp_id { get; set; }
    
        public virtual Compra Compra { get; set; }
    }
}