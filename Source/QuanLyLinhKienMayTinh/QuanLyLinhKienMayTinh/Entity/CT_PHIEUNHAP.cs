//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyLinhKienMayTinh.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_PHIEUNHAP
    {
        public string Ma_CTPN { get; set; }
        public string MaPhieuNhap { get; set; }
        public string MaLK { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string GhiChu { get; set; }
    
        public virtual LINHKIEN LINHKIEN { get; set; }
        public virtual PHIEUNHAP PHIEUNHAP { get; set; }
    }
}
