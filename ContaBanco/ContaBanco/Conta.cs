using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
      class Conta
    {
        // variavel do tipo 'Cliente' referencia a classe cliente
        //com nome de 'titular'


        public Cliente titular;

        static void Main(string[] args)
        {



            // instanciando um objeto do tipo cliente 
            //com nome de vistor

            Cliente victor = new Cliente();

            //instanciando o objeto de nome 'victor'
            //passando valor a variavel 'nome'.

            victor.nome = "victor";

            //criando um objeto de nome 'umaConta'. Instanciando
            Conta umaConta = new Conta();

            // atribuindo um titular a um objeto 
            //de nome'umaConta' com valor 'vistor'

            umaConta.titular = victor;

            umaConta.titular.rg = "12345678-9";




              //teste
             Console.WriteLine("veja:" + umaConta.titular.nome);
            Console.WriteLine("veja o RG:"+ victor.rg) ;

           

            Console.ReadKey();
        }




}
}
