using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_QuanLyPhongHat
    {
        string TaoMaPhong();
        List<tblLoaiPhong> BangLoaiPhong();
        string TrangThaiPhong(int TrangThai);
        int TrangThaiPhong(string TrangThai);
        string[] LoaiPhongs();
        string LayTenLoaiPhong(string ID);

        string LayMaLoaiPhong(string TenLoaiPhong);

        List<tblPhongHat> SapXep(string LoaiSapXep);
    }
}
