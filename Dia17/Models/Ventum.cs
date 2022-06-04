using System;
using System.Collections.Generic;

namespace Dia17.Models
{
    public partial class Ventum
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public decimal Importe { get; set; }
        public decimal Descuento { get; set; }
        public DateTime Fecha { get; set; }
    }
}
