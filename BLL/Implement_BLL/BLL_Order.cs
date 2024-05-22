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
        // Khai báo lớp DAL
        DAL_Order DAL = new DAL_Order();
        public void CapNhat_GoiMatHang(tblGoiMatHang tblGoiMatHang)
        {
            new DAL_Order().Update_GoiMatHang(tblGoiMatHang);
        }

        public List<tblDichVu> DanhSachDichVu()
        {
            return DAL.LayDuLieu_BangDichVu();
        }

        public List<tblMatHang> DanhSachMatHang()
        {
            return DAL.LayDuLieu_BangMatHang();
        }

        public string LayTenLoaiHang(string ID_LoaiHang)
        {
            return DAL.LayDuLieu_BangLoaiHang().Find(x => Equals(x.MaLoaiHang.Trim(), ID_LoaiHang.Trim())).TenLoaiHang.Trim();
        }

        public void Them_GoiDichVu(tblGoiDichVu tblGoiDichVu)
        {
            DAL.Create_GoiDichVu(tblGoiDichVu);
        }

        public void Them_GoiMatHang(tblGoiMatHang tblGoiMatHang)
        {
            DAL.Create_GoiMatHang(tblGoiMatHang);
        }

        public tblGoiDichVu TimDichVu_GoiTrung(string ID_PhongDat, string ID_DichVu)
        {
            return DAL.LayDuLieu_BangGoiDichVu().Find(x => Equals(x.MaPhongDat.Trim(), ID_PhongDat.Trim()) && Equals(x.MaDichVu.Trim(), ID_DichVu.Trim()));
        }

        public tblDichVu TimDichVu_Trung(string ID_DichVu)
        {
            return DAL.LayDuLieu_BangDichVu().Find(x=> Equals(x.MaDichVu.Trim(), ID_DichVu.Trim()));
        }

        public List<tblMatHang> TimKiem_MatHang(string ThongTinTimKiem)
        {
            return DAL.LayDuLieu_BangMatHang().FindAll(x => x.TenMatHang.ToLower().Contains(ThongTinTimKiem.ToLower().Trim()));
        }

        public tblGoiMatHang TimMathang_GoiTrung(string ID_PhongDat, string ID_MatHang)
        {
            return DAL.LayDuLieu_BangGoiMatHang().Find(x => Equals(x.MaPhongDat.Trim(), ID_PhongDat.Trim()) && Equals(x.MaMatHang.Trim(), ID_MatHang.Trim()));
        }

    }
}
