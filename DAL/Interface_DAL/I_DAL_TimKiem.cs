using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface_DAL
{
    public interface I_DAL_TimKiem
    {
        List<tblKhachHang> DuLieuBangKhachHang();

        List<tblNhanVien> DuLieuBangNhanVien();

        List<tblPhongHat> DuLieuBangPhongHat();
        
    }
}
