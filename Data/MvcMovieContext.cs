using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoNetcore.Models;
namespace DemoNetcore.Data{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<DemoNetcore.Models.Movie> Movie { get; set; }

        public DbSet<DemoNetcore.Models.Person> Person { get; set; }

        public DbSet<DemoNetcore.Models.Employee> Employee { get; set; }

        public DbSet<DemoNetcore.Models.Product> Product { get; set; }

        public DbSet<DemoNetcore.Models.Hocsinh> Hocsinhs{ get; set; }

        public DbSet<DemoNetcore.Models.khachhang> khachhang { get; set; }

        public DbSet<DemoNetcore.Models.hoadon> hoadon { get; set; }
        public DbSet<DemoNetcore.Models.Nhanvien> Hocsinh { get; set; }
    }


}

    