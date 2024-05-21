using BLL.Interface_BLL;
using DAL.Implement_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implement_BLL
{
    public class BLL_QuanLyKhachHang : ImplementBLL<tblKhachHang>, I_BLL_Karaoke<tblKhachHang>, I_BLL_QuanLyKhachHang
    {
        public string TaoMaKhachHang()
        {
            string MaKhachHang = "KH";
            MaKhachHang += DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            MaKhachHang += DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            return MaKhachHang;
        }

        public override void Them(tblKhachHang _DTO) => new DAL_QuanLyKhachHang().Them(_DTO);

        public override void Sua(tblKhachHang _DTO) => new DAL_QuanLyKhachHang().Sua(_DTO);

        public override void Xoa(tblKhachHang _DTO) => new DAL_QuanLyKhachHang().Xoa(_DTO);

        public List<tblKhachHang> DanhSachDoiTuong() => new DAL_QuanLyKhachHang().DanhSachDoiTuong();

        public tblKhachHang GetByID(string ID) => DanhSachDoiTuong().Find(x => Equals(x.MaKhachHang.Trim(), ID));

        public List<tblKhachHang> SapXepTheoSoDienThoai() => DanhSachDoiTuong().OrderBy(x => x.SoDienThoai).ToList();

        public List<tblKhachHang> SapXepTheoTenKhachHang() => DanhSachDoiTuong().OrderBy(x => x.TenKhachHang.Split()[x.TenKhachHang.Split().Length - 1]).ToList();
    }
}
