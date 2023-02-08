using ElsoftRestaurant.Services.ProductsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ElsoftRestaurant.Services.ProductsAPI.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }



    }
}
