using System.Data;
using System.Data.SqlClient;

namespace Desafio1_GroupSoftware
{
    public partial class TelaLogin : Form
    {

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
                if (txt_User.Text.Equals("group") && txt_Password.Text.Equals("admin"))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User ou senha estão errados!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_User.Focus();
                    txt_Password.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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