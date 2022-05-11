using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia5
{
    public class Coche : IVehiculo
    {
        public int Gasolina { get; set; }
        public Coche(int fuel)
        {
            Gasolina = fuel;
        }
        public void Conducir()
        {
            if (Gasolina > 0)
            {
                Console.WriteLine("Conduciendo");
            }
            else
            {
                Console.WriteLine("No hay gasolina");
            }
        }
        public bool Repostar(int cantidad)
        {
            Gasolina += cantidad;
            return true;
        }
    }
}
