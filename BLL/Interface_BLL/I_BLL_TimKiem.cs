using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_TimKiem
    {
        
        List<tblKhachHang> DuLieuTimKiemKhachHang(string LoaiTimKiem, string ThongTinTimKiem);

        List<tblNhanVien> DuLieuTimKiemNhanVien(string LoaiTimKiem, string ThongTinTimKiem);

        List<tblPhongHat> DuLieuTimKiemPhongHat(string LoaiTimKiem, string ThongTinTimKiem);

    }
}
