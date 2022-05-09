using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6
{
    public class Listadouble<T> : ListaDevPlace<T>
    {
        class Nodo
        {
            public T Info { get; set; }
            public Nodo Sig { get; set; }
        }

        private Nodo raiz;

        public Listadouble()
        {
            raiz = null;
        }
        public int CantidadItems()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                reco = reco.Sig;
                cant++;
            }
            return cant;
        }
        public void agregarItem(int pos, T x)
        {
            if (pos <= CantidadItems() + 1)
            {
                Nodo nuevo = new Nodo();
                nuevo.Info = x;
                if (pos == 1)
                {
                    nuevo.Sig = raiz;
                    raiz = nuevo;
                }
                else
                    if (pos == CantidadItems() + 1)
                {
                    Nodo reco = raiz;
                    while (reco.Sig != null)
                    {
                        reco = reco.Sig;
                    }
                    reco.Sig = nuevo;
                    nuevo.Sig = null;
                }
                else
                {
                    Nodo reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.Sig;
                    Nodo siguiente = reco.Sig;
                    reco.Sig = nuevo;
                    nuevo.Sig = siguiente;
                }
            }
        }

        public T borrarItem(int pos)
        {
            T informacion;
            if (pos == 1)
            {
                informacion = raiz.Info;
                raiz = raiz.Sig;
            }
            else
            {
                Nodo reco;
                reco = raiz;
                for (int f = 1; f <= pos - 2; f++)
                    reco = reco.Sig;
                Nodo prox = reco.Sig;
                reco.Sig = prox.Sig;
                informacion = prox.Info;
            }
            return informacion;
        }

        public void MostrarItem()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.Write(reco.Info + "-");
                reco = reco.Sig;
            }
            Console.WriteLine();
        }

        public void Obteneritem(int i)
        {

        }
    }
}
