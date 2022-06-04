namespace Dia17.Models.Request
{
    public class VehiculoRequest
    {
        public int Id { get; set; }
        public string Marca { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string Importe { get; set; } = null!;
        public DateTime FechaBaja { get; set; }
    }
}
