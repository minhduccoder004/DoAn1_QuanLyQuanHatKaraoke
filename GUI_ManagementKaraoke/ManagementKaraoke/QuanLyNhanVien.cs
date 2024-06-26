﻿using BLL.Implement_BLL;
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
        bool Flag_DoiAnh = false;
        string TenAnh;
        string DuongDanTuyetDoi;
        public string[] arr_ChucVu = { "Quản lý", "Thu ngân", "Phục vụ" };

        string[] arr_SapXepTheo = { "Tên nhân viên", "Địa chỉ", "Số điện thoại", "Email" };

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

            //  reset sắp xếp
            cbb_SapXepTheo.SelectedIndex = -1;
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
            dgv_DSNhanVien.Columns[8].HeaderText = "Chức vụ";
            dgv_DSNhanVien.Columns[8].Width = 100;
            dgv_DSNhanVien.Columns[9].Visible = false;
            dgv_DSNhanVien.Columns[10].Visible = false;
            dgv_DSNhanVien.Columns[11].Visible = false;

            // thêm dữ liệu cho combobox chức vụ
            cbb_ChucVu.DataSource = arr_ChucVu;
            cbb_ChucVu.SelectedIndex = -1;

            // Đổ dữ liệu cbb sắp xếp
            cbb_SapXepTheo.DataSource = arr_SapXepTheo;
            cbb_SapXepTheo.SelectedIndex = -1;
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

                cbb_ChucVu.Text = BLL.LayChucVu(Convert.ToInt32(dgv_DSNhanVien.Rows[e.RowIndex].Cells[8].Value));
            }
            // Thay đổi trạng thái cờ
            Flag_Status = true;
        }

        Image LayAnhNhanVien(string ID)
        {
            Image Anh;
            string TenAnh = "";

            if (BLL.DanhSachDoiTuong().Find(x => Equals(x.MaNhanVien.Trim(), ID)).FileAnh != null)
            {
                TenAnh = BLL.DanhSachDoiTuong().Find(x => Equals(x.MaNhanVien.Trim(), ID)).FileAnh.Trim();
            }

            if (TenAnh != "")
            {
                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                var relativePath = Path.Combine("AnhNhanVien", $"{TenAnh}");
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
            Flag_DoiAnh = true;
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
                if (Flag_DoiAnh)
                {
                    xuLyAnh.XoaAnh(NV.FileAnh ?? "");
                    NV.FileAnh = TenAnh;
                    Flag_DoiAnh = false;
                }

                NV.SoDienThoai = txt_SoDienThoai.Text.Trim();
                NV.TenNhanVien = txt_TenNhanVien.Text.Trim();
                NV.Email = txt_Email.Text.Trim();
                NV.DiaChi = txt_DiaChi.Text.Trim();
                if (rbt_Nam.Checked)
                {
                    NV.GioiTinh = "Nam";
                }
                if (rbt_Nu.Checked)
                {
                    NV.GioiTinh = "Nữ";
                }
                NV.NgaySinh = dtp_NgaySinh.Value;
                NV.ChucVu = BLL.LayChucVu(cbb_ChucVu.Text.Trim());

                BLL.Sua(NV);
                if (DuongDanTuyetDoi != null)
                {
                    xuLyAnh.SaoChepAnh_ThuMucPicture(DuongDanTuyetDoi, TenAnh);
                }
                Flag_Status = false;
                MessageBox.Show("Đã sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                var NhanVien = BLL.GetByID(txt_MaNhanVien.Text);

                NhanVien.TrangThaiXoa = 1;
                // Code xoá nhân viên
                BLL.Xoa(NhanVien);
                Flag_Status = false;
                MessageBox.Show("Xoá nhân viên thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới datagridview
                LamMoi();
            }
        }

        public void BatSuKien_LayDanhSach(object sender, Event_LayDSNhanVien e)
        {
            dgv_DSNhanVien.DataSource = e.DanhSachNhanVien;
        }

        private void dgv_DSNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                int ChucVu = Convert.ToInt32(e.Value);
                switch (ChucVu)
                {
                    case 0:
                        e.Value = "Quản lý";
                        break;
                    case 1:
                        e.Value = "Thu ngân";
                        break;
                    case 2:
                        e.Value = "Phục vụ";
                        break;
                }
            }
        }

        private void cbb_SapXepTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_SapXepTheo.Text.ToLower().Trim())
            {
                case "tên nhân viên":
                    dgv_DSNhanVien.DataSource = BLL.SapXep_TenNhanVien();
                    dgv_DSNhanVien.Refresh();
                    break;
                case "số điện thoại":
                    dgv_DSNhanVien.DataSource = BLL.SapXep_SoDienThoai();
                    dgv_DSNhanVien.Refresh();
                    break;
                case "địa chỉ":
                    dgv_DSNhanVien.DataSource = BLL.SapXep_DiaChi();
                    dgv_DSNhanVien.Refresh();
                    break;
                case "email":
                    dgv_DSNhanVien.DataSource = BLL.SapXep_Email();
                    dgv_DSNhanVien.Refresh();
                    break;
            }
        }
    }
}
