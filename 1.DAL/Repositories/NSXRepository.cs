using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositoties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositoties
{
    public class NSXRepository : INhaPhatHanhRepository
    {
        FpolyDBContext _context;
        public NSXRepository()
        {
            _context = new FpolyDBContext();
        }
        public bool AddNPH(NhaPhatHanh obj)
        {
            if (obj == null) return false;
            _context.NhaPhatHanhs.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteNPH(NhaPhatHanh obj)
        {
            if (obj == null) return false;
            var temp = _context.NhaPhatHanhs.FirstOrDefault(c => c.Id == obj.Id);
            _context.NhaPhatHanhs.Remove(temp);
            _context.SaveChanges();
            return true;
        }

        public List<NhaPhatHanh> GetAllNPH()
        {
            return _context.NhaPhatHanhs.ToList();
        }

        public bool UpdateNPH(NhaPhatHanh obj)
        {
            //public Guid Id { get; set; }
            //public string Ma { get; set; }
            //public string Ten { get; set; }
            //public int? TrangThai { get; set; }
            if (obj == null) return false;
            var temp = _context.NhaPhatHanhs.FirstOrDefault(c => c.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            temp.TrangThai = obj.TrangThai;
            _context.NhaPhatHanhs.Update(temp);
            _context.SaveChanges();
            return true;
        }
    }
}
