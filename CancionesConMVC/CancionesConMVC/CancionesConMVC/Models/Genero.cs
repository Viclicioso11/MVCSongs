using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesConMVC.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }

        public string Nombre { get; set; }

        public ICollection<Cancion> Canciones { get; set; }
    }
}
