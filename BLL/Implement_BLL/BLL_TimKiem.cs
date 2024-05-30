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
        // Khai báo lớp DAL
        DAL_TimKiem DAL = new DAL_TimKiem();

        public List<tblHoaDonBan> DuLieuBangHoaDonBan(List<tblHoaDonBan> DanhSachHoaDonBan, string LoaiTimKiem, string ThongTinTimKiem)
        {
         
            switch (LoaiTimKiem.ToLower())
            {
                case "tên khách hàng":
                    return DanhSachHoaDonBan.FindAll(x => x.tblKhachHang.TenKhachHang.ToLower().Trim().Contains(ThongTinTimKiem.Trim().ToLower()));
                case "tên nhân viên":
                    return DanhSachHoaDonBan.FindAll(x => x.tblNhanVien.TenNhanVien.ToLower().Trim().Contains(ThongTinTimKiem.ToLower().Trim()));
                default:
                    return default;
            }
        }

        public List<tblKhachHang> DuLieuTimKiemKhachHang(string LoaiTimKiem, string ThongTinTimKiem)
        {
            switch (LoaiTimKiem.ToLower())
            {
                case "tên khách hàng":
                    return DAL.DuLieuBangKhachHang().FindAll(x => x.TenKhachHang.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                case "số điện thoại":
                    return DAL.DuLieuBangKhachHang().FindAll(x => x.SoDienThoai.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
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
                    return DAL.DuLieuBangNhanVien().FindAll(x => x.TenNhanVien.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                case "số điện thoại":
                    return DAL.DuLieuBangNhanVien().FindAll(x => x.SoDienThoai.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                case "địa chỉ":
                    return DAL.DuLieuBangNhanVien().FindAll(x => x.DiaChi.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                case "năm sinh":
                    return DAL.DuLieuBangNhanVien().FindAll(x => x.NgaySinh.Value.Year.ToString().Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                case "email":
                    return DAL.DuLieuBangNhanVien().FindAll(x => x.Email.Trim().ToLower().Contains(ThongTinTimKiem.ToLower()));
                default:
                    return default;
            }
        }

        public List<tblPhongDat> DuLieuTimKiemPhongDat(List<tblPhongDat> DanhSachPhongDat, string LoaiTimKiem, string ThongTinTimKiem)
        {
            // "Tên khách hàng", "Số điện thoại", "Tên phòng", "Tên nhân viên"
            switch (LoaiTimKiem.ToLower())
            {
                case "tên khách hàng":
                    return DanhSachPhongDat.FindAll(x => x.tblKhachHang.TenKhachHang.ToLower().Trim().Contains(ThongTinTimKiem.ToLower().Trim()));
                case "số điện thoại":
                    return DanhSachPhongDat.FindAll(x => x.tblKhachHang.SoDienThoai.ToLower().Trim().Contains(ThongTinTimKiem.ToLower().Trim()));
                case "tên phòng":
                    return DanhSachPhongDat.FindAll(x => x.tblPhongHat.TenPhongHat.ToLower().Trim().Contains(ThongTinTimKiem.ToLower().Trim()));
                case "tên nhân viên":
                    return DanhSachPhongDat.FindAll(x => x.tblNhanVien.TenNhanVien.ToLower().Trim().Contains(ThongTinTimKiem.ToLower().Trim()));
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
