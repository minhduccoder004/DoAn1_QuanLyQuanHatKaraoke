using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface_DAL;
using DTO;

namespace DAL.Implement_DAL
{
    public class DAL_DangKy : ImplementDAL<tblNguoiDung>, I_DAL_Karaoke<tblNguoiDung>
    {
        DatabaseKaraoke DB_Karaoke = new DatabaseKaraoke();

        public List<tblNguoiDung> DanhSachDoiTuong()
        {
            return DB_Karaoke.tblNguoiDungs.ToList();
        }


        public override void Sua(tblNguoiDung _DTO)
        {
            throw new NotImplementedException();
        }

        public override void Them(tblNguoiDung _DTO)
        {
            DB_Karaoke.tblNguoiDungs.Add(_DTO);
            DB_Karaoke.SaveChanges();
        }

        public override void Xoa(tblNguoiDung _DTO)
        {
            throw new NotImplementedException();
        }



    }

     
}
