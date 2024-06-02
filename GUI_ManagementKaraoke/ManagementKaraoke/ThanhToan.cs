using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Implement_BLL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class ThanhToan : Form
    {
        // Khởi tạo thuộc tính
        QuanLyQuanHat Quanlys;
        TimeSpan _ThoiGian;
        string MaDichVu {  get; set; }
        string MaMatHang {  get; set; }

        // Khởi tạo lớp BLL
        BLL_ThanhToan BLL = new BLL_ThanhToan();

        public ThanhToan(QuanLyQuanHat form)
        {
            InitializeComponent();
            Quanlys = form;
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            // gắn dữ liệu cho thuộc tính
            _ThoiGian = Quanlys.Time;

            // Bắt đầu hoạt động time
            ThoiGian.Start();

            // Truyền thông tin vào các đối tượng trên form thanh toán
            txt_MaHoaDon.Text = Quanlys.MaHoaDonBan;
            txt_TenKhachHang.Text = BLL.LayTenKhachHang(BLL.LayMaKhachHang(Quanlys.MaHoaDonBan));
            txt_NgayTaoHoaDon.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm");
            txt_NhanVienPhucVu.Text = BLL.LayTenNhanVien(BLL.LayMaNhanVien(Quanlys.MaHoaDonBan));
            txt_ThoiGianPlay.Text = Quanlys.ThoiGianBatDau.ToString("dd/MM/yyyy - hh:mm");
            txt_TimeCurrentPlay.Text = BLL.Format_ThoiGian(_ThoiGian);

            dgv_DichVuUsed.DataSource = BLL.DichVu_KhachDaDung(Quanlys.MaHoaDonBan);
            dgv_MatHangUsed.DataSource = BLL.MatHang_KhachDaDung(Quanlys.MaHoaDonBan);

            // Format dgv
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

            // Tiền
            txt_TienPhong.Text = BLL.TienPhong_DaSuDung(Quanlys.MaHoaDonBan, _ThoiGian).ToString("#,###") + " đ";
            if (BLL.TienDichVu_DaSuDung(Quanlys.MaHoaDonBan) == 0)
            {
                txt_TongTienDichVu.Text = "0 đ";
            }
            else
            {
                txt_TongTienDichVu.Text = BLL.TienDichVu_DaSuDung(Quanlys.MaHoaDonBan).ToString("#,###") + " đ";
            }

            if (BLL.TienMatHang_DaSuDung(Quanlys.MaHoaDonBan) == 0)
            {
                txt_TongTienMatHang.Text = "0 đ";
            }
            else
            {
                txt_TongTienMatHang.Text = BLL.TienMatHang_DaSuDung(Quanlys.MaHoaDonBan).ToString("#,###") + " đ";
            }
            txt_ThanhTien.Text = BLL.ThanhTien_Tong(BLL.TienPhong_DaSuDung(Quanlys.MaHoaDonBan, _ThoiGian), BLL.TienDichVu_DaSuDung(Quanlys.MaHoaDonBan), BLL.TienMatHang_DaSuDung(Quanlys.MaHoaDonBan)).ToString("#,###") + " đ";
        }

        private void bt_ChotInvoice_Click(object sender, EventArgs e)
        {
            // Dừng thời gian
            ThoiGian.Stop();

            // Code chốt
            tblHoaDonBan HDB = new tblHoaDonBan();
            HDB.MaHoaDonBan = Quanlys.MaHoaDonBan;
            HDB.ThanhTien = BLL.ThanhTien_Tong(BLL.TienPhong_DaSuDung(Quanlys.MaHoaDonBan, _ThoiGian), BLL.TienDichVu_DaSuDung(Quanlys.MaHoaDonBan), BLL.TienMatHang_DaSuDung(Quanlys.MaHoaDonBan));
            HDB.ThoiGianTaoHoaDon = DateTime.Now;
            HDB.TrangThaiHoaDon = 1;

            BLL.CapNhat_HoaDonBan(HDB);

            // Code đổi trạng thái phòng đặt

            tblPhongDat PD = new tblPhongDat();
            PD.MaPhongDat = Quanlys.MaPhongDat;
            PD.ThoiGianPhongDung = DateTime.Now;
            PD.TrangThaiPhongDat = 2;

            BLL.CapNhat_PhongDat(PD);

            // Code đổi trạng thái phòng hát
            tblPhongHat PH = new tblPhongHat();
            PH.MaPhongHat = Quanlys.MaPhongHat;
            PH.TrangThaiPhong = 0;

            BLL.CapNhat_PhongHat(PH);

            // Làm mới danh sách
            Quanlys.LamMoi_KhiThanhToan();

            MessageBox.Show("Đã chốt thanh toán !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            txt_TimeCurrentPlay.Text = BLL.Format_ThoiGian(_ThoiGian) + "  Giờ !";
            _ThoiGian += new TimeSpan(0, 0, 1);
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
