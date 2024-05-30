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
    public class BLL_QuanLyPhongHat : ImplementBLL<tblPhongHat>, I_BLL_Karaoke<tblPhongHat>, I_BLL_QuanLyPhongHat
    {
        // Khai báo lớp DAL
        DAL_QuanLyPhongHat DAL = new DAL_QuanLyPhongHat();

        public List<tblLoaiPhong> BangLoaiPhong()
        {
            return DAL.LayDuLieu_BangLoaiPhong();
        }

        public List<tblPhongHat> DanhSachDoiTuong()
        {
            return DAL.DanhSachDoiTuong();
        }

        public List<KeyValuePair<int, int>> DuLieu_ThongKeHoatDong(string ID_PhongHat)
        {
            var XuLyDuLieu = from KiemKe in DAL.LayDuLieu_BangHoaDonBan().FindAll(x => x.tblPhongDat.MaPhong.Trim() == ID_PhongHat.Trim() && x.TrangThaiHoaDon == 1)
                             group KiemKe by KiemKe.ThoiGianTaoHoaDon.Value.Month into Gom
                             select new
                             {
                                 Thang = Gom.Key,
                                 SoLan = Gom.Count()
                             };
            var DanhSach = new List<KeyValuePair<int, int>>();
            foreach (var i in XuLyDuLieu)
            {
                DanhSach.Add(new KeyValuePair<int, int>(i.Thang, i.SoLan));
            }
            return DanhSach;
        }

        public tblPhongHat GetByID(string ID)
        {
            return DanhSachDoiTuong().Find(x => Equals(x.MaPhongHat.Trim(), ID.Trim()));
        }

        public string LayMaLoaiPhong(string TenLoaiPhong)
        {
            return BangLoaiPhong().Find(x => Equals(x.TenLoaiPhong.Trim(), TenLoaiPhong.Trim())).MaLoaiPhong;
        }

        public List<tblPhongHat> LayPhongTheoTrangThai(string LoaiTrangThai)
        {
            switch (LoaiTrangThai.ToLower().Trim())
            {
                case "không hoạt động":
                    return DanhSachDoiTuong().FindAll(x => x.TrangThaiPhong == 0);
                case "đang hoạt động":
                    return DanhSachDoiTuong().FindAll(x => x.TrangThaiPhong == 1);
                case "tất cả":
                    return DanhSachDoiTuong();
                default:
                    return DanhSachDoiTuong();
            }
        }

        public string LayTenLoaiPhong(string ID)
        {
            return BangLoaiPhong().Find(x => Equals(x.MaLoaiPhong.Trim(), ID.Trim())).TenLoaiPhong;
        }

        public string[] LoaiPhongs()
        {
            string[] arr_LoaiPhong = new string[BangLoaiPhong().Count];
            int count = 0;
            foreach (var i in BangLoaiPhong())
            {
                arr_LoaiPhong[count] = i.TenLoaiPhong;
                count++;
            }
            return arr_LoaiPhong;
        }

        public List<tblPhongHat> SapXep(List<tblPhongHat> PhongHats, string LoaiSapXep)
        {
            switch (LoaiSapXep.ToLower().Trim())
            {
                case "tên phòng":
                    return PhongHats.OrderBy(x => x.TenPhongHat).ToList();
                case "loại phòng":
                    return PhongHats.OrderBy(x => x.MaLoaiPhong).ToList();
                default:
                    return DanhSachDoiTuong();
            }
        }

        public override void Sua(tblPhongHat _DTO)
        {
            DAL.Sua(_DTO);
        }

        public string TaoMaPhong()
        {
            string MaPhongHat = "PH";
            MaPhongHat += DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            MaPhongHat += DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            return MaPhongHat;
        }

        public override void Them(tblPhongHat _DTO)
        {
            DAL.Them(_DTO);
        }

        public string TrangThaiPhong(int TrangThai)
        {
            switch (TrangThai)
            {
                case 0:
                    return "Không hoạt động";
                case 1:
                    return "Đang hoạt động";
                default:
                    return default;
            }
        }

        public int TrangThaiPhong(string TrangThai)
        {
            switch (TrangThai)
            {
                case "Không hoạt động":
                    return 0;
                case "Đang hoạt động":
                    return 1;
                default:
                    return default;
            }
        }

        public override void Xoa(tblPhongHat _DTO)
        {
            DAL.Xoa(_DTO);
        }
    }
}
