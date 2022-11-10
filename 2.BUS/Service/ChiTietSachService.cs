using _1.DAL.DomainClass;
using _1.DAL.Repositoties;
using _2.BUS.IService;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class ChiTietSachService : IChiTietSachService
    {
        private ChiTietSachRepository _iChiTietSachRepository;
        private List<ChiTietSach> _lstChiTietSach;
        private List<ChiTietSachView> _lstChiTietSachView;
        public string Add(ChiTietSach chiTietSach)
        {
            if (chiTietSach == null) return "Thêm chi tiết sách thất bại";
            _iChiTietSachRepository.Add(chiTietSach);
            return "Thêm chi tiết sách thành công";
        }

        public string Delete(Guid? id, ChiTietSach chiTietSach)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietSach> GetAll()
        {
            return _lstChiTietSach = _iChiTietSachRepository.GetAll();
        }

        public List<ChiTietSachView> GetAllChiTietSachView()
        {
            throw new NotImplementedException();
        }

        public string Update(Guid? id, ChiTietSach chiTietSach)
        {
            throw new NotImplementedException();
        }
    }
}
