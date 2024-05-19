using GUI_ManagementKaraoke.ManagementKaraoke;
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

namespace GUI_ManagementKaraoke
{
    public partial class Management_Karaoke : Form
    {
        // Khởi tạo các form quản lý
        QuanLyQuanHat TrangChu = new QuanLyQuanHat() { TopLevel = false };
        QuanLyHoaDon QL_HoaDon = new QuanLyHoaDon() { TopLevel = false };
        QuanLyDoanhThu ThongKe = new QuanLyDoanhThu() { TopLevel = false };
        QuanLyKhachHang QL_KhachHang = new QuanLyKhachHang() { TopLevel = false };
        QuanLyPhongHat QL_PhongHat = new QuanLyPhongHat() { TopLevel = false };
        QuanLyNhanVien QL_NhanVien = new QuanLyNhanVien() { TopLevel = false };
        
        // Khởi tạo các form chức năng
        InfoAccount infoAccount;
        InfoForm infoForm;
        MenuQuanLy menuQL;
        MenuNhanVien menuNV;
        int QuyenHan_Acc { get; set; }
        // Infomation form
        string[] arr_info = { "Trang Chủ", "Quản Lý Hoá Đơn", "Thống Kê", "Quản Lý Khách Hàng", "Quản Lý Nhân Viên", "Quản Lý Phòng Hát" };
        void MoForm(Form form, Guna2GradientPanel panel)
        {

            panel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }


        public Management_Karaoke(int quyenHan_Acc, string TaiKhoan)
        {
            InitializeComponent();
            QuyenHan_Acc = quyenHan_Acc;
            infoAccount = new InfoAccount(quyenHan_Acc, TaiKhoan) { TopLevel = false };
            infoForm = new InfoForm() { TopLevel = false };
            infoForm.DoiTenForm(arr_info[0]);
            menuQL = new MenuQuanLy() { TopLevel = false };
            menuNV = new MenuNhanVien() { TopLevel = false };
        }
        private void Management_Karaoke_Load(object sender, EventArgs e)
        {

            // Mở form thông tin tài khoản
            MoForm(infoAccount, pn_infoacc);
            // Mở form info form
            MoForm(infoForm, pn_iform);
            // Bắt sự kiện khi nhấn đăng xuất
            switch (QuyenHan_Acc)
            {
                case 0:
                    MoForm(menuQL, pn_menu);
                    menuQL.DangXuat += DangXuat;
                    break;
                case 1:
                    MoForm(menuNV, pn_menu);
                    menuNV.DangXuat += DangXuat;
                    break;
            }
            // Mở form trang chủ
            MoForm(TrangChu, pn_container);
            // các sự kiện khi click form chức năng quản lý
            menuQL.DatPhong += Click_DatPhong;
            menuQL.Click_TrangChu += Click_TrangChu;
            menuQL.Click_QuanLyHoaDon += Click_QuanLyHoaDon;
            menuQL.Click_ThongKe += Click_ThongKe;
            menuQL.Click_QuanLyKhachHang += Click_QuanLyKhachHang;
            menuQL.Click_QuanLyNhanVien += Click_QuanLyNhanVien;
            menuQL.Click_QuanLyPhongHat += Click_QuanLyPhongHat;
            // các sự kiện khi click form chức năng nhân viên
            menuNV.DatPhong += Click_DatPhong;
            menuNV.Click_TrangChu += Click_TrangChu;
            menuNV.Click_QuanLyHoaDon += Click_QuanLyHoaDon;
            menuNV.Click_QuanLyKhachHang += Click_QuanLyKhachHang;

            // Bắt sự kiện khi tìm kiếm
            infoForm.Event_KhachHangs += QL_KhachHang.BatSuKien_LayDanhSach;
            infoForm.Event_NhanViens += QL_NhanVien.BatSuKien_LayDanhSach;
            // Sự kiện tìm kiếm của phòng hát
            QL_PhongHat.Event_PhongHats += infoForm.BatSuKien_LayDanhSach;
            infoForm.Event_PhongHats += QL_PhongHat.BatSuKien_LayDanhSach;

        }
        // sự kiện đăng xuất
        public void DangXuat(object sender, EventArgs e)
        {
            this.Close();

        }
        // sự kiện click trang chủ
        public void Click_TrangChu(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            infoForm.DoiTenForm(arr_info[0]);
            MoForm(TrangChu, pn_container);
        }
        // sự kiện click quản lý hoá đơn
        public void Click_QuanLyHoaDon(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            infoForm.DoiTenForm(arr_info[1]);
            MoForm(QL_HoaDon, pn_container);

        }
        // sự kiện click thống kê
        public void Click_ThongKe(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            infoForm.DoiTenForm(arr_info[2]);
            MoForm(ThongKe, pn_container);
        }
        // sự kiện click quản lý khách hàng
        public void Click_QuanLyKhachHang(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            infoForm.DoiTenForm(arr_info[3]);
            MoForm(QL_KhachHang, pn_container);
        }
        // sự kiện click quản lý nhân viên
        public void Click_QuanLyNhanVien(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            infoForm.DoiTenForm(arr_info[4]);
            MoForm(QL_NhanVien, pn_container);
        }
        // sự kiện click quản lý phòng hát
        public void Click_QuanLyPhongHat(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            infoForm.DoiTenForm(arr_info[5]);
            MoForm(QL_PhongHat, pn_container);
        }
        public void Click_DatPhong(object sender, EventArgs e)
        {
            using (DatPhong datPhong = new DatPhong(TrangChu))
            {
                datPhong.ShowDialog();
            } 
        }
    }
}
