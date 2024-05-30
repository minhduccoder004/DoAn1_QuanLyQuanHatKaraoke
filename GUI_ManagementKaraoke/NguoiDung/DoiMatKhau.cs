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
            tblNguoiDung ND = new tblNguoiDung();
            ND.TenTaiKhoan = QuanLys.TaiKhoan;
            ND.MatKhau = txt_MatKhauMoi.Text;

            BLL.DoiMatKhau(ND);

            MessageBox.Show("Đã đổi mật khẩu !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}
