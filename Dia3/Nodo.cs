using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia3
{
    public class Nodo
    {
        public int dato;
        public Nodo siguiente;
        private string dato1;

        public Nodo(int dato)
        {
            this.dato=dato;
            this.siguiente = null;
        }

        public Nodo(string dato1)
        {
            this.dato1 = dato1;
        }
    }
}
