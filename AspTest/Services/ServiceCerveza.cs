using AspTest.Models;

namespace AspTest.Services
{
    public class ServiceCerveza : IBeer
    {
        private List<Cerveza> _cervezas = new List<Cerveza>() {

           new Cerveza(){Id=1,Nombre="Rama",Marca="Branch" },
           new Cerveza(){Id=2,Nombre="Llamarada Moe",Marca="Duff" }
        };

        public IEnumerable<Cerveza> Get() => _cervezas;

        public Cerveza? Get(int id) => _cervezas.FirstOrDefault(d => d.Id == id);

    }
}
