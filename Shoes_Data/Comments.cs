//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shoes_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int IdComent { get; set; }
        public int IdProduct { get; set; }
        public int IdRating { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public System.DateTime DateCommnet { get; set; }
    
        public virtual CatRatings CatRatings { get; set; }
        public virtual Products Products { get; set; }
    }
}
