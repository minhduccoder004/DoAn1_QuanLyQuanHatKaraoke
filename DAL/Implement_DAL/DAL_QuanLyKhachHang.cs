﻿using DAL.Interface_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace DAL.Implement_DAL
{
    public class DAL_QuanLyKhachHang : ImplementDAL<tblKhachHang>, I_DAL_Karaoke<tblKhachHang>, I_DAL_KhachHang
    {
        DatabaseKaraoke Database = new DatabaseKaraoke();
        public List<tblKhachHang> DanhSachDoiTuong()
        {
            return Database.tblKhachHangs.ToList();
        }

        public List<tblHoaDonBan> LayDuLieu_BangHoaDonBan()
        {
            return Database.tblHoaDonBans.ToList();
        }

        public override void Sua(tblKhachHang _DTO)
        {
            var Update = Database.tblKhachHangs.Find(_DTO.MaKhachHang);
            Update.TenKhachHang = _DTO.TenKhachHang;
            Update.SoDienThoai = _DTO.SoDienThoai;
            Database.SaveChanges();
        }

        public override void Them(tblKhachHang _DTO)
        {
            Database.tblKhachHangs.Add(_DTO);
            Database.SaveChanges();
        }

        public override void Xoa(tblKhachHang _DTO)
        {
            var Delete = Database.tblKhachHangs.Find(_DTO.MaKhachHang);
            Delete.TrangThaiXoa = _DTO.TrangThaiXoa;
            Database.SaveChanges();
        }
    }
}
