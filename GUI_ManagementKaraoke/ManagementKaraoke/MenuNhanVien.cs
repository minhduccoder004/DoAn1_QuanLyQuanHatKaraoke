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
    public partial class MenuNhanVien : Form
    {

        public event EventHandler DangXuat;
        public event EventHandler DatPhong;
        public event EventHandler Click_TrangChu;
        public event EventHandler Click_QuanLyHoaDon;
        public event EventHandler Click_QuanLyKhachHang;

        public MenuNhanVien()
        {
            InitializeComponent();
        }

        public void guna2Button8_Click(object sender, EventArgs e)
        {
            BatSuKien_DangXuat();
        }

        void BatSuKien_DangXuat()
        {
            DangXuat?.Invoke(this, EventArgs.Empty);
        }
        // click đặt phòng
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BatSuKien_ClickDatPhong();
        }
        // click Trang chủ
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            BatSuKien_ClickTrangChu();
        }
        // click Quản lý hoá đơn
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            BatSuKien_ClickQuanLyHoaDon();
        }
        //click Quản lý khách hàng
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            BatSuKien_ClickQuanLyKhachHang();
        }

        // Bắt sự kiện click đặt phòng
        void BatSuKien_ClickDatPhong() => DatPhong?.Invoke(this, EventArgs.Empty);
        // Bắt sự kiện click trang chủ
        void BatSuKien_ClickTrangChu() => Click_TrangChu?.Invoke(this, EventArgs.Empty);
        // Bắt sự kiện click quản lý hoá đơn
        void BatSuKien_ClickQuanLyHoaDon() => Click_QuanLyHoaDon?.Invoke(this, EventArgs.Empty);
        // Bắt sự kiện click quản lý khách hàng
        void BatSuKien_ClickQuanLyKhachHang() => Click_QuanLyKhachHang?.Invoke(this, EventArgs.Empty);
    }
}
