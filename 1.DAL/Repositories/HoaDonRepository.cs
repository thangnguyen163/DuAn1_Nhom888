using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositoties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositoties
{
    public class HoaDonRepository : IHoaDonRepository
    {
        public FpolyDBContext _DBContext = new FpolyDBContext();

        public bool AddHoadon(HoaDon obj)
        {
            if (obj == null) return false;
            _DBContext.HoaDons.Add(obj);
            _DBContext.SaveChanges();
            return true;
        }

        public bool DeleteHoadon(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _DBContext.HoaDons.FirstOrDefault(x => x.Id == obj.Id);
            _DBContext.HoaDons.Remove(obj);
            _DBContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return _DBContext.HoaDons.ToList();
        }

        public bool UpdateHoadon(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _DBContext.HoaDons.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.Idkh = obj.Idkh;
            tempobj.Idnv = obj.Idnv;
            tempobj.IddiemDung = obj.IddiemDung;
            tempobj.IddiemTich = obj.IddiemTich;
            tempobj.MaHd = obj.MaHd;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.Thue = obj.Thue;
            tempobj.GiamGia = obj.GiamGia;
            tempobj.TongTien = obj.TongTien;
            tempobj.GhiChu = obj.GhiChu;
            tempobj.TrangThai = obj.TrangThai;
            _DBContext.HoaDons.Update(tempobj);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
