using Ejercicio1.CpE.Servicios;

namespace Ejercicio1.CpE
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Variables

            int valor;
            string num;
            int x = 1;
            int y = 1;
            int z = 1;

            //Creación de objetos
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();
            //Guardamos el valor a través de los métodos
            valor = mi.pedirNumero();
            oi.operacion(x,y,z);
            num = oi.descendente(valor);
        }

    }

}
