using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_DatPhong
    {
        void Them_PhongDat(tblPhongDat tblPhongDat);
        List<tblLoaiPhong> LoaiPhongs();
        List<tblPhongHat> LayPhongHatTheoLoai(string MaPhong);
        List<tblLoaiDichVu> LoaiDichVus();
        List<tblDichVu> LayDichVuTheoLoai(string MaDichVu);
        List<tblNhanVien> NV_PhucVus();
    }
}
