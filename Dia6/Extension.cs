using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6
{
    public static class Extension
    {
        public static string MitadPrimera(this string cadena)
        {
            return cadena.Substring(0, cadena.Length / 2);
        }

        public static string MitadSegunda(this string cadena)
        {
            return cadena.Substring(cadena.Length / 2, cadena.Length / 2);
        }
        public static void Imprimir<T>(this List<T> lista)
        {
            foreach (var elemento in lista)
                Console.Write("{0} ", elemento);
        }
        public static void ComprobarEdad(this int edad)
        {
            if (edad >= 18)
            {
                Console.WriteLine("Mayor de edad");
            }
            else
            {
                Console.WriteLine("Menor de edad");
            }
        }
        public static void enteros(this int nro,int nro2)
        {
            Console.WriteLine("El valor es: ", nro+nro2);
        }
        public static void centavos(this double nro)
        {
            Console.WriteLine("El valor es: '{0,5:###.###}'", nro);
        }
    }
}
