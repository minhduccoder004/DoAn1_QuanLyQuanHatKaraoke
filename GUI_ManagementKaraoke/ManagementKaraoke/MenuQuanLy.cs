using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class MenuQuanLy : Form
    {
        // Khởi tạo lớp BLL


        // Khởi tạo các sự kiện
        public event EventHandler DangXuat;
        public event EventHandler DatPhong;
        public event EventHandler Click_TrangChu;
        public event EventHandler Click_QuanLyHoaDon;
        public event EventHandler Click_ThongKe;
        public event EventHandler Click_QuanLyKhachHang;
        public event EventHandler Click_QuanLyNhanVien;
        public event EventHandler Click_QuanLyPhongHat;

        public MenuQuanLy()
        {
            InitializeComponent();
        }

        public void guna2Button8_Click(object sender, EventArgs e)
        {
            BatSuKien_DangXuat();
        }


        private void guna2Button7_Click(object sender, EventArgs e)
        {
            // Quản lý khách hàng
            BatSuKien_ClickQuanLyKhachHang();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // Trang Chủ
            BatSuKien_ClickTrangChu();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Quản lý hoá đơn
            BatSuKien_ClickQuanLyHoaDon();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Thống kê
            BatSuKien_ClickThongKe();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            // Quản lý nhân viên
            BatSuKien_ClickQuanLyNhanVien();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            // Quản lý phòng hát
            BatSuKien_ClickQuanLyPhongHat();
        }


        // Các hàm bắt sự kiện khi click button

        // sự kiện đăng xuất
        void BatSuKien_DangXuat() => DangXuat?.Invoke(this, EventArgs.Empty);

        // sự kiện click trang chủ

        void BatSuKien_ClickTrangChu() => Click_TrangChu?.Invoke(this, EventArgs.Empty);


        // sự kiện click quản lý hoá đơn

        void BatSuKien_ClickQuanLyHoaDon()
        {
            Click_QuanLyHoaDon?.Invoke(this, EventArgs.Empty);
        }

        // sự kiện click thống kê

        void BatSuKien_ClickThongKe()
        {
            Click_ThongKe?.Invoke(this, EventArgs.Empty);
        }

        // sự kiện click quản lý khách hàng

        void BatSuKien_ClickQuanLyKhachHang()
        {
            Click_QuanLyKhachHang?.Invoke(this, EventArgs.Empty);
        }

        // sự kiện click quản lý nhân viên

        void BatSuKien_ClickQuanLyNhanVien()
        {
            Click_QuanLyNhanVien?.Invoke(this, EventArgs.Empty);   
        }

        // sự kiện click quản lý phòng hát

        void BatSuKien_ClickQuanLyPhongHat()
        {
            Click_QuanLyPhongHat?.Invoke(this, EventArgs.Empty);
        }

        // sự kiện click đặt phòng

        void BatSuKien_ClickDatPhong()
        {
            DatPhong?.Invoke(this, EventArgs.Empty);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BatSuKien_ClickDatPhong();
        }

    }
}
