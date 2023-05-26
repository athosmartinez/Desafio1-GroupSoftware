using Desafio1_GroupSoftware.Funcoes;
using System.Data;
using System.Data.SqlClient;

namespace Desafio1_GroupSoftware
{
    public partial class TelaLogin : Form
    {
        string connectionString = "Data Source=group-note02312;Initial Catalog=clientes;User ID=SA;Password=Admin@123";

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label_User_Click(object sender, EventArgs e)
        {

        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Password_Click(object sender, EventArgs e)
        {
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            Application.Exit();

        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_User.Text;
                string password = txt_Password.Text;
                bool loginSucesso = Util.VerificarLogin(username, password);
                if (loginSucesso)
                {
                    int usuarioID = Util.ObterIDUsuarioLogado(username);
                    Util.UserID = usuarioID;
                    if (usuarioID != -1)
                    {

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao obter o ID do usuário logado!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha estão incorretos!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_User.Focus();
                    txt_Password.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Acesso negado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkBox_Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Showpass.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suprimir o som de "beep" ao pressionar Enter
                button_Enter_Click(sender, e); // Chamar o evento de clique do botão de pesquisa
            }
        }

        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suprimir o som de "beep" ao pressionar Enter
                button_Enter_Click(sender, e); // Chamar o evento de clique do botão de pesquisa
            }
        }
    }
}