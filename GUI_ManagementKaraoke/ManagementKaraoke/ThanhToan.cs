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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class ThanhToan : Form
    {
        // Khởi tạo thuộc tính
        QuanLyQuanHat Quanlys;

        TimeSpan _ThoiGian;

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
        }

        private void bt_ChotInvoice_Click(object sender, EventArgs e)
        {
            // Dừng thời gian
            ThoiGian.Stop();
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            txt_TimeCurrentPlay.Text = BLL.Format_ThoiGian(_ThoiGian) + "  Giờ !";
            _ThoiGian += new TimeSpan(0, 0, 1);
        }
    }
}
