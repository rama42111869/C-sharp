using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia5
{
    public abstract class Animal
    {
        private string Nombre;
        private int edad;

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }
        public string GetNombre()
        {
            return Nombre;
        }

        public void setedad(int edad)
        {
            this.edad = edad;
        }

        public int getedad()
        {
            return edad;
        }

        public abstract void Comer();
        public abstract string Comer2();
        public abstract void sonido();
        public abstract int Calcularedadanimal(int edad);

    }
}
