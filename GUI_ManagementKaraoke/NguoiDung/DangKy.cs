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
using BLL.Implement_BLL;

namespace GUI_ManagementKaraoke.NguoiDung
{
    public partial class DangKy : Form
    {
        // khởi tạo lớp BLL
        BLL_DangKy BLL = new BLL_DangKy();
        public DangKy()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (BLL.Check_HopLe(txt_TenTaiKhoan.Text))
            {
                if (BLL.Check_NhapMatKhauTrungKhop(txt_MatKhau.Text, txt_XNMatKhau.Text))
                {
                    tblNguoiDung ND = new tblNguoiDung();
                    ND.Email = txt_Email.Text.Trim();
                    ND.TenTaiKhoan = txt_TenTaiKhoan.Text.Trim();
                    ND.MatKhau = txt_MatKhau.Text.Trim();
                    ND.QuyenHan = 1;
                    BLL.ThemNguoiDung(ND);

                    MessageBox.Show("Tạo tài khoản thành công !!");
                }
                else
                {
                    MessageBox.Show("Mật khẩu chưa trùng khớp !!");
                }
            }
            else
            {
                MessageBox.Show("Đã có tài khoản này, mời chọn tài khoản khác !!");
            }
        }
    }
}
