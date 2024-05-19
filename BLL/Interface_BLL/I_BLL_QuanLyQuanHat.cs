using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_QuanLyQuanHat
    {
        List<tblPhongDat> DanhSachPhongDat_ChuaHoatDong();
        List<tblPhongHat> DanhSachPhongHat();
        List<tblKhachHang> DanhSachKhachHang();
        List<tblNhanVien> DanhSachNhanVien();

        void CapNhat_PhongHat(tblPhongHat tblPhongHat);
        void CapNhat_PhongDat(tblPhongDat tblPhongDat);
        void Xoa_PhongDat(tblPhongDat tblPhongDat);
        void Xoa_GoiDichVu(tblGoiDichVu tblGoiDichVu);
        void Xoa_HoaDonBan(tblHoaDonBan tblHoaDonBan);

        string LayTenNhanVien(string ID);
        string LayTenPhong(string ID);
        string LayTenKhachHang(string ID);
        string LaySoDienThoai(string IDKhachHang);
        string LayTenLoaiPhong(string ID);
        string LayIDLoaiPhong(string IDPhongHat);
        tblGoiDichVu GetGoiDichVuByID(string IDPhongDat);
        tblHoaDonBan GetHoaDonBanByID(string IDPhongDat);

        tblPhongDat GetPhongDatByID(string ID);

        List<tblPhongDat> DanhSachPhongDat_DangHoatDong();
    }
}
