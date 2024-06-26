﻿using BLL.Implement_BLL;
using DTO;
using GUI_ManagementKaraoke.Event;
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
        BLL_QuanLyQuanHat BLL = new BLL_QuanLyQuanHat();

        // Khởi tạo thuộc tính
        string[] arr_DanhSach = { "Phòng lên lịch", "Phòng đang chạy" };
        public bool Flag_Status = false;
        bool Flag_Time = false;
        public TimeSpan Time {  get; set; }
        Color DisableButtonColor = Color.FromArgb(128, 179, 255);
        Color EnableButtonColor = Color.FromArgb(104, 126, 255);
        public string MaPhongDat { get; set; }
        public string MaPhongHat { get; set; }
        string MaDichVu {  get; set; }
        string MaMatHang { get; set; }
        public string MaHoaDonBan { get; set; }
        public DateTime ThoiGianBatDau { get; set; }

        public event EventHandler<Event_LayDSPhongDat> Event_PhongDats;



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

            txt_PhongDat.Text = ".............................";
            txt_SoDienThoai.Text = ".............................";
            txt_TenKhachHang.Text = ".............................";
            txt_ThoiGianDatPhong.Text = ".............................";
            txt_ThoiGianHoatDong.Text = ".............................";

            Flag_Time = false;
            ThoiGian.Stop();

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

        public void LamMoi_KhiThanhToan()
        {
            if (cbb_DanhSach.SelectedIndex == 1)
            {
                dgv_DanhSach.DataSource = new BLL_QuanLyQuanHat().DanhSachPhongDat_DangHoatDong();
                dgv_DanhSach.Refresh();
            }
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

            // trạng thái dtp
            dtp_NgayDatPhong.Enabled = false;
            dtp_NgayDatPhong.Value = DateTime.Today;

            // Khởi chạy sự kiện tìm kiếm
            SuKien_LayDS((List<tblPhongDat>)dgv_DanhSach.DataSource);
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
                    e.Value = BLL.LayTenPhong(e.Value.ToString());
                }
            }
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    e.Value = BLL.LayTenNhanVien(e.Value.ToString());
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    e.Value = BLL.LayTenKhachHang(e.Value.ToString());
                }
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
            // Đổi trạng thái cờ
            Flag_Status = false;
            Flag_Time = false;
            ThoiGian.Stop();

            switch (cbb_DanhSach.SelectedIndex)
            {
                case 0:
                    LamMoi();
                    // Đổi màu button
                    DoiMauButton_Dis();
                    dtp_NgayDatPhong.Enabled = true;
                    SuKien_LayDS((List<tblPhongDat>)dgv_DanhSach.DataSource);
                    break;
                case 1:
                    LamMoi();
                    // Đổi màu button
                    DoiMauButton_Dis();
                    dtp_NgayDatPhong.Enabled = false;
                    SuKien_LayDS((List<tblPhongDat>)dgv_DanhSach.DataSource);
                    break;
            }
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                
                // Đổi trạng thái cờ
                Flag_Status = true;
                Flag_Time = true;

                switch (cbb_DanhSach.SelectedIndex)
                {
                    case 1:
                        // Chạy time
                        ThoiGian.Start();
                        break;
                }

                // Info current MaPhongDat
                MaPhongDat = dgv_DanhSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                MaPhongHat = dgv_DanhSach.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Set values 
                txt_TenKhachHang.Text = BLL.LayTenKhachHang(dgv_DanhSach.Rows[e.RowIndex].Cells[3].Value.ToString());
                txt_SoDienThoai.Text = BLL.LaySoDienThoai(dgv_DanhSach.Rows[e.RowIndex].Cells[3].Value.ToString());
                txt_ThoiGianDatPhong.Text = Convert.ToDateTime(dgv_DanhSach.Rows[e.RowIndex].Cells[4].Value).ToString("dd / MM / yyyy");
                txt_PhongDat.Text = BLL.LayTenPhong(dgv_DanhSach.Rows[e.RowIndex].Cells[1].Value.ToString()) + " - " + BLL.LayTenLoaiPhong(BLL.LayIDLoaiPhong(dgv_DanhSach.Rows[e.RowIndex].Cells[1].Value.ToString()));
                Time = BLL.TinhThoiGian(DateTime.Now, Convert.ToDateTime(dgv_DanhSach.Rows[e.RowIndex].Cells[5].Value));
                ThoiGianBatDau = Convert.ToDateTime(dgv_DanhSach.Rows[e.RowIndex].Cells[5].Value);

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
                MaHoaDonBan = BLL.LayIDHoaDonBan(MaPhongDat);

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
                using (ThanhToan TT = new ThanhToan(this))
                {
                    TT.ShowDialog();
                }
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
                BLL.CapNhat_PhongHat(PH);
                BLL.CapNhat_PhongDat(PD);

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

        private void dgv_MatHangSuDung_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            if (Flag_Time)
            {
                txt_ThoiGianHoatDong.Text = BLL.Format_ThoiGian(Time) + "  Giờ !";
                Time += new TimeSpan(0, 0, 1);
            }
        }

        void SuKien_LayDS(List<tblPhongDat> DanhSachPhongDat)
        {
            Event_LayDSPhongDat e = new Event_LayDSPhongDat();
            e.DanhSachPhongDat = DanhSachPhongDat;
            Event_PhongDats?.Invoke(this, e);
        }
        public void BatSuKien_LayDanhSach(object sender, Event_LayDSPhongDat e)
        {
            dgv_DanhSach.DataSource = e.DanhSachPhongDat;
            dgv_DanhSach.Refresh();
        }

        private void bt_NgayDatPhong_Click(object sender, EventArgs e)
        {
            dgv_DanhSach.DataSource = BLL.TimKiemTheoNgay_DanhSachPhongDat_ChuaHoatDong(dtp_NgayDatPhong.Value);
            dgv_DanhSach.Refresh();

            SuKien_LayDS((List<tblPhongDat>)dgv_DanhSach.DataSource);
        }
    }
}
