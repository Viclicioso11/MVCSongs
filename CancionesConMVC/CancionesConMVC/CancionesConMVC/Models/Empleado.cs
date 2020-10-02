using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesConMVC.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Cargo { get; set; }

        
        public int? JefeDirecto { get; set; }

        [ForeignKey("JefeDirecto")]
        public Empleado EmpleadoJefe { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public ICollection<Empleado> Empleados { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }
}
