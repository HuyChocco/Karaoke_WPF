//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKaraoke.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.ChamCongs = new HashSet<ChamCong>();
            this.HoaDons = new HashSet<HoaDon>();
        }
    
        public int maNV { get; set; }
        public string tenNV { get; set; }
        public Nullable<System.DateTime> ngaySinh { get; set; }
        public Nullable<int> maLoaiNV { get; set; }
        public Nullable<int> maCT { get; set; }
        public Nullable<int> maCS { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
    
        public virtual CaTruc CaTruc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChamCong> ChamCongs { get; set; }
        public virtual CoSo CoSo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual LoaiNhanVien LoaiNhanVien { get; set; }
    }
}
