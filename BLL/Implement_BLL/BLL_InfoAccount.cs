using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implement_BLL
{
    public class BLL_InfoAccount
    {
        public string Check_QuyenHan(int QuyenHan)
        {
            switch (QuyenHan)
            {
                case 0:
                    return "Quản lý";
                case 1:
                    return "Nhân viên";
            }

            return "Không xác định ?";
        }
    }
}
