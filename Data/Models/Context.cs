
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace FoodApp.Data.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
           .UseLazyLoadingProxies()
           .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.InvalidIncludePathError))
           .UseSqlServer("Data Source=HOME-PC; database=FoodAp; integrated security=true");
        }
        public DbSet<Category> categories { get; set; }
       public  DbSet<Food> foods { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}
