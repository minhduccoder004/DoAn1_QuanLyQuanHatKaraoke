using BLL.Interface_BLL;
using DAL.Implement_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implement_BLL
{
    public class BLL_TimKiem : I_BLL_TimKiem
    {
        public List<tblKhachHang> DuLieuTimKiemKhachHang(string LoaiTimKiem, string ThongTinTimKiem)
        {
            switch (LoaiTimKiem.ToLower())
            {
                case "tên khách hàng":
                    return new DAL_TimKiem().DuLieuBangKhachHang().FindAll(x => x.TenKhachHang.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                case "số điện thoại":
                    return new DAL_TimKiem().DuLieuBangKhachHang().FindAll(x => x.SoDienThoai.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                default:
                    return default;
            }
        }

        public List<tblNhanVien> DuLieuTimKiemNhanVien(string LoaiTimKiem, string ThongTinTimKiem)
        {
            // "Tên nhân viên", "Số điện thoại", "Địa chỉ", "Năm sinh", "Email"
            switch (LoaiTimKiem.ToLower())
            {
                case "tên nhân viên":
                    return new DAL_TimKiem().DuLieuBangNhanVien().FindAll(x => x.TenNhanVien.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                case "số điện thoại":
                    return new DAL_TimKiem().DuLieuBangNhanVien().FindAll(x => x.SoDienThoai.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                case "địa chỉ":
                    return new DAL_TimKiem().DuLieuBangNhanVien().FindAll(x => x.DiaChi.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                case "năm sinh":
                    return new DAL_TimKiem().DuLieuBangNhanVien().FindAll(x => x.NgaySinh.Value.Year.ToString().Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                case "email":
                    return new DAL_TimKiem().DuLieuBangNhanVien().FindAll(x => x.Email.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                default:
                    return default;
            }
        }

        public List<tblPhongHat> DuLieuTimKiemPhongHat(List<tblPhongHat> DanhSachPhongHat, string LoaiTimKiem, string ThongTinTimKiem)
        {
            // "Tên phòng", "Loại phòng"
            switch (LoaiTimKiem.ToLower())
            {
                case "tên phòng":
                    return DanhSachPhongHat.FindAll(x => x.TenPhongHat.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                case "loại phòng":
                    return DanhSachPhongHat.FindAll(x => x.tblLoaiPhong.TenLoaiPhong.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                default:
                    return default;
            }

        }
    }
}
