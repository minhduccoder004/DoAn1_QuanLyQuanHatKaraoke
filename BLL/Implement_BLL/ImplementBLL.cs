using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implement_BLL
{
    public abstract class ImplementBLL<DTO>
    {
        public abstract void Them(DTO _DTO);
        public abstract void Sua(DTO _DTO);
        public abstract void Xoa(DTO _DTO);

    }
}
