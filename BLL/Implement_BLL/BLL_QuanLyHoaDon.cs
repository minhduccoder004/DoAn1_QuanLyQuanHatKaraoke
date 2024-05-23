using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface_BLL;
using DAL.Implement_DAL;
using DTO;

namespace BLL.Implement_BLL
{
    public class BLL_QuanLyHoaDon : I_BLL_QuanLyHoaDon
    {
        DAL_QuanLyHoaDon DAL = new DAL_QuanLyHoaDon();
        public List<tblHoaDonBan> DanhSach_HoaDonBan()
        {
            return DAL.LayDuLieu_BangHoaDonBan().FindAll(x => x.TrangThaiHoaDon == 1);
        }

        public List<tblGoiDichVu> DichVuUsed(string ID_HoaDonBan)
        {
            return DAL.LayDuLieu_BangGoiDichVu().FindAll(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDonBan.Trim()));
        }

        public string Format_Tien(double Tien)
        {
            return Tien.ToString("#,###") + " đ";
        }

        public string LayTenKhachHang(string ID_KhachHang)
        {
            return DAL.LayDuLieu_BangKhachHang().Find(x => Equals(x.MaKhachHang.Trim(), ID_KhachHang.Trim())).TenKhachHang.Trim();
        }

        public string LayTenNhanVien(string ID_NhanVien)
        {
            return DAL.LayDuLieu_BangNhanVien().Find(x => Equals(x.MaNhanVien.Trim(), ID_NhanVien.Trim())).TenNhanVien.Trim();
        }

        public tblHoaDonBan Lay_HoaDon(string ID_HoaDonBan)
        {
            return DAL.LayDuLieu_BangHoaDonBan().Find(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDonBan.Trim()));
        }

        public List<tblGoiMatHang> MatHangUsed(string ID_HoaDonBan)
        {
            return DAL.LayDuLieu_BangGoiMatHang().FindAll(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDonBan.Trim()));
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
