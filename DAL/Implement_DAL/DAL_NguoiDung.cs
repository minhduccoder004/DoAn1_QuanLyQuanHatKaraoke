using DAL.Implement_DAL;
using DAL.Interface_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NguoiDung : ImplementDAL<tblNguoiDung>, I_DAL_Karaoke<tblNguoiDung>, I_DAL_NguoiDung
    {
        DatabaseKaraoke DB = new DatabaseKaraoke();
        public List<tblNguoiDung> DanhSachDoiTuong()
        {
            return DB.tblNguoiDungs.ToList();
        }

        public void DoiMatKhau(tblNguoiDung ND)
        {
            var NguoiDung = DB.tblNguoiDungs.Find(ND.TenTaiKhoan);
            if (NguoiDung != null)
            {
                NguoiDung.MatKhau = ND.MatKhau;
            }
            DB.SaveChanges();
        }

        public override void Sua(tblNguoiDung _DTO)
        {
            var NguoiDung = DB.tblNguoiDungs.Find(_DTO.TenTaiKhoan);
            if (NguoiDung != null)
            {
                NguoiDung.MatKhau = _DTO.MatKhau;
                NguoiDung.Email = _DTO.Email;
                NguoiDung.SoDienThoai = _DTO.SoDienThoai;
                NguoiDung.QuyenHan = _DTO.QuyenHan;
            }
            DB.SaveChanges();
        }

        public override void Them(tblNguoiDung _DTO)
        {
            DB.tblNguoiDungs.Add(_DTO);
            DB.SaveChanges();
        }

        public override void Xoa(tblNguoiDung _DTO)
        {
            DB.tblNguoiDungs.Remove(_DTO);
            DB.SaveChanges();
        }
    }
}
