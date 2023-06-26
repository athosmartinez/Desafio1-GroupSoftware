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
    public partial class EditarDadosCliente : Form
    {
        public EditarDadosCliente()
        {
            InitializeComponent();
            txt_nome.Text = Classes.DadosClienteLista.Nome;
            txt_Endereco.Text = Classes.DadosClienteLista.Endereco;
            mask_telefone.Text = Classes.DadosClienteLista.Telefone;
            txt_email.Text = Classes.DadosClienteLista.Email;
            text_Documento.Text = Classes.DadosClienteLista.Documento;

            // Desabilitar o RadioButton
            radio_CNPJ.Enabled = false;
            radio_CPF.Enabled = false;
            // Tornar os TextBox somente leitura
            txt_nome.Enabled = false;
            text_Documento.Enabled = false;



        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskText_Documento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            text_Documento.Select(0, 0);
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void mask_telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mask_telefone.Select(0, 0);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!radio_CNPJ.Checked && !radio_CPF.Checked)
            {
                MessageBox.Show("SELECIONE O TIPO DE DOCUMENTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radio_CNPJ.Checked && !Util.ValidarCNPJ(text_Documento.Text))
            {
                MessageBox.Show("CNPJ Inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radio_CPF.Checked && !Util.ValidarCPF(text_Documento.Text))
            {
                MessageBox.Show("CPF Inválido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(txt_nome.Text.Trim()) ||
                     string.IsNullOrEmpty(txt_Endereco.Text.Trim()) ||
                     string.IsNullOrEmpty(text_Documento.Text.Replace("_", "").Trim()) ||
                     string.IsNullOrEmpty(mask_telefone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim()) ||
                     string.IsNullOrEmpty(text_Documento.Text.Replace("_", "").Trim()) ||
                     mask_telefone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length < 11 ||
                     string.IsNullOrEmpty(txt_email.Text.Trim()))
            {
                MessageBox.Show("PREENCHA TODOS OS DADOS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((radio_CNPJ.Checked && Util.ValidarCNPJ(text_Documento.Text)) ||
                     (radio_CPF.Checked && Util.ValidarCPF(text_Documento.Text)))
            {
                // Obtenha os valores dos campos de entrada
                string nome = txt_nome.Text;
                string email = txt_email.Text;
                string endereco = txt_Endereco.Text;
                string documento = text_Documento.Text;
                string telefone = mask_telefone.Text;
                int usuarioID = Util.UserID;

                // Verifique se o cliente já existe para o usuário atual
                if (Util.VerificarClienteExistente(nome, documento, usuarioID))
                {
                    // Atualize os dados do cliente
                    Util.AtualizarDadosCliente(nome, email, endereco, documento, telefone, usuarioID);
                }
                else
                {
                    // Adicione um novo cliente
                    Util.InserirDadosCliente(nome, email, endereco, documento, telefone, usuarioID);
                }
            }
        }

        private void EditarDadosCliente_Load(object sender, EventArgs e)
        {
            if (text_Documento.Text.Length == 14)
            {
                radio_CPF.Checked = true;
                radio_CNPJ.Checked = false;
            }
            else if (text_Documento.Text.Length == 18)
            {
                radio_CPF.Checked = false;
                radio_CNPJ.Checked = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja deletar o cliente?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                // Obtém os valores dos campos relevantes
                string nome = txt_nome.Text;
                string endereco = txt_Endereco.Text;
                string documento = Classes.DadosClienteLista.Documento;
                string email = txt_email.Text;
                string telefone = mask_telefone.Text;
                int usuarioID = Util.UserID;

                // Chama a função para deletar o cliente
                Util.DeletarCliente(nome, endereco, documento, email, telefone, usuarioID);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
