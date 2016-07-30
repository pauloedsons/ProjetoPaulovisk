using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaelummConta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conta paulo = new Conta();
            paulo.nomeDoTitular = "PauloEdson";
            paulo.saldoDaConta = 12000.0;
            paulo.numeroDaConta = 1;

            paulo.Saca(2000.0);
            MessageBox.Show("Saldo:" + paulo.saldoDaConta);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta luiz = new Conta();
            luiz.nomeDoTitular = "Luiz Paulo";
            luiz.saldoDaConta = 12000.0;
            luiz.numeroDaConta = 1;

            luiz.Saca(1000.0);
            MessageBox.Show("Saldo:" + luiz.saldoDaConta);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta paulo = new Conta();
            Conta luiz = new Conta();

            paulo.Transfere(100.0,  this.luiz.saldoDaConta);

        MessageBox.Show("Saldo da transferencia:" + paulo.saldoDaConta);

        }
    }
}
