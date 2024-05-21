using BLL.Interface_BLL;
using DAL.Implement_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implement_BLL
{
    public class BLL_QuanLyNhanVien : ImplementBLL<tblNhanVien>, I_BLL_Karaoke<tblNhanVien>, I_BLL_QuanLyNhanVien
    {
        public override void Them(tblNhanVien _DTO) => new DAL_QuanLyNhanVien().Them(_DTO);
        public override void Sua(tblNhanVien _DTO) => new DAL_QuanLyNhanVien().Sua(_DTO);
        public override void Xoa(tblNhanVien _DTO) => new DAL_QuanLyNhanVien().Xoa(_DTO);
        public List<tblNhanVien> DanhSachDoiTuong() => new DAL_QuanLyNhanVien().DanhSachDoiTuong();
        public tblNhanVien GetByID(string ID) => DanhSachDoiTuong().Find(x => Equals(x.MaNhanVien.Trim(), ID));

        public string TaoMaNhanVien()
        {
            string MaNhanVien = "NV";

            MaNhanVien += DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            MaNhanVien += DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

            return MaNhanVien;
        }

        public List<tblNhanVien> SapXep_SoDienThoai() => DanhSachDoiTuong().OrderBy(x => x.SoDienThoai.Trim()).ToList();

        public List<tblNhanVien> SapXep_TenNhanVien() => DanhSachDoiTuong().OrderBy(x => x.TenNhanVien.Trim().Split()[x.TenNhanVien.Trim().Split().Length - 1]).ToList();

        public List<tblNhanVien> SapXep_Email() => DanhSachDoiTuong().OrderBy(x => x.Email.Trim()).ToList();

        public List<tblNhanVien> SapXep_DiaChi() => DanhSachDoiTuong().OrderBy(x => x.DiaChi.Trim()).ToList();

        public List<tblNhanVien> LayDanhSach_NhanVienNam() => DanhSachDoiTuong().FindAll(x => Equals(x.GioiTinh.Trim(), 0));

        public List<tblNhanVien> LayDanhSach_NhanVienNu() => DanhSachDoiTuong().FindAll(x => Equals(x.GioiTinh.Trim(), 1));

        public string LayChucVu(int ChucVu)
        {
            switch (ChucVu)
            {
                case 0:
                    return "Quản lý";
                case 1:
                    return "Thu ngân";
                case 2:
                    return "Phục vụ";
                default:
                    return default;
            }
        }

        public int LayChucVu(string ChucVu)
        {
            switch (ChucVu)
            {
                case "Quản lý":
                    return 0;
                case "Thu ngân":
                    return 1;
                case "Phục vụ":
                    return 2;
                default:
                    return default;
            }
        }
    }
}
