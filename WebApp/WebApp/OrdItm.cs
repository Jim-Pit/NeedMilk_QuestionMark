//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdItm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quanti { get; set; }
        public int Cus_ID { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
