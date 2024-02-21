using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context
{
    public class AppDbContext : DbContext
    {
        // essa parametro vai conter as opções de configuração que
        // serão usadas para configurar o contexto do banco de dados (ex: string de conexão)
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) {}

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
