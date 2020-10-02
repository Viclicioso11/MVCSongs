using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesConMVC.Models
{
    public class DetalleFactura
    {
        [Key]
        public int DetFacturaId { get; set; }

        public int FacturaId { get; set; }

        public Factura Factura { get; set; }

        public int CancionId { get; set; }

        public Cancion Cancion { get; set; }

        public float PrecioUnidad { get; set; }

        public int Cantidad { get; set; }

    }
}
