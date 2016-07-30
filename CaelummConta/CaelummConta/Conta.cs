using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelummConta
{
    class Conta{

        public string nomeDoTitular;
        public double saldoDaConta;
        public int numeroDaConta;
        

        public void Deposita(double valor)
        {
            saldoDaConta += valor;


        }
        public bool Saca(double valor)
        { 
           if(saldoDaConta >= valor)
            {
                saldoDaConta -= valor;

            }
        }
          public void Transfere(double valor, Conta destino )
        {



            if ( this.Saca(valor))
            {
                destino.Deposita(valor);
            }

        }
    }
}
