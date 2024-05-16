using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.Implement_DAL
{
    public abstract class ImplementDAL<DTO>
    {
        public abstract void Them (DTO _DTO);
        public abstract void Sua(DTO _DTO);
        public abstract void Xoa(DTO _DTO);

    }
}
