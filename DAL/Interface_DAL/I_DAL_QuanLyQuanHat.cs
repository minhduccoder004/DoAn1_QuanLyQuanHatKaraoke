using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface_DAL
{
    public interface I_DAL_QuanLyQuanHat
    {

        List<tblPhongDat> LayDuLieu_BangPhongDat();
        List<tblPhongHat> LayDuLieu_BangPhongHat();
        List<tblNhanVien> LayDuLieu_BangNhanVien();
        List<tblKhachHang> LayDuLieu_BangKhachHang();
        List<tblLoaiPhong> LayDuLieu_BangLoaiPhong();
        List<tblGoiDichVu> LayDuLieu_BangGoiDichVu();
        List<tblHoaDonBan> LayDuLieu_BangHoaDonBan();

        void Update_PhongDat(tblPhongDat tblPhongDat);
        void Update_PhongHat(tblPhongHat tblPhongHat);
        void Delete_PhongDat(tblPhongDat tblPhongDat);
        void Delete_GoiDichVu(tblGoiDichVu tblGoiDichVu);
        void Delete_HoaDonBan(tblHoaDonBan tblHoaDonBan);
 
    }
}
