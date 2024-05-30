using BLL.Implement_BLL;
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
    public partial class XuatHoaDon : Form
    {
        // Khởi tạo lớp BLL
        BLL_XuatHoaDon BLL = new BLL_XuatHoaDon();
        QuanLyHoaDon QuanLys;
        string MaMatHang {  get; set; }
        string MaDichVu {  get; set; }
        public XuatHoaDon(QuanLyHoaDon form)
        {
            InitializeComponent();
            QuanLys = form;
        }

        private void XuatHoaDon_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu vào txt
            txt_MaHoaDon.Text = QuanLys.MaHoaDonBan;
            txt_TenKhachHang.Text = BLL.LayTenKhachHang(BLL.GetByID_HoaDon(QuanLys.MaHoaDonBan).MaKhachHang);
            txt_SoDienThoai.Text = BLL.GetByID_HoaDon(QuanLys.MaHoaDonBan).tblKhachHang.SoDienThoai;
            txt_NhanVienPhucVu.Text = BLL.LayTenNhanVien(BLL.GetByID_HoaDon(QuanLys.MaHoaDonBan).MaNhanVien);
            txt_PhongUsed.Text = BLL.LayTenPhongHat(BLL.GetByID_HoaDon(QuanLys.MaHoaDonBan).tblPhongDat.MaPhong);
            txt_NgayTaoHoaDon.Text = BLL.GetByID_HoaDon(QuanLys.MaHoaDonBan).ThoiGianTaoHoaDon.Value.ToString();

            // Đổ dữ liệu vào dgv

            dgv_DichVuSuDung.DataSource = BLL.DichVu_SuDung(QuanLys.MaHoaDonBan);
            dgv_DichVuSuDung.Refresh();
            dgv_MatHangSuDung.DataSource = BLL.MatHang_SuDung(QuanLys.MaHoaDonBan);
            dgv_MatHangSuDung.Refresh();

            //dgv_DichVuUsed và dgv_MatHangUsed
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

            // Thành tiền
            var Tien_DichVu = BLL.TinhTongTien_DichVu(BLL.DichVu_SuDung(QuanLys.MaHoaDonBan));
            if (Tien_DichVu != 0)
            {
                txt_TongTienDichVu.Text = Tien_DichVu.ToString("#,###") + " đ.";
            }
            else
            {
                txt_TongTienDichVu.Text = "0 đ.";
            }
            var TienItems = BLL.TinhTongTien_MatHang(BLL.MatHang_SuDung(QuanLys.MaHoaDonBan));
            if (TienItems != 0)
            {
                txt_TongTienItems.Text = TienItems.ToString("#,###") + " đ.";
            }
            else
            {
                txt_TongTienItems.Text = "0 đ.";
            }
            txt_TimeUsed.Text = BLL.Format_ThoiGian(BLL.ThoiGianSuDung(QuanLys.MaHoaDonBan));
            var TienPhong = BLL.TinhTongTien_Phong(QuanLys.MaHoaDonBan);
            txt_TongTienPhong.Text = TienPhong.ToString("#,###") + " đ.";
            txt_ThanhTien.Text = BLL.TinhTongTien_ThanhToan(Tien_DichVu, TienItems, TienPhong).ToString("#,###") + " đ.";

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
    }
}
