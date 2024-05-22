using DAL.Interface_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement_DAL
{
    public class DAL_TimKiem : I_DAL_TimKiem
    {
        DatabaseKaraoke DB = new DatabaseKaraoke();
        public List<tblKhachHang> DuLieuBangKhachHang()
        {
            return DB.tblKhachHangs.ToList();
        }
        public List<tblNhanVien> DuLieuBangNhanVien()
        {
            return DB.tblNhanViens.ToList();
        }

        public List<tblPhongHat> DuLieuBangPhongHat()
        {
            return DB.tblPhongHats.ToList();
        }
    }
}
