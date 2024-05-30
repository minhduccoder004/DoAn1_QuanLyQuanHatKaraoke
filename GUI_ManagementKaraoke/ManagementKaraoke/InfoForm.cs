using BLL.Implement_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_ManagementKaraoke.Event;
using DTO;
using System.Management;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class InfoForm : Form
    {
        // Khởi tạo sự kiện
        public event EventHandler<Event_LayDSKhachHang> Event_KhachHangs;
        public event EventHandler<Event_LayDSNhanVien> Event_NhanViens;
        public event EventHandler<Event_LayDSPhongHat> Event_PhongHats;
        public event EventHandler<Event_LayDSPhongDat> Event_PhongDats;
        public event EventHandler<Event_LayDSHoaDon> Event_HoaDons;
        // Khởi tạo lớp BLL
        BLL_TimKiem BLL = new BLL_TimKiem();
        // Mảng tìm kiếm các form 
        readonly string[] arr_SearchByTrangChu = { "Tên khách hàng", "Số điện thoại", "Tên phòng", "Tên nhân viên" };
        readonly string[] arr_SearchByQLHoaDon = { "Tên khách hàng", "Tên nhân viên" };
        readonly string[] arr_SearchByThongKe = { "Không có !!" };
        readonly string[] arr_SearchByQLKhachHang = { "Tên khách hàng", "Số điện thoại" };
        readonly string[] arr_SearchByQLNhanVien = { "Tên nhân viên", "Số điện thoại", "Địa chỉ", "Năm sinh", "Email" };
        readonly string[] arr_SearchByQLPhongHat = { "Tên phòng", "Loại phòng" };
        // Khởi tạo thuộc tính
        List<tblPhongHat> DanhSachPhongHat;
        List<tblPhongDat> DanhSachPhongDat;
        List<tblHoaDonBan> DanhSachHoaDon;
        public InfoForm()
        {
            InitializeComponent();
            DanhSachPhongHat = new List<tblPhongHat>();
            DanhSachPhongDat = new List<tblPhongDat>();
            DanhSachHoaDon = new List<tblHoaDonBan>();
        }

        public void DoiTenForm(string TenForm)
        {
            lb_infoFrm.Text = TenForm;
        }

        private void lb_infoFrm_TextChanged(object sender, EventArgs e)
        {
            switch (lb_infoFrm.Text.Trim().ToLower())
            {
                case "trang chủ":
                    cbb_TimKiemTheo.DataSource = arr_SearchByTrangChu;
                    break;
                case "quản lý hoá đơn":
                    cbb_TimKiemTheo.DataSource = arr_SearchByQLHoaDon;
                    break;
                case "thống kê":
                    cbb_TimKiemTheo.DataSource = arr_SearchByThongKe;
                    break;
                case "quản lý khách hàng":
                    cbb_TimKiemTheo.DataSource = arr_SearchByQLKhachHang;
                    break;
                case "quản lý nhân viên":
                    cbb_TimKiemTheo.DataSource = arr_SearchByQLNhanVien;
                    break;
                case "quản lý phòng hát":
                    cbb_TimKiemTheo.DataSource = arr_SearchByQLPhongHat;
                    break;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            switch (lb_infoFrm.Text.Trim().ToLower())
            {
                case "trang chủ":
                    SuKien_PhongDats(BLL.DuLieuTimKiemPhongDat(DanhSachPhongDat, cbb_TimKiemTheo.Text, txt_ThongTinTimKiem.Text));
                    break;
                case "quản lý hoá đơn":
                    SuKien_HoaDons(BLL.DuLieuBangHoaDonBan(DanhSachHoaDon, cbb_TimKiemTheo.Text, txt_ThongTinTimKiem.Text));
                    break;
                case "thống kê":
                    break;
                case "quản lý khách hàng":

                    SuKien_KhachHangs(BLL.DuLieuTimKiemKhachHang(cbb_TimKiemTheo.Text, txt_ThongTinTimKiem.Text));

                    break;
                case "quản lý nhân viên":

                    SuKien_NhanViens(BLL.DuLieuTimKiemNhanVien(cbb_TimKiemTheo.Text, txt_ThongTinTimKiem.Text));

                    break;
                case "quản lý phòng hát":

                    SuKien_PhongHats(BLL.DuLieuTimKiemPhongHat(DanhSachPhongHat, cbb_TimKiemTheo.Text, txt_ThongTinTimKiem.Text)) ;

                    break;
            }
        }

        void SuKien_KhachHangs(List<tblKhachHang> tblKhachHangs)
        {
            Event_LayDSKhachHang e = new Event_LayDSKhachHang();
            e.DanhSachKhachHang = tblKhachHangs;
            Event_KhachHangs?.Invoke(this, e);
        }

        void SuKien_NhanViens(List<tblNhanVien> tblNhanViens)
        {
            Event_LayDSNhanVien e = new Event_LayDSNhanVien();
            e.DanhSachNhanVien = tblNhanViens;
            Event_NhanViens?.Invoke(this, e);
        }
        // Phòng hát
        void SuKien_PhongHats(List<tblPhongHat> tblPhongHats)
        {
            Event_LayDSPhongHat e = new Event_LayDSPhongHat();
            e.DanhSachPhongHat = tblPhongHats;
            Event_PhongHats?.Invoke(this, e);
        }

        public void BatSuKien_LayDanhSach(object sender, Event_LayDSPhongHat e)
        {
            DanhSachPhongHat = e.DanhSachPhongHat;
        }
        // Phòng đặt

        void SuKien_PhongDats(List<tblPhongDat> tblPhongDats)
        {
            Event_LayDSPhongDat e = new Event_LayDSPhongDat();
            e.DanhSachPhongDat = tblPhongDats;
            Event_PhongDats?.Invoke(this, e);
        }
         
        public void BatSuKien_LayDanhSach_PhongDat(object sender, Event_LayDSPhongDat e)
        {
            DanhSachPhongDat = e.DanhSachPhongDat;
        }

        // Hoá đơn bán

        void SuKien_HoaDons(List<tblHoaDonBan> tblHoaDonBans)
        {
            Event_LayDSHoaDon e = new Event_LayDSHoaDon();
            e.DanhSachHoaDonBan = tblHoaDonBans;
            Event_HoaDons?.Invoke(this, e);
        }

        public void BatSuKien_LayDanhSach_HoaDon(object sender, Event_LayDSHoaDon e)
        {
            DanhSachHoaDon = e.DanhSachHoaDonBan;
        }
    }
}
