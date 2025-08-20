using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class frmCaixaEletronico : Form
    {
        Conta conta = new Conta();

        public frmCaixaEletronico()
        {
            InitializeComponent();
            conta.saldo = 5000;
            lblSaldo.Text = conta.saldo.ToString("C2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conta
        }
    }
}
