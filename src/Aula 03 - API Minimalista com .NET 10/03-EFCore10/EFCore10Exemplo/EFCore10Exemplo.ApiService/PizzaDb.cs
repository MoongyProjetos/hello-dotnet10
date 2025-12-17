using EFCore10Exemplo.ApiService.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore10Exemplo.ApiService
{
    public class PizzaDb : DbContext
    {
        public PizzaDb(DbContextOptions<PizzaDb> options) : base(options)
        {

        }
        public DbSet<Pizza> Pizzas { get; set; } = null!;
    }
}
