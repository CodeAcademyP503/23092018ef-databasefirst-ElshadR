//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Depazite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Credity
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> Person_Id { get; set; }
        public System.DateTime DateOfCredit { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
