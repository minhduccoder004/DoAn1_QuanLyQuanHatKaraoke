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
        DangNhap FrmDangNhap;
        DangKy FrmDangKy = new DangKy() {TopLevel= false };
        QuenMatKhau FrmQuenMatKhau = new QuenMatKhau() { TopLevel = false };


        void AnDaCoTK()
        {
            lb_DaCoTK.Hide();
            llb_DaCoTK.Hide();
        }
        void HienDaCoTK()
        {
            lb_DaCoTK.Show();
            llb_DaCoTK.Show();
        }
        void AnChuaCoTK()
        {
            lb_ChuaCoTK.Hide();
            llb_ChuaCoTK.Hide();
        }
        void HienChuaCoTK()
        {
            lb_ChuaCoTK.Show();
            llb_ChuaCoTK.Show();
        }

        void MoFrm(Form form)
        {
            pn_ChucNang.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        void DongFrm()
        {
            pn_ChucNang.Controls.Clear();
        }
        public Nguoi_Dung()
        {
            InitializeComponent();
            FrmDangNhap = new DangNhap() { TopLevel = false };
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(FrmDangNhap);
        }

        private void Nguoi_Dung_Load(object sender, EventArgs e)
        {
            AnDaCoTK();
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

        private void llb_DaCoTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DongFrm();
            AnDaCoTK();
            HienChuaCoTK();
            MoFrm(FrmDangNhap);
        }

        private void llb_ChuaCoTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DongFrm();
            HienDaCoTK();
            AnChuaCoTK();
            MoFrm(FrmDangKy);
        }

        private void llb_QuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DongFrm();
            MoFrm(FrmQuenMatKhau);
        }
    }
}
