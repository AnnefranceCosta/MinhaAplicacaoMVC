using Microsoft.EntityFrameworkCore;
using MinhaAplicacaoMvc.Models;

namespace MinhaAplicacaoMvc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
