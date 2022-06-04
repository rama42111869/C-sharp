namespace Dia17.Models.Request
{
    public class ClienteRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Dni { get; set; } = null!;
        public string Direccion { get; set; } = null!;
    }
}
