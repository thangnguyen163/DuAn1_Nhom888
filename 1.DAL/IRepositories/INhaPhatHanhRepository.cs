using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositoties
{
    public interface INhaPhatHanhRepository
    {
        bool AddNPH(NhaPhatHanh obj);
        bool UpdateNPH(NhaPhatHanh obj);
        bool DeleteNPH(NhaPhatHanh obj);
        List<NhaPhatHanh> GetAllNPH();
    }
}
