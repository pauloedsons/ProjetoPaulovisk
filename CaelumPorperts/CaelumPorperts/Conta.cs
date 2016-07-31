using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumPorperts
{

    // Transforme os atributos da classe Conta em propriedades. 
    //Permita que o saldo da conta seja lido,porém 
    //não seja alterado fora da classe, altere também o código das classes 
    //que utilizam a conta para que elas acessem 
    //as propriedades ao invés dos atributos diretamente.


    class Conta
    {
        private int numero = 20;
        private int saldo = 53;
                      
       // propriedade 'Numero'

        public int Numero
        {
            get
            {

                return this.numero;

            }
            set
            {

            }
             
        }
        //propriedade 'Saldo'

        public int Saldo
        {
            get
            {

                return this.saldo;

            }
            private set
            {

            } 

        } 
 
        

        //metodo para ler a propriedade

        public void MetodoParaLeitura()
        {
            Conta c = new Conta(); 

            Console.WriteLine("resultado:" +  c.Numero);

            Console.WriteLine("resultado:" + c.Saldo);


        }


    }
}
