using GUI_ManagementKaraoke.NguoiDung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ManagementKaraoke
{
    public partial class Nguoi_Dung : Form
    {
        readonly DangNhap FrmDangNhap = new DangNhap() { TopLevel = false };

        void MoFrm(Form form)
        {
            pn_ChucNang.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        public Nguoi_Dung()
        {
            InitializeComponent();
        }

        private void Nguoi_Dung_Load(object sender, EventArgs e)
        {
            MoFrm(FrmDangNhap);
            FrmDangNhap.DongFormNguoiDung += DangNhapThanhCong;
        }
        public void DangNhapThanhCong(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap.FrmQuanLy.FormClosed += BatSuKien_FormDangNhapDong;
        }
        void BatSuKien_FormDangNhapDong(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
