//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Raamen.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CartDetail
    {
        public int CartDetailId { get; set; }
        public int CartId { get; set; }
        public int RamenId { get; set; }
        public int Quantity { get; set; }
    
        public virtual Cart Cart { get; set; }
        public virtual Raman Raman { get; set; }
    }
}