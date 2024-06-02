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
    public partial class ThemPhong : Form
    {
        // Khởi tạo thuộc tính
        QuanLyPhongHat QuanLys;
        string[] arr_TrangThai = { "Không hoạt động", "Đang hoạt động" };

        // Khởi tạo lớp BLL
        BLL_QuanLyPhongHat BLL = new BLL_QuanLyPhongHat();
        public ThemPhong(QuanLyPhongHat Parents)
        {
            InitializeComponent();
            QuanLys = Parents;
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            var LuaChon = MessageBox.Show("Bạn có muốn huỷ bỏ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (LuaChon == DialogResult.OK)
            {
                Close();
            }
        }

        private void bt_XacNhan_Click(object sender, EventArgs e)
        {
            tblPhongHat PH = new tblPhongHat()
            {
                MaPhongHat = BLL.TaoMaPhong(),
                TenPhongHat = txt_TenPhong.Text,
                TrangThaiPhong = BLL.TrangThaiPhong(cbb_TrangThaiPhong.Text),
                MaLoaiPhong = cbb_LoaiPhong.SelectedValue.ToString(),
                TrangThaiXoa = 0
            };

            BLL.Them(PH);

            QuanLys.LamMoi();

            MessageBox.Show("Thêm phòng thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
        private void ThemPhong_Load(object sender, EventArgs e)
        {
            cbb_TrangThaiPhong.DataSource = arr_TrangThai;


            cbb_LoaiPhong.DataSource = BLL.BangLoaiPhong();
            cbb_LoaiPhong.DisplayMember = "TenLoaiPhong";
            cbb_LoaiPhong.ValueMember = "MaLoaiPhong";
        }
    }
}
