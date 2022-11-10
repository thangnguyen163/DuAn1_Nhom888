﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("DiemTieuDung")]
    [Index(nameof(Ma), Name = "UQ__DiemTieu__3214CC9E64588855", IsUnique = true)]
    public partial class DiemTieuDung
    {
        public DiemTieuDung()
        {
            LichSuDiemDungs = new HashSet<LichSuDiemDung>();
            LichSuDiemTiches = new HashSet<LichSuDiemTich>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        public int? SoDiem { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(LichSuDiemDung.IddiemTieuDungNavigation))]
        public virtual ICollection<LichSuDiemDung> LichSuDiemDungs { get; set; }
        [InverseProperty(nameof(LichSuDiemTich.IddiemTieuDungNavigation))]
        public virtual ICollection<LichSuDiemTich> LichSuDiemTiches { get; set; }
    }
}