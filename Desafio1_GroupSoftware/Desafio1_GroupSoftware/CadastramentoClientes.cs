using Desafio1_GroupSoftware.Funcoes;


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
            else if (radio_CPF.Checked && !Util.ValidarCPF(maskText_Documento.Text))
            {
                MessageBox.Show("CPF Inválido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(txt_nome.Text.Trim()) ||
           string.IsNullOrEmpty(txt_Endereco.Text.Trim()) ||
           string.IsNullOrEmpty(maskText_Documento.Text.Replace("_", "").Trim()) ||
           string.IsNullOrEmpty(mask_telefone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim()) ||
           string.IsNullOrEmpty(maskText_Documento.Text.Replace("_", "").Trim()) ||
           mask_telefone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length < 11 ||
           string.IsNullOrEmpty(txt_email.Text.Trim()))
            {
                MessageBox.Show("PREENCHA TODOS OS DADOS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((radio_CNPJ.Checked && Util.ValidarCNPJ(maskText_Documento.Text)) ||
               (radio_CPF.Checked && Util.ValidarCPF(maskText_Documento.Text)))
            {
                // Obtenha os valores dos campos de entrada
                string nome = txt_nome.Text;
                string email = txt_email.Text;
                string endereco = txt_Endereco.Text;
                string documento = maskText_Documento.Text;
                string telefone = mask_telefone.Text;
                int usuarioID = Util.UserID;

                // Chame o método para inserir os dados na tabela
                Util.InserirDadosCliente(nome, email, endereco, documento, telefone, usuarioID);
                
                //Depois de salvar, limpa os campos
                txt_nome.Text = "";
                txt_email.Text = "";
                txt_Endereco.Text = "";
                maskText_Documento.Text = "";
                mask_telefone.Text = "";

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
                maskText_Documento.Mask = "00.000.000/0000-00";
                maskText_Documento.Text = "";
            }
            else if (radio_CPF.Checked)
            {
                label_Doc.Text = "CPF: ";
                maskText_Documento.Mask = "000.000.000-00";
                maskText_Documento.Text = "";
            }
            else
            {
                label_Doc.Text = "Documento: ";
                maskText_Documento.Mask = "";
                maskText_Documento.Text = "";
            }
        }

        private void button_save_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CadastramentoClientes_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Save_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Exit_Click(sender, e);
            }
        }

        private void txt_Endereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Save_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Exit_Click(sender, e);
            }
        }

        private void maskText_Documento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Save_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Exit_Click(sender, e);
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Save_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Exit_Click(sender, e);
            }
        }

        private void mask_telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Save_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Exit_Click(sender, e);
            }
        }
    }
}
