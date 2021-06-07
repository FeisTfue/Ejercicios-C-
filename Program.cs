using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso oProceso = new Proceso();

            Console.WriteLine("Contando los numeros primos menores a 20: ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Thread HiloPrimo = new Thread(oProceso.ContarPrimos);
            HiloPrimo.IsBackground = true;
            HiloPrimo.Start();
            HiloPrimo.Join();

            Console.ReadLine();
        }
    }
    class Proceso
    {
        public void ContarPrimos()
        {
            int c = 0;
            for (int numero = 1; numero <= 20; numero++)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (numero % i == 0)
                    {
                        c = c + 1;
                    }
                }
                if (c==2)
                {
                    Console.Write(numero);
                    Console.WriteLine();
                }
                c = 0;
            }

            Console.WriteLine();
        }
    }
}
