using DAL.Interface_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement_DAL
{
    public class DAL_DatPhong : I_DAL_Karaoke<tblPhongDat>, I_DAL_DatPhong
    {
        // Khởi tạo lớp DatabaseKaraoke
        DatabaseKaraoke DB = new DatabaseKaraoke();

        public void Create_DatPhong(tblPhongDat tblPhongDat)
        {
            DB.tblPhongDats.Add(tblPhongDat);
            DB.SaveChanges();
        }

        public void Create_GoiDichVu(tblGoiDichVu tblGoiDichVu)
        {
            DB.tblGoiDichVus.Add(tblGoiDichVu);
            DB.SaveChanges();
        }

        public void Create_HoaDonBan(tblHoaDonBan tblHoaDonBan)
        {
            DB.tblHoaDonBans.Add(tblHoaDonBan);
            DB.SaveChanges();
        }

        public void Create_KhachHang(tblKhachHang tblKhachHang)
        {
            DB.tblKhachHangs.Add(tblKhachHang);
            DB.SaveChanges();
        }

        public List<tblPhongDat> DanhSachDoiTuong()
        {
            return DB.tblPhongDats.ToList();
        }

        public List<tblDichVu> LayDuLieu_BangDichVu()
        {
            return DB.tblDichVus.ToList();
        }

        public List<tblKhachHang> LayDuLieu_BangKhachHang()
        {
            return DB.tblKhachHangs.ToList() ;
        }

        public List<tblLoaiDichVu> LayDuLieu_BangLoaiDichVu()
        {
            return DB.tblLoaiDichVus.ToList();
        }

        public List<tblLoaiPhong> LayDuLieu_BangLoaiPhong()
        {
            return DB.tblLoaiPhongs.ToList();
        }

        public List<tblNhanVien> LayDuLieu_BangNhanVien()
        {
            return DB.tblNhanViens.ToList();
        }

        public List<tblPhongHat> LayDuLieu_BangPhongHat()
        {
            return DB.tblPhongHats.ToList();
        }
    }
}
