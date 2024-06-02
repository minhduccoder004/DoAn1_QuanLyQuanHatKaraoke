using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ManagementKaraoke.Picture
{
    public class XuLyAnh
    {

        public void SaoChepAnh_ThuMucPicture(string DuongDanAnh, string TenAnh)
        {
            var DuongDanUngDung = AppDomain.CurrentDomain.BaseDirectory;
            var DuongDanTuongDoi = Path.Combine("AnhNhanVien", $"{TenAnh}");
            var DuongDanDayDu = Path.GetFullPath(Path.Combine(DuongDanUngDung, DuongDanTuongDoi));

            File.Copy(DuongDanAnh, DuongDanDayDu, true);
        }

        // phương thức lấy ảnh trả về kiểu dữ liệu tuple(string, string) 
        // value1: tên ảnh
        // value2: đường dẫn tuyệt đối đến ảnh
        public (string,string) ChonAnh(Guna2PictureBox Anh)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";

            var LuaChon = openFileDialog.ShowDialog();

            if (LuaChon == DialogResult.OK)
            {
                string FileSelect = openFileDialog.FileName;

                Anh.Image = System.Drawing.Image.FromFile(FileSelect);
                Anh.SizeMode = PictureBoxSizeMode.Zoom;

                return (DoiTenAnh(FileSelect.Split('\\')[FileSelect.Split('\\').Length - 1]), FileSelect);
            }

            return ("", "");
        }

        public void XoaAnh(string TenAnh)
        {
            if (!Equals(TenAnh, ""))
            {
                var DuongDanUngDung = AppDomain.CurrentDomain.BaseDirectory;
                var DuongDanTuongDoi = Path.Combine("AnhNhanVien", $"{TenAnh}");
                var DuongDanDayDu = Path.GetFullPath(Path.Combine(DuongDanUngDung, DuongDanTuongDoi));

                File.Delete(DuongDanDayDu);
            }
            
        }

        string DoiTenAnh(string TenAnh)
        {
            var Cat_TenAnh = TenAnh.Split('.');
            string TenAnhMoi = Cat_TenAnh[0] + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + '.' + Cat_TenAnh[1];
            return TenAnhMoi;
        }
    }
}
