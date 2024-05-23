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

        string LayTenKhachHang(string ID_KhachHang);
        string LayTenNhanVien(string ID_NhanVien);

        string Format_Tien(double Tien);

        tblHoaDonBan Lay_HoaDon(string ID_HoaDonBan);

        string LayTenDichVu(string IDDichVu);
        string LayGiaTienDichVu(string IDDichVu);
        string LayTenMatHang(string IDMatHang);
        string LayGiaTienMatHang(string IDMatHang);
    }
}
