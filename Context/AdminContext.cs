using Adminer.Models;
using Microsoft.EntityFrameworkCore;

namespace Adminer.Context
{
    public class AdminContext : DbContext
    {
        public AdminContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=.;Database=AdminDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<UsersDTO> tblUser { get; set; }
        public DbSet<ApplicationDTO> tblApplication { get; set; }

        public DbSet<EnvironmentDTO> tblEnvironment { get; set; }
    }
}
