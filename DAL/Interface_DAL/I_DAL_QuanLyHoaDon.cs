using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface_DAL
{
    public interface I_DAL_QuanLyHoaDon
    {

        List<tblGoiDichVu> LayDuLieu_BangGoiDichVu();
        List<tblGoiMatHang> LayDuLieu_BangGoiMatHang();
        List<tblHoaDonBan> LayDuLieu_BangHoaDonBan();
        List<tblNhanVien> LayDuLieu_BangNhanVien();
        List<tblKhachHang> LayDuLieu_BangKhachHang();
        List<tblDichVu> LayDuLieu_BangDichVu();
        List<tblMatHang> LayDuLieu_BangMatHang();


    }
}
