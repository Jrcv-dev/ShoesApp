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
    
    public partial class SizeForProduct
    {
        public int IdSizeProduct { get; set; }
        public int IdProduct { get; set; }
        public int IdSize { get; set; }
    
        public virtual CatSizes CatSizes { get; set; }
        public virtual Products Products { get; set; }
    }
}
