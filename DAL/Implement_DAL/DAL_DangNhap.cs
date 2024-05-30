using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement_DAL
{
    public class DAL_DangNhap
    {
        public List<tblNguoiDung> LayDanhSachNguoiDung()
        {
            return new DatabaseKaraoke().tblNguoiDungs.ToList();
        }

    }
}
