using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apostila_uniesp
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

    

        static void Main(string[] args)
        {
             

            Conta c = new Conta();

            c.numero = 1;
            c.titular = "Paulovisk";
            c.saldo = 150.0;


           

            Console.ReadKey();

        }
         public void  Saca()
        {
            if(this.saldo == 150.0)
            {
                this.saldo -= 50.0;
                Console.WriteLine("resultado:" + this.saldo);


            }


        }
    }
}
