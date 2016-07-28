using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCaelum1
{
    class Conta
    {

        public string nomeDoTitular;
        public double saldo;
        public int numeroDaConta;


        // metodo para depositar
        public void Deposita(double valor)
        {
            //objeto (saldo) recebe do paramentro valor
            // metodo para depositar 

            saldo += valor;

        }

        // metodo para sacar 
        public void Saca(double valor, double saldo)
        {

            //verifica a condicao, se objeto saldo >= valor 
            //se condicao for aceita, o paramentro valor
            //recebe ele mesmo em negativo

            if (this.saldo >= valor)
            {
                valor -= saldo;
            }
        }
        //metodo para transferir 
        public void Transfere(double valor, double destino)
        {

            //verifica a condicao se o metodo saca ocorre,. 
            //se ocorrer o parametro destino chama o metodo Deposita
            //com o parametro de valor nele
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }

        }


      }

    }
