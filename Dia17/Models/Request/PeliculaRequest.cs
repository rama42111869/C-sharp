namespace Dia17.Models.Request
{
    public class PeliculaRequest
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Genero { get; set; } = null!;
        public DateTime FechaBaja { get; set; }
    }
}
