﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EcommerceEntities : DbContext
    {
        public EcommerceEntities()
            : base("name=EcommerceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cart_Details> Cart_Details { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order_Status> Order_Status { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<Product_Image> Product_Image { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
    }
}