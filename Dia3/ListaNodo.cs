using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia3
{
    public class ListaNodo
    {
        private Nodo primero;
        private int size;

        public ListaNodo()
        {
            primero = null;
            size = 0;
        }

        public void addNodo(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            Nodo valor1, valor2;
            if (primero == null)
            {
                primero = nuevo;
                nuevo.siguiente = null;
            }
            else
            {
                valor1 = primero;
                while (valor1 != null)
                {
                    valor2 = valor1.siguiente;
                    if (nuevo.dato <= valor1.dato)
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                        break;
                    }
                    else {
                        if (nuevo.dato > valor1.dato && valor2 == null)
                        {
                            valor1.siguiente = nuevo;
                            nuevo.siguiente = null;
                            break;
                        }
                        else
                        {
                            if (valor1.dato < nuevo.dato && valor2.dato >= nuevo.dato)
                            {
                                valor1.siguiente = nuevo;
                                nuevo.siguiente = valor2;
                                break;
                            }
                            else
                            {
                                valor1 = valor1.siguiente;
                            }
                        }
                    }
                }
            }
        }

        public void ListaVacia()
        {
            if (primero == null)
            {
                Console.WriteLine("LISTA VACIA");
            }
            else
            {
                Console.WriteLine("La lista contiene datos");
            }
        }
        public void Listar()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.Write($"[{actual.dato}]->");
                actual = actual.siguiente;
            }
        }

        public void Borrar1ro()
        {
            primero = primero.siguiente;
        }

        public void BorrarUltimo()
        {
            Nodo anterior = primero;
            Nodo actual = primero;
            while (actual.siguiente != null)
            {
                anterior = actual;
                actual = actual.siguiente;
            }
        }

        public void BorrarPosNodo(int p)
        {
            Nodo anterior = primero;
            Nodo actual = primero;
            int dato = 0;
            if (p > 0)
            {
                while (dato != p && actual.siguiente != null)
                {
                    anterior = actual;
                    actual = actual.siguiente;
                    dato++;
                }
                anterior.siguiente = actual.siguiente;
            }
        }

        public Nodo BuscarNodo(int n)
        {
            Nodo p = primero;
            if (p == null)
            {
                Console.WriteLine("La lista no tiene datos");
            }
            else
            {
                while (p.siguiente != null || p.siguiente == null)
                {
                    if (p.dato == n)
                    {
                        return p;
                    }
                    else
                    {
                        if (p.siguiente == null)
                        {
                            return null;
                        }
                    }
                    p = p.siguiente;
                }
            }
            return null;
        }

        public void Sustituir(int orig, int nuevo)
        {
            Nodo pos = BuscarNodo(orig);
            if (pos != null || pos == null)
            {
                pos.dato = nuevo;
            }
        }
        public int Size()
        {
            return size;
        }
      
    }
}
