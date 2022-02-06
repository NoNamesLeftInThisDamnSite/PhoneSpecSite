using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhoneSpecSite.Models;

namespace PhoneSpecSite.Data
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //generatee default authentication tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Lipsva kod
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Phones> Phones { get; set; }
        public DbSet<PhoneCompany> PhoneCompany { get; set; }
    }
}
