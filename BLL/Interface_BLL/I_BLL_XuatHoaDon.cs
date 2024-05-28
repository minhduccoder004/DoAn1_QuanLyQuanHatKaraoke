using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_XuatHoaDon
    {

        string LayTenNhanVien(string ID_NhanVien);
        string LayTenKhachHang(string ID_KhachHang);
        string LayTenPhongHat(string ID_PhongHat);
        void XuatBaoCao();
        double TinhTongTien_MatHang(List<tblGoiMatHang> DanhSach);
        double TinhTongTien_DichVu(List<tblGoiDichVu> DanhSach);
        double TinhTongTien_Phong(string ID_HoaDon);
        double TinhTongTien_ThanhToan(params double[] Tiens);
        TimeSpan ThoiGianSuDung(string ID_HoaDon);
        string Format_ThoiGian(TimeSpan Time);

        string LayTenDichVu(string IDDichVu);
        string LayGiaTienDichVu(string IDDichVu);
        string LayTenMatHang(string IDMatHang);
        string LayGiaTienMatHang(string IDMatHang);

        tblHoaDonBan GetByID_HoaDon(string ID_HoaDon);

        List<tblGoiDichVu> DichVu_SuDung(string ID_HoaDon);
        List<tblGoiMatHang> MatHang_SuDung(string ID_HoaDon);

    }
}
