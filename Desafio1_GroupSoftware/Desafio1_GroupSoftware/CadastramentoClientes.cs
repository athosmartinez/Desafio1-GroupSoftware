using Desafio1_GroupSoftware.Funcoes;
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

        private void label_Tipo_Click(object sender, EventArgs e)
        {

        }

        private void label_Endereco_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!radio_CNPJ.Checked && !radio_CPF.Checked)
            {
                MessageBox.Show("SELECIONE O TIPO DE DOCUMENTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radio_CNPJ.Checked && !Util.ValidarCNPJ(maskText_Documento.Text))
            {
                MessageBox.Show("CNPJ Inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radio_CNPJ.Checked && Util.ValidarCNPJ(maskText_Documento.Text))
            {
                MessageBox.Show("OK!");
            }
            else if (radio_CPF.Checked && !Util.ValidarCPF(maskText_Documento.Text))
            {
                MessageBox.Show("CPF Inválido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radio_CPF.Checked && Util.ValidarCPF(maskText_Documento.Text))
            {
                MessageBox.Show("OK");
            }
        }

        private void label_Doc_Click(object sender, EventArgs e)
        {

        }

        private void maskText_Telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mask_telefone.Select(0, 0);
        }

        private void maskText_Documento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskText_Documento.Select(0, 0);
        }

        private void radio_CNPJ_CheckedChanged(object sender, EventArgs e)
        {
            MudouCNPJCPF();
        }


        private void radio_CPF_CheckedChanged(object sender, EventArgs e)
        {
            MudouCNPJCPF();
        }

        private void groupBox_Form_Enter(object sender, EventArgs e)
        {

        }
        private void MudouCNPJCPF()
        {
            if (radio_CNPJ.Checked)
            {
                label_Doc.Text = "CPNJ: ";
                maskText_Documento.Mask = "00,000,000/0000-00";
                maskText_Documento.Text = "";
            }
            else if (radio_CPF.Checked)
            {
                label_Doc.Text = "CPF: ";
                maskText_Documento.Mask = "000,000,000-00";
                maskText_Documento.Text = "";
            }
            else
            {
                label_Doc.Text = "Documento: ";
                maskText_Documento.Mask = "";
                maskText_Documento.Text = "";
            }
        }
    }
}
