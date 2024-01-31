using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.CpE.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void operacion(int y, int x, int z)
        {

            int multiplicacion = y * x;
           int division = z / multiplicacion;
            Console.WriteLine("El resultado de " + y + " multiplicado por  " + x + " y dividido por " + z + " es igual a:" + division );
        }

        public string descendente(int valor)
        {
            string aux = "";

            for (int i = 1; i <= valor; i++)
            {
                aux = aux + i;
                Console.WriteLine(aux);
            }
            return aux;
        }

    }
}
