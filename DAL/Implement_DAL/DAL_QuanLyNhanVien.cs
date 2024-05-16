using DAL.Interface_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement_DAL
{
    public class DAL_QuanLyNhanVien : ImplementDAL<tblNhanVien>, I_DAL_Karaoke<tblNhanVien>, I_DAL_NhanVien
    {
        DatabaseKaraoke DB = new DatabaseKaraoke();
        public List<tblNhanVien> DanhSachDoiTuong() => DB.tblNhanViens.ToList();

        public override void Sua(tblNhanVien _DTO)
        {
            var Update = DB.tblNhanViens.Find(_DTO.MaNhanVien);

            Update.TenNhanVien = _DTO.TenNhanVien;
            Update.SoDienThoai = _DTO.SoDienThoai;
            Update.DiaChi = _DTO.DiaChi;
            Update.NgaySinh = _DTO.NgaySinh;
            Update.GioiTinh = _DTO.GioiTinh;
            Update.FileAnh = _DTO.FileAnh; 
            Update.Email = _DTO.Email;

            DB.SaveChanges();
        }

        public override void Them(tblNhanVien _DTO)
        {
            DB.tblNhanViens.Add(_DTO);
            DB.SaveChanges();
        }

        public override void Xoa(tblNhanVien _DTO)
        {
            DB.tblNhanViens.Remove(_DTO);
            DB.SaveChanges();
        }
    }
}
