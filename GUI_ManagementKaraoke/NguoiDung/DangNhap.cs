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
    public partial class DangNhap : Form
    {
        public BLL_DangNhap BLL = new BLL_DangNhap();
        public int QuyenHan {  get; set; }
        public string TaiKhoan { get; set; }
        public Management_Karaoke FrmQuanLy;
        public event EventHandler DongFormNguoiDung;
        public DangNhap()
        {
            InitializeComponent();
        }
        void BatSuKien_DongFormNguoiDung()
        {
            DongFormNguoiDung?.Invoke(this, EventArgs.Empty);
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            cbb_ChucVu.Text = "Nhân viên";
        }
        private void ckb_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_HienMatKhau.Checked)
            {
                txt_MatKhau.PasswordChar = '\0';
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }
        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            var _QuyenHan = BLL.KiemTraQuyenHan(cbb_ChucVu.Text);
            var KiemTra = new BLL_DangNhap().KiemTraTaiKhoan(txt_TaiKhoan.Text, txt_MatKhau.Text, _QuyenHan);

            switch (KiemTra)
            {
                case -1:
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo");
                    break;
                case 0:
                    MessageBox.Show("Sai mật khẩu", "Thông báo");
                    break;
                case 1:
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    QuyenHan = _QuyenHan;
                    TaiKhoan = txt_TaiKhoan.Text;
                    FrmQuanLy = new Management_Karaoke(QuyenHan, txt_TaiKhoan.Text);
                    BatSuKien_DongFormNguoiDung();
                    FrmQuanLy.Show();
                    break;
            }
        }
    }
}
