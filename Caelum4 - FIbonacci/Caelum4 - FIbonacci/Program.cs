using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum4___FIbonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacci = 0;

            for(int i = 1; i < 100; i++)
            {
                i +=1;

                fibonacci *= i ;
               

                Console.WriteLine("Fibonacci:"+fibonacci);
          }
            Console.ReadKey();
        }
    }
}
