﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckRequests.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VantEDGEPointEntities : DbContext
    {
        public VantEDGEPointEntities()
            : base("name=VantEDGEPointEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<check_detail> check_detail { get; set; }
        public virtual DbSet<check_request> check_request { get; set; }
        public virtual DbSet<check_request_action> check_request_action { get; set; }
        public virtual DbSet<check_request_audit> check_request_audit { get; set; }
        public virtual DbSet<check_request_detail> check_request_detail { get; set; }
        public virtual DbSet<check_request_postage> check_request_postage { get; set; }
        public virtual DbSet<check_request_processing_state> check_request_processing_state { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<media_order> media_order { get; set; }
        public virtual DbSet<media_order_detail> media_order_detail { get; set; }
    }
}
