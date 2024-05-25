using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_QuanLyDoanhThu
    {
        List<tblHoaDonBan> BangHoaDonBan();
        List<tblHoaDonBan> LayHoaDonBan_TheoThoiGian(int KieuXem, DateTime ThoiGianBatDau, DateTime ThoiGianKetThuc);

        List<KeyValuePair<DateTime, double>> BangDoanhThu_TheoNgay(List<tblHoaDonBan> HoaDons);
        List<KeyValuePair<string, int>> Top5NhanVien();
        List<KeyValuePair<string, int>> Top5PhongHat();
        List<KeyValuePair<string, int>> MatHang_SuDungNhieu(List<tblHoaDonBan> HoaDons);
 
        KeyValuePair<int, double> Tong_HoaDon_DoanhThu(int KieuXem, DateTime ThoiGianBatDau, DateTime ThoiGianKetThuc, List<tblHoaDonBan> HoaDons);

        string LayTenNhanVien(string ID_NhanVien);
        string LayTenPhongHat(string ID_PhongHat);
        string LayTenMatHang(string ID_MatHang);

        int KieuXem(string KieuXem);
        int TongKhachHang(List<tblHoaDonBan> HoaDons);
        int TongKhachVangLai(List<tblHoaDonBan> HoaDons);
        int TongKhachRaVaoQuan(List<tblHoaDonBan> HoaDons);
    }
}
