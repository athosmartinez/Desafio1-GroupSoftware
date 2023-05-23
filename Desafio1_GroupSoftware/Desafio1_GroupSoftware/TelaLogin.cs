namespace Desafio1_GroupSoftware
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            this.KeyPress += TelaLogin_KeyPress; // Associa o evento KeyPress ao método TelaLogin_KeyPress

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
            Application.Exit();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_User.Text.Equals("group") && txt_Password.Text.Equals("admin"))
                {

                    /*var cadastramento_clientes = new CadastramentoClientes();
                    cadastramento_clientes.Show();
                    frmPrincipal frmPrincipal = new frmPrincipal();
                    frmPrincipal.Show();
                    this.Close();
                    //this.Visible = false;*/
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Password", "Failed Acess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_User.Focus();
                    txt_Password.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TelaLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Indica que o evento de tecla foi tratado para evitar que o caractere Enter seja inserido em controles de texto
                button_Enter.PerformClick(); // Chame o método PerformClick do botão para executar a mesma função
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
    }
}