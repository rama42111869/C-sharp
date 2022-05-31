using System;
using System.Collections.Generic;

namespace ApiLibros.Models
{
    public partial class Libros
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? NombreLibro { get; set; }
        public int? Año { get; set; }
    }
}
