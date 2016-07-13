using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.0;
            int i = 1;
            while (i <= 12) {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
                Console.WriteLine("Valor investido agora é " + valorInvestido);
            }
            

            Console.ReadKey();

        }
    }
}
