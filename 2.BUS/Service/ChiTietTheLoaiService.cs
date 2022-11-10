using _1.DAL.DomainClass;
using _1.DAL.IRepositoties;
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
    public class ChiTietTheLoaiService : IChiTietTheLoaiService
    {
        IChiTietTheLoaiRepository _ichiTietTheLoaiRepository;
        IChiTietSachRepository _ichiTietSachRepository;
        ITheLoaiRepository _iTheLoaiRepository;
        public ChiTietTheLoaiService()
        {
            _ichiTietTheLoaiRepository = new ChiTietTheLoaiRepository();
            _ichiTietSachRepository = new ChiTietSachRepository();
            _iTheLoaiRepository = new TheLoaiRepository();
        }
        public string Add(ChiTietTheLoai obj)
        {
            if (obj == null) return "Thêm không thành công";
            if (_ichiTietTheLoaiRepository.AddCTTheLoai(obj)) return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(ChiTietTheLoai obj)
        {
            if (obj == null) return "Xóa không thành công";
            if (_ichiTietTheLoaiRepository.DeleteCTTheLoai(obj)) return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<ChiTietTheLoaiView> GetAll()
        {
            List<ChiTietTheLoaiView> lstcttlv = new List<ChiTietTheLoaiView>();
            lstcttlv =
                (from a in _ichiTietTheLoaiRepository.GetAllCTTheLoai()
                 join b in _ichiTietSachRepository.GetAll() on a.IdChiTietSach equals b.Id
                 join c in _iTheLoaiRepository.GetAllTheLoai() on a.IdTheLoai equals c.Id
                 select new ChiTietTheLoaiView()
                 {
                     Id = a.Id,
                     IdTheLoai = c.Id,
                     IdChiTietSach = b.Id,
                     Ma = a.Ma,
                     Ten = a.Ten,
                     TrangThai = a.TrangThai,
                 }).ToList();
            return lstcttlv;
        }

        public string Update(ChiTietTheLoai obj)
        {
            if (obj == null) return "Cập nhật không thành công";
            if (_ichiTietTheLoaiRepository.UpdateCTTheLoai(obj)) return "Cập nhật thành công";
            return "Cập nhật không thành công";
        }
    }
}
