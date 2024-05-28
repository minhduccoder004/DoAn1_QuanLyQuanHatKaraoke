using BLL.Implement_BLL;
using DTO;
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
using GUI_ManagementKaraoke.Event;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class QuanLyKhachHang : Form
    {

        // Thuộc tính trong form
        bool Flag_Status = false;
        Color DisableButtonColor = Color.FromArgb(128, 179, 255);
        Color EnableButtonColor = Color.FromArgb(104, 126, 255);

        // Khởi tạo lớp BLL
        BLL_QuanLyKhachHang BLL = new BLL_QuanLyKhachHang();

        // Làm mới dữ liệu trong datagridview
        public void LamMoi()
        {
            dgv_DSKhachHang.DataSource = BLL.DanhSachDoiTuong();
            dgv_DSKhachHang.Refresh();
        }

        void DoDuLieu_DoThi(string ID_KhachHang)
        {
            var DuLieu = BLL.SoLan_SuDungDichVu(ID_KhachHang);

            // thiết lập dữ liệu các cột
            chart_TanSuat.Series.Clear();
            chart_TanSuat.Series.Add("Số lần");
            chart_TanSuat.Series["Số lần"].XValueType = ChartValueType.Int32;

            if (DuLieu.Count > 0)
            {
                foreach (var item in DuLieu)
                {
                    chart_TanSuat.Series["Số lần"].Points.AddXY(item.Key, item.Value);
                }
            }
            else
            {
                chart_TanSuat.Series["Số lần"].Points.AddXY(DateTime.Today.Month, 0);
            }



            chart_TanSuat.ChartAreas[0].AxisX.Title = "Tháng";
            chart_TanSuat.ChartAreas[0].AxisY.Title = "Số lần";


        }

        void Reset_Chart()
        {
            chart_TanSuat.Series.Clear();
        }



        // Disable txt

        // Enable txt
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            // Gán dữ liệu cho datagridview
            dgv_DSKhachHang.DataSource = BLL.DanhSachDoiTuong();

            // Format datagridview
            dgv_DSKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgv_DSKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgv_DSKhachHang.Columns[2].HeaderText = "Số điện thoại";
            dgv_DSKhachHang.Columns[3].Visible = false;
            dgv_DSKhachHang.Columns[4].Visible = false;
            dgv_DSKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            // Đổi màu button (disable)
            bt_Update.FillColor = DisableButtonColor;
            bt_Delete.FillColor = DisableButtonColor;

            // Reset chart
            Reset_Chart();
        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            ThemKhachHang Create_KH = new ThemKhachHang(this);
            Create_KH.ShowDialog();


        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            // Làm mới dữ liệu bảng
            dgv_DSKhachHang.ClearSelection();
            dgv_DSKhachHang.DataSource = BLL.DanhSachDoiTuong();
            dgv_DSKhachHang.Refresh();

            // Đổi trạng thái cờ
            Flag_Status = false;

            // Đổi màu button (disable)
            bt_Update.FillColor = DisableButtonColor;
            bt_Delete.FillColor = DisableButtonColor;
            bt_Create.FillColor = EnableButtonColor;

            // Làm mới txt
            txt_MaKH.Clear();
            txt_TenKhachHang.Clear();
            txt_SoDienThoai.Clear();

            // làm mới cbb_TimKiemTheo
            cbb_SapXepTheo.SelectedIndex = -1;

            // Reset chart
            Reset_Chart();

            //txt_DoiTrangThai_ReadOnly
            txt_MaKH.ReadOnly = false;
        }

        private void dgv_DSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đổi màu button (Enable)
            bt_Update.FillColor = EnableButtonColor;
            bt_Delete.FillColor = EnableButtonColor;
            // Đổi màu button (Disable)
            bt_Create.FillColor = DisableButtonColor;

            //txt_DoiTrangThai_ReadOnly
            txt_MaKH.ReadOnly = true;

            // Gán dữ liệu cho txt
            if (e.RowIndex != -1)
            {
                txt_MaKH.Text = dgv_DSKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                txt_TenKhachHang.Text = dgv_DSKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                txt_SoDienThoai.Text = dgv_DSKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();

                // Đổ dữ liệu đồ thị
                DoDuLieu_DoThi(dgv_DSKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            // Thay đổi trạng thái cờ
            Flag_Status = true;
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (Flag_Status)
            {
                var Result = MessageBox.Show("Bạn có muốn thay đổi thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (Result)
                {
                    case DialogResult.Yes:
                        // Đổi màu button (disable)
                        bt_Update.FillColor = DisableButtonColor;
                        bt_Delete.FillColor = DisableButtonColor;
                        // Đổi màu button (enable)
                        bt_Create.FillColor = EnableButtonColor;
                        // Thay đổi trạng thái cờ.
                        Flag_Status = false;

                        //txt_DoiTrangThai_ReadOnly
                        txt_MaKH.ReadOnly = true;

                        // code sửa dữ liệu đã chọn khỏi table
                        tblKhachHang KH = new tblKhachHang();
                        KH.MaKhachHang = txt_MaKH.Text;
                        KH.TenKhachHang = txt_TenKhachHang.Text;
                        KH.SoDienThoai = txt_SoDienThoai.Text;

                        BLL.Sua(KH);

                        // Làm mới bảng
                        LamMoi();
                        break;
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (Flag_Status)
            {
                var Result = MessageBox.Show("Bạn có muốn thay đổi thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (Result)
                {
                    case DialogResult.Yes:
                        // Đổi màu button (disable)
                        bt_Update.FillColor = DisableButtonColor;
                        bt_Delete.FillColor = DisableButtonColor;
                        // Đổi màu button (enable)
                        bt_Create.FillColor = EnableButtonColor;
                        // Thay đổi trạng thái cờ
                        Flag_Status = false;
                        // Code xoá dữ liệu đã chọn khỏi table

                        BLL.Xoa(BLL.GetByID(txt_MaKH.Text));

                        // Làm mới bảng
                        LamMoi();

                        //txt_DoiTrangThai_ReadOnly
                        txt_MaKH.ReadOnly = true;
                        break;
                }


            }
        }

        void SuKienLamMoi(object sender, EventArgs e) => LamMoi();

        // Bắt sự kiện
        public void BatSuKien_LayDanhSach(object sender, Event_LayDSKhachHang e)
        {
            dgv_DSKhachHang.DataSource = e.DanhSachKhachHang;
        }

        private void cbb_SapXepTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_SapXepTheo.Text.ToLower())
            {
                case "tên khách hàng":
                    dgv_DSKhachHang.DataSource = BLL.SapXepTheoTenKhachHang();
                    dgv_DSKhachHang.Refresh();
                    break;
                case "số điện thoại":
                    dgv_DSKhachHang.DataSource = BLL.SapXepTheoSoDienThoai();
                    dgv_DSKhachHang.Refresh();
                    break;
            }
        }
    }
}
