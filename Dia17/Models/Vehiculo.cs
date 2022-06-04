using System;
using System.Collections.Generic;

namespace Dia17.Models
{
    public partial class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string Importe { get; set; } = null!;
        public DateTime FechaBaja { get; set; }
    }
}
