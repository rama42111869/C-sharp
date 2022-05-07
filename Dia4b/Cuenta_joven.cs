using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia4b
{
    public class Cuenta_joven : Cuenta
    {
        private int bono;
        private int edad;
        public int Getbono()
        {
            return bono;
        }
        public void setbono(int bono)
        {
            this.bono = bono;
        }

        public int GetEdad()
        {
            return edad;
        }
        public void setedad(int edad)
        {
            this.edad = edad;
        }

        public Cuenta_joven(string titular, int cantidad,int bono,int edad) : base(titular, cantidad)
        {
            this.bono = bono;
            this.edad = edad;
        }

        public Boolean esTitularValido(int edad)
        {
            Boolean estado=false;
            if (edad > 25) { 
            estado= true;
            }
            else if(edad <25)
            {
                estado=false;
            }
            return estado;
        }
    }
}
