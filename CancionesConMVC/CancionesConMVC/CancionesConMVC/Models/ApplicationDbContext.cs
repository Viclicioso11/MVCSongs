using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesConMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
                                                                                                                                           
        }


        public DbSet<Album> Albums { get; set; }

        public DbSet<Artista> Artistas { get; set; }

        public DbSet<Cancion> Canciones { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<DetalleFactura> DetalleFacturas { get; set; }

        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Factura> Facturas { get; set; }

        public DbSet<Genero> Generos { get; set; }


    }
}
