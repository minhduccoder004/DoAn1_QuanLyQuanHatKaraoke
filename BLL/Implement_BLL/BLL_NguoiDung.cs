using BLL.Interface_BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implement_BLL
{
    public class BLL_NguoiDung : ImplementBLL<tblNguoiDung>, I_BLL_Karaoke<tblNguoiDung>, I_BLL_NguoiDung
    {
        // Khởi tạo lớp DAL
        DAL_NguoiDung DAL = new DAL_NguoiDung();
        public List<tblNguoiDung> DanhSachDoiTuong()
        {
            return DAL.DanhSachDoiTuong();
        }

        public tblNguoiDung GetByID(string ID)
        {
            return DanhSachDoiTuong().Find(x => Equals(x.TenTaiKhoan.Trim(), ID.Trim()));
        }

        public string QuyenHanNguoiDung(int QuyenHan)
        {
            switch (QuyenHan)
            {
                case 0:
                    return "Quản lý";
                case 1:
                    return "Nhân viên";
                default:
                    return default;
            }
        }

        public int QuyenHanNguoiDung(string QuyenHan)
        {
            switch (QuyenHan)
            {
                case "Quản lý":
                    return 0;
                case "Nhân viên":
                    return 1;
                default:
                    return default;
            }
        }

        public override void Sua(tblNguoiDung _DTO)
        {
            DAL.Sua(_DTO);
        }

        public override void Them(tblNguoiDung _DTO)
        {
            DAL.Them(_DTO);
        }

        public List<tblNguoiDung> TimKiemNguoiDung(string ThongTinTimKiem)
        {
            return DanhSachDoiTuong().FindAll(x => x.TenTaiKhoan.Trim().Contains(ThongTinTimKiem.Trim()));
        }

        public override void Xoa(tblNguoiDung _DTO)
        {
            DAL.Xoa(_DTO);
        }
    }
}
