using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6
{
    public class ListaCola<T>
    {
        class Nodo
        {
            public T Info { get; set; }
            public Nodo Sig { get; set; }
        }

        private Nodo raiz;

        public ListaCola()
        {
            raiz = null;
        }

        public void Insertar(int pos, T x)
        {
            if (pos <= Cantidad() + 1)
            {
                Nodo nuevo = new Nodo();
                nuevo.Info = x;
                if (pos == 1)
                {
                    nuevo.Sig = raiz;
                    raiz = nuevo;
                }
                else
                    if (pos == Cantidad() + 1)
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

        public T Extraer(int pos)
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

        public void Imprimir()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.Write(reco.Info + "-");
                reco = reco.Sig;
            }
            Console.WriteLine();
        }

        public int Cantidad()
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
    }
}
