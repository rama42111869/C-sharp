namespace ApiLibros.Models.Request
{
    public class LibrosRequest
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? NombreLibro { get; set; }
        public int? Año { get; set; }
    }
}
