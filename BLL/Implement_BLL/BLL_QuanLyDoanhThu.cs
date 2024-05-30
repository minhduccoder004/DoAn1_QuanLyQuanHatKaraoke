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
    public class BLL_QuanLyDoanhThu : I_BLL_QuanLyDoanhThu
    {
        DAL_QuanLyDoanhThu DAL = new DAL_QuanLyDoanhThu();

        public List<KeyValuePair<DateTime, double>> BangDoanhThu_TheoNgay(List<tblHoaDonBan> HoaDons)
        {
            var XuLyDuLieu = from HoaDon in HoaDons
                               group HoaDon by HoaDon.ThoiGianTaoHoaDon.Value.Date into Gom
                               select new
                               {
                                   Ngay = Gom.Key,
                                   TongTien = Gom.Sum(x => x.ThanhTien)
                               };
            var DoanhThuTheoNgay = new List<KeyValuePair<DateTime, double>>();
            foreach (var i in XuLyDuLieu)
            {
                DoanhThuTheoNgay.Add(new KeyValuePair<DateTime, double>(key: i.Ngay, value: (double) i.TongTien));
            }

            return DoanhThuTheoNgay;
        }

        public List<tblHoaDonBan> BangHoaDonBan()
        {
            return DAL.LayDuLieu_BangHoaDonBan().FindAll(x => x.TrangThaiHoaDon == 1);
        }

        public int KieuXem(string KieuXem)
        {
            switch (KieuXem)
            {
                case "Chọn thời gian":
                    return 0;
                case "Hôm nay":
                    return 1;
                case "7 ngày gần nhất":
                    return 2;
                case "30 ngày trước":
                    return 3;
                case "Tháng này":
                    return 4;
                default:
                    return default;
            }
        }

        public List<tblHoaDonBan> LayHoaDonBan_TheoThoiGian(int KieuXem, DateTime ThoiGianBatDau, DateTime ThoiGianKetThuc)
        {
            switch (KieuXem)
            {
                case 0:
                    return BangHoaDonBan().Where(hd => hd.ThoiGianTaoHoaDon.Value.Date >= ThoiGianBatDau && hd.ThoiGianTaoHoaDon.Value.Date <= ThoiGianKetThuc).ToList();
                case 1:
                    return BangHoaDonBan().Where(hd => hd.ThoiGianTaoHoaDon.Value.Date == DateTime.Today).ToList();
                case 2:
                    return BangHoaDonBan().Where(hd => hd.ThoiGianTaoHoaDon.Value.Date >= DateTime.Today.AddDays(-7) && hd.ThoiGianTaoHoaDon.Value.Date <= DateTime.Today).ToList();
                case 3:
                    return BangHoaDonBan().Where(hd => hd.ThoiGianTaoHoaDon.Value.Date >= DateTime.Today.AddDays(-30) && hd.ThoiGianTaoHoaDon.Value.Date <= DateTime.Today).ToList();
                case 4:
                    return BangHoaDonBan().Where(hd => hd.ThoiGianTaoHoaDon.Value.Date >= new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1) && hd.ThoiGianTaoHoaDon.Value.Date <= new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).AddDays(-1)).ToList();
                default:
                    return BangHoaDonBan();
            }
        }

        public string LayTenMatHang(string ID_MatHang)
        {
            return DAL.LayDuLieu_BangMatHang().Find(x => Equals(x.MaMatHang.Trim(), ID_MatHang.Trim())).TenMatHang.Trim();
        }

        public string LayTenNhanVien(string ID_NhanVien)
        {
            return DAL.LayDuLieu_BangNhanVien().Find(x => Equals(x.MaNhanVien.Trim(),ID_NhanVien.Trim())).TenNhanVien.Trim();
        }

        public string LayTenPhongHat(string ID_PhongHat)
        {
            return DAL.LayDuLieu_BangPhongHat().Find(x => Equals(x.MaPhongHat.Trim(), ID_PhongHat.Trim())).TenPhongHat.Trim();
        }

        public List<KeyValuePair<string, int>> MatHang_SuDungNhieu(List<tblHoaDonBan> HoaDons)
        {
            var XuLyDuLieu = from HoaDon in HoaDons join MatHang in DAL.LayDuLieu_BangGoiMatHang() on HoaDon.MaHoaDonBan equals MatHang.MaHoaDonBan
                             group MatHang by MatHang.MaMatHang into Gom
                             select new
                             {
                                 TenMatHang = LayTenMatHang(Gom.Key),
                                 SoLuong = Gom.Sum(x => x.SoLuong)
                             };

            var DanhSachMatHang = new List<KeyValuePair<string, int>>();
            foreach (var i in XuLyDuLieu)
            {
                DanhSachMatHang.Add(new KeyValuePair<string, int>(i.TenMatHang, (int)i.SoLuong));
            }

            return DanhSachMatHang.OrderByDescending(x => x.Value).ToList();
        }

        public int TongKhachHang(List<tblHoaDonBan> HoaDons)
        {
            return HoaDons.Count(x => x.MaKhachHang.Trim() != "KH000");
        }

        public int TongKhachRaVaoQuan(List<tblHoaDonBan> HoaDons)
        {
            return HoaDons.Count();
        }

        public int TongKhachVangLai(List<tblHoaDonBan> HoaDons)
        {
            return HoaDons.Count(x => x.MaKhachHang.Trim() == "KH000");
        }

        public KeyValuePair<int, double> Tong_HoaDon_DoanhThu(int KieuXem, DateTime ThoiGianBatDau, DateTime ThoiGianKetThuc, List<tblHoaDonBan> HoaDons)
        {
            List<tblHoaDonBan> DanhSach;
            switch (KieuXem)
            {
                case 0:
                    DanhSach = HoaDons.Where(hd => hd.ThoiGianTaoHoaDon.Value.Date >= ThoiGianBatDau && hd.ThoiGianTaoHoaDon.Value.Date <= ThoiGianKetThuc).ToList();
                    return new KeyValuePair<int, double>(DanhSach.Count(), Convert.ToDouble(DanhSach.Sum(x => x.ThanhTien)));
                case 1:
                    DanhSach = HoaDons.Where(hd => hd.ThoiGianTaoHoaDon.Value.Date == DateTime.Today).ToList();
                    return new KeyValuePair<int, double>(DanhSach.Count(), Convert.ToDouble(DanhSach.Sum(x => x.ThanhTien)));
                case 2:
                    DanhSach = HoaDons.Where(hd => hd.ThoiGianTaoHoaDon.Value.Date >= DateTime.Today.AddDays(-7) && hd.ThoiGianTaoHoaDon.Value.Date <= DateTime.Today).ToList();
                    return new KeyValuePair<int, double>(DanhSach.Count(), Convert.ToDouble(DanhSach.Sum(x => x.ThanhTien)));
                case 3:
                    DanhSach = HoaDons.Where(hd => hd.ThoiGianTaoHoaDon.Value.Date >= DateTime.Today.AddDays(-30) && hd.ThoiGianTaoHoaDon.Value.Date <= DateTime.Today).ToList();
                    return new KeyValuePair<int, double>(DanhSach.Count(), Convert.ToDouble(DanhSach.Sum(x => x.ThanhTien)));
                case 4:
                    DanhSach = HoaDons.Where(hd => hd.ThoiGianTaoHoaDon.Value.Date >= new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1) && hd.ThoiGianTaoHoaDon.Value.Date <= new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).AddDays(-1)).ToList();
                    return new KeyValuePair<int, double>(DanhSach.Count(), Convert.ToDouble(DanhSach.Sum(x => x.ThanhTien)));
                default:
                    DanhSach = HoaDons;
                    return new KeyValuePair<int, double>(DanhSach.Count(), Convert.ToDouble(DanhSach.Sum(x => x.ThanhTien)));
            }
        }

        public List<KeyValuePair<string, int>> Top5NhanVien()
        {
            var XuLyDuLieu = from NhanVien in DAL.LayDuLieu_BangHoaDonBan().FindAll(x => x.TrangThaiHoaDon == 1)
                             group NhanVien by NhanVien.MaNhanVien into Gom
                             select new
                             {
                                 TenNhanVien = LayTenNhanVien(Gom.Key),
                                 SoLanPhucVu = Gom.Count()
                             };
            var Top5NhanVien = new List<KeyValuePair<string, int>>();
            foreach (var i in XuLyDuLieu)
            {
                Top5NhanVien.Add(new KeyValuePair<string, int>(key: i.TenNhanVien, value: i.SoLanPhucVu));
            }
            return Top5NhanVien.OrderByDescending(x => x.Value).ToList();
        }

        public List<KeyValuePair<string, int>> Top5PhongHat()
        {
            var XuLyDuLieu = from PhongHat in DAL.LayDuLieu_BangHoaDonBan().FindAll(x => x.TrangThaiHoaDon == 1)
                             group PhongHat by PhongHat.tblPhongDat.MaPhong into Gom
                             select new
                             {
                                 TenPhongHat = LayTenPhongHat(Gom.Key),
                                 SoLanSuDung = Gom.Count()
                             };
            var Top5PhongHat = new List<KeyValuePair<string, int>>();  
            foreach (var i in XuLyDuLieu)
            {
                Top5PhongHat.Add(new KeyValuePair<string, int>(i.TenPhongHat, i.SoLanSuDung));
            }
            return Top5PhongHat.OrderByDescending(x => x.Value).ToList();
        }
    }
}
