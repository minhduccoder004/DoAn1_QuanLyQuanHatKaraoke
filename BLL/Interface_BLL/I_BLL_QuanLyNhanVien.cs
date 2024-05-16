using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_QuanLyNhanVien
    {
        string TaoMaNhanVien();
        List<tblNhanVien> SapXep_SoDienThoai();
        List<tblNhanVien> SapXep_TenNhanVien();
        List<tblNhanVien> SapXep_Email();
        List<tblNhanVien> SapXep_DiaChi();
        List<tblNhanVien> LayDanhSach_NhanVienNam();
        List<tblNhanVien> LayDanhSach_NhanVienNu();


    }
}
