using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL.Interface_BLL
{
    public interface I_BLL_QuanLyQuanHat
    {
        List<tblPhongDat> DanhSachPhongDat_ChuaHoatDong();
        List<tblPhongDat> DanhSachPhongDat_DangHoatDong();
        List<tblGoiMatHang> DanhSachMatHang_KhachGoi(string ID_PhongDat);
        List<tblGoiDichVu> DanhSachDichVu_KhachGoi(string ID_PhongDat);

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
        string LayTenDichVu(string IDDichVu);
        string LayGiaTienDichVu(string IDDichVu);
        string LayTenMatHang(string IDMatHang);
        string LayGiaTienMatHang(string IDMatHang);
        string LayIDHoaDonBan(string IDPhongDat);

        tblGoiDichVu GetGoiDichVuByID(string IDPhongDat);
        tblHoaDonBan GetHoaDonBanByID(string IDPhongDat);
        tblPhongDat GetPhongDatByID(string ID);

        string Format_ThoiGian(TimeSpan Time);
        TimeSpan TinhThoiGian(DateTime currentTime, DateTime ThoiGianBatDau);
    }
}
