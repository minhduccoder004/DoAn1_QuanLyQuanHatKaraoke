using DAL.Interface_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement_DAL
{
    public class DAL_QuanLyPhongHat : ImplementDAL<tblPhongHat>, I_DAL_Karaoke<tblPhongHat>, I_DAL_PhongHat
    {
        // Khai báo database
        DatabaseKaraoke Database = new DatabaseKaraoke();

        public List<tblPhongHat> DanhSachDoiTuong()
        {
            return Database.tblPhongHats.ToList();
        }

        public List<tblLoaiPhong> LayDuLieu_BangLoaiPhong()
        {
            return Database.tblLoaiPhongs.ToList();
        }

        public override void Sua(tblPhongHat _DTO)
        {
            var Update = Database.tblPhongHats.Find(_DTO.MaPhongHat);
            
            Update.MaLoaiPhong = _DTO.MaLoaiPhong;
            Update.TenPhongHat = _DTO.TenPhongHat;

            Database.SaveChanges();
        }

        public override void Them(tblPhongHat _DTO)
        {
            Database.tblPhongHats.Add(_DTO);
            Database.SaveChanges();
        }

        public override void Xoa(tblPhongHat _DTO)
        {
            Database.tblPhongHats.Remove(_DTO); 
            Database.SaveChanges();
        }
    }
}
