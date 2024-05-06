using Microsoft.EntityFrameworkCore;
using SignarRBancodeDados.Models;

namespace SignarRBancodeDados.Context
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
