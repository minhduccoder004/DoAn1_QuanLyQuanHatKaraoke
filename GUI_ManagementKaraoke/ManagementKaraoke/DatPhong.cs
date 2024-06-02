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
    public partial class DatPhong : Form
    {
        // Khởi tạo lớp BLL
        BLL_DatPhong BLL = new BLL_DatPhong();

        // Khởi tạo thuộc tính
        QuanLyQuanHat QuanLys;

        public DatPhong(QuanLyQuanHat QuanLys)
        {
            InitializeComponent();
            this.QuanLys = QuanLys;
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu cho các combobox (nhân viên, loại phòng, phòng, loại dịch vụ, dịch vụ)
            cbb_NhanVienPhucVu.DataSource = BLL.NV_PhucVus();
            cbb_NhanVienPhucVu.DisplayMember = "TenNhanVien";
            cbb_NhanVienPhucVu.ValueMember = "MaNhanVien";
            cbb_NhanVienPhucVu.SelectedIndex = -1;

            cbb_LoaiPhong.DataSource = BLL.LoaiPhongs();
            cbb_LoaiPhong.DisplayMember = "TenLoaiPhong";
            cbb_LoaiPhong.ValueMember = "MaLoaiPhong";
            cbb_LoaiPhong.SelectedIndex = -1;

            cbb_LoaiDichVu.DataSource = BLL.LoaiDichVus();
            cbb_LoaiDichVu.DisplayMember = "TenLoaiDichVu";
            cbb_LoaiDichVu.ValueMember = "MaLoaiDichVu";
            cbb_LoaiDichVu.SelectedIndex = -1;


            dtp_NgayDatPhong.Value = DateTime.Today;
        }

        private void cbb_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_LoaiPhong.SelectedValue != null)
            {
                cbb_Phong.DataSource = BLL.LayPhongHatTheoLoai(cbb_LoaiPhong.SelectedValue.ToString().Trim());
                cbb_Phong.DisplayMember = "TenPhongHat";
                cbb_Phong.ValueMember = "MaPhongHat";
                cbb_Phong.SelectedIndex = -1;
            }
        }

        private void cbb_LoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_LoaiDichVu.SelectedValue != null)
            {
                cbb_DichVu.DataSource = BLL.LayDichVuTheoLoai(cbb_LoaiDichVu.SelectedValue.ToString().Trim());
                cbb_DichVu.DisplayMember = "TenDichVu";
                cbb_DichVu.ValueMember = "MaDichVu";
                cbb_DichVu.SelectedIndex = -1;
            }
        }

        private void cb_KhachHangVangLai_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_KhachHangVangLai.Checked)
            {
                txt_SoDienThoai.Enabled = false;
                txt_TenKhachHang.Enabled = false;
            }
            else
            {
                txt_SoDienThoai.Enabled = true;
                txt_TenKhachHang.Enabled = true;
            }
        }

        private void cb_SuDungDichVu_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_SuDungDichVu.Checked)
            {
                cbb_LoaiDichVu.Enabled = true;
                cbb_DichVu.Enabled = true;
            }
            else
            {
                cbb_LoaiDichVu.Enabled = false;
                cbb_DichVu.Enabled = false;
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_DatPhong_Click(object sender, EventArgs e)
        {

            // Kiểm tra phòng hợp lệ
            if (BLL.KiemTraPhongHopLe(cbb_Phong.SelectedValue.ToString().Trim(), dtp_NgayDatPhong.Value))
            {
                // Nếu phòng hợp lệ thì như sau

                tblPhongDat PD = new tblPhongDat();

                PD.MaPhongDat = BLL.TaoMaPhongDat();
                if (cb_KhachHangVangLai.Checked)
                {
                    PD.MaKhachHang = "KH000               ";
                }
                else
                {
                    var TonTai = BLL.TimKiemKhachHangTheoSoDienThoai(txt_SoDienThoai.Text);
                    if (TonTai != null)
                    {
                        PD.MaKhachHang = TonTai.MaKhachHang;
                    }
                    else
                    {
                        tblKhachHang KH = new tblKhachHang();
                        KH.MaKhachHang = BLL.TaoMaKhachHang();
                        PD.MaKhachHang = KH.MaKhachHang;
                        KH.TenKhachHang = txt_TenKhachHang.Text;
                        KH.SoDienThoai = txt_SoDienThoai.Text;
                        BLL.Them_KhachHang(KH);
                    }
                }
                PD.MaNhanVien = cbb_NhanVienPhucVu.SelectedValue.ToString();
                PD.MaPhong = cbb_Phong.SelectedValue.ToString();

                PD.ThoiGianPhongDat = BLL.ThoiGianDatPhong(dtp_NgayDatPhong.Value, Convert.ToInt32(nud_Gio.Value), Convert.ToInt32(nud_Phut.Value));
                PD.TrangThaiPhongDat = 0;

                BLL.Them_PhongDat(PD);
                QuanLys.LamMoi();

                tblHoaDonBan HDB = new tblHoaDonBan();
                HDB.MaHoaDonBan = BLL.TaoMaHoaDonBan();
                HDB.MaNhanVien = cbb_NhanVienPhucVu.SelectedValue.ToString().Trim();
                HDB.MaKhachHang = PD.MaKhachHang;
                HDB.MaPhongDat = PD.MaPhongDat;
                HDB.TrangThaiHoaDon = 0;

                BLL.TaoHoaDon(HDB);

                if (cb_SuDungDichVu.Checked)
                {
                    tblGoiDichVu GDV = new tblGoiDichVu();

                    GDV.MaPhongDat = PD.MaPhongDat;
                    GDV.MaDichVu = cbb_DichVu.SelectedValue.ToString().Trim();
                    GDV.MaHoaDonBan = HDB.MaHoaDonBan;

                    BLL.Them_GoiDichVu(GDV);
                }


                MessageBox.Show("Đặt phòng thành công !!");

                Close();


            }
            else
            {
                // Nếu phòng không hợp lệ thì như sau
                MessageBox.Show("Phòng muốn đặt đang bận, hãy chọn phòng khác !!!");
            }






            
        }

        private void err_SoDienThoai_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void txt_SoDienThoai_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
