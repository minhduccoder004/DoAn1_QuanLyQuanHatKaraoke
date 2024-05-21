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
    public class BLL_Order : I_BLL_Order
    {
        public void CapNhat_GoiMatHang(tblGoiMatHang tblGoiMatHang)
        {
            new DAL_Order().Update_GoiMatHang(tblGoiMatHang);
        }

        public List<tblDichVu> DanhSachDichVu()
        {
            return new DAL_Order().LayDuLieu_BangDichVu();
        }

        public List<tblMatHang> DanhSachMatHang()
        {
            return new DAL_Order().LayDuLieu_BangMatHang();
        }

        public string LayTenLoaiHang(string ID_LoaiHang)
        {
            return new DAL_Order().LayDuLieu_BangLoaiHang().Find(x => Equals(x.MaLoaiHang.Trim(), ID_LoaiHang.Trim())).TenLoaiHang.Trim();
        }

        public void Them_GoiDichVu(tblGoiDichVu tblGoiDichVu)
        {
            new DAL_Order().Create_GoiDichVu(tblGoiDichVu);
        }

        public void Them_GoiMatHang(tblGoiMatHang tblGoiMatHang)
        {
            new DAL_Order().Create_GoiMatHang(tblGoiMatHang);
        }

        public tblGoiDichVu TimDichVu_GoiTrung(string ID_PhongDat, string ID_DichVu)
        {
            return new DAL_Order().LayDuLieu_BangGoiDichVu().Find(x => Equals(x.MaPhongDat.Trim(), ID_PhongDat.Trim()) && Equals(x.MaDichVu.Trim(), ID_DichVu.Trim()));
        }

        public tblDichVu TimDichVu_Trung(string ID_DichVu)
        {
            return new DAL_Order().LayDuLieu_BangDichVu().Find(x=> Equals(x.MaDichVu.Trim(), ID_DichVu.Trim()));
        }

        public List<tblMatHang> TimKiem_MatHang(string ThongTinTimKiem)
        {
            return new DAL_Order().LayDuLieu_BangMatHang().FindAll(x => x.TenMatHang.ToLower().Contains(ThongTinTimKiem.ToLower().Trim()));
        }

        public tblGoiMatHang TimMathang_GoiTrung(string ID_PhongDat, string ID_MatHang)
        {
            return new DAL_Order().LayDuLieu_BangGoiMatHang().Find(x => Equals(x.MaPhongDat.Trim(), ID_PhongDat.Trim()) && Equals(x.MaMatHang.Trim(), ID_MatHang.Trim()));
        }

    }
}
