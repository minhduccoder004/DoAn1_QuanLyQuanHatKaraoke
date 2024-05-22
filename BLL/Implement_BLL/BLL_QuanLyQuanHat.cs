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

        // Khởi tạo lớp DAL
        DAL_QuanLyQuanHat DAL = new DAL_QuanLyQuanHat();
        public void CapNhat_PhongDat(tblPhongDat tblPhongDat)
        {
            DAL.Update_PhongDat(tblPhongDat);
        }

        public void CapNhat_PhongHat(tblPhongHat tblPhongHat)
        {
            DAL.Update_PhongHat(tblPhongHat);
        }

        public List<tblPhongDat> DanhSachPhongDat_ChuaHoatDong()
        {
            return DAL.LayDuLieu_BangPhongDat().FindAll(x => x.TrangThaiPhongDat == 0);
        }

        public List<tblPhongDat> DanhSachPhongDat_DangHoatDong()
        {
            return DAL.LayDuLieu_BangPhongDat().FindAll(x => x.TrangThaiPhongDat == 1);
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

        // Chỉnh ở đây
        public List<tblGoiMatHang> DanhSachMatHang_KhachGoi(string ID_PhongDat)
        {
            return DAL.LayDuLieu_BangGoiMatHang().FindAll(x => Equals(x.MaPhongDat.Trim(), ID_PhongDat.Trim()));
        }

        public List<tblGoiDichVu> DanhSachDichVu_KhachGoi(string ID_PhongDat)
        {
            return DAL.LayDuLieu_BangGoiDichVu().FindAll(x => Equals(x.MaPhongDat.Trim(), ID_PhongDat.Trim()));
        }

        public string LayTenDichVu(string IDDichVu)
        {
            return DAL.LayDuLieu_BangDichVu().Find(x => Equals(x.MaDichVu.Trim(), IDDichVu.Trim())).TenDichVu.Trim();
        }

        public string LayGiaTienDichVu(string IDDichVu)
        {
            return DAL.LayDuLieu_BangDichVu().Find(x => Equals(x.MaDichVu.Trim(), IDDichVu.Trim())).GiaDichVu.ToString();
        }

        public string LayTenMatHang(string IDMatHang)
        {
            return DAL.LayDuLieu_BangMatHang().Find(x => Equals(x.MaMatHang.Trim(), IDMatHang.Trim())).TenMatHang.Trim();
        }

        public string LayGiaTienMatHang(string IDMatHang)
        {
            return DAL.LayDuLieu_BangMatHang().Find(x => Equals(x.MaMatHang.Trim(), IDMatHang.Trim())).DonGiaMatHang.ToString();
        }

        public string LayIDHoaDonBan(string IDPhongDat)
        {
            return DAL.LayDuLieu_BangPhongDat().Find(x => Equals(x.MaPhongDat.Trim(), IDPhongDat.Trim())).tblHoaDonBans.ToList().Find(x => Equals(x.MaPhongDat.Trim(), IDPhongDat.Trim())).MaHoaDonBan.Trim();

        }


        public string Format_ThoiGian(TimeSpan Time)
        {
            int Day = Time.Days;
            int Hours = Time.Hours;
            int Minutes = Time.Minutes;
            int Seconds = Time.Seconds;

            return $"{(Day * 24) + Hours}:{Minutes}:{Seconds}";
        }

        public TimeSpan TinhThoiGian(DateTime currentTime, DateTime ThoiGianBatDau)
        {
            return currentTime - ThoiGianBatDau;
        }
    }
}
