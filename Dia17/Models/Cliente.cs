using System;
using System.Collections.Generic;

namespace Dia17.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Dni { get; set; } = null!;
        public string Direccion { get; set; } = null!;
    }
}
