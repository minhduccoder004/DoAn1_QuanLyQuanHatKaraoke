using BLL.Implement_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class QuanLyDoanhThu : Form
    {

        // Khai báo lớp BLL
        BLL_QuanLyDoanhThu BLL = new BLL_QuanLyDoanhThu();


        // Khởi tạo thuộc tính
        string[] arr_LuaChon = {"Chọn thời gian", "Hôm nay", "7 ngày gần nhất", "30 ngày trước", "Tháng này" };
        public QuanLyDoanhThu()
        {
            InitializeComponent();
        }

        /*------------------------------------------------------------------------------------------------*/
        // Khởi tạo phương thức
        #region Phương_thức
        void Top5NhanVien()
        {
            switch (BLL.Top5NhanVien().Count())
            {
                case 1:
                    txt_Top1.Text = BLL.Top5NhanVien()[0].Key;
                    break;
                case 2:
                    txt_Top1.Text = BLL.Top5NhanVien()[0].Key;
                    txt_Top2.Text = BLL.Top5NhanVien()[1].Key;
                    break;
                case 3:
                    txt_Top1.Text = BLL.Top5NhanVien()[0].Key;
                    txt_Top2.Text = BLL.Top5NhanVien()[1].Key;
                    txt_Top3.Text = BLL.Top5NhanVien()[2].Key;
                    break;
                case 4:
                    txt_Top1.Text = BLL.Top5NhanVien()[0].Key;
                    txt_Top2.Text = BLL.Top5NhanVien()[1].Key;
                    txt_Top3.Text = BLL.Top5NhanVien()[2].Key;
                    txt_Top4.Text = BLL.Top5NhanVien()[3].Key;
                    break;
                case 5:
                    txt_Top1.Text = BLL.Top5NhanVien()[0].Key;
                    txt_Top2.Text = BLL.Top5NhanVien()[1].Key;
                    txt_Top3.Text = BLL.Top5NhanVien()[2].Key;
                    txt_Top4.Text = BLL.Top5NhanVien()[3].Key;
                    txt_Top5.Text = BLL.Top5NhanVien()[4].Key;
                    break;
            }
        }

        void Top5PhongHat()
        {
            switch(BLL.Top5PhongHat().Count)
            {
                case 1:
                    txt_Top1Phong.Text = BLL.Top5PhongHat()[0].Key;
                    break;
                case 2:
                    txt_Top1Phong.Text = BLL.Top5PhongHat()[0].Key;
                    txt_Top2Phong.Text = BLL.Top5PhongHat()[1].Key;
                    break;
                case 3:
                    txt_Top1Phong.Text = BLL.Top5PhongHat()[0].Key;
                    txt_Top2Phong.Text = BLL.Top5PhongHat()[1].Key;
                    txt_Top3Phong.Text = BLL.Top5PhongHat()[2].Key;
                    break;
                case 4:
                    txt_Top1Phong.Text = BLL.Top5PhongHat()[0].Key;
                    txt_Top2Phong.Text = BLL.Top5PhongHat()[1].Key;
                    txt_Top3Phong.Text = BLL.Top5PhongHat()[2].Key;
                    txt_Top4Phong.Text = BLL.Top5PhongHat()[3].Key;
                    break;
                case 5:
                    txt_Top1Phong.Text = BLL.Top5PhongHat()[0].Key;
                    txt_Top2Phong.Text = BLL.Top5PhongHat()[1].Key;
                    txt_Top3Phong.Text = BLL.Top5PhongHat()[2].Key;
                    txt_Top4Phong.Text = BLL.Top5PhongHat()[3].Key;
                    txt_Top5Phong.Text = BLL.Top5PhongHat()[4].Key;
                    break;
            }
        }

        void DoDuLieu_DoThi()
        {
            var DuLieu = BLL.BangDoanhThu_TheoNgay(BLL.LayHoaDonBan_TheoThoiGian(BLL.KieuXem(cbb_KieuXem.Text), dtp_Tu.Value, dtp_Den.Value));

            // thiết lập dữ liệu các cột
            chr_DoThi.Series.Clear();
            chr_DoThi.Series.Add("Doanh Thu");
            chr_DoThi.Series["Doanh Thu"].XValueType = ChartValueType.Date;

            if (DuLieu.Count > 0)
            {
                foreach (var item in DuLieu)
                {
                    chr_DoThi.Series["Doanh Thu"].Points.AddXY(item.Key, item.Value);
                }
            }
            else
            {
                chr_DoThi.Series["Doanh Thu"].Points.AddXY(DateTime.Today, 0);
            }

            

            chr_DoThi.ChartAreas[0].AxisX.Title = "Thời gian";
            chr_DoThi.ChartAreas[0].AxisY.Title = "Thu nhập";

            
        }

        void Tong_HoaDon_ThuNhap()
        {
            int TongHoaDon = BLL.Tong_HoaDon_DoanhThu(BLL.KieuXem(cbb_KieuXem.Text), dtp_Tu.Value, dtp_Den.Value, BLL.LayHoaDonBan_TheoThoiGian(BLL.KieuXem(cbb_KieuXem.Text), dtp_Tu.Value, dtp_Den.Value)).Key;
            double TongThuNhap = BLL.Tong_HoaDon_DoanhThu(BLL.KieuXem(cbb_KieuXem.Text), dtp_Tu.Value, dtp_Den.Value, BLL.LayHoaDonBan_TheoThoiGian(BLL.KieuXem(cbb_KieuXem.Text), dtp_Tu.Value, dtp_Den.Value)).Value;
            txt_TongHoaDon.Text = $"+ Thêm: {TongHoaDon} hoá đơn." ;
            if (TongThuNhap != 0)
            {
                txt_TongThuNhap.Text = $"+ Thêm: " + TongThuNhap.ToString("#,###") + " đ.";
            }
            else
            {
                txt_TongThuNhap.Text = $"+ Thêm: 0 đ.";
            }
        }

        void SoLuongTruyCap()
        {
            txt_TongKhachHang.Text = BLL.TongKhachHang(BLL.LayHoaDonBan_TheoThoiGian(BLL.KieuXem(cbb_KieuXem.Text), dtp_Tu.Value, dtp_Den.Value)).ToString() + " khách hàng.";
            txt_TongKhachVangLai.Text = BLL.TongKhachVangLai(BLL.LayHoaDonBan_TheoThoiGian(BLL.KieuXem(cbb_KieuXem.Text), dtp_Tu.Value, dtp_Den.Value)).ToString() + " khách hàng.";
            txt_TongKhachRaVaoQuan.Text = BLL.TongKhachRaVaoQuan(BLL.LayHoaDonBan_TheoThoiGian(BLL.KieuXem(cbb_KieuXem.Text), dtp_Tu.Value, dtp_Den.Value)).ToString() + " khách hàng.";
        }

        void DanhSachMatHang_TheMostUsed()
        {
            dgv_ItemsUsed.DataSource = BLL.MatHang_SuDungNhieu(BLL.LayHoaDonBan_TheoThoiGian(BLL.KieuXem(cbb_KieuXem.Text), dtp_Tu.Value, dtp_Den.Value));
            dgv_ItemsUsed.Columns[0].HeaderText = "Tên mặt hàng";
            dgv_ItemsUsed.Columns[1].HeaderText = "Số lượng";
        }

        #endregion
        /*------------------------------------------------------------------------------------------------*/

        private void QuanLyDoanhThu_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu combobox
            cbb_KieuXem.DataSource = arr_LuaChon;
            cbb_KieuXem.SelectedIndex = 1;

            // format dữ liệu dtp
            dtp_Tu.Value = DateTime.Today;
            dtp_Den.Value = DateTime.Today;

            // Dữ liệu đồ thị
            DoDuLieu_DoThi();

            // Dữ liệu top 5 nhân viên
            Top5NhanVien();

            // Dữ liệu top 5 phòng hát
            Top5PhongHat();

            // Tổng hoá đơn và doanh thu
            Tong_HoaDon_ThuNhap();

            // Số lượng truy cập
            SoLuongTruyCap();

            // Mặt hàng sử dụng nhiều
            DanhSachMatHang_TheMostUsed();
        }

        private void cbb_KieuXem_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoDuLieu_DoThi();
            Tong_HoaDon_ThuNhap();
            SoLuongTruyCap();
            if (cbb_KieuXem.Text == "Chọn thời gian")
            {
                dtp_Tu.Enabled = true;
                dtp_Den.Enabled = true;
                bt_Done.Enabled = true;
            }
            else
            {
                dtp_Tu.Enabled = false;
                dtp_Den.Enabled = false;
                bt_Done.Enabled = false;
            }
            DanhSachMatHang_TheMostUsed();
        }

        private void bt_Done_Click(object sender, EventArgs e)
        {
            DoDuLieu_DoThi();
            Tong_HoaDon_ThuNhap();
            SoLuongTruyCap();
            DanhSachMatHang_TheMostUsed();
        }
    }
}
