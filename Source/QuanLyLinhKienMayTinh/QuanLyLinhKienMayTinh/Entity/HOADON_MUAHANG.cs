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
    
    public partial class HOADON_MUAHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON_MUAHANG()
        {
            this.CT_HOADONMUA = new HashSet<CT_HOADONMUA>();
        }
    
        public string MaHD { get; set; }
        public Nullable<System.DateTime> NgayMua { get; set; }
        public string MaNCC { get; set; }
        public string MaNV { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADONMUA> CT_HOADONMUA { get; set; }
        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
