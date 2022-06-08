using AspTest.Models;

namespace AspTest.Services
{
    public interface IBeer
    {
        public IEnumerable<Cerveza> Get();
        public Cerveza? Get(int id);
    }
}
