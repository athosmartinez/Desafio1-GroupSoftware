using Desafio1_GroupSoftware.Funcoes;
using System.Data.SqlClient;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Desafio1_GroupSoftware
{
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void text_CrieUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_CrieSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_ConfirmeSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
            {
                text_CrieSenha.UseSystemPasswordChar = false;
                text_ConfirmeSenha.UseSystemPasswordChar = false;
            }
            else
            {
                text_CrieSenha.UseSystemPasswordChar = true;
                text_ConfirmeSenha.UseSystemPasswordChar = true;
            }
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            string username = text_CrieUser.Text;
            string senhaCriptografada = BCryptNet.HashPassword(text_CrieSenha.Text);
            string email = txt_Email.Text;

            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            if (text_CrieSenha.Text != text_ConfirmeSenha.Text)
            {
                MessageBox.Show("SENHAS DEVEM SER IGUAIS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(text_CrieSenha.Text))
            {
                MessageBox.Show("A senha não pode estar vazia.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (text_CrieSenha.Text.Contains(" "))
            {
                MessageBox.Show("A senha não pode conter espaços em branco.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(text_CrieUser.Text) || string.IsNullOrEmpty(text_ConfirmeSenha.Text))
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Util.AdicionarNovoUsuario(username, senhaCriptografada, email);
                this.Close();

            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_CrieUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Salvar_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Cancelar_Click(sender, e);
            }
        }

        private void text_CrieSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Salvar_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Cancelar_Click(sender, e);
            }
        }

        private void text_ConfirmeSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Salvar_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Cancelar_Click(sender, e);
            }
        }

        private void NovoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Salvar_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Cancelar_Click(sender, e);
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
