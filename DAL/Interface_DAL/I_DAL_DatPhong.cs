using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface_DAL
{
    public interface I_DAL_DatPhong
    {
        void Create_DatPhong(tblPhongDat tblPhongDat);
        List<tblLoaiPhong> LayDuLieu_BangLoaiPhong();
        List<tblNhanVien> LayDuLieu_BangNhanVien();
        List<tblPhongHat> LayDuLieu_BangPhongHat();
        List<tblLoaiDichVu> LayDuLieu_BangLoaiDichVu();
        List<tblDichVu> LayDuLieu_BangDichVu();
    }
}
