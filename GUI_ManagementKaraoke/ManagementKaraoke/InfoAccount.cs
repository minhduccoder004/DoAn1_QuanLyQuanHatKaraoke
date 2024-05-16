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
            label4.Text = TaiKhoan;
            // label3 = quyền hạn
            label3.Text = BLL.Check_QuyenHan(QuyenHan);
        }
    }
}
