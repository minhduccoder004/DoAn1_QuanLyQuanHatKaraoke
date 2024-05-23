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

        public List<tblDichVu> LayDuLieu_BangDichVu()
        {
            return DB.tblDichVus.ToList();
        }

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

        public List<tblMatHang> LayDuLieu_BangMatHang()
        {
            return DB.tblMatHangs.ToList();
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
            DB.SaveChanges();
        }

        public void Update_PhongDat(tblPhongDat tblPhongDat)
        {
            var PhongDat = DB.tblPhongDats.Find(tblPhongDat.MaPhongDat);
            if (PhongDat != null)
            {
                PhongDat.ThoiGianPhongDung = tblPhongDat.ThoiGianPhongDung;
                PhongDat.TrangThaiPhongDat = tblPhongDat.TrangThaiPhongDat;
            }
            DB.SaveChanges();
        }

        public void Update_PhongHat(tblPhongHat tblPhongHat)
        {
            var PhongHat = DB.tblPhongHats.Find(tblPhongHat.MaPhongHat);
            if (PhongHat != null)
            {
                PhongHat.TrangThaiPhong = tblPhongHat.TrangThaiPhong;
            }
            DB.SaveChanges();
        }
    }
}
