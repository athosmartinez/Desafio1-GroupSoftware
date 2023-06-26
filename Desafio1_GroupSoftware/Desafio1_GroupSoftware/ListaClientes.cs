using System.Data;
using Desafio1_GroupSoftware.Funcoes;
using System.Data.SqlClient;
using OfficeOpenXml;
using System.Windows.Forms;


namespace Desafio1_GroupSoftware
{
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Pesquisa_Click(object sender, EventArgs e)
        {

            string termoPesquisa = txt_Pesquisa.Text.ToLower(); // Obter o termo de pesquisa em letras minúsculas
            DataTable lista_clientes_filtrados = Util.ConsultarClientesFiltrados(txt_Pesquisa.Text);
            dataGrid_Clientes.DataSource = lista_clientes_filtrados;

        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Pesquisa_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                button_Voltar_Click(sender, e);
            }
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void ListaClientes_Shown(object sender, EventArgs e)
        {
            DataTable lista_clientes = Util.ConsultarDadosClientes();
            dataGrid_Clientes.DataSource = lista_clientes;
            int numeroID = Util.UserID;
            string numeroIDString = numeroID.ToString();
            label_ActiveUser.Text = "TABELA: " + Util.UserName.ToUpper() + " - " + numeroIDString;
        }

        private void dataGrid_Clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid_Clientes.Rows[e.RowIndex];
                string nome = row.Cells["nomeDataGridViewTextBoxColumn"].Value.ToString();
                string email = row.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
                string endereco = row.Cells["Endereço"].Value.ToString();
                string documento = row.Cells["documentoDataGridViewTextBoxColumn"].Value.ToString();
                string telefone = row.Cells["telefoneDataGridViewTextBoxColumn"].Value.ToString();
                int numeroID = Util.UserID;
                // Salve os dados em algum lugar para uso posterior, como em variáveis ou em uma classe estática.
                // Exemplo:
                Classes.DadosClienteLista.Nome = nome;
                Classes.DadosClienteLista.Email = email;
                Classes.DadosClienteLista.Endereco = endereco;
                Classes.DadosClienteLista.Documento = documento;
                Classes.DadosClienteLista.Telefone = telefone;
                Classes.DadosClienteLista.UserID = numeroID;
                EditarDadosCliente editarDados = new EditarDadosCliente();
                editarDados.ShowDialog();
                AtualizarTabela();
            }
        }

        private void AtualizarTabela()
        {
            DataTable lista_clientes = Util.ConsultarDadosClientes();
            dataGrid_Clientes.DataSource = lista_clientes;
        }
        private void button_Exportar_Click(object sender, EventArgs e)
        {
            Util.ExportarBanco();
        }

        private void button_Importar_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Verificar se o usuário selecionou um arquivo válido
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                // Importar os dados do cliente
                Util.ImportarDadosDoExcel(filePath);
            }
            AtualizarTabela();
        }

        private void dataGrid_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
