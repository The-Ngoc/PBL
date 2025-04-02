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
        public DbSet<Faculty> lisFaculty { get; set; }
        public DbSet<Subject> listSubject { get; set; }
        public DbSet<Class> listClass { get; set; }


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
                optionsBuilder.UseSqlServer("Data Source=BAPBOMM\\MSSQLSERVER01;Initial Catalog=Data01;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>().ToTable("Khoa");
            modelBuilder.Entity<Subject>().ToTable("MonHoc");
            modelBuilder.Entity<Class>().ToTable("LopHoc");
        }
    }
}
