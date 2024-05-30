using System;
using System.Collections.Generic;
using System.IO;
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

        public List<tblHoaDonBan> TimKiem_HoaDons_TheoMocThoiGian(DateTime BatDau, DateTime KetThuc)
        {
            return DanhSach_HoaDonBan().FindAll(x => x.ThoiGianTaoHoaDon.Value.Day >= BatDau.Day && x.ThoiGianTaoHoaDon.Value.Day <= KetThuc.Day);
        }

        public void Xoa_HoaDon(tblHoaDonBan tblHoaDonBan)
        {
            DAL.Xoa_HoaDon(tblHoaDonBan);
        }

        public string DuongDan_LogoHoaDon()
        {
            var DuongDanUngDung = AppDomain.CurrentDomain.BaseDirectory;
            var DuongDanTuongDoi = Path.Combine("..", "..", "Picture", "LogoLoginKaraoke.png");
            var DuongDanDayDu = Path.GetFullPath(Path.Combine(DuongDanUngDung, DuongDanTuongDoi));

            return DuongDanDayDu;
        }

        public double TongTien_MatHang(string ID_HoaDon)
        {
            double TienMatHang = 0;
            var DanhSachMatHang = DAL.LayDuLieu_BangGoiMatHang().FindAll(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDon.Trim()));

            foreach (var i in DanhSachMatHang)
            {
                TienMatHang += Convert.ToDouble(i.tblMatHang.DonGiaMatHang * i.SoLuong);
            }

            return TienMatHang;
        }

        public double TongTien_DichVu(string ID_HoaDon)
        {
            double TienDichVu = 0;
            var DanhSachDichVu = DAL.LayDuLieu_BangGoiDichVu().FindAll(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDon.Trim()));

            foreach (var i in DanhSachDichVu)
            {
                TienDichVu += Convert.ToDouble(i.tblDichVu.GiaDichVu);
            }

            return TienDichVu;
        }

        public double TongTien_Phong(string ID_HoaDon, TimeSpan GioSuDung)
        {
            double TienPhong = DAL.LayDuLieu_BangHoaDonBan().Find(x => Equals(x.MaHoaDonBan.Trim(), ID_HoaDon.Trim())).tblPhongDat.tblPhongHat.tblLoaiPhong.DonGiaPhong;

            TienPhong += GioSuDung.Hours * 150000;

            if (GioSuDung.Minutes >= 30)
            {
                TienPhong += 0.5 * 150000;
            }
            else
            {
                TienPhong += 0.2 * 150000;
            }

            return TienPhong;
        }

        public double ThanhTien_HoaDon(params double[] CacLoaiTiens)
        {
            return CacLoaiTiens.Sum();
        }
    }
}
