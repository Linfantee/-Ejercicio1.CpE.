using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.CpE.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirNumero()
        {
            int valor;
            Console.WriteLine("Introduzca los valores de los números enteros:");
            Console.WriteLine("Introduzca el primer número:");
            valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número:");
            valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer número:");
            valor = Convert.ToInt32(Console.ReadLine());
            
            return valor;
        }
    }
}
