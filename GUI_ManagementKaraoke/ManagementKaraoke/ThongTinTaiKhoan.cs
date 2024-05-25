using BLL.Implement_BLL;
using DTO;
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
    public partial class ThongTinTaiKhoan : Form
    {

        BLL_NguoiDung BLL = new BLL_NguoiDung();

        InfoAccount QuanLys;
        public ThongTinTaiKhoan(InfoAccount form)
        {
            InitializeComponent();
            QuanLys = form;
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Text = QuanLys.TaiKhoan;
            txt_MatKhau.Text = BLL.GetByID(QuanLys.TaiKhoan).MatKhau;
            txt_SoDienThoai.Text = BLL.GetByID(QuanLys.TaiKhoan).SoDienThoai;
            txt_Email.Text = BLL.GetByID(QuanLys.TaiKhoan).Email;
            txt_QuyenHan.Text = BLL.QuyenHanNguoiDung(QuanLys.QuyenHan);
        }

        private void bt_SuaThongTin_Click(object sender, EventArgs e)
        {
            tblNguoiDung ND = new tblNguoiDung();

            ND.TenTaiKhoan = QuanLys.TaiKhoan;
            ND.MatKhau = txt_MatKhau.Text;
            ND.Email = txt_Email.Text;
            ND.SoDienThoai = txt_SoDienThoai.Text;
            ND.QuyenHan = BLL.QuyenHanNguoiDung(txt_QuyenHan.Text);

            BLL.Sua(ND);

            MessageBox.Show("Đã sửa thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
