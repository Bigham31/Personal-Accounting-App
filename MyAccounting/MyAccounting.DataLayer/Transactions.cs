//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyAccounting.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transactions
    {
        public int ID { get; set; }
        public int ContactID { get; set; }
        public int TypeID { get; set; }
        public int Amount { get; set; }
        public string Discription { get; set; }
        public System.DateTime DateTime { get; set; }
    
        public virtual AccountingType AccountingType { get; set; }
        public virtual Contacts Contacts { get; set; }
    }
}