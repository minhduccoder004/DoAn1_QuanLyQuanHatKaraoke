using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_NguoiDung
    {
        string QuyenHanNguoiDung(int QuyenHan);
        int QuyenHanNguoiDung(string QuyenHan);

        List<tblNguoiDung> TimKiemNguoiDung(string ThongTinTimKiem);

        void DoiMatKhau(tblNguoiDung ND);

    }
}
