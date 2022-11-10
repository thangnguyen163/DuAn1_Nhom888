using _1.DAL.IRepositoties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositoties
{
    public class HoaDonChiTietRepository : IChitietHoadonRepository
    {
        //public FpolyDBContext _DBContext = new FpolyDBContext();
        //public List<HoaDon> _lstHoadon;

        //public bool AddHoaDonChitiet(HoaDonChiTiet obj)
        //{
        //    if (obj == null) return false;
        //    _DBContext.HoaDonChiTiets.Add(obj);
        //    _DBContext.SaveChanges();
        //    return true;
        //}

        //public bool DeleteHoaDonChitiet(HoaDonChiTiet obj)
        //{
        //    if (obj == null) return false;
        //    var tempobj = _DBContext.HoaDonChiTiets.FirstOrDefault(c => c.Id == obj.Id);
        //    _DBContext.HoaDonChiTiets.Remove(tempobj);
        //    _DBContext.SaveChanges();
        //    return true;
        //}

        //public List<HoaDonChiTiet> GetAllHoaDonChitiet()
        //{
        //    return _DBContext.HoaDonChiTiets.ToList();
        //}

        //public bool UpdateHoaDonChitiet(HoaDonChiTiet obj)
        //{
        //    if (obj == null) return false;
        //    var tempobj = _DBContext.HoaDonChiTiets.FirstOrDefault(c => c.Id == obj.Id);
        //    tempobj.GiamGia = obj.GiamGia;
        //    tempobj.SoLuong = obj.SoLuong;
        //    tempobj.DonGia = obj.DonGia;
        //    tempobj.ThanhTien = obj.ThanhTien;
        //    tempobj.TrangThai = obj.TrangThai;
        //    _DBContext.HoaDonChiTiets.Update(tempobj);
        //    _DBContext.SaveChanges();
        //    return true;

        //}
    }
}
