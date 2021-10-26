using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LTQLDbContext.Models
{
    public partial class LapTrinhQuanLyDbContext : DbContext
    {
        public LapTrinhQuanLyDbContext() : base("name = LapTrinhQuanLyDbContext")
        {

        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Persion> Persions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
            .Property(e => e.Username)
            .IsUnicode(false);
            modelBuilder.Entity<Student>()
            .Property(e => e.StudentID)
            .IsUnicode(false);
            modelBuilder.Entity<KhachHang>()
            .Property(e => e.MaKhachHang)
            .IsUnicode(false);
        }


    }
}