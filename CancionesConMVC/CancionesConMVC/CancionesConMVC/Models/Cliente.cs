using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesConMVC.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }
 
        public int SoporteId { get; set; }

        [ForeignKey("SoporteId")]
        public Empleado Empleado { get; set; }

        public ICollection<Factura> Facturas { get; set; }
    }
}
