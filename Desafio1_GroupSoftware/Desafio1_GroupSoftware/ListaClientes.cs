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

        private void button_Exportar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter a conexão com o banco de dados
                string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consultar os dados do usuário logado
                    string query = "SELECT * FROM clientes WHERE usuarioID = @usuarioID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuarioID", Util.UserID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Criar o objeto SaveFileDialog para escolher o local e nome do arquivo Excel
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Arquivo Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Salvar Banco de Dados do Usuário";
                    saveFileDialog.FileName = "Banco de dados_" + Util.UserID + "_" + Util.UserName;

                    // Verificar se o usuário selecionou um local e nome de arquivo válido
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Criar o arquivo Excel usando o EPPlus
                        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                        using (ExcelPackage package = new ExcelPackage(excelFile))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Banco de Dados");

                            // Preencher as células com os dados da tabela
                            for (int col = 0; col < dataTable.Columns.Count; col++)
                            {
                                worksheet.Cells[1, col + 1].Value = dataTable.Columns[col].ColumnName;
                            }

                            for (int row = 0; row < dataTable.Rows.Count; row++)
                            {
                                for (int col = 0; col < dataTable.Columns.Count; col++)
                                {
                                    worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col];
                                }
                            }

                            // Salvar o arquivo Excel
                            package.Save();
                        }

                        MessageBox.Show("Banco de dados exportado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
