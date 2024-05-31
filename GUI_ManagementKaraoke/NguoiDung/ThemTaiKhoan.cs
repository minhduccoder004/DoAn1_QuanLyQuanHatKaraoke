using BLL.Implement_BLL;
using DTO;
using GUI_ManagementKaraoke.ManagementKaraoke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ManagementKaraoke.NguoiDung
{
    public partial class ThemTaiKhoan : Form
    {

        /*------------------Khai báo lớp BLL------------------*/
        BLL_NguoiDung BLL = new BLL_NguoiDung();
        /*----------------------------------------------------*/

        /*------------------Khởi tạo thuộc tính---------------*/
        QuanLyTaiKhoan QuanLys;
        /*----------------------------------------------------*/

        /*------------------Khởi tạo phương thức--------------*/
        /*----------------------------------------------------*/
        public ThemTaiKhoan(QuanLyTaiKhoan form)
        {
            InitializeComponent();
            QuanLys = form;
        }

        private void bt_HuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_ThemTaiKhoan_Click(object sender, EventArgs e)
        {
            tblNguoiDung ND = new tblNguoiDung();
            ND.TenTaiKhoan = txt_TenTaiKhoan.Text;
            ND.MatKhau = txt_MatKhau.Text;
            ND.QuyenHan = BLL.QuyenHanNguoiDung(cbb_QuyenHan.Text.Trim());

            BLL.Them(ND);

            QuanLys.DoDuLieu_DanhSachTaiKhoan();
            MessageBox.Show("Đã thêm người dùng !!");
            
            Close();
        }

        private void err_TenTaiKhoan_MouseHover(object sender, EventArgs e)
        {
            

            if (BLL.GetByID(txt_TenTaiKhoan.Text.Trim()) != null)
            {
                tt_HienThiLoi.SetToolTip(err_TenTaiKhoan, "<b style=\"color:red;\">Đã có tên tài khoản này, chọn tên tài khoản khác<b>");
            }
            else
            {

            }
        }

        private void txt_TenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (BLL.GetByID(txt_TenTaiKhoan.Text.Trim()) != null)
            {
                err_TenTaiKhoan.Visible = true;
            }
            else
            {
                err_TenTaiKhoan.Visible = false;
            }
        }
    }
}
