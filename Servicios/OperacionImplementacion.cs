using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.CpE.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public float operacion()
        {
            //multiplicación y división, aunque sean números enteros ponemos float por si la división da decimales.
            Console.WriteLine("Introduzca los valores de los números enteros:");
            Console.WriteLine("Introduzca el primer número:");
            float y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número:");
            float x = Convert.ToInt32(Console.ReadLine());
            float multiplicacion = y * x;
            Console.WriteLine("Introduzca el tercer número:");
            float z = Convert.ToInt32(Console.ReadLine());
            float division = multiplicacion / z;
            Console.WriteLine("El resultado de " + y + " multiplicado por  " + x + " y dividido por " + z + " es igual a: " + division);

            //ordenamos por orden descendente el valor de la división
            string aux = "";
            int resultado = Convert.ToInt32(division);

            for (int i = resultado; i >= 1; i--)
            {
                aux = aux + i;
                Console.WriteLine(aux);
            }
            return division;

        }



    }
}
