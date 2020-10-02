using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesConMVC.Models
{
    public class Cancion
    {
        public int CancionId { get; set; }

        public string Nombre { get; set; }

        public int AlbumId { get; set; }

        public Album Album { get; set; }

        public int GeneroId { get; set; }

        public Genero Genero { get; set; }

        ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
