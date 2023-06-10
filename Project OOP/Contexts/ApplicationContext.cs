using Microsoft.EntityFrameworkCore;
using Project_OOP.Models;

namespace Project_OOP.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ApplicationModel> ApplicationDataBase { get; set; }
        public DbSet<UsersModel> UserDataBase { get; set; }
        public DbSet<CarsModel> CarDataBase { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database = Project_OOP; Trusted_Connection = True; ");
        }

    }
}