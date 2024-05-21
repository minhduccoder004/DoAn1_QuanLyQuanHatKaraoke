using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_Order
    {

        void Them_GoiDichVu(tblGoiDichVu tblGoiDichVu);
        void Them_GoiMatHang(tblGoiMatHang tblGoiMatHang);
        void CapNhat_GoiMatHang(tblGoiMatHang tblGoiMatHang);
        tblGoiMatHang TimMathang_GoiTrung(string ID_PhongDat, string ID_MatHang);
        tblGoiDichVu TimDichVu_GoiTrung(string ID_PhongDat, string ID_DichVu);

        tblDichVu TimDichVu_Trung(string ID_DichVu);

        List<tblMatHang> DanhSachMatHang();
        List<tblDichVu> DanhSachDichVu();
        List<tblMatHang> TimKiem_MatHang(string ThongTinTimKiem);

        string LayTenLoaiHang(string ID_LoaiHang);
        
    }
}
