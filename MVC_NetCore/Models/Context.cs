using Microsoft.EntityFrameworkCore;
using MVC_NetCore.Models;

namespace MVC_NetCore.Models
{
    public class Context : DbContext

    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> produtos { get; set;  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=CursoMVC;Integrated Security=True");
        }

        public DbSet<MVC_NetCore.Models.Produto> Produto { get; set; }

    }
}

