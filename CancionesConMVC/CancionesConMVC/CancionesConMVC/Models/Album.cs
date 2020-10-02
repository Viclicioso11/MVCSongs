using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesConMVC.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Titulo { get; set; }

        public int ArtistaId { get; set; }

        public Artista Artista { get; set; }

        public ICollection<Cancion> Canciones { get; set; }
    }
}
