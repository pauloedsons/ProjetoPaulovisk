using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaelumConta2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaPaulo = new Conta();
            contaPaulo.saldo = 1000.0;
            contaPaulo.titular = "Paulo Edson";
            contaPaulo.numero = 22;

            MessageBox.Show(contaPaulo.titular);
        }
    }
}
