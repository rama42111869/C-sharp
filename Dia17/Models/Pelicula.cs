using System;
using System.Collections.Generic;

namespace Dia17.Models
{
    public partial class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Genero { get; set; } = null!;
        public DateTime FechaBaja { get; set; }
    }
}
