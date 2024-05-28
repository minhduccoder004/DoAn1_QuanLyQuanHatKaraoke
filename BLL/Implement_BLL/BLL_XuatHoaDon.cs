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
    public class BLL_XuatHoaDon : I_BLL_XuatHoaDon
    {
        DAL_XuatHoaDon DAL = new DAL_XuatHoaDon();

        public List<tblGoiDichVu> DichVu_SuDung(string ID_HoaDon)
        {
            return DAL.LayDuLieu_BangGoiDichVu().FindAll(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDon.Trim()));
        }

        public tblHoaDonBan GetByID_HoaDon(string ID_HoaDon)
        {
            return DAL.LayDuLieu_BangHoaDonBan().Find(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDon.Trim()));
        }

        public string LayTenKhachHang(string ID_KhachHang)
        {
            return DAL.LayDuLieu_BangKhachHang().Find(x => Equals(x.MaKhachHang.Trim(), ID_KhachHang.Trim())).TenKhachHang.Trim();
        }

        public string LayTenNhanVien(string ID_NhanVien)
        {
            return DAL.LayDuLieu_BangNhanVien().Find(x => Equals(x.MaNhanVien.Trim(), ID_NhanVien.Trim())).TenNhanVien.Trim();
        }

        public string LayTenPhongHat(string ID_PhongHat)
        {
            return DAL.LayDuLieu_BangPhongHat().Find(x => Equals(x.MaPhongHat.Trim(), ID_PhongHat.Trim())).TenPhongHat.Trim();
        }

        public List<tblGoiMatHang> MatHang_SuDung(string ID_HoaDon)
        {
            return DAL.LayDuLieu_BangGoiMatHang().FindAll(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDon.Trim()));
        }

        public TimeSpan ThoiGianSuDung(string ID_HoaDon)
        {
            tblHoaDonBan HoaDon = DAL.LayDuLieu_BangHoaDonBan().Find(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDon.Trim()));
            return (TimeSpan)(HoaDon.tblPhongDat.ThoiGianPhongDung - HoaDon.tblPhongDat.ThoiGianPhongHoatDong);
        }

        public double TinhTongTien_DichVu(List<tblGoiDichVu> DanhSach)
        {
            double TongTien = 0.0;

            foreach (var i in DanhSach)
            {
                TongTien += (double)i.tblDichVu.GiaDichVu;
            }

            return TongTien;
        }

        public double TinhTongTien_MatHang(List<tblGoiMatHang> DanhSach)
        {
            double TongTien = 0.0;

            foreach (var i in DanhSach)
            {
                TongTien += (double)i.SoLuong * (double)i.tblMatHang.DonGiaMatHang;
            }

            return TongTien;
        }

        public double TinhTongTien_Phong(string ID_HoaDon)
        {
            tblHoaDonBan HoaDon = DAL.LayDuLieu_BangHoaDonBan().Find(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDon.Trim()));
            double TienPhong = HoaDon.tblPhongDat.tblPhongHat.tblLoaiPhong.DonGiaPhong;
            TimeSpan ThoiGianSuDung = (TimeSpan)(HoaDon.tblPhongDat.ThoiGianPhongDung - HoaDon.tblPhongDat.ThoiGianPhongHoatDong);

            TienPhong += ThoiGianSuDung.Hours * 150000;

            if (ThoiGianSuDung.Minutes >= 30)
            {
                TienPhong += 0.5 * 150000;
            }
            else
            {
                TienPhong += 0.2 * 150000;
            }

            return TienPhong;
        }

        public double TinhTongTien_ThanhToan(params double[] Tiens)
        {
            return Tiens.Sum();
        }

        public void XuatBaoCao()
        {
            throw new NotImplementedException();
        }


        public string Format_ThoiGian(TimeSpan Time)
        {
            int Day = Time.Days;
            int Hours = Time.Hours;
            int Minutes = Time.Minutes;
            int Seconds = Time.Seconds;

            return $"{(Day * 24) + Hours}:{Minutes}:{Seconds}";
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
    }
}
