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
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }

        private void text_NovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Confirma_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Voltar_Click(sender, e);
            }
        }

        private void text_ConfirmeSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Confirma_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Voltar_Click(sender, e);
            }
        }

        private void button_Confirma_Click(object sender, EventArgs e)
        {
            string code = text_User.Text;
            string novaSenha = text_NovaSenha.Text;
            if (text_NovaSenha.Text != text_ConfirmeSenha.Text)
            {
                MessageBox.Show("SENHAS DEVEM SER IGUAIS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(text_NovaSenha.Text))
            {
                MessageBox.Show("A senha não pode estar vazia.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (text_NovaSenha.Text.Contains(" "))
            {
                MessageBox.Show("A senha não pode conter espaços em branco.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(code))
            {
                Util.AlterarSenha(code, novaSenha);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado no banco de dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_ConfirmeSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_NovaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Confirma_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Voltar_Click(sender, e);
            }
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
            {
                text_NovaSenha.UseSystemPasswordChar = false;
                text_ConfirmeSenha.UseSystemPasswordChar = false;
            }
            else
            {
                text_NovaSenha.UseSystemPasswordChar = true;
                text_ConfirmeSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
