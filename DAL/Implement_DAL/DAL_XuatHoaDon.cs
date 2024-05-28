using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface_DAL;
using DTO;

namespace DAL.Implement_DAL
{
    public class DAL_XuatHoaDon : I_DAL_XuatHoaDon
    {
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

        public List<tblPhongHat> LayDuLieu_BangPhongHat()
        {
            return DB.tblPhongHats.ToList();
        }
    }
}
