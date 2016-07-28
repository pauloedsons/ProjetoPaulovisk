using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCaelum1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaDoPaulo = new Conta();

            contaDoPaulo.nomeDoTitular = " Paulo Edson";

            contaDoPaulo.saldo = 5000.00;
            contaDoPaulo.saldo.Saca(50);
            MessageBox.Show(" saldo: " + contaDoPaulo.saldo);


            MessageBox.Show(contaDoPaulo.nomeDoTitular+contaDoPaulo.saldo);
              
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Conta saldoTotalDasContas = new Conta();
            saldoTotalDasContas.saldo = 0;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta contaDaMina = new Conta();

            contaDaMina.numeroDaConta = 23;

            contaDaMina.nomeDoTitular = "MINA";

            contaDaMina.saldo = 10000.00;
        }
    }
}
