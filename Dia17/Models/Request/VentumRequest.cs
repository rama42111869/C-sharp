namespace Dia17.Models.Request
{
    public class VentumRequest
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public decimal Importe { get; set; }
        public decimal Descuento { get; set; }
        public DateTime Fecha { get; set; }
    }
}
