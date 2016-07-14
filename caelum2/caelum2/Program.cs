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
            int soma =0;

            for ( int i = 0; i <100; i++)
            {

                soma = soma + 1;
                
                Console.WriteLine("Numero:"  + soma);
            }
            Console.ReadKey();


        }
    }
}
