using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BTTH.Models;

namespace BTTH.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;} 
    }
}