using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<DemoMVC.Models.Employee> Employee { get; set; } = default!;
        public DbSet<DemoMVC.Models.HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
        public DbSet<DemoMVC.Models.DaiLy> DaiLy { get; set; } = default!;
    }
}
