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
        DatabaseKaraoke Database = new DatabaseKaraoke();

        public List<tblKhachHang> DuLieuBangKhachHang()
        {
            return Database.tblKhachHangs.ToList();
        }
        public List<tblNhanVien> DuLieuBangNhanVien()
        {
            return Database.tblNhanViens.ToList();
        }

        public List<tblPhongHat> DuLieuBangPhongHat()
        {
            return Database.tblPhongHats.ToList();
        }
    }
}
