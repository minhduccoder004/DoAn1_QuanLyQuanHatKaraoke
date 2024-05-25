using BLL.Implement_BLL;
using DTO;
using GUI_ManagementKaraoke.NguoiDung;
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
    public partial class QuanLyTaiKhoan : Form
    {
        /*---------------Khởi tạo lớp BLL-------------------*/

        BLL_NguoiDung BLL = new BLL_NguoiDung();

        /*--------------------------------------------------*/

        /*---------------Khởi tạo thuộc tính----------------*/

        string[] arr_QuyenHan = { "Quản lý", "Nhân viên" };
        bool Flag_Status = false;
        Color DisableColorButton = Color.FromArgb(128, 179, 255);
        Color EnableColorButton = Color.FromArgb(104, 126, 255);

        /*--------------------------------------------------*/

        /*---------------Khởi tạo phương thức---------------*/

        public void DoDuLieu_DanhSachTaiKhoan()
        {
            dgv_TaiKhoan.DataSource = BLL.DanhSachDoiTuong();
            dgv_TaiKhoan.Refresh();
        }

        void DoDuLieu_Cbb()
        {
            cbb_QuyenHan.DataSource = arr_QuyenHan;
            cbb_QuyenHan.SelectedIndex = -1;
        }

        /*--------------------------------------------------*/

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu dgv
            DoDuLieu_DanhSachTaiKhoan();

            // Format dgv
            dgv_TaiKhoan.Columns[0].HeaderText = "Tên tài khoản";
            dgv_TaiKhoan.Columns[1].HeaderText = "Mật khẩu";
            dgv_TaiKhoan.Columns[2].Visible = false;
            dgv_TaiKhoan.Columns[3].Visible = false;
            dgv_TaiKhoan.Columns[4].HeaderText = "Quyền hạn";

            // Đổ dữ liệu combobox quyền hạn
            DoDuLieu_Cbb();

            // Đổi màu button
            bt_Update.FillColor = DisableColorButton;
            bt_XoaTaiKhoan.FillColor = DisableColorButton;
        }

        private void dgv_TaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    if (e.Value != null)
                    {
                        e.Value = e.Value.ToString().Trim();
                    }
                    break;
                case 1:
                    if (e.Value != null)
                    {
                        e.Value = e.Value.ToString().Trim();
                    }
                    break;
                case 4:
                    if (e.Value != null)
                    {
                        e.Value = BLL.QuyenHanNguoiDung(Convert.ToInt32(e.Value));
                    }
                    break;

            }
        }

        private void dgv_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // đổ dữ liệu txt
                txt_TaiKhoan.Text = dgv_TaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_MatKhau.Text = dgv_TaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_SoDienThoai.Text = BLL.GetByID(dgv_TaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString()).SoDienThoai;
                txt_Email.Text = BLL.GetByID(dgv_TaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString()).Email;
                switch (BLL.GetByID(dgv_TaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString()).QuyenHan)
                {
                    case 0:
                        cbb_QuyenHan.SelectedIndex = 0;
                        break;
                    case 1:
                        cbb_QuyenHan.SelectedIndex = 1;
                        break;
                }
            }
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            // Làm mới txt
            txt_TaiKhoan.Text = "...............................";
            txt_MatKhau.Text = string.Empty;
            txt_SoDienThoai.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_TimKiem.Text = string.Empty;

            // Đổ lại dữ liệu dgv
            DoDuLieu_DanhSachTaiKhoan();

            // Đổ lại dữ liệu cbb
            DoDuLieu_Cbb();

            // Đổi màu button
            bt_Create.FillColor = EnableColorButton;
            bt_Update.FillColor = DisableColorButton;
            bt_XoaTaiKhoan.FillColor = DisableColorButton;
        }

        private void bt_Refresh_dgv_Click(object sender, EventArgs e)
        {
            // xoá text tìm kiếm
            txt_TimKiem.Text = string.Empty;

            // Đổ lại dữ liệu dgv
            DoDuLieu_DanhSachTaiKhoan();

        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            if (!Flag_Status)
            {
                ThemTaiKhoan TK = new ThemTaiKhoan(this);
                TK.ShowDialog();
            }
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (Flag_Status)
            {
                // Đổi cờ
                Flag_Status = false;
                // Đổi màu bt
                bt_Create.FillColor = EnableColorButton;
                bt_Update.FillColor = DisableColorButton;
                bt_XoaTaiKhoan.FillColor = DisableColorButton;

                // code
                tblNguoiDung ND = new tblNguoiDung();
                ND.TenTaiKhoan = txt_TaiKhoan.Text.Trim();
                ND.MatKhau = txt_MatKhau.Text.Trim();
                ND.Email = txt_Email.Text.Trim();
                ND.SoDienThoai = txt_SoDienThoai.Text.Trim();
                ND.QuyenHan = BLL.QuyenHanNguoiDung(cbb_QuyenHan.Text.Trim());

                BLL.Sua(ND);

                DoDuLieu_DanhSachTaiKhoan();

                MessageBox.Show("Đã sửa đổi thông tin !!");
            }
        }

        private void bt_XoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (Flag_Status)
            {
                // Đổi cờ
                Flag_Status = false;

                // Đổi màu bt
                bt_Create.FillColor = EnableColorButton;
                bt_Update.FillColor = DisableColorButton;
                bt_XoaTaiKhoan.FillColor= DisableColorButton;

                // code
                BLL.Xoa(BLL.GetByID(txt_TaiKhoan.Text.Trim()));

                MessageBox.Show("Đã xoá tài khoản !!");

                // đổ lại dữ liệu
                DoDuLieu_DanhSachTaiKhoan();

                // Làm mới txt
                txt_TaiKhoan.Text = "...............................";
                txt_MatKhau.Text = string.Empty;
                txt_SoDienThoai.Text = string.Empty;
                txt_Email.Text = string.Empty;
                txt_TimKiem.Text = string.Empty;
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            dgv_TaiKhoan.DataSource = BLL.TimKiemNguoiDung(txt_TimKiem.Text);
            dgv_TaiKhoan.Refresh();
        }

        private void txt_MatKhau_Click(object sender, EventArgs e)
        {
            // đổi cờ
            Flag_Status = true;

            // đổi màu bt
            bt_Create.FillColor = DisableColorButton;
            bt_Update.FillColor = EnableColorButton;
            bt_XoaTaiKhoan.FillColor = EnableColorButton;
        }

        private void txt_Email_Click(object sender, EventArgs e)
        {
            // đổi cờ
            Flag_Status = true;

            // đổi màu bt
            bt_Create.FillColor = DisableColorButton;
            bt_Update.FillColor = EnableColorButton;
            bt_XoaTaiKhoan.FillColor = EnableColorButton;
        }

        private void txt_SoDienThoai_Click(object sender, EventArgs e)
        {
            // đổi cờ
            Flag_Status = true;

            // đổi màu bt
            bt_Create.FillColor = DisableColorButton;
            bt_Update.FillColor = EnableColorButton;
            bt_XoaTaiKhoan.FillColor = EnableColorButton;
        }

        private void cbb_QuyenHan_Click(object sender, EventArgs e)
        {
            // đổi cờ
            Flag_Status = true;

            // đổi màu bt
            bt_Create.FillColor = DisableColorButton;
            bt_Update.FillColor = EnableColorButton;
            bt_XoaTaiKhoan.FillColor = EnableColorButton;
        }
    }
}
