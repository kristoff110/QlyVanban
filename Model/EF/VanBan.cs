namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VanBan")]
    public partial class VanBan
    {
        public int VanBanID { get; set; }

        [StringLength(2000)]
        public string TieuDe { get; set; }

        [StringLength(2000)]
        public string TieuDeKhongDau { get; set; }

        [StringLength(200)]
        public string SoVanBan { get; set; }

        [Column(TypeName = "text")]
        public string TomTatNoiDung { get; set; }

        [Column(TypeName = "text")]
        public string TomTatNoiDungKhongDau { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(1000)]
        public string CreatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(1000)]
        public string UpdatedUser { get; set; }

        public bool? IsPublish { get; set; }

        public bool? GhimLenDau { get; set; }

        [StringLength(1000)]
        public string Tag { get; set; }

        public DateTime? PublishDate { get; set; }
    }
}
