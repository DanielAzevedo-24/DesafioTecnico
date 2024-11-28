using Microsoft.EntityFrameworkCore;
using ProdutoService.Models;

namespace ProdutoService.Data
{
    public class ProdutoDbContext : DbContext
    {
        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}

