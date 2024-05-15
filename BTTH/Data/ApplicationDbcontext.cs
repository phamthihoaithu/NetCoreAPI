using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BTTH.Models;

namespace BTTH.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;} = default!;
          public DbSet<Employee> Employee { get; set;} = default!;
            public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set;} = default!;
              public DbSet<DaiLy> DaiLy { get; set;} = default!;
    }
}