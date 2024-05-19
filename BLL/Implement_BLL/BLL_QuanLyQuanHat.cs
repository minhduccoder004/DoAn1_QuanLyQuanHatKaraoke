using BLL.Interface_BLL;
using DAL.Implement_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implement_BLL
{
    public class BLL_QuanLyQuanHat : I_BLL_QuanLyQuanHat
    {

        // Khai báo lớp DAL
        DAL_QuanLyQuanHat DAL = new DAL_QuanLyQuanHat();

        public void CapNhat_PhongDat(tblPhongDat tblPhongDat)
        {
            DAL.Update_PhongDat(tblPhongDat);
        }

        public void CapNhat_PhongHat(tblPhongHat tblPhongHat)
        {
            DAL.Update_PhongHat(tblPhongHat);
        }

        public List<tblKhachHang> DanhSachKhachHang()
        {
            return DAL.LayDuLieu_BangKhachHang();
        }

        public List<tblNhanVien> DanhSachNhanVien()
        {
            return DAL.LayDuLieu_BangNhanVien();
        }

        public List<tblPhongDat> DanhSachPhongDat_ChuaHoatDong()
        {
            return DAL.LayDuLieu_BangPhongDat().FindAll(x => x.TrangThaiPhongDat == 0);
        }

        public List<tblPhongDat> DanhSachPhongDat_DangHoatDong()
        {
            return DAL.LayDuLieu_BangPhongDat().FindAll(x => x.TrangThaiPhongDat == 1);
        }

        public List<tblPhongHat> DanhSachPhongHat()
        {
            return DAL.LayDuLieu_BangPhongHat();
        }

        public tblPhongDat GetPhongDatByID(string ID)
        {
            return DAL.LayDuLieu_BangPhongDat().Find(x => Equals(x.MaPhongDat.Trim(), ID.Trim()));
        }

        public tblGoiDichVu GetGoiDichVuByID(string IDPhongDat)
        {
            return DAL.LayDuLieu_BangGoiDichVu().Find(x => Equals(x.tblPhongDat.MaPhongDat.Trim(), IDPhongDat.Trim()));
        }

        public tblHoaDonBan GetHoaDonBanByID(string IDPhongDat)
        {
            return DAL.LayDuLieu_BangHoaDonBan().Find(x => Equals(x.tblPhongDat.MaPhongDat.Trim(), IDPhongDat.Trim()));
        }

        public string LayIDLoaiPhong(string IDPhongHat)
        {
            return DAL.LayDuLieu_BangPhongHat().Find(x => Equals(x.MaPhongHat.Trim(), IDPhongHat.Trim())).MaLoaiPhong.Trim();
        }

        public string LaySoDienThoai(string IDKhachHang)
        {
            return DAL.LayDuLieu_BangKhachHang().Find(x => Equals(x.MaKhachHang.Trim(), IDKhachHang.Trim())).SoDienThoai.Trim();
        }

        public string LayTenKhachHang(string ID)
        {
            return DAL.LayDuLieu_BangKhachHang().Find(x => Equals(x.MaKhachHang.Trim(), ID.Trim())).TenKhachHang.Trim();
        }

        public string LayTenLoaiPhong(string ID)
        {
            return DAL.LayDuLieu_BangLoaiPhong().Find(x => Equals(x.MaLoaiPhong.Trim(), ID.Trim())).TenLoaiPhong.Trim();
        }

        public string LayTenNhanVien(string ID)
        {
            return DAL.LayDuLieu_BangNhanVien().Find(x => Equals(x.MaNhanVien.Trim(), ID.Trim())).TenNhanVien.Trim();
        }

        public string LayTenPhong(string ID)
        {
            return DAL.LayDuLieu_BangPhongHat().Find(x => Equals(x.MaPhongHat.Trim(), ID.Trim())).TenPhongHat.Trim();
        }

        public void Xoa_GoiDichVu(tblGoiDichVu tblGoiDichVu)
        {
            DAL.Delete_GoiDichVu(tblGoiDichVu);
        }

        public void Xoa_HoaDonBan(tblHoaDonBan tblHoaDonBan)
        {
            DAL.Delete_HoaDonBan(tblHoaDonBan);
        }

        public void Xoa_PhongDat(tblPhongDat tblPhongDat)
        {
            DAL.Delete_PhongDat(tblPhongDat);
        }
    }
}
