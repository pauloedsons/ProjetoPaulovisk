using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caelum2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros = 0;
            for (int i = 0; i < 100; i++)
            {
                numeros += 1;
                if (numeros % 3 == 0)
                {
                    Console.WriteLine("Numeros "+ numeros);
                }
            }
            

            Console.ReadKey();


        }
    }
}
