using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia4b
{
    public class Cuenta
    {
        private String titular;
        private int cantidad;

        public void settitular(String titular)
        {
            this.titular = titular;
        }
        public String gettitular()
        {
            return titular;
        }

        public int Getcantidad()
        {
            return cantidad;
        }
        public void setcantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public int ingresarcantidad(int cantidad,int cantidad2)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("Operacion invalida, su cantidad base sigue igual");
            }
            return cantidad+cantidad2;
        }

        public int retirarcantidad(int cantidad, int cantidad2)
        {
            return cantidad - cantidad2;
        }

    }
}
