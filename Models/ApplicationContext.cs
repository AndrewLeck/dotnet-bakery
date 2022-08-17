using Microsoft.EntityFrameworkCore;
namespace DotnetBakery.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

        //Refernece our Models
        //Baker is the class needs to match the file name same thing with bread
        public DbSet<Baker> Bakers {get; set;}
        public DbSet<Bread> Breads {get; set;}
    }
}