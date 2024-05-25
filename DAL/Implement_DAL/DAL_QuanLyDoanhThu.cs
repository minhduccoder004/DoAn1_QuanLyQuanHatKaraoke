using DAL.Interface_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement_DAL
{
    public class DAL_QuanLyDoanhThu : I_DAL_QuanLyDoanhThu
    {
        DatabaseKaraoke DB = new DatabaseKaraoke();

        public List<tblGoiMatHang> LayDuLieu_BangGoiMatHang()
        {
            return DB.tblGoiMatHangs.ToList();
        }

        public List<tblHoaDonBan> LayDuLieu_BangHoaDonBan()
        {
            return DB.tblHoaDonBans.ToList();
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
