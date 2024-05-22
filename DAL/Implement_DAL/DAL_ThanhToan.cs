using DAL.Interface_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement_DAL
{
    public class DAL_ThanhToan : I_DAL_ThanhToan
    {
        // Khởi tạo lớp DTO
        DatabaseKaraoke DB = new DatabaseKaraoke();
        public List<tblGoiDichVu> LayDuLieu_BangGoiDichVu()
        {
            return DB.tblGoiDichVus.ToList();
        }

        public List<tblGoiMatHang> LayDuLieu_BangGoiMatHang()
        {
            return DB.tblGoiMatHangs.ToList();
        }

        public List<tblHoaDonBan> LayDuLieu_BangHoaDonBan()
        {
           return DB.tblHoaDonBans.ToList();
        }

        public List<tblKhachHang> LayDuLieu_BangKhachHang()
        {
            return DB.tblKhachHangs.ToList();
        }

        public List<tblNhanVien> LayDuLieu_BangNhanVien()
        {
            return DB.tblNhanViens.ToList();
        }

        public void Update_HoaDonBan(tblHoaDonBan tblHoaDonBan)
        {
            var HoaDonBan = DB.tblHoaDonBans.Find(tblHoaDonBan.MaHoaDonBan);
            if (HoaDonBan != null)
            {
                HoaDonBan.ThoiGianTaoHoaDon = tblHoaDonBan.ThoiGianTaoHoaDon;
                HoaDonBan.ThanhTien = tblHoaDonBan.ThanhTien;
                HoaDonBan.TrangThaiHoaDon = tblHoaDonBan.TrangThaiHoaDon;
            }
        }
    }
}
