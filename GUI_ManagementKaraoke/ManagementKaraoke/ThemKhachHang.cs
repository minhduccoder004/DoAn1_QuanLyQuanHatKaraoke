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
    public partial class ThemKhachHang : Form
    {

        // Khởi tạo lớp BLL
        BLL_QuanLyKhachHang BLL = new BLL_QuanLyKhachHang();

        // Khởi tạo lớp QuanLyKhachHang
        QuanLyKhachHang QuanLys { get; set; }

        public ThemKhachHang(QuanLyKhachHang Parent)
        {
            InitializeComponent();
            QuanLys = Parent;
        }

        private void bt_HuyBo_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("Bạn có chắc muốn huỷ bỏ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (Result)
            {
                case DialogResult.Yes:
                    Close();
                    break;
            }
        }

        private void bt_XacNhan_Click(object sender, EventArgs e)
        {

            // Code thêm khách hàng
            tblKhachHang KH = new tblKhachHang();

            KH.MaKhachHang = BLL.TaoMaKhachHang();
            KH.TenKhachHang = txt_TenKhachHang.Text;
            KH.SoDienThoai = txt_SoDienThoai.Text;

            BLL.Them(KH);
            QuanLys.LamMoi();

            MessageBox.Show("Thêm khách hàng thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}
