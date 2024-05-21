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

        public List<tblKhachHang> DuLieuBangKhachHang()
        {
            return new DatabaseKaraoke().tblKhachHangs.ToList();
        }
        public List<tblNhanVien> DuLieuBangNhanVien()
        {
            return new DatabaseKaraoke().tblNhanViens.ToList();
        }

        public List<tblPhongHat> DuLieuBangPhongHat()
        {
            return new DatabaseKaraoke().tblPhongHats.ToList();
        }
    }
}
