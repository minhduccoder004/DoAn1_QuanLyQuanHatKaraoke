using BLL.Implement_BLL;
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
    public partial class InfoAccount : Form
    {
        BLL_InfoAccount BLL = new BLL_InfoAccount();
        public int QuyenHan {  get; set; }
        public string TaiKhoan { get; set; }

        public InfoAccount(int QuyenHan, string TaiKhoan)
        {
            InitializeComponent();
            this.QuyenHan = QuyenHan;
            this.TaiKhoan = TaiKhoan;
        }

        private void InfoAccount_Load(object sender, EventArgs e)
        {
            // label4 = tên tài khoản
            txt_Account.Text = TaiKhoan;
            // label3 = quyền hạn
            txt_QuyenHan.Text = BLL.Check_QuyenHan(QuyenHan);

            switch (QuyenHan)
            {
                case 1:
                    bt_Menu.ContextMenuStrip = menuNhanVien_QLTaiKhoan;
                    break;
                case 0:
                    bt_Menu.ContextMenuStrip = menuQuanLy_QLTaiKhoan;
                    break;
            }
        }

        private void bt_Menu_Click(object sender, EventArgs e)
        {
            switch (QuyenHan)
            {
                case 1:
                    bt_Menu.ContextMenuStrip.Show(bt_Menu, new Point(0, 76));

                    break;
                case 0:
                    bt_Menu.ContextMenuStrip.Show(bt_Menu, new Point(0, 76));
                    break;
            }
        }
    }
}
