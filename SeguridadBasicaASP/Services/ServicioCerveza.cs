using SeguridadBasicaASP.Models;
using System.Text.Json;

namespace SeguridadBasicaASP.Services
{
    public class ServicioCerveza :IServicioCerveza
    {
        string path = @"C:\Users\Equipo\source\repos\SeguridadBasicaASP\Cerveza.json";
       
        public async Task<List<Cerveza>> Get()
        {
            string content = await File.ReadAllTextAsync(path);
            var beers=JsonSerializer.Deserialize<List<Cerveza>>(content);
            return beers;
        }
    }
}
