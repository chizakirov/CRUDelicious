using Microsoft.EntityFrameworkCore;
 
namespace CRUDelicious.Models
{
    public class DishContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DishContext(DbContextOptions<DishContext> options) : base(options) { }
        public DbSet<Dish> dishes {get;set;}
    }
}