using BLL.Implement_BLL;
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
using GUI_ManagementKaraoke.Event;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class QuanLyPhongHat : Form
    {
        // Khởi tạo lớp BLL
        BLL_QuanLyPhongHat BLL = new BLL_QuanLyPhongHat();

        // Khởi tạo thuộc tính
        bool Flag_Status = false;
        Color DisableButtonColor = Color.FromArgb(128, 179, 255);
        Color EnableButtonColor = Color.FromArgb(104, 126, 255);


        // Khởi tạo các phương thức
        public void LamMoi()
        {
            dgv_DanhSachPhong.DataSource = BLL.DanhSachDoiTuong();
            dgv_DanhSachPhong.Refresh();
        }

        // Hàm khởi tạo
        public QuanLyPhongHat()
        {
            InitializeComponent();
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            // Đổi màu button
            bt_Create.FillColor = EnableButtonColor;
            bt_Update.FillColor = DisableButtonColor;
            bt_Delete.FillColor = DisableButtonColor;

            // Làm mới
            LamMoi();

            // Reset text
            cbb_LoaiPhong.SelectedIndex = -1;
            txt_MaPhong.Text = string.Empty;
            txt_TenPhong.Text = string.Empty;
            txt_TrangThaiPhong.Text = string.Empty;
            cbb_SapXepTheo.SelectedIndex = -1;

            // Đổi trạng thái cờ
            Flag_Status = false;
        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            if (!Flag_Status)
            {
                ThemPhong Create_Phong = new ThemPhong(this);
                Create_Phong.ShowDialog();
            }
        }

        private void QuanLyPhongHat_Load(object sender, EventArgs e)
        {
            // Làm mới dgv
            LamMoi();

            // Đổi màu button
            bt_Update.FillColor = DisableButtonColor;
            bt_Delete.FillColor = DisableButtonColor;

            // Format dgv
            dgv_DanhSachPhong.Columns[0].HeaderText = "Mã phòng";
            dgv_DanhSachPhong.Columns[1].HeaderText = "Tên phòng";
            dgv_DanhSachPhong.Columns[2].HeaderText = "Trạng thái phòng";
            dgv_DanhSachPhong.Columns[3].HeaderText = "Loại phòng";
            dgv_DanhSachPhong.Columns[4].Visible = false;
            dgv_DanhSachPhong.Columns[5].Visible = false;

            // cbb
            cbb_LoaiPhong.DataSource = BLL.LoaiPhongs();
        }

        private void dgv_DanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cbb_LoaiPhong.Text = BLL.LayTenLoaiPhong(dgv_DanhSachPhong[3, e.RowIndex].Value.ToString());
                txt_MaPhong.Text = dgv_DanhSachPhong[0, e.RowIndex].Value.ToString();
                txt_TenPhong.Text = dgv_DanhSachPhong[1, e.RowIndex].Value.ToString();
                txt_TrangThaiPhong.Text = BLL.TrangThaiPhong(Convert.ToInt32(dgv_DanhSachPhong[2, e.RowIndex].Value));


                // Đổi màu button
                bt_Create.FillColor = DisableButtonColor;
                bt_Update.FillColor = EnableButtonColor;
                bt_Delete.FillColor = EnableButtonColor;

                // Đổi trạng thái cờ
                Flag_Status = true;
            }
        }

        private void dgv_DanhSachPhong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int TrangThai = Convert.ToInt32(e.Value);
                switch (TrangThai)
                {
                    case 0:
                        e.Value = "Không hoạt động";
                        break;
                    case 1:
                        e.Value = "Đang hoạt động";
                        break;
                }
            }
            if (e.ColumnIndex == 3)
            {
                string LoaiPhong = e.Value.ToString();
                switch (LoaiPhong.Trim())
                {
                    case "LP001":
                        e.Value = "Phòng VIP";
                        break;
                    case "LP002":
                        e.Value = "Phòng LUX";
                        break;
                    case "LP003":
                        e.Value = "Phòng thường";
                        break;
                }
            }
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (Flag_Status)
            {
                // Code cập nhật phòng
                tblPhongHat PH = new tblPhongHat();

                PH.MaPhongHat = txt_MaPhong.Text;
                PH.TrangThaiPhong = BLL.TrangThaiPhong(txt_TrangThaiPhong.Text);
                PH.MaLoaiPhong = BLL.LayMaLoaiPhong(cbb_LoaiPhong.Text); 
                PH.TenPhongHat = txt_TenPhong.Text;

                BLL.Sua(PH);

                // Đổi màu button

                bt_Create.FillColor = EnableButtonColor;
                bt_Update.FillColor = DisableButtonColor;
                bt_Delete.FillColor = DisableButtonColor;

                // Đổi trạng thái cờ
                Flag_Status = false;

                // Làm mới
                LamMoi();
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (Flag_Status)
            {
                // Đổi màu button
                bt_Create.FillColor = EnableButtonColor;
                bt_Update.FillColor = DisableButtonColor;
                bt_Delete.FillColor = DisableButtonColor;

                // Đổi trạng thái cờ
                Flag_Status = false;

                BLL.Xoa(BLL.GetByID(txt_MaPhong.Text));


                // Làm mới
                LamMoi();
            }
        }

        private void cbb_SapXepTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_DanhSachPhong.DataSource = BLL.SapXep(cbb_SapXepTheo.Text);
            dgv_DanhSachPhong.Refresh();
        }

        public void BatSuKien_LayDanhSach(object sender, Event_LayDSPhongHat e)
        {
            dgv_DanhSachPhong.DataSource = e.DanhSachPhongHat;
            dgv_DanhSachPhong.Refresh();
        } 
    }
}
