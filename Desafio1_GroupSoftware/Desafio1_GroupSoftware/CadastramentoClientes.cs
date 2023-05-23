using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_GroupSoftware
{
    public partial class CadastramentoClientes : Form
    {
        public CadastramentoClientes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkbox_cpf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_cpf.Checked)
            {
                checkbox_cnpj.Checked = false;
       
                label7.Text = "CPF: ";
                maskedTextBox1.Mask = "000,000,000-00";

            }
            else if (!checkbox_cnpj.Checked || !checkbox_cpf.Checked)
            {
                label7.Text = "Documento: ";
                maskedTextBox1.Mask = "";
                maskedTextBox1.Text = "";

            }
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_cnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_cnpj.Checked)
            {
                checkbox_cpf.Checked = false;

                label7.Text = "CPNJ: ";
                maskedTextBox1.Mask = "00,000,000/0000-00";
            }
            else if (!checkbox_cnpj.Checked || !checkbox_cpf.Checked)
            {
                label7.Text = "Documento: ";
                maskedTextBox1.Mask = "";
                maskedTextBox1.Text = "";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            var tela_login = new TelaLogin();
            tela_login.Show();
            this.Visible = false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void mask_telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mask_telefone.Select(0, 0);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.Select(0, 0);
        }
    }
}
