namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileVanBan")]
    public partial class FileVanBan
    {
        [Key]
        public long FileID { get; set; }

        public int VanBanID { get; set; }

        [StringLength(1000)]
        public string FileName { get; set; }

        [StringLength(20)]
        public string FileType { get; set; }

        public long? FileSize { get; set; }

        [StringLength(2000)]
        public string ClientFileName { get; set; }

        [StringLength(1000)]
        public string ServerFileName { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(1000)]
        public string UpdatedUser { get; set; }

        [StringLength(2000)]
        public string MapPath { get; set; }

        public int? PageNumber { get; set; }

        public int? DownloadCount { get; set; }
    }
}
