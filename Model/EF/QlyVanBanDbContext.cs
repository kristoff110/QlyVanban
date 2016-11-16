namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QlyVanBanDbContext : DbContext
    {
        public QlyVanBanDbContext()
            : base("name=QlyVanBanDbContext")
        {
        }

        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<FileVanBan> FileVanBans { get; set; }
        public virtual DbSet<VanBan> VanBans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VanBan>()
                .Property(e => e.TomTatNoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<VanBan>()
                .Property(e => e.TomTatNoiDungKhongDau)
                .IsUnicode(false);
        }
    }
}
