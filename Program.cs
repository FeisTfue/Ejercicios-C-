using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso oProceso = new Proceso();
            
            Console.WriteLine("Contando IMPARES desde un hilo: ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Thread HiloImpar = new Thread(oProceso.ContarNumerosImpares);
            HiloImpar.IsBackground = true;
            HiloImpar.Start();
            HiloImpar.Join();

            Console.ReadLine();
        }
    }
    class Proceso
    {
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
