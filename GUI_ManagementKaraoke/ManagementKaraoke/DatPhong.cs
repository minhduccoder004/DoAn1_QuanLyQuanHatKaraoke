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
    public partial class DatPhong : Form
    {
        // Khởi tạo lớp BLL
        BLL_DatPhong BLL = new BLL_DatPhong();

        public DatPhong()
        {
            InitializeComponent();
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
    }
}
