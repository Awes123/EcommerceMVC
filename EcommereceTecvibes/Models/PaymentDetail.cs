//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommereceTecvibes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentDetail
    {
        public int Payment_ID { get; set; }
        public Nullable<int> Order_ID { get; set; }
        public string Payment_By { get; set; }
        public string Payment_Status { get; set; }
        public string Transaction_ID { get; set; }
        public Nullable<System.DateTime> Date_Created { get; set; }
        public Nullable<System.DateTime> Date_Modified { get; set; }
    
        public virtual OrderDetail OrderDetail { get; set; }
    }
}