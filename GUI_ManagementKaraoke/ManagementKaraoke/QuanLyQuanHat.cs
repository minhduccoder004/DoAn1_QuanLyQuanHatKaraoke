using BLL.Implement_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class QuanLyQuanHat : Form
    {
        // Khởi tạo lớp BLL
        BLL_QuanLyQuanHat BLL = new BLL_QuanLyQuanHat();

        // Khởi tạo thuộc tính
        string[] arr_DanhSach = { "Phòng lên lịch", "Phòng đang chạy" };
        bool Flag_Status = false;
        Color DisableButtonColor = Color.FromArgb(128, 179, 255);
        Color EnableButtonColor = Color.FromArgb(104, 126, 255);
        string MaPhongDat { get; set; }

        // Tạo các phương thức
        void FormatHeaderTable()
        {
            switch (cbb_DanhSach.SelectedIndex)
            {
                case 0:
                    dgv_DanhSach.Columns[0].HeaderText = "Mã phòng đặt";
                    dgv_DanhSach.Columns[0].Width = 170;
                    dgv_DanhSach.Columns[1].HeaderText = "Phòng";
                    dgv_DanhSach.Columns[1].Width = 100;
                    dgv_DanhSach.Columns[2].HeaderText = "Nhân viên";
                    dgv_DanhSach.Columns[2].Width = 130;
                    dgv_DanhSach.Columns[3].HeaderText = "Khách hàng";
                    dgv_DanhSach.Columns[4].Visible = true;
                    dgv_DanhSach.Columns[4].HeaderText = "Thời gian lên lịch";
                    dgv_DanhSach.Columns[4].Width = 190;
                    dgv_DanhSach.Columns[5].Visible = false;
                    dgv_DanhSach.Columns[6].Visible = false;
                    dgv_DanhSach.Columns[7].Visible = false;
                    dgv_DanhSach.Columns[8].Visible = false;
                    dgv_DanhSach.Columns[9].Visible = false;
                    dgv_DanhSach.Columns[10].Visible = false;
                    dgv_DanhSach.Columns[11].Visible = false;
                    dgv_DanhSach.Columns[12].Visible = false;
                    dgv_DanhSach.Columns[13].Visible = false;
                    break;
                case 1:
                    dgv_DanhSach.Columns[0].HeaderText = "Mã phòng đặt";
                    dgv_DanhSach.Columns[0].Width = 170;
                    dgv_DanhSach.Columns[1].HeaderText = "Phòng";
                    dgv_DanhSach.Columns[1].Width = 100;
                    dgv_DanhSach.Columns[2].HeaderText = "Nhân viên";
                    dgv_DanhSach.Columns[2].Width = 130;
                    dgv_DanhSach.Columns[3].HeaderText = "Khách hàng";
                    dgv_DanhSach.Columns[4].Visible = false;
                    dgv_DanhSach.Columns[5].Visible = true;
                    dgv_DanhSach.Columns[5].HeaderText = "Thời gian phòng bắt đầu hoạt động";
                    dgv_DanhSach.Columns[5].Width = 190;
                    dgv_DanhSach.Columns[6].Visible = false;
                    dgv_DanhSach.Columns[7].Visible = false;
                    dgv_DanhSach.Columns[8].Visible = false;
                    dgv_DanhSach.Columns[9].Visible = false;
                    dgv_DanhSach.Columns[10].Visible = false;
                    dgv_DanhSach.Columns[11].Visible = false;
                    dgv_DanhSach.Columns[12].Visible = false;
                    dgv_DanhSach.Columns[13].Visible = false;
                    break;
            }
        }

        public void LamMoi()
        {

            switch (cbb_DanhSach.SelectedIndex)
            {
                case 0:
                    dgv_DanhSach.DataSource = BLL.DanhSachPhongDat_ChuaHoatDong();
                    dgv_DanhSach.Refresh();
                    FormatHeaderTable();
                    DoiMauButtonTheoTrangThaiDanhSach();
                    break;
                case 1:
                    dgv_DanhSach.DataSource = BLL.DanhSachPhongDat_DangHoatDong();
                    dgv_DanhSach.Refresh();
                    FormatHeaderTable();
                    DoiMauButtonTheoTrangThaiDanhSach();
                    break;
            }
        }

        void DoiMauButtonTheoTrangThaiDanhSach()
        {
            switch (cbb_DanhSach.SelectedIndex)
            {
                case 0:
                    bt_BatDau.FillColor = EnableButtonColor;
                    bt_Order.FillColor = DisableButtonColor;
                    bt_ThanhToan.FillColor = DisableButtonColor;
                    break;
                case 1:
                    bt_BatDau.FillColor = DisableButtonColor;
                    bt_Order.FillColor = EnableButtonColor;
                    bt_ThanhToan.FillColor = EnableButtonColor;
                    break;
            }
        }


        public QuanLyQuanHat()
        {
            InitializeComponent();
        }

        private void QuanLyQuanHat_Load(object sender, EventArgs e)
        {
            // Dữ liệu combobox danh sách
            cbb_DanhSach.DataSource = arr_DanhSach;
            cbb_DanhSach.SelectedIndex = 1;

            // Format datagridview
            LamMoi();

            // Đổi màu button 
            bt_Delete.FillColor = DisableButtonColor;
        }

        private void dgv_DanhSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    e.Value = e.Value.ToString().Trim();
                }
                catch(Exception)
                {

                }
            }
            if (e.ColumnIndex == 1)
            {
                try
                {
                    e.Value = BLL.LayTenPhong(e.Value.ToString());
                }
                catch (Exception) { }
            }
            if (e.ColumnIndex == 2)
            {
                try { e.Value = BLL.LayTenNhanVien(e.Value.ToString()); } catch (Exception) { }
            }
            if (e.ColumnIndex == 3)
            {
                try { e.Value = BLL.LayTenKhachHang(e.Value.ToString()); } catch(Exception) { }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (cbb_DanhSach.SelectedIndex == 0 && Flag_Status)
            {
                // Code
                if (BLL.GetGoiDichVuByID(MaPhongDat) != null)
                {
                    BLL.Xoa_GoiDichVu(BLL.GetGoiDichVuByID(MaPhongDat));
                }
                BLL.Xoa_HoaDonBan(BLL.GetHoaDonBanByID(MaPhongDat));
                BLL.Xoa_PhongDat(BLL.GetPhongDatByID(MaPhongDat));

                // Đổi trạng thái cờ
                Flag_Status = false;

                // Làm mới
                dgv_DanhSach.DataSource = BLL.DanhSachPhongDat_ChuaHoatDong();
                dgv_DanhSach.Refresh();


                MessageBox.Show("Đã xoá phòng được đặt !!");
            }
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            // Làm mới txt
            txt_TenKhachHang.Text = ".............................";
            txt_SoDienThoai.Text = ".............................";
            txt_PhongDat.Text = ".............................";
            txt_ThoiGianDatPhong.Text = ".............................";

            // Chuyển về danh sách phòng đang hoạt động
            cbb_DanhSach.SelectedIndex = 1;

            // Đổi màu button
            bt_Delete.FillColor = DisableButtonColor;

            // Đổi trạng thái cờ
            Flag_Status = false;
        }

        private void cbb_DanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            Flag_Status = false;
            switch (cbb_DanhSach.SelectedIndex)
            {
                case 0:
                    LamMoi();
                    break;
                case 1:
                    LamMoi();
                    break;
            }
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // Đổi màu button
                bt_Delete.FillColor = EnableButtonColor;

                // Đổi trạng thái cờ
                Flag_Status = true;

                // Info current MaPhongDat
                MaPhongDat = dgv_DanhSach.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Set values 
                txt_TenKhachHang.Text = BLL.LayTenKhachHang(dgv_DanhSach.Rows[e.RowIndex].Cells[3].Value.ToString());
                txt_SoDienThoai.Text = BLL.LaySoDienThoai(dgv_DanhSach.Rows[e.RowIndex].Cells[3].Value.ToString());
                txt_ThoiGianDatPhong.Text = Convert.ToDateTime(dgv_DanhSach.Rows[e.RowIndex].Cells[4].Value).ToString("dd / MM / yyyy");
                txt_PhongDat.Text = BLL.LayTenPhong(dgv_DanhSach.Rows[e.RowIndex].Cells[1].Value.ToString()) + " - " + BLL.LayTenLoaiPhong(BLL.LayIDLoaiPhong(dgv_DanhSach.Rows[e.RowIndex].Cells[1].Value.ToString()));
            }
        }

        private void txt_SoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txt_SoDienThoai.Text == string.Empty)
            {
                txt_SoDienThoai.Text = "Không có số";
            }
        }

        private void bt_Order_Click(object sender, EventArgs e)
        {
            if (cbb_DanhSach.SelectedIndex == 1 && Flag_Status)
            {
                // Đổi trạng thái cờ
                Flag_Status = false;
            }
        }

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            if (cbb_DanhSach.SelectedIndex == 1 && Flag_Status)
            {
                // Đổi trạng thái cờ
                Flag_Status = false;
            }
        }

        private void bt_BatDau_Click(object sender, EventArgs e)
        {
            if (cbb_DanhSach.SelectedIndex == 0 && Flag_Status)
            {
                // Đổi trạng thái cờ
                Flag_Status = false;
            }
        }
    }
}
