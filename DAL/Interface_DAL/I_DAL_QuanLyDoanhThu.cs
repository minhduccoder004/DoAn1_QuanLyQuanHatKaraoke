using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface_DAL
{
    public interface I_DAL_QuanLyDoanhThu
    {
        List<tblHoaDonBan> LayDuLieu_BangHoaDonBan();
        List<tblNhanVien> LayDuLieu_BangNhanVien();
        List<tblPhongHat> LayDuLieu_BangPhongHat();
        List<tblMatHang> LayDuLieu_BangMatHang();
        List<tblGoiMatHang> LayDuLieu_BangGoiMatHang();

    }
}
