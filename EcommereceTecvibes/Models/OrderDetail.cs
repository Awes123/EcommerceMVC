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
    
    public partial class OrderDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderDetail()
        {
            this.Order_Status = new HashSet<Order_Status>();
            this.PaymentDetails = new HashSet<PaymentDetail>();
        }
    
        public int Order_ID { get; set; }
        public Nullable<int> Cart_ID { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public Nullable<decimal> FinalAmount { get; set; }
        public Nullable<decimal> Discount_Amount { get; set; }
        public Nullable<decimal> DeliveryCharges { get; set; }
        public Nullable<System.DateTime> Date_Created { get; set; }
        public Nullable<System.DateTime> Date_Modified { get; set; }
    
        public virtual Cart_Details Cart_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Status> Order_Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentDetail> PaymentDetails { get; set; }
    }
}