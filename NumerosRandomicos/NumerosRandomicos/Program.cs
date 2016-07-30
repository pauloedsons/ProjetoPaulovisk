using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRandomicos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criar um objeto aleatório
            // Random rnd = new Random ();
            // Criar um objeto aleatório com uma semente com um grau de pseudoaleatória

            Random rnd = new Random(DateTime.Now.Millisecond);


            Console.WriteLine("-----------------------------------");

            // Gerando um número aleatório qualquer
            Console.WriteLine(rnd.Next().ToString());

            Console.WriteLine("-----------------------------------");

            for (int i = 0; i <= 5; i++) {


                // Gerando um número aleatório
                //entre 00 e 61 (não inclui o ultimo valor [100])
            Console.WriteLine(rnd.Next(00, 61).ToString());


            }

            Console.WriteLine("-----------------------------------");

            // Gerando um número aleátório entre 0 e 100
            Console.WriteLine(rnd.Next(100).ToString());

            Console.WriteLine("-----------------------------------");


            // Aguarda até que uma tecla seja pressionada
            Console.ReadKey();




        }
    }
}
