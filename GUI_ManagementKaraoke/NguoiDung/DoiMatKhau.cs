using BLL.Implement_BLL;
using DTO;
using GUI_ManagementKaraoke.ManagementKaraoke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ManagementKaraoke.NguoiDung
{
    public partial class DoiMatKhau : Form
    {
        BLL_NguoiDung BLL = new BLL_NguoiDung();
        InfoAccount QuanLys;
        public DoiMatKhau(InfoAccount form)
        {
            InitializeComponent();
            QuanLys = form;
        }

        private void bt_XacNhanDoi_Click(object sender, EventArgs e)
        {

            if (!Equals(BLL.GetByID(QuanLys.TaiKhoan).MatKhau.Trim(), txt_MatKhauCu.Text))
            {
                MessageBox.Show("Mật khẩu cũ không trùng khớp !!");
            }
            else
            {
                if (Equals(txt_MatKhauMoi.Text, txt_XacNhanMatKhau.Text))
                {
                    tblNguoiDung ND = new tblNguoiDung();
                    ND.TenTaiKhoan = QuanLys.TaiKhoan;
                    ND.MatKhau = txt_MatKhauMoi.Text;

                    BLL.DoiMatKhau(ND);

                    MessageBox.Show("Đã đổi mật khẩu !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới nhập không trùng khớp !!");
                }
            }
        }

        private void txt_MatKhauCu_TextChanged(object sender, EventArgs e)
        {
            if (!Equals(BLL.GetByID(QuanLys.TaiKhoan).MatKhau.Trim(), txt_MatKhauCu.Text))
            {
                err_MatKhauCu.Visible = true;
            }
            else
            {
                err_MatKhauCu.Visible = false;
            }
        }

        private void txt_MatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_XacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void err_MatKhauCu_MouseHover(object sender, EventArgs e)
        {
            if (!Equals(BLL.GetByID(QuanLys.TaiKhoan).MatKhau.Trim(), txt_MatKhauCu.Text))
            {
                tt_HienThiLoi.SetToolTip(err_MatKhauCu, "<b style=\"color:red;\">Mật khẩu cũ nhập sai !!<b>");
            }
        }
    }
}
