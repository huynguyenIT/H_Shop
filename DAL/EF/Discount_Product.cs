//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Discount_Product
    {
        public string Content { get; set; }
        public Nullable<double> Price_Dis { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public int Id_SanPham { get; set; }
    
        public virtual Product Product { get; set; }
    }
}