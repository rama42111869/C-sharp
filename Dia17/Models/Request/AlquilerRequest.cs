namespace Dia17.Models.Request
{
    public class AlquilerRequest
    {
        public int Id { get; set; }
        public int PeliculaId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
    }
}
