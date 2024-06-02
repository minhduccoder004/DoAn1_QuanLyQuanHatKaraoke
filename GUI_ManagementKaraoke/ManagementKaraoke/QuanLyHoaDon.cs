using BLL.Implement_BLL;
using DTO;
using GUI_ManagementKaraoke.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Web.UI.WebControls;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class QuanLyHoaDon : Form
    {

        // Khởi tạo lớp BLL
        BLL_QuanLyHoaDon BLL = new BLL_QuanLyHoaDon ();

        // Khởi tạo thuộc tính
        string MaMatHang {  get; set; }
        string MaDichVu {  get; set; }

        public string MaHoaDonBan { get; set; }
        public event EventHandler<Event_LayDSHoaDon> Event_HoaDons;


        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        /*----------------Xuất hoá đơn ra word-----------------*/

        void XuatHoaDon_Word()
        {

            // Khởi tạo đối tượng Word kèm tạo 1 bản word tên HoaDon_Word
            Microsoft.Office.Interop.Word.Application Word = new Microsoft.Office.Interop.Word.Application();
            var HoaDon_Word = Word.Documents.Add();

            // Khởi tạo thuộc tính cho hoá đơn
            var AnhLogo = BLL.DuongDan_LogoHoaDon();
            var MaHoaDon = txt_MaHoaDon.Text;
            var TenKhachHang = txt_TenKhachHang.Text;
            var TenNhanVien = txt_NhanVien.Text;
            var SoDienThoai = BLL.Lay_HoaDon(MaHoaDon).tblKhachHang.SoDienThoai;
            var NgayTaoHoaDon = txt_ThoiGianTaoHoaDon.Text;
            var DanhSach_DichVuSuDung = BLL.DichVuUsed(txt_MaHoaDon.Text);
            var DanhSach_MatHangSuDung = BLL.MatHangUsed(txt_MaHoaDon.Text);

            // Code chỉnh sửa word
            /*-----Logo hoá đơn-----*/
            var Logo = HoaDon_Word.Content.Paragraphs.Add().Range;
            var Anh = HoaDon_Word.InlineShapes.AddPicture(AnhLogo, false, true, Logo);
            Anh.Width = 200;
            Anh.Height = 100;
            Logo.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            /*-----Tiêu đề-----*/
            var TieuDe_01 = HoaDon_Word.Content.Paragraphs.Add().Range;
            TieuDe_01.Text = "Karaoke Minh Đức kính chào quý khách";
            TieuDe_01.Font.Name = "Times New Roman";
            TieuDe_01.Font.Bold = 1;
            TieuDe_01.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            TieuDe_01.Font.Size = 16;
            var TieuDe_02 = HoaDon_Word.Content.Paragraphs.Add().Range;
            TieuDe_02.Text = "Địa chỉ: Nhân Hoà, Mỹ Hào, Hưng Yên - SĐT: 0862268163";
            TieuDe_02.Font.Name = "Times New Roman";
            TieuDe_02.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            TieuDe_02.Font.Size = 10;
            TieuDe_02.Font.Bold = 1;
            TieuDe_02.Font.Italic = 1;
            TieuDe_02.InsertParagraphAfter();

            var Separator = HoaDon_Word.Content.Paragraphs.Add().Range;
            Separator.Text = "---------------------------------------------------------";
            Separator.Font.Name = "Times New Roman";
            Separator.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            Separator.InsertParagraphAfter();

            /*-----Thông tin hoá đơn-----*/
            var Title_Info = HoaDon_Word.Content.Paragraphs.Add().Range;
            Title_Info.Text = "Phiếu thanh toán";
            Title_Info.Font.Name = "Times New Roman";
            Title_Info.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            Title_Info.Font.Bold = 1;
            Title_Info.Font.Size = 15;
            Title_Info.InsertParagraphAfter();

            var info_MaHoaDon = HoaDon_Word.Content.Paragraphs.Add().Range;
            info_MaHoaDon.Text = $"Mã hoá đơn : {MaHoaDon}.";
            info_MaHoaDon.Font.Name = "Times New Roman";
            info_MaHoaDon.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            info_MaHoaDon.Font.Bold = 1;
            info_MaHoaDon.Font.Size = 10;
            info_MaHoaDon.InsertParagraphAfter();

            var info_TenKhachHang = HoaDon_Word.Content.Paragraphs.Add().Range;
            info_TenKhachHang.Text = $"Tên khách hàng : {TenKhachHang}.";
            info_TenKhachHang.Font.Name = "Times New Roman";
            info_TenKhachHang.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            info_TenKhachHang.Font.Bold = 1;
            info_TenKhachHang.Font.Size = 10;
            info_TenKhachHang.InsertParagraphAfter();

            var info_SoDienThoai = HoaDon_Word.Content.Paragraphs.Add().Range;
            info_SoDienThoai.Text = $"Số điện thoại : {SoDienThoai}.";
            info_SoDienThoai.Font.Name = "Times New Roman";
            info_SoDienThoai.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            info_SoDienThoai.Font.Bold = 1;
            info_SoDienThoai.Font.Size = 10;
            info_SoDienThoai.InsertParagraphAfter();

            var info_NhanVien = HoaDon_Word.Content.Paragraphs.Add().Range;
            info_NhanVien.Text = $"Nhân viên : {TenNhanVien}.";
            info_NhanVien.Font.Name = "Times New Roman";
            info_NhanVien.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            info_NhanVien.Font.Bold = 1;
            info_NhanVien.Font.Size = 10;
            info_NhanVien.InsertParagraphAfter();

            var info_NgayTaoHoaDon = HoaDon_Word.Content.Paragraphs.Add().Range;
            info_NgayTaoHoaDon.Text = $"Ngày tạo hoá đơn : {NgayTaoHoaDon}.";
            info_NgayTaoHoaDon.Font.Name = "Times New Roman";
            info_NgayTaoHoaDon.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            info_NgayTaoHoaDon.Font.Bold = 1;
            info_NgayTaoHoaDon.Font.Size = 10;
            info_NgayTaoHoaDon.InsertParagraphAfter();

            /*-----Danh sách mặt hàng sử dụng-----*/
            var label_MatHangSuDung = HoaDon_Word.Content.Paragraphs.Add().Range;
            label_MatHangSuDung.Text = "Mặt hàng sử dụng";
            label_MatHangSuDung.Font.Name = "Times New Roman";
            label_MatHangSuDung.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            label_MatHangSuDung.Font.Bold = 1;
            label_MatHangSuDung.Font.Size = 10;
            label_MatHangSuDung.InsertParagraphAfter();

            var Bang_MatHangSuDung = HoaDon_Word.Tables.Add(HoaDon_Word.Content.Paragraphs.Add().Range, DanhSach_MatHangSuDung.Count + 1, 4);
            Bang_MatHangSuDung.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
            Bang_MatHangSuDung.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

            // Thêm tiêu đề cho cột
            Bang_MatHangSuDung.Cell(1, 1).Range.Text = "Mã phòng đặt";
            Bang_MatHangSuDung.Cell(1, 2).Range.Text = "Tên mặt hàng";
            Bang_MatHangSuDung.Cell(1, 3).Range.Text = "Số lượng";
            Bang_MatHangSuDung.Cell(1, 4).Range.Text = "Đơn giá";

            // Thêm dữ liệu cho bảng
            for (int i = 0; i < DanhSach_MatHangSuDung.Count; i++)
            {
                var MatHang = DanhSach_MatHangSuDung[i];
                Bang_MatHangSuDung.Cell(i + 2, 1).Range.Text = MatHang.MaPhongDat;
                Bang_MatHangSuDung.Cell(i + 2, 2).Range.Text = MatHang.tblMatHang.TenMatHang;
                Bang_MatHangSuDung.Cell(i + 2, 3).Range.Text = MatHang.SoLuong.ToString();
                Bang_MatHangSuDung.Cell(i + 2, 4).Range.Text = MatHang.tblMatHang.DonGiaMatHang.ToString("#,###") + " đ.";
            }

            // Thành tiền của mặt hàng sử dụng
            var ThanhTien_MatHang = HoaDon_Word.Content.Paragraphs.Add().Range;
            double Tien_MatHangs = BLL.TongTien_MatHang(MaHoaDon);
            ThanhTien_MatHang.Text = $"Tổng tiền: {Tien_MatHangs:#,###} đ.";
            ThanhTien_MatHang.Font.Name = "Times New Roman";
            ThanhTien_MatHang.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            ThanhTien_MatHang.Font.Size = 10;
            ThanhTien_MatHang.Font.Bold = 1;
            ThanhTien_MatHang.InsertParagraphAfter();

            /*-----Danh sách dịch vụ sử dụng-----*/
            var label_DichVuSuDung = HoaDon_Word.Content.Paragraphs.Add().Range;
            label_DichVuSuDung.Text = "Dịch vụ sử dụng";
            label_DichVuSuDung.Font.Name = "Times New Roman";
            label_DichVuSuDung.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            label_DichVuSuDung.Font.Bold = 1;
            label_DichVuSuDung.Font.Size = 10;
            label_DichVuSuDung.InsertParagraphAfter();

            var Bang_DichVuSuDung = HoaDon_Word.Tables.Add(HoaDon_Word.Content.Paragraphs.Add().Range, DanhSach_DichVuSuDung.Count + 1, 3);
            Bang_DichVuSuDung.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
            Bang_DichVuSuDung.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

            // Thêm tiêu đề cho cột
            Bang_DichVuSuDung.Cell(1, 1).Range.Text = "Mã phòng đặt";
            Bang_DichVuSuDung.Cell(1, 2).Range.Text = "Tên dịch vụ";
            Bang_DichVuSuDung.Cell(1, 3).Range.Text = "Giá tiền";

            // Thêm dữ liệu cho bảng
            for (int i = 0; i < DanhSach_DichVuSuDung.Count; i++)
            {
                var DichVu = DanhSach_DichVuSuDung[i];
                Bang_DichVuSuDung.Cell(i + 2, 1).Range.Text = DichVu.MaPhongDat;
                Bang_DichVuSuDung.Cell(i + 2, 2).Range.Text = DichVu.tblDichVu.TenDichVu;
                Bang_DichVuSuDung.Cell(i + 2, 3).Range.Text = DichVu.tblDichVu.GiaDichVu.Value.ToString("#,###") + " đ.";
            }

            // Thành tiền của dịch vụ sử dụng
            var ThanhTien_DichVu = HoaDon_Word.Content.Paragraphs.Add().Range;
            double Tien_DichVus = BLL.TongTien_DichVu(MaHoaDon);
            ThanhTien_DichVu.Text = $"Tổng tiền: {Tien_DichVus:#,###} đ.";
            ThanhTien_DichVu.Font.Name = "Times New Roman";
            ThanhTien_DichVu.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            ThanhTien_DichVu.Font.Size = 10;
            ThanhTien_DichVu.Font.Bold = 1;
            ThanhTien_DichVu.InsertParagraphAfter();

            /*-----Thông tin phòng sử dụng-----*/
            var ThoiGianDungPhong = BLL.Lay_HoaDon(MaHoaDon).tblPhongDat.ThoiGianPhongDung.Value - BLL.Lay_HoaDon(MaHoaDon).tblPhongDat.ThoiGianPhongHoatDong.Value;
            var ThongTin_Phong = HoaDon_Word.Content.Paragraphs.Add().Range;
            ThongTin_Phong.Text = $"Phòng sử dụng: {BLL.Lay_HoaDon(MaHoaDon).tblPhongDat.tblPhongHat.TenPhongHat}    Thời gian hoạt động: {ThoiGianDungPhong.Hours}:{ThoiGianDungPhong.Minutes}:{ThoiGianDungPhong.Seconds}";
            ThongTin_Phong.Font.Name = "Times New Roman";
            ThongTin_Phong.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            ThongTin_Phong.Font.Size = 10;
            ThongTin_Phong.Font.Bold = 1;
            ThongTin_Phong.InsertParagraphAfter();

            var TienPhong = HoaDon_Word.Content.Paragraphs.Add().Range;
            double Tien_Phongs = BLL.TongTien_Phong(MaHoaDon, ThoiGianDungPhong);
            TienPhong.Text = $"Tổng tiền: {Tien_Phongs:#,###} đ.";
            TienPhong.Font.Name = "Times New Roman";
            TienPhong.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            TienPhong.Font.Bold = 1;
            TienPhong.Font.Size = 10;
            TienPhong.InsertParagraphAfter();

            /*-----Thành tiền-----*/
            var ThanhTien = HoaDon_Word.Content.Paragraphs.Add().Range;
            double ThanhTiens = BLL.ThanhTien_HoaDon(Tien_MatHangs, Tien_DichVus, Tien_Phongs);
            ThanhTien.Text = $"Thành tiền: {ThanhTiens:#,###} đ.";
            ThanhTien.Font.Name = "Times New Roman";
            ThanhTien.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            ThanhTien.Font.Bold = 1;
            ThanhTien.Font.Size = 12;
            ThanhTien.InsertParagraphAfter();

            /*-----Lời cảm ơn-----*/
            var title_CamOn = HoaDon_Word.Content.Paragraphs.Add().Range;
            title_CamOn.Text = "Cảm ơn quý khách !!";
            title_CamOn.Font.Name = "Times New Roman";
            title_CamOn.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            title_CamOn.Font.Bold = 1;
            title_CamOn.Font.Size = 16;
            title_CamOn.InsertParagraphAfter();

            // Lưu file
            string TenFile = $"HoaDon_{MaHoaDon}";
            HoaDon_Word.SaveAs2($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{TenFile}");

            // Đóng Word
            HoaDon_Word.Close();
            Word.Quit();

            // Thông báo
            MessageBox.Show("Đã in hoá đơn !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /*-----------------------------------------------------*/


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

            // Lấy danh sách cho sự kiện tìm kiếm
            SuKien_LayDS((List<tblHoaDonBan>)dgv_HoaDonBan.DataSource);

            // dtp format
            dtp_BatDau.Value = DateTime.Today.AddDays(-1);
            dtp_KetThuc.Value = DateTime.Today;
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

        public void LamMoi()
        {
            // Đổ lại dữ liệu dgv
            dgv_HoaDonBan.DataSource = BLL.DanhSach_HoaDonBan();
            dgv_HoaDonBan.Refresh();
            dgv_MatHangUsed.DataSource = new List<tblGoiMatHang>();
            dgv_MatHangUsed.Refresh();
            dgv_DichVuUsed.DataSource = new List<tblGoiDichVu>();
            dgv_DichVuUsed.Refresh();

            // xoá dữ liệu txt
            txt_MaHoaDon.Text = "....................";
            txt_NhanVien.Text = "....................";
            txt_TenKhachHang.Text = "....................";
            txt_ThanhTien.Text = "....................";
            txt_ThoiGianTaoHoaDon.Text = "....................";
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            // Đổ lại dữ liệu dgv
            dgv_HoaDonBan.DataSource = BLL.DanhSach_HoaDonBan();
            dgv_HoaDonBan.Refresh();
            dgv_MatHangUsed.DataSource = new List<tblGoiMatHang>();
            dgv_MatHangUsed.Refresh();
            dgv_DichVuUsed.DataSource = new List<tblGoiDichVu>();
            dgv_DichVuUsed.Refresh();

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
            XuatHoaDon_Word();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            
            BLL.Xoa_HoaDon(BLL.Lay_HoaDon(txt_MaHoaDon.Text));

            MessageBox.Show("Đã xoá hoá đơn !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        void SuKien_LayDS(List<tblHoaDonBan> DanhSachHoaDonBan)
        {
            Event_LayDSHoaDon e = new Event_LayDSHoaDon();
            e.DanhSachHoaDonBan = DanhSachHoaDonBan;
            Event_HoaDons?.Invoke(this, e);
        }
        public void BatSuKien_LayDanhSach(object sender, Event_LayDSHoaDon e)
        {
            dgv_HoaDonBan.DataSource = e.DanhSachHoaDonBan;
            dgv_HoaDonBan.Refresh();
        }

        private void bt_DongY_MocThoiGian_Click(object sender, EventArgs e)
        {
            dgv_HoaDonBan.DataSource = BLL.TimKiem_HoaDons_TheoMocThoiGian(dtp_BatDau.Value, dtp_KetThuc.Value);
            dgv_HoaDonBan.Refresh();

            SuKien_LayDS((List<tblHoaDonBan>)dgv_HoaDonBan.DataSource);
        }
    }
}
