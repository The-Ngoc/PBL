using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PBL.module;


namespace PBL.data
{
    class AppDBContext : DbContext
    {
        public DbSet<Faculty> listFaculty { get; set; }
        public DbSet<Subject> listSubject { get; set; }
        public DbSet<Class> listClass { get; set; }

        public DbSet<Teacher> listTeacher { get; set; }
        public DbSet<Room> listRoom { get; set; }
        public DbSet<Assign> listAssign { get; set; }
        public DbSet<ClassSession> listClassSession { get; set; }
        public DbSet<Schedule> listSchedule { get; set; }


        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public AppDBContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-I5VFBP6\\BAPBOM;Initial Catalog=PBL3;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>().ToTable("Khoa");
            modelBuilder.Entity<Subject>().ToTable("MonHoc");
            modelBuilder.Entity<Class>().ToTable("LopHoc");
            modelBuilder.Entity<Teacher>().ToTable("GiangVien");
            modelBuilder.Entity<Room>().ToTable("PhongHoc");
            modelBuilder.Entity<Assign>().ToTable("PhanCong");
            modelBuilder.Entity<ClassSession>().ToTable("BuoiHoc");
            modelBuilder.Entity<Schedule>().ToTable("ThoiKhoaBieu");
        }
    }
}
