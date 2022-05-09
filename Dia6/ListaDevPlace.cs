using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6
{
    public interface ListaDevPlace<T>
    {
        public void agregarItem(int pos, T x);
        public T borrarItem(int pos);
        public void MostrarItem();

        public int CantidadItems();

        public void Obteneritem(int i);
    }
}
