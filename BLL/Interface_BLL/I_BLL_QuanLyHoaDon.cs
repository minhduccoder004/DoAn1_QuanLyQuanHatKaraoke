using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_QuanLyHoaDon
    {
        List<tblHoaDonBan> DanhSach_HoaDonBan();
        List<tblGoiDichVu> DichVuUsed(string ID_HoaDonBan);
        List<tblGoiMatHang> MatHangUsed(string ID_HoaDonBan);
        List<tblHoaDonBan> TimKiem_HoaDons_TheoMocThoiGian(DateTime BatDau, DateTime KetThuc);

        string LayTenKhachHang(string ID_KhachHang);
        string LayTenNhanVien(string ID_NhanVien);

        string Format_Tien(double Tien);

        tblHoaDonBan Lay_HoaDon(string ID_HoaDonBan);

        string LayTenDichVu(string IDDichVu);
        string LayGiaTienDichVu(string IDDichVu);
        string LayTenMatHang(string IDMatHang);
        string LayGiaTienMatHang(string IDMatHang);

        void Xoa_HoaDon(tblHoaDonBan tblHoaDonBan);

        string DuongDan_LogoHoaDon();

        double TongTien_MatHang(string ID_HoaDon);
        double TongTien_DichVu(string ID_HoaDon);
        double TongTien_Phong(string ID_HoaDon, TimeSpan GioSuDung);
        double ThanhTien_HoaDon(params double[] CacLoaiTiens);
    }
}
