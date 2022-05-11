using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia5
{
    public class Gato : Animal
    {
        public override void Comer()
        {
            Console.WriteLine("Comio atun");
        }
        public override string Comer2()
        {
            return "Comi demasiado";
        }
        public override void sonido()
        {
            Console.WriteLine("Dice miau");
        }

        public override int Calcularedadanimal(int edad)
        {
            return edad * 5;
        }

    }
}
