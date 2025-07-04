using BaristaCafe.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Persistence.Context
{
    public class BaristaCafeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PJJV610\\SQLEXPRESS;initial catalog=BaristaCafeDB;integrated security=true;TrustServerCertificate=true;");
        }
        public BaristaCafeContext(DbContextOptions<BaristaCafeContext> options)
      : base(options)
        {
        }

        public DbSet<AboutCafe> AboutCafes { get; set; }
        public DbSet<Baristas> Baristases { get; set; }
        public DbSet<BaristaDesc> BaristaDescs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<WelcomeScreen> WelcomeScreens { get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<SocailMedia> SocailMedias { get; set; }






    }
}
