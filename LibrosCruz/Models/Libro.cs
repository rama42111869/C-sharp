using System;
using System.Collections.Generic;

namespace LibrosCruz.Models
{
    public partial class Libro
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Autor { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
