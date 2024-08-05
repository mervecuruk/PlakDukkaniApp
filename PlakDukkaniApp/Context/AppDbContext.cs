using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniApp.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<Album> Albumler { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-0MKLK4U5\\SQLEXPRESS;Initial Catalog=PlakDukkaniDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yonetici>().HasKey(y => y.Id);
            modelBuilder.Entity<Yonetici>().Property(y => y.KullaniciAdi).IsUnicode().IsRequired();
            modelBuilder.Entity<Yonetici>().Property(y => y.Sifre).IsRequired();


            modelBuilder.Entity<Album>().HasKey(a => a.Id);
            modelBuilder.Entity<Album>().Property(a => a.AlbumAdi).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Album>().Property(a => a.SanatciAdi).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Album>().Property(a => a.SanatciSoyadi).HasColumnType("nvarchar(50)").IsRequired();


            base.OnModelCreating(modelBuilder);
        }
    }
}
