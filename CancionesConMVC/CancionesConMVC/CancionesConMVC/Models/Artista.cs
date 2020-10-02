using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesConMVC.Models
{
    public class Artista
    {
        public int ArtistaId { get; set; }

        public string Nombre { get; set; }

        public ICollection<Album> Albumes { get; set; }
    }
}
