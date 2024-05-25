using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Implement_DAL;

namespace BLL.Implement_BLL
{
    public class BLL_DangNhap
    {
        public List<tblNguoiDung> DanhSachNguoiDung()
        {
            return new DAL_DangNhap().LayDanhSachNguoiDung() ;
        }

        public int KiemTraTaiKhoan(string TenTaiKhoan, string MatKhau, int _QuyenHan)
        {
            var NguoiDung = DanhSachNguoiDung().Find(x => Equals(x.TenTaiKhoan.Trim(), TenTaiKhoan) && Equals(x.QuyenHan, _QuyenHan)) ;

            if (NguoiDung == null)
            {
                return -1;
            }
            else
            {
                if (Equals(NguoiDung.MatKhau.Trim(), MatKhau))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }


        public int KiemTraQuyenHan(string QuyenHan)
        {
            switch (QuyenHan.ToLower().Trim())
            {
                case "quản lý":
                    {
                        return 0;
                    }

                case "nhân viên":
                    {
                        return 1;
                    }
                default:
                    {
                        return -1;
                    }
            }
        }
    }
}
