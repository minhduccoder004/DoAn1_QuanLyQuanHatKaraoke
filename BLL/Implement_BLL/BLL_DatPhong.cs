using BLL.Interface_BLL;
using DAL.Implement_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implement_BLL
{
    public class BLL_DatPhong : I_BLL_Karaoke<tblPhongDat>, I_BLL_DatPhong
    {
        // Khởi tạo lớp DAL
        DAL_DatPhong DAL = new DAL_DatPhong();

        public List<tblPhongDat> DanhSachDoiTuong()
        {
            return DAL.DanhSachDoiTuong();
        }

        public tblPhongDat GetByID(string ID)
        {
            return DanhSachDoiTuong().Find(x => Equals(x.MaPhongDat.Trim(), ID.Trim()));
        }

        public List<tblDichVu> LayDichVuTheoLoai(string MaDichVu)
        {
            return DAL.LayDuLieu_BangDichVu().FindAll(x => Equals(x.tblLoaiDichVu.MaLoaiDichVu.Trim(), MaDichVu.Trim()));
        }

        public List<tblPhongHat> LayPhongHatTheoLoai(string MaPhong)
        {
            return DAL.LayDuLieu_BangPhongHat().FindAll(x => Equals(x.tblLoaiPhong.MaLoaiPhong.Trim(), MaPhong.Trim()) && x.TrangThaiPhong == 0);
        }

        public List<tblLoaiDichVu> LoaiDichVus()
        {
            return DAL.LayDuLieu_BangLoaiDichVu();
        }

        public List<tblLoaiPhong> LoaiPhongs()
        {
            return DAL.LayDuLieu_BangLoaiPhong();
        }

        public List<tblNhanVien> NV_PhucVus()
        {
            return DAL.LayDuLieu_BangNhanVien().FindAll(x => x.ChucVu == 2);
        }

        public void TaoHoaDon(tblHoaDonBan tblHoaDonBan)
        {
            DAL.Create_HoaDonBan(tblHoaDonBan);
        }

        public string TaoMaHoaDonBan()
        {
            string MaHoaDonBan = "HDB";

            MaHoaDonBan += DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            MaHoaDonBan += DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

            return MaHoaDonBan;
        }

        public string TaoMaKhachHang()
        {
            string MaKhachHang = "KH";
            MaKhachHang += DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            MaKhachHang += DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            return MaKhachHang;
        }

        public string TaoMaPhongDat()
        {
            string MaPhongDat = "PD";

            MaPhongDat += DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            MaPhongDat += DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

            return MaPhongDat;
        }

        public void Them_GoiDichVu(tblGoiDichVu tblGoiDichVu)
        {
            DAL.Create_GoiDichVu(tblGoiDichVu);
        }

        public void Them_KhachHang(tblKhachHang tblKhachHang)
        {
            DAL.Create_KhachHang(tblKhachHang);
        }

        public void Them_PhongDat(tblPhongDat tblPhongDat)
        {
            DAL.Create_DatPhong(tblPhongDat);
        }

        public DateTime ThoiGianDatPhong(DateTime NgayThangNam, int Gio, int Phut)
        {
            return new DateTime(NgayThangNam.Year, NgayThangNam.Month, NgayThangNam.Day, Gio, Phut, 0);
        }

        public tblKhachHang TimKiemKhachHangTheoSoDienThoai(string SoDienThoai)
        {
            return DAL.LayDuLieu_BangKhachHang().Find(x => Equals(x.SoDienThoai.Trim(), SoDienThoai.Trim()));
        }
    }
}
