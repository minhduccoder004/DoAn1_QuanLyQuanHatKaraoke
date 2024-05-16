using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface_BLL
{
    public interface I_BLL_Karaoke<DTO>
    {
        List<DTO> DanhSachDoiTuong();
        DTO GetByID(string ID);
    }
}
