using BLL.Implement_BLL;
using DTO;
using GUI_ManagementKaraoke.Event;
using GUI_ManagementKaraoke.Picture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class QuanLyNhanVien : Form
    {
        // Khởi tạo thuộc tính
        Color DisableButtonColor = Color.FromArgb(128, 179, 255);
        Color EnableButtonColor = Color.FromArgb(104, 126, 255);
        bool Flag_Status = false;
        string TenAnh;
        string DuongDanTuyetDoi;

        // Khởi tạo lớp xử lý ảnh

        XuLyAnh xuLyAnh = new XuLyAnh();

        // Khai báo lớp BLL
        BLL_QuanLyNhanVien BLL = new BLL_QuanLyNhanVien();
        // Phương thức làm mới dữ liệu
        public void LamMoi()
        {
            dgv_DSNhanVien.DataSource = BLL.DanhSachDoiTuong();
            dgv_DSNhanVien.Refresh();
        }

        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            ThemNhanVien Create_NV = new ThemNhanVien(this);
            Create_NV.ShowDialog();
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            // Làm mới datagridview
            LamMoi();

            // Đổi màu button
            bt_Create.FillColor = EnableButtonColor;
            bt_Delete.FillColor = DisableButtonColor;
            bt_Update.FillColor = DisableButtonColor;

            // Reset infor
            pic_AnhNhanVien.Image = null;
            txt_MaNhanVien.Text = string.Empty;
            txt_TenNhanVien.Text = string.Empty;
            rbt_Nam.Checked = false;
            rbt_Nu.Checked = false;
            dtp_NgaySinh.Value = DateTime.Now;
            txt_Email.Text = string.Empty;
            txt_DiaChi.Text = string.Empty;
            txt_SoDienThoai.Text = string.Empty;

            // 
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            // Làm mới dgv
            LamMoi();

            // Đổi màu button
            bt_Delete.FillColor = DisableButtonColor;
            bt_Update.FillColor = DisableButtonColor;

            // Format datagridview
            dgv_DSNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgv_DSNhanVien.Columns[0].Width = 160;
            dgv_DSNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgv_DSNhanVien.Columns[1].Width = 180;
            dgv_DSNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dgv_DSNhanVien.Columns[2].Width = 80;
            dgv_DSNhanVien.Columns[3].HeaderText = "Số điện thoại";
            dgv_DSNhanVien.Columns[3].Width = 100;
            dgv_DSNhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgv_DSNhanVien.Columns[4].Width = 170;
            dgv_DSNhanVien.Columns[5].HeaderText = "Giới tính";
            dgv_DSNhanVien.Columns[5].Width = 50;
            dgv_DSNhanVien.Columns[6].HeaderText = "Email";
            dgv_DSNhanVien.Columns[6].Width = 250;
            dgv_DSNhanVien.Columns[7].Visible = false;
            dgv_DSNhanVien.Columns[8].Visible = false;
            dgv_DSNhanVien.Columns[9].Visible = false;

            // 
        }

        private void dgv_DSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đổi màu button (Enable)
            bt_Update.FillColor = EnableButtonColor;
            bt_Delete.FillColor = EnableButtonColor;
            // Đổi màu button (Disable)
            bt_Create.FillColor = DisableButtonColor;
            // Gán dữ liệu cho txt
            if (e.RowIndex != -1)
            {
                pic_AnhNhanVien.Image = LayAnhNhanVien(dgv_DSNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                pic_AnhNhanVien.SizeMode = PictureBoxSizeMode.Zoom;

                txt_MaNhanVien.Text = dgv_DSNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                txt_TenNhanVien.Text = dgv_DSNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                dtp_NgaySinh.Value = Convert.ToDateTime(dgv_DSNhanVien.Rows[e.RowIndex].Cells[2].Value);
                txt_SoDienThoai.Text = dgv_DSNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                txt_DiaChi.Text = dgv_DSNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                if (Equals(dgv_DSNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString().Trim(), "Nam"))
                {
                    rbt_Nam.Checked = true;
                }
                else if (Equals(dgv_DSNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString().Trim(), "Nữ"))
                {
                    rbt_Nu.Checked = true;
                }
                else
                {
                    rbt_Nam.Checked = false;
                    rbt_Nu.Checked = false;
                }
                txt_Email.Text = dgv_DSNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
            }
            // Thay đổi trạng thái cờ
            Flag_Status = true;
        }

        Image LayAnhNhanVien(string ID)
        {
            Image Anh;
            var TenAnh = BLL.DanhSachDoiTuong().Find(x => Equals(x.MaNhanVien.Trim(), ID)).FileAnh.Trim();

            if (TenAnh != "")
            {
                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                var relativePath = Path.Combine("..", "..", "Picture", "AnhNhanVien", $"{TenAnh}");
                var fullPath = Path.GetFullPath(Path.Combine(basePath, relativePath));


                using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    Anh = Image.FromStream(fs);
                }
                return Anh;
            }

            return default;
        }

        private void bt_ThemAnh_Click(object sender, EventArgs e)
        {
            // Code đổi ảnh
            var LayAnh = xuLyAnh.ChonAnh(pic_AnhNhanVien);

            TenAnh = LayAnh.Item1;
            DuongDanTuyetDoi = LayAnh.Item2;

        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (Flag_Status)
            {
                // Code đổi màu button
                bt_Create.FillColor = EnableButtonColor;
                bt_Update.FillColor = DisableButtonColor;
                bt_Delete.FillColor = DisableButtonColor;

                // Code đổi thông tin nhân viên
                tblNhanVien NV = BLL.GetByID(txt_MaNhanVien.Text);
                xuLyAnh.XoaAnh(NV.FileAnh);
                NV.FileAnh = TenAnh;
                BLL.Sua(NV);
                xuLyAnh.SaoChepAnh_ThuMucPicture(DuongDanTuyetDoi, TenAnh);
                Flag_Status = false;

                // Làm mới
                LamMoi();
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (Flag_Status)
            {
                // Code đổi màu button
                bt_Create.FillColor = EnableButtonColor;
                bt_Update.FillColor = DisableButtonColor;
                bt_Delete.FillColor = DisableButtonColor;

                // Code xoá nhân viên
                BLL.Xoa(BLL.GetByID(txt_MaNhanVien.Text));
                Flag_Status = false;

                // Làm mới datagridview
                LamMoi();
            }
        }

        public void BatSuKien_LayDanhSach(object sender, Event_LayDSNhanVien e)
        {
            dgv_DSNhanVien.DataSource = e.DanhSachNhanVien;
        }
    }
}
