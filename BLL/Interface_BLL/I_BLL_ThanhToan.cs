﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_ThanhToan
    {
        string LayTenKhachHang(string ID_KhachHang);
        string LayMaKhachHang(string ID_HoaDonBan);
        string LayTenNhanVien(string ID_NhanVien);
        string LayMaNhanVien(string ID_HoaDonBan);
        string Format_ThoiGian(TimeSpan Time);

        List<tblGoiDichVu> DichVu_KhachDaDung(string ID_HoaDonBan);
        List<tblGoiMatHang> MatHang_KhachDaDung(string ID_HoaDonBan);

        double TienDichVu_DaSuDung();
        double TienMatHang_DaSuDung();
        double ThanhTien_Tong();
    }
}