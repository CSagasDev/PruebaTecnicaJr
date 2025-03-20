using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PruebaTecnica.Models
{
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions<TiendaContext> options) : base(options) { }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Venta> Venta { get; set; }
    }
}
