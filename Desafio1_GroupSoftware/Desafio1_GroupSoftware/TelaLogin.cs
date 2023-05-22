namespace Desafio1_GroupSoftware
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                if (txt_user.Text.Equals("group") && txt_password.Text.Equals("admin"))
                {
                    
                    var cadastramento_clientes = new CadastramentoClientes();
                    cadastramento_clientes.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Wrong Password", "Failed Acess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_user.Focus();
                    txt_password.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkBox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpass.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
    }
}