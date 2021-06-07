using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso oProceso = new Proceso();

            Console.WriteLine("Sumando los numeros del 1 al 10");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Thread Suma = new Thread(oProceso.SumaNumeros);
            Suma.IsBackground = true;
            Suma.Start();
            Suma.Join();

            Console.ReadLine();
        }
    }
    class Proceso
    {
        public void SumaNumeros()
        {
            int sumaw = 0;
            for (int numero = 1; numero <= 10; numero++)
            {
                Console.Write(numero + " + ");
                sumaw = sumaw + numero;
                for (int GranContador = 0; GranContador <= 20000000; GranContador++);
            }
            
            Console.WriteLine();
            Console.WriteLine("La suma es: "+sumaw);

            Console.WriteLine();
        }
    }
}
