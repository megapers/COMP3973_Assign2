using Assign2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assign2.Data
{

    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {    }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("X-MasUser");
        }
         public DbSet<User> Users { get; set; }
    }

}