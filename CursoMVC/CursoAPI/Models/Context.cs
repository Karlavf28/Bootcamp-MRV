
using System;
using Microsoft.EntityFrameworkCore;

namespace CursoAPI.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1401; Database=Cursomvc;User=SA; Password=<Numsey@Password>");

        }

    }
}
