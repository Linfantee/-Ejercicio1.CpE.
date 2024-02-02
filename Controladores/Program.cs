using Ejercicio1.CpE.Servicios;

namespace Ejercicio1.CpE
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            //Creación de objetos 
            OperacionInterfaz oi = new OperacionImplementacion();
            //Guardamos el valor a través de los métodos 
            oi.operacion();
       
        }

    }

}
