using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Implement_DAL;
using DTO;

namespace BLL.Implement_BLL
{
    public class BLL_DangKy
    {
        DAL_DangKy DAL = new DAL_DangKy();
        List<tblNguoiDung> DanhSachTaiKhoan;

        public BLL_DangKy()
        {
            DanhSachTaiKhoan = DAL.DanhSachDoiTuong();
        }

        public void ThemNguoiDung(tblNguoiDung NguoiDung)
        {
            DAL.Them(NguoiDung);
        }

        public bool Check_HopLe(string TenTaiKhoan) => (DanhSachTaiKhoan.Find(x => x.TenTaiKhoan.Trim() == TenTaiKhoan) == null);

        public bool Check_NhapMatKhauTrungKhop(string MatKhau, string NhapLaiMatKhau) => Equals(MatKhau, NhapLaiMatKhau);
        
    }
}
