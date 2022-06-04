using System;
using System.Collections.Generic;

namespace Dia17.Models
{
    public partial class Alquiler
    {
        public int Id { get; set; }
        public int PeliculaId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
    }
}
