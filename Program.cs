using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso oProceso = new Proceso();

            Console.WriteLine("Contando PARES desde un hilo: ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Thread HiloPar = new Thread(oProceso.ContarNumerosPares);
            HiloPar.IsBackground = true;
            HiloPar.Start();
            HiloPar.Join();

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
    }
}
