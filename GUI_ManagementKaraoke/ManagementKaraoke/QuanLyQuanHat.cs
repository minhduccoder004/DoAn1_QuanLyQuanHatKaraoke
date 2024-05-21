using BLL.Implement_BLL;
using DTO;
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

        // Khởi tạo thuộc tính
        string[] arr_DanhSach = { "Phòng lên lịch", "Phòng đang chạy" };
        public bool Flag_Status = false;
        Color DisableButtonColor = Color.FromArgb(128, 179, 255);
        Color EnableButtonColor = Color.FromArgb(104, 126, 255);
        public string MaPhongDat { get; set; }
        string MaPhongHat { get; set; }
        string MaDichVu {  get; set; }
        string MaMatHang { get; set; }
        public string MaHoaDonBan { get; set; }

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


            // Dgv dịch vụ sử dụng
            dgv_DichVuSuDung.Columns[0].HeaderText = "Mã phòng đặt";
            dgv_DichVuSuDung.Columns[1].Visible = false;
            dgv_DichVuSuDung.Columns[2].HeaderText = "Tên dịch vụ";
            dgv_DichVuSuDung.Columns[3].HeaderText = "Giá tiền";
            dgv_DichVuSuDung.Columns[4].Visible = false;
            dgv_DichVuSuDung.Columns[5].Visible = false;

            // Dgv mặt hàng sử dụng
            dgv_MatHangSuDung.Columns[0].HeaderText = "Mã phòng đặt";
            dgv_MatHangSuDung.Columns[1].Visible = false;
            dgv_MatHangSuDung.Columns[2].HeaderText = "Tên mặt hàng";
            dgv_MatHangSuDung.Columns[3].HeaderText = "Số lượng";
            dgv_MatHangSuDung.Columns[4].Visible = false;
            dgv_MatHangSuDung.Columns[5].HeaderText = "Đơn giá";
            dgv_MatHangSuDung.Columns[6].Visible = false;
        }

        public void LamMoi()
        {
            dgv_MatHangSuDung.DataSource = new List<tblGoiMatHang>();
            dgv_DichVuSuDung.DataSource = new List<tblGoiDichVu>();

            switch (cbb_DanhSach.SelectedIndex)
            {
                case 0:
                    dgv_DanhSach.DataSource = new BLL_QuanLyQuanHat().DanhSachPhongDat_ChuaHoatDong();
                    dgv_DanhSach.Refresh();
                    FormatHeaderTable();

                    // Đổi màu button
                    DoiMauButton_Dis();
                    break;
                case 1:
                    dgv_DanhSach.DataSource = new BLL_QuanLyQuanHat().DanhSachPhongDat_DangHoatDong();
                    dgv_DanhSach.Refresh();
                    FormatHeaderTable();

                    // Đổi màu button
                    DoiMauButton_Dis();
                    
                    break;
            }
        }

        public void LamMoi_MatHangDichVu()
        {
            dgv_DichVuSuDung.DataSource = new BLL_QuanLyQuanHat().DanhSachDichVu_KhachGoi(MaPhongDat);
            dgv_DichVuSuDung.Refresh();
            dgv_MatHangSuDung.DataSource = new BLL_QuanLyQuanHat().DanhSachMatHang_KhachGoi(MaPhongDat);
            dgv_MatHangSuDung.Refresh();
        }

        void DoiMauButton_Dis()
        {
            bt_BatDau.FillColor = DisableButtonColor;
            bt_Delete.FillColor = DisableButtonColor;
            bt_Order.FillColor = DisableButtonColor;
            bt_ThanhToan.FillColor = DisableButtonColor;
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
            bt_Order.FillColor = DisableButtonColor;
            bt_ThanhToan.FillColor = DisableButtonColor;
            bt_BatDau.FillColor = DisableButtonColor;

            // 
        }

        private void dgv_DanhSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString().Trim();
                }
            }
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null)
                {
                    e.Value = new BLL_QuanLyQuanHat().LayTenPhong(e.Value.ToString());
                }
            }
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    e.Value = new BLL_QuanLyQuanHat().LayTenNhanVien(e.Value.ToString());
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    e.Value = new BLL_QuanLyQuanHat().LayTenKhachHang(e.Value.ToString());
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (cbb_DanhSach.SelectedIndex == 0 && Flag_Status)
            {
                // Code
                if (new BLL_QuanLyQuanHat().GetGoiDichVuByID(MaPhongDat) != null)
                {
                    new BLL_QuanLyQuanHat().Xoa_GoiDichVu(new BLL_QuanLyQuanHat().GetGoiDichVuByID(MaPhongDat));
                }
                new BLL_QuanLyQuanHat().Xoa_HoaDonBan(new BLL_QuanLyQuanHat().GetHoaDonBanByID(MaPhongDat));
                new BLL_QuanLyQuanHat().Xoa_PhongDat(new BLL_QuanLyQuanHat().GetPhongDatByID(MaPhongDat));

                // Đổi trạng thái cờ
                Flag_Status = false;

                // Làm mới
                dgv_DanhSach.DataSource = new BLL_QuanLyQuanHat().DanhSachPhongDat_ChuaHoatDong();
                dgv_DanhSach.Refresh();

                // Đổi màu button
                bt_Delete.FillColor = DisableButtonColor;

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
            bt_BatDau.FillColor = DisableButtonColor;
            bt_Order.FillColor = DisableButtonColor;
            bt_ThanhToan.FillColor = DisableButtonColor;

            // Đổi trạng thái cờ
            Flag_Status = false;

            // Làm mới
            LamMoi();
        }

        private void cbb_DanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            Flag_Status = false;
            switch (cbb_DanhSach.SelectedIndex)
            {
                case 0:
                    LamMoi();
                    // Đổi màu button
                    DoiMauButton_Dis();
                    break;
                case 1:
                    LamMoi();
                    // Đổi màu button
                    DoiMauButton_Dis();
                    break;
            }
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                
                // Đổi trạng thái cờ
                Flag_Status = true;

                // Info current MaPhongDat
                MaPhongDat = dgv_DanhSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                MaPhongHat = dgv_DanhSach.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Set values 
                txt_TenKhachHang.Text = new BLL_QuanLyQuanHat().LayTenKhachHang(dgv_DanhSach.Rows[e.RowIndex].Cells[3].Value.ToString());
                txt_SoDienThoai.Text = new BLL_QuanLyQuanHat().LaySoDienThoai(dgv_DanhSach.Rows[e.RowIndex].Cells[3].Value.ToString());
                txt_ThoiGianDatPhong.Text = Convert.ToDateTime(dgv_DanhSach.Rows[e.RowIndex].Cells[4].Value).ToString("dd / MM / yyyy");
                txt_PhongDat.Text = new BLL_QuanLyQuanHat().LayTenPhong(dgv_DanhSach.Rows[e.RowIndex].Cells[1].Value.ToString()) + " - " + new BLL_QuanLyQuanHat().LayTenLoaiPhong(new BLL_QuanLyQuanHat().LayIDLoaiPhong(dgv_DanhSach.Rows[e.RowIndex].Cells[1].Value.ToString()));

                switch (cbb_DanhSach.SelectedIndex)
                {
                    case 0:
                        // Đổi màu button
                        bt_Delete.FillColor = EnableButtonColor;
                        bt_BatDau.FillColor = EnableButtonColor;
                        bt_Order.FillColor = DisableButtonColor;
                        bt_ThanhToan.FillColor = DisableButtonColor;
                        break;
                    case 1:
                        // Đổi màu button
                        bt_Delete.FillColor = DisableButtonColor;
                        bt_BatDau.FillColor = DisableButtonColor;
                        bt_Order.FillColor = EnableButtonColor;
                        bt_ThanhToan.FillColor = EnableButtonColor;
                        break;
                }

                dgv_DichVuSuDung.DataSource = new BLL_QuanLyQuanHat().DanhSachDichVu_KhachGoi(MaPhongDat);
                dgv_DichVuSuDung.Refresh();
                dgv_MatHangSuDung.DataSource = new BLL_QuanLyQuanHat().DanhSachMatHang_KhachGoi(MaPhongDat);
                dgv_MatHangSuDung.Refresh();

                // Lấy mã hoá đơn
                MaHoaDonBan = new BLL_QuanLyQuanHat().LayIDHoaDonBan(MaPhongDat);

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

                // Khởi tạo form Order
                Order O = new Order(this);
                O.ShowDialog();

                // 

            }
        }

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            if (cbb_DanhSach.SelectedIndex == 1 && Flag_Status)
            {
                // Đổi trạng thái cờ
                Flag_Status = false;

                // Khởi tạo form Thanh toán
                ThanhToan TT = new ThanhToan(this);
                TT.ShowDialog();
            }
        }

        private void bt_BatDau_Click(object sender, EventArgs e)
        {
            if (cbb_DanhSach.SelectedIndex == 0 && Flag_Status)
            {
                // Đổi trạng thái cờ
                Flag_Status = false;

                tblPhongDat PD = new tblPhongDat();
                PD.MaPhongDat = MaPhongDat;
                PD.TrangThaiPhongDat = 1;
                PD.ThoiGianPhongHoatDong = DateTime.Now;

                tblPhongHat PH = new tblPhongHat();
                PH.MaPhongHat = MaPhongHat;
                PH.TrangThaiPhong = 1;

                // Cập nhật dữ liệu   
                new BLL_QuanLyQuanHat().CapNhat_PhongHat(PH);
                new BLL_QuanLyQuanHat().CapNhat_PhongDat(PD);

                // Làm mới dữ liệu
                LamMoi();

            }
        }

        private void dgv_DichVuSuDung_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    MaDichVu = e.Value.ToString().Trim();
                    e.Value = new BLL_QuanLyQuanHat().LayTenDichVu(e.Value.ToString().Trim());
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDouble(new BLL_QuanLyQuanHat().LayGiaTienDichVu(MaDichVu)).ToString("#,###") + "đ";
                }
            }
        }

        private void dgv_MatHangSuDung_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    if (e.Value != null)
                    {
                        MaMatHang = e.Value.ToString().Trim();
                        e.Value = new BLL_QuanLyQuanHat().LayTenMatHang(e.Value.ToString().Trim()); 
                    }
                    break;
                case 5:
                    if (e.Value != null)
                    {
                        e.Value = Convert.ToDouble(new BLL_QuanLyQuanHat().LayGiaTienMatHang(MaMatHang)).ToString("#,###") + "đ";
                    }
                    break;
            }
            
        }
    }
}
