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
    public class BLL_ThanhToan : I_BLL_ThanhToan
    {
        // Khởi tạo lớp DAL
        DAL_ThanhToan DAL = new DAL_ThanhToan();

        public string LayMaKhachHang(string ID_HoaDonBan)
        {
            return DAL.LayDuLieu_BangHoaDonBan().Find(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDonBan.Trim())).MaKhachHang.Trim();
        }

        public string LayMaNhanVien(string ID_HoaDonBan)
        {
            return DAL.LayDuLieu_BangHoaDonBan().Find(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDonBan.Trim())).MaNhanVien.Trim();
        }

        public string LayTenKhachHang(string ID_KhachHang)
        {
            return DAL.LayDuLieu_BangKhachHang().Find(x => Equals(x.MaKhachHang.Trim(), ID_KhachHang.Trim())).TenKhachHang.Trim();
        }

        public string LayTenNhanVien(string ID_NhanVien)
        {
            return DAL.LayDuLieu_BangNhanVien().Find(x => Equals(x.MaNhanVien.Trim(), ID_NhanVien.Trim())).TenNhanVien.Trim();
        }
        public string Format_ThoiGian(TimeSpan Time)
        {
            int Day = Time.Days;
            int Hours = Time.Hours;
            int Minutes = Time.Minutes;
            int Seconds = Time.Seconds;

            return $"{(Day * 24) + Hours}:{Minutes}:{Seconds}";
        }

        public List<tblGoiDichVu> DichVu_KhachDaDung(string ID_HoaDonBan)
        {
            return DAL.LayDuLieu_BangGoiDichVu().FindAll(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDonBan.Trim()));
        }

        public List<tblGoiMatHang> MatHang_KhachDaDung(string ID_HoaDonBan)
        {
            return DAL.LayDuLieu_BangGoiMatHang().FindAll(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDonBan.Trim()));
        }

        public double TienDichVu_DaSuDung()
        {
            throw new NotImplementedException();
        }

        public double TienMatHang_DaSuDung()
        {
            throw new NotImplementedException();
        }

        public double ThanhTien_Tong()
        {
            throw new NotImplementedException();
        }
    }
}
