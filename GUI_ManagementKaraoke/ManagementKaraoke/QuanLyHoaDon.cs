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

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class QuanLyHoaDon : Form
    {
        // Tạo cờ
        bool Flag_Status_BatDau = false;
        bool Flag_Status_KetThuc = false;

        // Khởi tạo lớp BLL
        BLL_QuanLyHoaDon BLL = new BLL_QuanLyHoaDon ();

        // Khởi tạo thuộc tính
        string MaMatHang {  get; set; }
        string MaDichVu {  get; set; }

        public string MaHoaDonBan { get; set; }


        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu vào dgv

            dgv_HoaDonBan.DataSource = BLL.DanhSach_HoaDonBan();
            dgv_MatHangUsed.DataSource = new List<tblGoiMatHang>();
            dgv_DichVuUsed.DataSource = new List<tblGoiDichVu>();

            // Format dgv
            // dgv_HoaDonBan
            dgv_HoaDonBan.Columns[0].HeaderText = "Mã hoá đơn";
            dgv_HoaDonBan.Columns[1].HeaderText = "Tên nhân viên";
            dgv_HoaDonBan.Columns[2].HeaderText = "Tên khách hàng";
            dgv_HoaDonBan.Columns[3].HeaderText = "Thời gian tạo hoá đơn";
            dgv_HoaDonBan.Columns[4].HeaderText = "Thành tiền";
            dgv_HoaDonBan.Columns[5].Visible = false;
            dgv_HoaDonBan.Columns[6].Visible = false;
            dgv_HoaDonBan.Columns[7].Visible = false;
            dgv_HoaDonBan.Columns[8].Visible = false;
            dgv_HoaDonBan.Columns[9].Visible = false;
            dgv_HoaDonBan.Columns[10].Visible = false;
            dgv_HoaDonBan.Columns[11].Visible = false;

            //dgv_DichVuUsed và dgv_MatHangUsed
            // Dgv dịch vụ sử dụng
            dgv_DichVuUsed.Columns[0].HeaderText = "Mã phòng đặt";
            dgv_DichVuUsed.Columns[1].Visible = false;
            dgv_DichVuUsed.Columns[2].HeaderText = "Tên dịch vụ";
            dgv_DichVuUsed.Columns[3].HeaderText = "Giá tiền";
            dgv_DichVuUsed.Columns[4].Visible = false;
            dgv_DichVuUsed.Columns[5].Visible = false;

            // Dgv mặt hàng sử dụng
            dgv_MatHangUsed.Columns[0].HeaderText = "Mã phòng đặt";
            dgv_MatHangUsed.Columns[1].Visible = false;
            dgv_MatHangUsed.Columns[2].HeaderText = "Tên mặt hàng";
            dgv_MatHangUsed.Columns[3].HeaderText = "Số lượng";
            dgv_MatHangUsed.Columns[4].Visible = false;
            dgv_MatHangUsed.Columns[5].HeaderText = "Đơn giá";
            dgv_MatHangUsed.Columns[6].Visible = false;
        }

        private void dgv_HoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txt_MaHoaDon.Text = dgv_HoaDonBan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_TenKhachHang.Text = BLL.LayTenKhachHang(dgv_HoaDonBan.Rows[e.RowIndex].Cells[2].Value.ToString());
                txt_NhanVien.Text = BLL.LayTenNhanVien(dgv_HoaDonBan.Rows[e.RowIndex].Cells[1].Value.ToString());
                txt_ThoiGianTaoHoaDon.Text = Convert.ToDateTime(dgv_HoaDonBan.Rows[e.RowIndex].Cells[3].Value).ToString();
                txt_ThanhTien.Text = BLL.Format_Tien(Convert.ToDouble(dgv_HoaDonBan.Rows[e.RowIndex].Cells[4].Value));

                dgv_DichVuUsed.DataSource = BLL.DichVuUsed(dgv_HoaDonBan.Rows[e.RowIndex].Cells[0].Value.ToString());
                dgv_MatHangUsed.DataSource = BLL.MatHangUsed(dgv_HoaDonBan.Rows[e.RowIndex].Cells[0].Value.ToString());

                MaHoaDonBan = dgv_HoaDonBan.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            // Đổ lại dữ liệu dgv
            dgv_HoaDonBan.DataSource = BLL.DanhSach_HoaDonBan();

            dgv_MatHangUsed.DataSource = new List<tblGoiMatHang>();
            dgv_DichVuUsed.DataSource = new List<tblGoiDichVu>();

            // xoá dữ liệu txt
            txt_MaHoaDon.Text = "....................";
            txt_NhanVien.Text = "....................";
            txt_TenKhachHang.Text = "....................";
            txt_ThanhTien.Text = "....................";
            txt_ThoiGianTaoHoaDon.Text = "....................";

            // 
        }

        private void bt_XuatHoaDon_Click(object sender, EventArgs e)
        {
            using (XuatHoaDon HD = new XuatHoaDon(this))
            {
                HD.ShowDialog();
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {

        }

        private void dgv_HoaDonBan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    e.Value = BLL.LayTenNhanVien(e.Value.ToString().Trim());
                    break;
                case 2:
                    e.Value = BLL.LayTenKhachHang(e.Value.ToString().Trim());
                    break;
                case 4:
                    e.Value = BLL.Format_Tien(Convert.ToDouble(e.Value));
                    break;
            }
        }

        private void dgv_MatHangUsed_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    if (e.Value != null)
                    {
                        MaMatHang = e.Value.ToString().Trim();
                        e.Value = BLL.LayTenMatHang(e.Value.ToString().Trim());
                    }
                    break;
                case 5:
                    if (e.Value != null)
                    {
                        e.Value = Convert.ToDouble(BLL.LayGiaTienMatHang(MaMatHang)).ToString("#,###") + "đ";
                    }
                    break;
            }
        }

        private void dgv_DichVuUsed_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    MaDichVu = e.Value.ToString().Trim();
                    e.Value = BLL.LayTenDichVu(e.Value.ToString().Trim());
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDouble(BLL.LayGiaTienDichVu(MaDichVu)).ToString("#,###") + "đ";
                }
            }
        }
    }
}
