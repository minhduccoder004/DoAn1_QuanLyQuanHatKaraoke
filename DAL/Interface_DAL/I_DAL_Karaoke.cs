using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface_DAL
{
    public interface I_DAL_Karaoke<DTO>
    {
       List<DTO> DanhSachDoiTuong();
    }
}
