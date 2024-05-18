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
    public class BLL_DatPhong : I_BLL_Karaoke<tblPhongDat>, I_BLL_DatPhong
    {
        // Khởi tạo lớp DAL
        DAL_DatPhong DAL = new DAL_DatPhong();

        public List<tblPhongDat> DanhSachDoiTuong()
        {
            return DAL.DanhSachDoiTuong();
        }

        public tblPhongDat GetByID(string ID)
        {
            return DanhSachDoiTuong().Find(x => Equals(x.MaPhongDat.Trim(), ID.Trim()));
        }

        public List<tblDichVu> LayDichVuTheoLoai(string MaDichVu)
        {
            return DAL.LayDuLieu_BangDichVu().FindAll(x => Equals(x.tblLoaiDichVu.MaLoaiDichVu.Trim(), MaDichVu.Trim()));
        }

        public List<tblPhongHat> LayPhongHatTheoLoai(string MaPhong)
        {
            return DAL.LayDuLieu_BangPhongHat().FindAll(x => Equals(x.tblLoaiPhong.MaLoaiPhong.Trim(), MaPhong.Trim()) && x.TrangThaiPhong == 0);
        }

        public List<tblLoaiDichVu> LoaiDichVus()
        {
            return DAL.LayDuLieu_BangLoaiDichVu();
        }

        public List<tblLoaiPhong> LoaiPhongs()
        {
            return DAL.LayDuLieu_BangLoaiPhong();
        }

        public List<tblNhanVien> NV_PhucVus()
        {
            return DAL.LayDuLieu_BangNhanVien().FindAll(x => x.ChucVu == 2);
        }

        public void Them_PhongDat(tblPhongDat tblPhongDat)
        {
            DAL.Create_DatPhong(tblPhongDat);
        }
    }
}
