using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class OrderEatDBContext : DbContext
    {
        public OrderEatDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Comidas> comidas { get; set; }
        public DbSet<Personas> personas { get; set; }
        public DbSet<Factura> facturas { get; set; }
        public DbSet<Clientes> clientes { get; set; }
    }
}
