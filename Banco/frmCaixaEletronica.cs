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
    public partial class frmCaixaEletronica : Form
    {
        Conta conta = new Conta();
        public frmCaixaEletronica()
        {
            InitializeComponent();
            conta.LimiteCredito = 1000; // Definindo o limite de crédito da conta
            conta.Saldo = 5000; // Inicializando o saldo da conta   
            lblSaldo.Text = conta.Saldo.ToString("C"); // Exibindo o saldo formatado
            AtualizaSaldoLimite();
        }

        private void AtualizaSaldoLimite()  
        {
            numLimiteCredito.Value = conta.LimiteCredito; // Atualizando o limite de crédito no NumericUpDown
            lblSaldo.Text = conta.Saldo.ToString("C"); // Exibindo o saldo formatado
            lblSaldoLimite.Text = (conta.Saldo + conta.LimiteCredito).ToString("C"); // Exibindo o limite formatado
        }
        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                conta.Sacar(numValorSaque.Value);
                AtualizaSaldoLimite();
                lblSaldo.Text = conta.Saldo.ToString("C"); // Exibindo o saldo formatado    
                MessageBox.Show("Saque realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar saque! " + "\n\nMais detalhes:" + ex.Message, "Erro ao sacar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            conta.Depositar(numValorDeposito.Value);
            lblSaldo.Text = conta.Saldo.ToString("C"); // Exibindo o saldo formatado
            AtualizaSaldoLimite();
            MessageBox.Show("Depósito realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numLimiteCredito_Validating(object sender, CancelEventArgs e)
        {
            conta.LimiteCredito = numLimiteCredito.Value; // Atualizando o limite de crédito
            AtualizaSaldoLimite();
        }

        
        
    }
}