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
        public void CapNhat_PhongDat(tblPhongDat tblPhongDat)
        {
            new DAL_QuanLyQuanHat().Update_PhongDat(tblPhongDat);
        }

        public void CapNhat_PhongHat(tblPhongHat tblPhongHat)
        {
            new DAL_QuanLyQuanHat().Update_PhongHat(tblPhongHat);
        }

        public List<tblPhongDat> DanhSachPhongDat_ChuaHoatDong()
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangPhongDat().FindAll(x => x.TrangThaiPhongDat == 0);
        }

        public List<tblPhongDat> DanhSachPhongDat_DangHoatDong()
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangPhongDat().FindAll(x => x.TrangThaiPhongDat == 1);
        }

        public tblPhongDat GetPhongDatByID(string ID)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangPhongDat().Find(x => Equals(x.MaPhongDat.Trim(), ID.Trim()));
        }

        public tblGoiDichVu GetGoiDichVuByID(string IDPhongDat)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangGoiDichVu().Find(x => Equals(x.tblPhongDat.MaPhongDat.Trim(), IDPhongDat.Trim()));
        }

        public tblHoaDonBan GetHoaDonBanByID(string IDPhongDat)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangHoaDonBan().Find(x => Equals(x.tblPhongDat.MaPhongDat.Trim(), IDPhongDat.Trim()));
        }

        public string LayIDLoaiPhong(string IDPhongHat)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangPhongHat().Find(x => Equals(x.MaPhongHat.Trim(), IDPhongHat.Trim())).MaLoaiPhong.Trim();
        }

        public string LaySoDienThoai(string IDKhachHang)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangKhachHang().Find(x => Equals(x.MaKhachHang.Trim(), IDKhachHang.Trim())).SoDienThoai.Trim();
        }

        public string LayTenKhachHang(string ID)    
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangKhachHang().Find(x => Equals(x.MaKhachHang.Trim(), ID.Trim())).TenKhachHang.Trim();
        }

        public string LayTenLoaiPhong(string ID)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangLoaiPhong().Find(x => Equals(x.MaLoaiPhong.Trim(), ID.Trim())).TenLoaiPhong.Trim();
        }

        public string LayTenNhanVien(string ID)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangNhanVien().Find(x => Equals(x.MaNhanVien.Trim(), ID.Trim())).TenNhanVien.Trim();
        }

        public string LayTenPhong(string ID)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangPhongHat().Find(x => Equals(x.MaPhongHat.Trim(), ID.Trim())).TenPhongHat.Trim();
        }

        public void Xoa_GoiDichVu(tblGoiDichVu tblGoiDichVu)
        {
            new DAL_QuanLyQuanHat().Delete_GoiDichVu(tblGoiDichVu);
        }

        public void Xoa_HoaDonBan(tblHoaDonBan tblHoaDonBan)
        {
            new DAL_QuanLyQuanHat().Delete_HoaDonBan(tblHoaDonBan);
        }

        public void Xoa_PhongDat(tblPhongDat tblPhongDat)
        {
            new DAL_QuanLyQuanHat().Delete_PhongDat(tblPhongDat);
        }

        public List<tblGoiMatHang> DanhSachMatHang_KhachGoi(string ID_PhongDat)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangGoiMatHang().FindAll(x => Equals(x.MaPhongDat.Trim(), ID_PhongDat.Trim()));
        }

        public List<tblGoiDichVu> DanhSachDichVu_KhachGoi(string ID_PhongDat)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangGoiDichVu().FindAll(x => Equals(x.MaPhongDat.Trim(), ID_PhongDat.Trim()));
        }

        public string LayTenDichVu(string IDDichVu)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangDichVu().Find(x => Equals(x.MaDichVu.Trim(), IDDichVu.Trim())).TenDichVu.Trim();
        }

        public string LayGiaTienDichVu(string IDDichVu)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangDichVu().Find(x => Equals(x.MaDichVu.Trim(), IDDichVu.Trim())).GiaDichVu.ToString();
        }

        public string LayTenMatHang(string IDMatHang)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangMatHang().Find(x => Equals(x.MaMatHang.Trim(), IDMatHang.Trim())).TenMatHang.Trim();
        }

        public string LayGiaTienMatHang(string IDMatHang)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangMatHang().Find(x => Equals(x.MaMatHang.Trim(), IDMatHang.Trim())).DonGiaMatHang.ToString();
        }

        public string LayIDHoaDonBan(string IDPhongDat)
        {
            return new DAL_QuanLyQuanHat().LayDuLieu_BangPhongDat().Find(x => Equals(x.MaPhongDat.Trim(), IDPhongDat.Trim())).tblHoaDonBans.ToList().Find(x => Equals(x.MaPhongDat.Trim(), IDPhongDat.Trim())).MaHoaDonBan.Trim();

        }
    }
}
