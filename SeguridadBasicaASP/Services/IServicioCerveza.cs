using SeguridadBasicaASP.Models;

namespace SeguridadBasicaASP.Services
{
    public interface IServicioCerveza
    {
        public Task<List<Cerveza>> Get();
    }
}
