using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia4b
{
    public class Eiffel
    {
        private int elemento;

        public Eiffel(int elemento)
        {
            this.elemento = elemento;
        }
        public int Getelemento()
        {
            return elemento;
        }
        public void setelemento(int elemento)
        {
            this.elemento = elemento;
        }

        public void Ordenamiento_Insercion(int[] array, int dim)
        {
            for (int i = 0; i < dim; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while ((j >= 0) && (array[j] > temp))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }

    }
}
