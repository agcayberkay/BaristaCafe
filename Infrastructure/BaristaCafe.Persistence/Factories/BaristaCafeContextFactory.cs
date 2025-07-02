using BaristaCafe.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Persistence.Factories
{
    public class BaristaCafeContextFactory : IDesignTimeDbContextFactory<BaristaCafeContext>
    {
        public BaristaCafeContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BaristaCafeContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-PJJV610\\SQLEXPRESS;Database=BaristaCafeDB;Trusted_Connection=True;TrustServerCertificate=True;");

            return new BaristaCafeContext(optionsBuilder.Options);
        }
    }
}
