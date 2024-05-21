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
        public void Delete_GoiDichVu(tblGoiDichVu tblGoiDichVu)
        {
            using (DatabaseKaraoke DB = new DatabaseKaraoke())
            {
                DB.tblGoiDichVus.Remove(tblGoiDichVu);
                DB.SaveChanges();
            }

        }

        public void Delete_HoaDonBan(tblHoaDonBan tblHoaDonBan)
        {
            using (DatabaseKaraoke DB = new DatabaseKaraoke())
            {
                DB.tblHoaDonBans.Remove(tblHoaDonBan);
                DB.SaveChanges();
            }

        }

        public void Delete_PhongDat(tblPhongDat tblPhongDat)
        {
            using (DatabaseKaraoke DB = new DatabaseKaraoke())
            {
                DB.tblPhongDats.Remove(tblPhongDat);
                DB.SaveChanges();
            }

        }

        public List<tblDichVu> LayDuLieu_BangDichVu()
        {
            return new DatabaseKaraoke().tblDichVus.ToList();
        }

        public List<tblGoiDichVu> LayDuLieu_BangGoiDichVu()
        {
            return new DatabaseKaraoke().tblGoiDichVus.ToList();
        }

        public List<tblGoiMatHang> LayDuLieu_BangGoiMatHang()
        {
            return new DatabaseKaraoke().tblGoiMatHangs.ToList();
        }

        public List<tblHoaDonBan> LayDuLieu_BangHoaDonBan()
        {
            return new DatabaseKaraoke().tblHoaDonBans.ToList();
        }

        public List<tblKhachHang> LayDuLieu_BangKhachHang()
        {
            return new DatabaseKaraoke().tblKhachHangs.ToList();
        }

        public List<tblLoaiPhong> LayDuLieu_BangLoaiPhong()
        {
            return new DatabaseKaraoke().tblLoaiPhongs.ToList();
        }

        public List<tblMatHang> LayDuLieu_BangMatHang()
        {
            return new DatabaseKaraoke().tblMatHangs.ToList();
        }

        public List<tblNhanVien> LayDuLieu_BangNhanVien()
        {
            return new DatabaseKaraoke().tblNhanViens.ToList();
        }

        public List<tblPhongDat> LayDuLieu_BangPhongDat()
        {
            return new DatabaseKaraoke().tblPhongDats.ToList();
        }

        public List<tblPhongHat> LayDuLieu_BangPhongHat()
        {
            return new DatabaseKaraoke().tblPhongHats.ToList();
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
