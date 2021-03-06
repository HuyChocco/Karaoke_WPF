﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyKaraokeEntities : DbContext
    {
        public QuanLyKaraokeEntities()
            : base("name=QuanLyKaraokeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<CaTruc> CaTrucs { get; set; }
        public virtual DbSet<ChamCong> ChamCongs { get; set; }
        public virtual DbSet<CoSo> CoSoes { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<LoaiKH> LoaiKHs { get; set; }
        public virtual DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int USP_chamCongNV(Nullable<int> maNV, Nullable<int> maCT, Nullable<System.DateTime> ngayChamCong, Nullable<double> diemChamCong)
        {
            var maNVParameter = maNV.HasValue ?
                new ObjectParameter("maNV", maNV) :
                new ObjectParameter("maNV", typeof(int));
    
            var maCTParameter = maCT.HasValue ?
                new ObjectParameter("maCT", maCT) :
                new ObjectParameter("maCT", typeof(int));
    
            var ngayChamCongParameter = ngayChamCong.HasValue ?
                new ObjectParameter("ngayChamCong", ngayChamCong) :
                new ObjectParameter("ngayChamCong", typeof(System.DateTime));
    
            var diemChamCongParameter = diemChamCong.HasValue ?
                new ObjectParameter("DiemChamCong", diemChamCong) :
                new ObjectParameter("DiemChamCong", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_chamCongNV", maNVParameter, maCTParameter, ngayChamCongParameter, diemChamCongParameter);
        }
    
        public virtual int USP_ChuyenPhong(Nullable<int> idRoom1, Nullable<int> idRoom2)
        {
            var idRoom1Parameter = idRoom1.HasValue ?
                new ObjectParameter("idRoom1", idRoom1) :
                new ObjectParameter("idRoom1", typeof(int));
    
            var idRoom2Parameter = idRoom2.HasValue ?
                new ObjectParameter("idRoom2", idRoom2) :
                new ObjectParameter("idRoom2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ChuyenPhong", idRoom1Parameter, idRoom2Parameter);
        }
    
        public virtual ObjectResult<USP_GetListBillByDate_Result> USP_GetListBillByDate(Nullable<System.DateTime> checkIn, Nullable<System.DateTime> checkOut)
        {
            var checkInParameter = checkIn.HasValue ?
                new ObjectParameter("checkIn", checkIn) :
                new ObjectParameter("checkIn", typeof(System.DateTime));
    
            var checkOutParameter = checkOut.HasValue ?
                new ObjectParameter("checkOut", checkOut) :
                new ObjectParameter("checkOut", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetListBillByDate_Result>("USP_GetListBillByDate", checkInParameter, checkOutParameter);
        }
    
        public virtual int USP_GopPhong(Nullable<int> maPhong1, Nullable<int> maPhong2)
        {
            var maPhong1Parameter = maPhong1.HasValue ?
                new ObjectParameter("maPhong1", maPhong1) :
                new ObjectParameter("maPhong1", typeof(int));
    
            var maPhong2Parameter = maPhong2.HasValue ?
                new ObjectParameter("maPhong2", maPhong2) :
                new ObjectParameter("maPhong2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_GopPhong", maPhong1Parameter, maPhong2Parameter);
        }
    
        public virtual int USP_KhuyenMaiKH(Nullable<int> maHD)
        {
            var maHDParameter = maHD.HasValue ?
                new ObjectParameter("maHD", maHD) :
                new ObjectParameter("maHD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_KhuyenMaiKH", maHDParameter);
        }
    
        public virtual ObjectResult<USP_LayDSHoaDonTheoNgayVaTrang_Result> USP_LayDSHoaDonTheoNgayVaTrang(Nullable<System.DateTime> checkIn, Nullable<System.DateTime> checkOut, Nullable<int> page)
        {
            var checkInParameter = checkIn.HasValue ?
                new ObjectParameter("checkIn", checkIn) :
                new ObjectParameter("checkIn", typeof(System.DateTime));
    
            var checkOutParameter = checkOut.HasValue ?
                new ObjectParameter("checkOut", checkOut) :
                new ObjectParameter("checkOut", typeof(System.DateTime));
    
            var pageParameter = page.HasValue ?
                new ObjectParameter("page", page) :
                new ObjectParameter("page", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_LayDSHoaDonTheoNgayVaTrang_Result>("USP_LayDSHoaDonTheoNgayVaTrang", checkInParameter, checkOutParameter, pageParameter);
        }
    
        public virtual ObjectResult<USP_LayDSPhong_Result> USP_LayDSPhong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_LayDSPhong_Result>("USP_LayDSPhong");
        }
    
        public virtual ObjectResult<Nullable<int>> USP_LaySoHoaDonTheoNgay(Nullable<System.DateTime> checkIn, Nullable<System.DateTime> checkOut)
        {
            var checkInParameter = checkIn.HasValue ?
                new ObjectParameter("checkIn", checkIn) :
                new ObjectParameter("checkIn", typeof(System.DateTime));
    
            var checkOutParameter = checkOut.HasValue ?
                new ObjectParameter("checkOut", checkOut) :
                new ObjectParameter("checkOut", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("USP_LaySoHoaDonTheoNgay", checkInParameter, checkOutParameter);
        }
    
        public virtual ObjectResult<USP_Login_Result> USP_Login(string userName, string passWord)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("passWord", passWord) :
                new ObjectParameter("passWord", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_Login_Result>("USP_Login", userNameParameter, passWordParameter);
        }
    
        public virtual int USP_ThanhToanHoaDon(Nullable<int> maHD, Nullable<int> giamGia, Nullable<double> tongTien)
        {
            var maHDParameter = maHD.HasValue ?
                new ObjectParameter("maHD", maHD) :
                new ObjectParameter("maHD", typeof(int));
    
            var giamGiaParameter = giamGia.HasValue ?
                new ObjectParameter("giamGia", giamGia) :
                new ObjectParameter("giamGia", typeof(int));
    
            var tongTienParameter = tongTien.HasValue ?
                new ObjectParameter("tongTien", tongTien) :
                new ObjectParameter("tongTien", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ThanhToanHoaDon", maHDParameter, giamGiaParameter, tongTienParameter);
        }
    
        public virtual int USP_ThemCTHD(Nullable<int> maHD, Nullable<int> maSP, Nullable<int> soLuong)
        {
            var maHDParameter = maHD.HasValue ?
                new ObjectParameter("maHD", maHD) :
                new ObjectParameter("maHD", typeof(int));
    
            var maSPParameter = maSP.HasValue ?
                new ObjectParameter("maSP", maSP) :
                new ObjectParameter("maSP", typeof(int));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("soLuong", soLuong) :
                new ObjectParameter("soLuong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ThemCTHD", maHDParameter, maSPParameter, soLuongParameter);
        }
    
        public virtual int USP_ThemCTHD2(Nullable<int> maHD, Nullable<int> maSP, Nullable<int> soLuong)
        {
            var maHDParameter = maHD.HasValue ?
                new ObjectParameter("maHD", maHD) :
                new ObjectParameter("maHD", typeof(int));
    
            var maSPParameter = maSP.HasValue ?
                new ObjectParameter("maSP", maSP) :
                new ObjectParameter("maSP", typeof(int));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("soLuong", soLuong) :
                new ObjectParameter("soLuong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ThemCTHD2", maHDParameter, maSPParameter, soLuongParameter);
        }
    
        public virtual int USP_ThemHoaDon(Nullable<int> maPhong, Nullable<int> maNV, string tenKH, string sdt)
        {
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("maPhong", maPhong) :
                new ObjectParameter("maPhong", typeof(int));
    
            var maNVParameter = maNV.HasValue ?
                new ObjectParameter("maNV", maNV) :
                new ObjectParameter("maNV", typeof(int));
    
            var tenKHParameter = tenKH != null ?
                new ObjectParameter("tenKH", tenKH) :
                new ObjectParameter("tenKH", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ThemHoaDon", maPhongParameter, maNVParameter, tenKHParameter, sdtParameter);
        }
    
        public virtual int USP_themKH(Nullable<int> maLoaiKH, string tenKH, string sDT, string diaChi, Nullable<int> diemTichLuy)
        {
            var maLoaiKHParameter = maLoaiKH.HasValue ?
                new ObjectParameter("MaLoaiKH", maLoaiKH) :
                new ObjectParameter("MaLoaiKH", typeof(int));
    
            var tenKHParameter = tenKH != null ?
                new ObjectParameter("TenKH", tenKH) :
                new ObjectParameter("TenKH", typeof(string));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            var diemTichLuyParameter = diemTichLuy.HasValue ?
                new ObjectParameter("DiemTichLuy", diemTichLuy) :
                new ObjectParameter("DiemTichLuy", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_themKH", maLoaiKHParameter, tenKHParameter, sDTParameter, diaChiParameter, diemTichLuyParameter);
        }
    
        public virtual int USP_TinhDiemKH(Nullable<int> maHD)
        {
            var maHDParameter = maHD.HasValue ?
                new ObjectParameter("maHD", maHD) :
                new ObjectParameter("maHD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_TinhDiemKH", maHDParameter);
        }
    
        public virtual ObjectResult<USP_tinhLuongThang_Result> USP_tinhLuongThang(Nullable<int> thang)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_tinhLuongThang_Result>("USP_tinhLuongThang", thangParameter);
        }
    
        public virtual int USP_UpdateAccount(string userName, string displayName, string password, string newPassword)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var displayNameParameter = displayName != null ?
                new ObjectParameter("displayName", displayName) :
                new ObjectParameter("displayName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var newPasswordParameter = newPassword != null ?
                new ObjectParameter("newPassword", newPassword) :
                new ObjectParameter("newPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_UpdateAccount", userNameParameter, displayNameParameter, passwordParameter, newPasswordParameter);
        }
    
        public virtual ObjectResult<USP_xemChamCong_Result> USP_xemChamCong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_xemChamCong_Result>("USP_xemChamCong");
        }
    
        public virtual ObjectResult<USP_XuatHoaDon_Result> USP_XuatHoaDon(Nullable<int> maHD)
        {
            var maHDParameter = maHD.HasValue ?
                new ObjectParameter("maHD", maHD) :
                new ObjectParameter("maHD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_XuatHoaDon_Result>("USP_XuatHoaDon", maHDParameter);
        }
    
        public virtual ObjectResult<USP_XuatHoaDon2_Result> USP_XuatHoaDon2(Nullable<int> maHD)
        {
            var maHDParameter = maHD.HasValue ?
                new ObjectParameter("maHD", maHD) :
                new ObjectParameter("maHD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_XuatHoaDon2_Result>("USP_XuatHoaDon2", maHDParameter);
        }
    }
}
