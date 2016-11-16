namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMuc")]
    public partial class DanhMuc
    {
        public int DanhMucID { get; set; }

        [StringLength(1000)]
        public string TenDanhMuc { get; set; }

        [StringLength(1000)]
        public string TenDanhMucKhongDau { get; set; }

        public int? LFT { get; set; }

        public int? RGT { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
