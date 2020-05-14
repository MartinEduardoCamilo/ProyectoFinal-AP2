using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Contexto: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server = .\SqlExpress; Database = FotoStudio2; Trusted_Connection = True; ");
        }

        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
    }
}
