﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KhachHang")]
    [Index(nameof(Ma), Name = "UQ__KhachHan__3214CC9E8E13D319", IsUnique = true)]
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }
        [Column("SDT")]
        [StringLength(30)]
        public string Sdt { get; set; }
        [Column("IDDiemTieuDung")]
        public Guid? IddiemTieuDung { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(HoaDon.IdkhNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
