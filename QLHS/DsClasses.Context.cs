﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLHS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookstoreEntities1 : DbContext
    {
        public BookstoreEntities1()
            : base("name=BookstoreEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CaLamViec> CaLamViecs { get; set; }
        public virtual DbSet<CT_CaLamViec> CT_CaLamViec { get; set; }
        public virtual DbSet<CT_HD> CT_HD { get; set; }
        public virtual DbSet<DanhMucSach> DanhMucSaches { get; set; }
        public virtual DbSet<DanhMucVanPhongPham> DanhMucVanPhongPhams { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}