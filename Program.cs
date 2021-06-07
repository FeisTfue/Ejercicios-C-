using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso oProceso = new Proceso();

            Console.WriteLine("Lanzando los dos hilos al mismo tiempo: ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Thread nuevoHiloPar = new Thread(oProceso.ContarNumerosPares);
            Thread nuevoHiloImpar = new Thread(oProceso.ContarNumerosImpares);

            nuevoHiloPar.Start();
            nuevoHiloImpar.Start();

            Console.ReadLine();
        }
    }
    class Proceso
    {
        public void ContarNumerosPares()
        {
            for (int numero = 0; numero <= 100; numero = numero + 2)
            {
                Console.Write(numero + " ");
                for (int GranContador = 0; GranContador <= 20000000; GranContador++) ;
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public void ContarNumerosImpares()
        {
            for (int numero = 1; numero <= 100; numero = numero + 2)
            {
                Console.Write(numero + " ");
                for (int GranContador = 0; GranContador <= 20000000; GranContador++) ;
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
