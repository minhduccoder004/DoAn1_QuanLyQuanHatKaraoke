using DAL.Interface_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement_DAL
{
    public class DAL_QuanLyQuanHat : I_DAL_QuanLyQuanHat
    {
        DatabaseKaraoke DB = new DatabaseKaraoke();
        public void Delete_GoiDichVu(tblGoiDichVu tblGoiDichVu)
        {
            DB.tblGoiDichVus.Remove(tblGoiDichVu);
            DB.SaveChanges();

        }

        public void Delete_HoaDonBan(tblHoaDonBan tblHoaDonBan)
        {
            DB.tblHoaDonBans.Remove(tblHoaDonBan);
            DB.SaveChanges();

        }

        public void Delete_PhongDat(tblPhongDat tblPhongDat)
        {
            DB.tblPhongDats.Remove(tblPhongDat);
            DB.SaveChanges();

        }

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

        public List<tblLoaiPhong> LayDuLieu_BangLoaiPhong()
        {
            return DB.tblLoaiPhongs.ToList();
        }

        public List<tblMatHang> LayDuLieu_BangMatHang()
        {
            return DB.tblMatHangs.ToList();
        }

        public List<tblNhanVien> LayDuLieu_BangNhanVien()
        {
            return DB.tblNhanViens.ToList();
        }

        public List<tblPhongDat> LayDuLieu_BangPhongDat()
        {
            return DB.tblPhongDats.ToList();
        }

        public List<tblPhongHat> LayDuLieu_BangPhongHat()
        {
            return DB.tblPhongHats.ToList();
        }

        public void Update_PhongDat(tblPhongDat tblPhongDat)
        {
            using (DatabaseKaraoke DB = new DatabaseKaraoke())
            {
                var PhongDat = DB.tblPhongDats.Find(tblPhongDat.MaPhongDat);
                if (PhongDat != null)
                {
                    PhongDat.ThoiGianPhongHoatDong = tblPhongDat.ThoiGianPhongHoatDong;
                    PhongDat.ThoiGianPhongDung = tblPhongDat.ThoiGianPhongDung;
                    PhongDat.TrangThaiPhongDat = tblPhongDat.TrangThaiPhongDat;
                }
                DB.SaveChanges();
            }


        }

        public void Update_PhongHat(tblPhongHat tblPhongHat)
        {
            using (DatabaseKaraoke DB = new DatabaseKaraoke())
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
}
