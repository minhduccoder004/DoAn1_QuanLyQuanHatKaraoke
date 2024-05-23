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

        public double TienDichVu_DaSuDung(string ID_HoaDonBan)
        {
            double TienDichVu = 0;
            var DanhSachDichVu = DAL.LayDuLieu_BangGoiDichVu().FindAll(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDonBan.Trim()));

            foreach (var i in DanhSachDichVu)
            {
                TienDichVu += Convert.ToDouble(i.tblDichVu.GiaDichVu);
            }

            return TienDichVu;
        }

        public double TienMatHang_DaSuDung(string ID_HoaDonBan)
        {
            double TienMatHang = 0;
            var DanhSachMatHang = DAL.LayDuLieu_BangGoiMatHang().FindAll(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDonBan.Trim()));

            foreach (var i in DanhSachMatHang)
            {
                TienMatHang += Convert.ToDouble(i.tblMatHang.DonGiaMatHang * i.SoLuong);
            }

            return TienMatHang;
        }

        public double ThanhTien_Tong(double TienPhong, double TienDichVu, double TienMatHang)
        {
            return TienPhong + TienDichVu + TienMatHang;
        }

        public double TienPhong_DaSuDung(string ID_HoaDonBan, TimeSpan GioSuDung)
        {
            double TienPhong = DAL.LayDuLieu_BangHoaDonBan().Find(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDonBan.Trim())).tblPhongDat.tblPhongHat.tblLoaiPhong.DonGiaPhong;

            TienPhong += GioSuDung.Hours * 150000;

            if (GioSuDung.Minutes >= 30)
            {
                TienPhong += 0.5 * 150000;
            }
            else
            {
                TienPhong += 0.2 * 150000;
            }

            return TienPhong;

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

        public void CapNhat_HoaDonBan(tblHoaDonBan tblHoaDonBan)
        {
            DAL.Update_HoaDonBan(tblHoaDonBan);
        }

        public void CapNhat_PhongDat(tblPhongDat tblPhongDat)
        {
            DAL.Update_PhongDat(tblPhongDat);
        }

        public void CapNhat_PhongHat(tblPhongHat tblPhongHat)
        {
            DAL.Update_PhongHat(tblPhongHat);
        }
    }
}
