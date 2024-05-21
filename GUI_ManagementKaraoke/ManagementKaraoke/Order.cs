using BLL.Implement_BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class Order : Form
    {
        // Khởi tạo thuộc tính
        QuanLyQuanHat Quanlys { get; set; }
        bool Click_Order = false;
        string MatHang { get; set; }

        public Order(QuanLyQuanHat form)
        {
            InitializeComponent();
            Quanlys = form;
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Click_Order)
            {
                Quanlys.Flag_Status = true;
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu cho các combobox
            cbb_DichVu.DataSource = new BLL_Order().DanhSachDichVu();
            cbb_DichVu.DisplayMember = "TenDichVu";
            cbb_DichVu.ValueMember = "MaDichVu";

            cbb_DichVu.SelectedIndex = -1;

            // Đổ dữ liệu vào dgv
            dgv_DanhSachMatHang.DataSource = new BLL_Order().DanhSachMatHang();

            // Format dgv
            dgv_DanhSachMatHang.Columns[0].HeaderText = "Mã mặt hàng";
            dgv_DanhSachMatHang.Columns[1].HeaderText = "Tên mặt hàng";
            dgv_DanhSachMatHang.Columns[2].HeaderText = "Đơn vị tính";
            dgv_DanhSachMatHang.Columns[3].Visible = false;
            dgv_DanhSachMatHang.Columns[4].HeaderText = "Loại mặt hàng";
            dgv_DanhSachMatHang.Columns[5].Visible = false;
            dgv_DanhSachMatHang.Columns[6].Visible = false;


        }

        private void bt_DatHang_Click(object sender, EventArgs e)
        {
            // Đổi trạng thái cờ
            Click_Order = true;

            // Code đặt hàng (đặt mặt hàng, đặt dịch vụ)

            tblGoiMatHang GMH = new tblGoiMatHang
            {
                MaPhongDat = Quanlys.MaPhongDat,
                MaHoaDonBan = Quanlys.MaHoaDonBan,
                MaMatHang = MatHang,
                SoLuong = Convert.ToInt32(nud_SoLuong.Value)
            };

            var KiemTra_TonTai = new BLL_Order().TimMathang_GoiTrung(GMH.MaPhongDat, GMH.MaMatHang);
            if (KiemTra_TonTai != null)
            {

                new BLL_Order().CapNhat_GoiMatHang(GMH);
            }
            else
            {
                new BLL_Order().Them_GoiMatHang(GMH);
            }

            if (ck_GoiDichVu.Checked)
            {
                tblGoiDichVu GDV = new tblGoiDichVu
                {
                    MaPhongDat = Quanlys.MaPhongDat,
                    MaHoaDonBan = Quanlys.MaHoaDonBan,
                    MaDichVu = cbb_DichVu.SelectedValue.ToString().Trim()
                };

                new BLL_Order().Them_GoiDichVu(GDV);
            }

            // Thông báo thêm thành công
            MessageBox.Show("Order thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Làm mới dữ liệu
            Quanlys.LamMoi_MatHangDichVu();

        }

        private void bt_HuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbb_DichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_DichVu.SelectedValue != null)
            {
                var TonTai = new BLL_Order().TimDichVu_GoiTrung(Quanlys.MaPhongDat, cbb_DichVu.SelectedValue.ToString().Trim());
                if (TonTai != null)
                {
                    MessageBox.Show("Dịch vụ này đã được gọi, chọn dịch vụ khác !!");
                    cbb_DichVu.SelectedIndex = -1;
                }
            }
            
        }

        private void ck_GoiDichVu_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_GoiDichVu.Checked == true)
            {
                cbb_DichVu.Enabled = true;
            }
            else
            {
                cbb_DichVu.Enabled = false;
            }
        }

        private void dgv_DanhSachMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MatHang = dgv_DanhSachMatHang.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                txt_LoaiHang.Text = new BLL_Order().LayTenLoaiHang(dgv_DanhSachMatHang.Rows[e.RowIndex].Cells[4].Value.ToString().Trim());
                txt_MatHang.Text = dgv_DanhSachMatHang.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            }
        }

        private void dgv_DanhSachMatHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                e.Value = new BLL_Order().LayTenLoaiHang(e.Value.ToString().Trim());
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            dgv_DanhSachMatHang.DataSource = new BLL_Order().TimKiem_MatHang(txt_TimKiem.Text);
            dgv_DanhSachMatHang.Refresh();
        }

        private void bt_Reload_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = string.Empty;
            dgv_DanhSachMatHang.DataSource = new BLL_Order().DanhSachMatHang();
            dgv_DanhSachMatHang.Refresh();
        }
    }
}
