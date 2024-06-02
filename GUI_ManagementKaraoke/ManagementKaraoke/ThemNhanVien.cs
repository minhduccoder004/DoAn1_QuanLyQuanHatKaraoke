using BLL.Implement_BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using GUI_ManagementKaraoke.Picture;

namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    public partial class ThemNhanVien : Form
    {
        // Khởi tạo lớp xử lý ảnh
        XuLyAnh xuLyAnh = new XuLyAnh();

        // Khởi tạo thuộc tính
        (string, string) TenAnh_DuongDanTuyetDoi;
        QuanLyNhanVien QuanLys;


        // Khởi tạo lớp BLL
        BLL_QuanLyNhanVien BLL = new BLL_QuanLyNhanVien();

        public ThemNhanVien(QuanLyNhanVien form)
        {
            InitializeComponent();
            QuanLys = form;
        }

        private void bt_ThemAnh_Click(object sender, EventArgs e)
        {
            TenAnh_DuongDanTuyetDoi = xuLyAnh.ChonAnh(pic_AnhNhanVien);
        }

        private void bt_XacNhan_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Bạn có muốn thêm nhân viên ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                case DialogResult.OK:
                    {
                        tblNhanVien NV = new tblNhanVien();
                        NV.MaNhanVien = BLL.TaoMaNhanVien();
                        NV.TenNhanVien = txt_TenNhanVien.Text;
                        if (rbt_Nam.Checked)
                        {
                            NV.GioiTinh = "Nam";
                        }
                        if (rbt_Nu.Checked)
                        {
                            NV.GioiTinh = "Nữ";
                        }
                        NV.NgaySinh = dtp_NgaySinh.Value;
                        NV.DiaChi = txt_DiaChi.Text;
                        NV.Email = txt_Email.Text;
                        NV.SoDienThoai = txt_SoDienThoai.Text;
                        NV.FileAnh = TenAnh_DuongDanTuyetDoi.Item1;
                        NV.ChucVu = BLL.LayChucVu(cbb_ChucVu.Text);
                        NV.TrangThaiXoa = 0;

                        if (TenAnh_DuongDanTuyetDoi.Item1 != "")
                        {
                            xuLyAnh.SaoChepAnh_ThuMucPicture(TenAnh_DuongDanTuyetDoi.Item2, TenAnh_DuongDanTuyetDoi.Item1);

                        }

                        BLL.Them(NV);

                        QuanLys.LamMoi();

                        Close();
                        break;
                    }

                case DialogResult.Cancel:
                    {
                        break;
                    }
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Bạn có muốn huỷ bỏ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                case DialogResult.OK:
                    {
                        Close();
                        break;
                    }

                case DialogResult.Cancel:
                    {

                        break;
                    }
            }
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu cho combobox chức vụ
            cbb_ChucVu.DataSource = QuanLys.arr_ChucVu;
            cbb_ChucVu.SelectedIndex = -1;
        }
    }
}
