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
    
    public partial class UserDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserDetail()
        {
            this.Cart_Details = new HashSet<Cart_Details>();
        }
    
        public int User_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] HashPassword { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> Date_Created { get; set; }
        public Nullable<System.DateTime> Date_Modified { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart_Details> Cart_Details { get; set; }
    }
}
