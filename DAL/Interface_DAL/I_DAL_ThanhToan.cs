﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface_DAL
{
    public interface I_DAL_ThanhToan
    {
        List<tblNhanVien> LayDuLieu_BangNhanVien();
        List<tblKhachHang> LayDuLieu_BangKhachHang();
        List<tblGoiDichVu> LayDuLieu_BangGoiDichVu();
        List<tblGoiMatHang> LayDuLieu_BangGoiMatHang();
        List<tblHoaDonBan> LayDuLieu_BangHoaDonBan();
        List<tblDichVu> LayDuLieu_BangDichVu();
        List<tblMatHang> LayDuLieu_BangMatHang();

        void Update_HoaDonBan(tblHoaDonBan tblHoaDonBan);
        void Update_PhongDat(tblPhongDat tblPhongDat);
        void Update_PhongHat(tblPhongHat tblPhongHat);

    }
}
