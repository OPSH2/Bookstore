//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CT_HD
    {
        public string maHD { get; set; }
        public string maSP { get; set; }
        public Nullable<int> soLuong { get; set; }
        public Nullable<int> donGia { get; set; }
        public Nullable<int> thanhTien { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
