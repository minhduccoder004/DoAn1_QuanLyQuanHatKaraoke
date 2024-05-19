using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_DatPhong
    {
        void Them_PhongDat(tblPhongDat tblPhongDat);
        void Them_KhachHang(tblKhachHang tblKhachHang);
        void Them_GoiDichVu(tblGoiDichVu tblGoiDichVu);
        void TaoHoaDon(tblHoaDonBan tblHoaDonBan);
        List<tblLoaiPhong> LoaiPhongs();
        List<tblPhongHat> LayPhongHatTheoLoai(string MaPhong);
        List<tblLoaiDichVu> LoaiDichVus();
        List<tblDichVu> LayDichVuTheoLoai(string MaDichVu);
        List<tblNhanVien> NV_PhucVus();
        string TaoMaPhongDat();
        string TaoMaKhachHang();
        string TaoMaHoaDonBan();
        DateTime ThoiGianDatPhong(DateTime NgayThangNam, int Gio, int Phut);
        tblKhachHang TimKiemKhachHangTheoSoDienThoai(string SoDienThoai);
    }
}
