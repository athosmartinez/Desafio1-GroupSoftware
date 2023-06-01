using OfficeOpenXml;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms.VisualStyles;
using BCryptNet = BCrypt.Net.BCrypt;


namespace Desafio1_GroupSoftware.Funcoes
{
    public static class Util
    {
        //VALIDAÇÕES DADOS
        public static string SomenteNumeros(this string s)
        {
            return string.Join("", System.Text.RegularExpressions.Regex.Split(s, @"[^\d]"));
        }
        private static bool TodosDigitosIguaisCnpj(string cnpj)
        {
            for (int i = 1; i < cnpj.Length; i++)
            {
                if (cnpj[i] != cnpj[0])
                    return false;
            }
            return true;
        }
        private static bool TodosDigitosIguaisCpf(string cpf)
        {
            for (int i = 1; i < cpf.Length; i++)
            {
                if (cpf[i] != cpf[0])
                    return false;
            }
            return true;
        }

        public static bool ValidarCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim().SomenteNumeros();
            if (cnpj.Length != 14 || TodosDigitosIguaisCnpj(cnpj))
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }


        public static bool ValidarCPF(string cpf)
        {
            cpf = cpf.Trim().SomenteNumeros();
            if (cpf.Length != 11 || TodosDigitosIguaisCpf(cpf))
                return false;

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static string RemoverAcentos(string txtPesquisa)
        {
            string txtSemAcento = txtPesquisa.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in txtSemAcento)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }
        //INSERI DADOS NO BANCO
        public static void InserirDadosCliente(string nome, string email, string endereco, string documento, string telefone, int usuarioID)
        {
            try
            {
                string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Util.UserID = usuarioID;

                    // Verificar se o cliente já existe com base no nome, telefone e documento
                    string queryVerificacao = "SELECT COUNT(*) FROM clientes WHERE (nome = @nome OR documento = @documento) AND usuarioID = @usuarioID ";
                    SqlCommand commandVerificacao = new SqlCommand(queryVerificacao, connection);
                    commandVerificacao.Parameters.AddWithValue("@nome", nome);
                    commandVerificacao.Parameters.AddWithValue("@documento", documento);
                    commandVerificacao.Parameters.AddWithValue("@usuarioID", usuarioID);
                    int count = (int)commandVerificacao.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Cliente já existe no banco de dados. Verifique os campos NOME, DOCUMENTO para o seu usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Não realizar a inserção se o cliente já existe
                    }
                    // Inserir o cliente caso não exista
                    string queryInsercao = "INSERT INTO clientes (nome, email, endereco, documento, telefone, usuarioID, IDCliente) VALUES (@nome, @email, @endereco, @documento, @telefone, @usuarioID, @idcliente)";
                    SqlCommand commandInsercao = new SqlCommand(queryInsercao, connection);
                    commandInsercao.Parameters.AddWithValue("@nome", nome);
                    commandInsercao.Parameters.AddWithValue("@email", email);
                    commandInsercao.Parameters.AddWithValue("@endereco", endereco);
                    commandInsercao.Parameters.AddWithValue("@documento", documento);
                    commandInsercao.Parameters.AddWithValue("@telefone", telefone);
                    commandInsercao.Parameters.AddWithValue("@usuarioID", usuarioID);
                    commandInsercao.Parameters.AddWithValue("@idcliente", ObterProximoIdCliente());
                    commandInsercao.ExecuteNonQuery();
                    MessageBox.Show("Dados do cliente inseridos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados do cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool VerificarClienteExistente(string nome, string documento, int usuarioID)
        {
            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            string query = "SELECT COUNT(*) FROM clientes WHERE nome = @Nome AND documento = @Documento AND usuarioID = @UsuarioID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Documento", documento);
                command.Parameters.AddWithValue("@UsuarioID", usuarioID);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public static void AtualizarDadosCliente(string nome, string email, string endereco, string documento, string telefone, int usuarioID)
        {
            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            string queryVerificarExistencia = "SELECT COUNT(*) FROM clientes WHERE email = @Email AND endereco = @Endereco AND documento = @Documento AND telefone = @Telefone AND nome = @Nome AND usuarioID = @UsuarioID ";
            string queryAtualizar = "UPDATE clientes SET email = @Email, endereco = @Endereco, documento = @Documento, telefone = @Telefone WHERE nome = @Nome AND usuarioID = @UsuarioID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Verificar a existência de valores duplicados
                    SqlCommand verificarExistenciaCommand = new SqlCommand(queryVerificarExistencia, connection);
                    verificarExistenciaCommand.Parameters.AddWithValue("@Email", email);
                    verificarExistenciaCommand.Parameters.AddWithValue("@Endereco", endereco);
                    verificarExistenciaCommand.Parameters.AddWithValue("@Nome", nome);
                    verificarExistenciaCommand.Parameters.AddWithValue("@Telefone", telefone);
                    verificarExistenciaCommand.Parameters.AddWithValue("@Documento", documento);
                    verificarExistenciaCommand.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    int duplicadosCount = (int)verificarExistenciaCommand.ExecuteScalar();

                    if (duplicadosCount > 5)
                    {
                        MessageBox.Show("Falha ao atualizar os dados do cliente. Já existe um cliente com o mesmo DOCUMENTO, TELFONE ou NOME.");
                    }
                    else
                    {
                        // Atualizar os dados do cliente
                        SqlCommand atualizarCommand = new SqlCommand(queryAtualizar, connection);
                        atualizarCommand.Parameters.AddWithValue("@Email", email);
                        atualizarCommand.Parameters.AddWithValue("@Endereco", endereco);
                        atualizarCommand.Parameters.AddWithValue("@Nome", nome);
                        atualizarCommand.Parameters.AddWithValue("@Telefone", telefone);
                        atualizarCommand.Parameters.AddWithValue("@Documento", documento);
                        atualizarCommand.Parameters.AddWithValue("@UsuarioID", usuarioID);

                        int rowsAffected = atualizarCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dados do cliente atualizados com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao atualizar os dados do cliente.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do cliente: " + ex.Message);
            }
        }
        public static void DeletarCliente(string nome, string endereco, string documento, string email, string telefone, int usuarioID)
        {
            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            string query = "DELETE FROM clientes WHERE nome = @Nome AND endereco = @Endereco AND documento = @Documento AND email = @Email AND telefone = @Telefone AND usuarioID = @UsuarioID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Endereco", endereco);
                    command.Parameters.AddWithValue("@Documento", documento);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@UsuarioID", usuarioID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente deletado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao deletar o cliente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o cliente: " + ex.Message);
            }
        }

        //CONSULTAS NO BANCO
        public static DataTable ConsultarDadosClientes()
        {

            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            string query = "SELECT * FROM clientes WHERE usuarioID = @usuarioID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioID", Util.UserID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static DataTable ConsultarClientesFiltrados(string termoPesquisa)
        {
            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            string query = "SELECT * FROM clientes WHERE usuarioID = @usuarioID " +
                          "AND (LOWER(nome) LIKE @termoPesquisa OR " +
                          "LOWER(endereco) LIKE @termoPesquisa OR " +
                          "REPLACE(LOWER(documento), ',', '') LIKE @termoPesquisa OR " +
                          "LOWER(email) LIKE @termoPesquisa OR " +
                          "LOWER(telefone) LIKE @termoPesquisa)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioID", Util.UserID);
                command.Parameters.AddWithValue("@termoPesquisa", "%" + termoPesquisa.ToLower() + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        //LOGIN
        public static bool VerificarLogin(string username, string senha)
        {
            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT senha FROM usuarios WHERE username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                string encryptedPassword = command.ExecuteScalar()?.ToString();
                bool isPasswordCorrect = BCryptNet.Verify(senha, encryptedPassword);

                if (isPasswordCorrect)
                {
                    // A senha está correta, o login é bem-sucedido
                    return true;
                }
                else
                {
                    // A senha está incorreta
                    return false;
                }
            }
        }

        // Declare uma variável global para armazenar o ID do usuário logado
        public static int UserID { get; set; }
        public static string UserName { get; set; }

        public static int ObterIDUsuarioLogado(string username)
        {
            try
            {
                string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
                string query = "SELECT id FROM usuarios WHERE username = @username";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    UserName = username;
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        UserID = Convert.ToInt32(result);
                        return UserID;
                    }
                    else
                    {
                        return -1; // Usuário não encontrado
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter ID do usuário logado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public static int ObterProximoIdCliente()
        {
            try
            {
                string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
                string query = "  SELECT Max(IDCliente) + 1 FROM clientes WHERE usuarioID = @UsuarioID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UsuarioID", Util.UserID);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    { //se não encontrar um proximo ID - retorna 1 - primeiro
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro obter proximo ID disponivel: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public static void AdicionarNovoUsuario(string username, string senhaCriptografada)
        {
            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Verificar se o usuário já existe
                    string checkUserQuery = "SELECT COUNT(*) FROM usuarios WHERE username = @Username";
                    SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection);
                    checkUserCommand.Parameters.AddWithValue("@Username", username);

                    int userCount = (int)checkUserCommand.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Já existe um usuário com esse nome de usuário. Vá em ESQUECI MINHA SENHA a para redefinir a senha deste usuário!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Inserir o novo usuário
                        string insertQuery = "INSERT INTO usuarios (username, senha) VALUES (@Username, @Password)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@Username", username);
                        insertCommand.Parameters.AddWithValue("@Password", senhaCriptografada);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuário criado com sucesso!");

                        }
                        else
                        {
                            MessageBox.Show("Falha ao criar usuário.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir usuário no banco de dados: " + ex.Message);
            }
        }
        //ALTERA DADO NO BANCO
        public static void AlterarSenha(string username, string novaSenha)
        {
            string senhaCriptografada = BCryptNet.HashPassword(novaSenha);
            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Verificar se o usuário existe
                    string checkUserQuery = "SELECT COUNT(*) FROM usuarios WHERE username = @Username";
                    SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection);
                    checkUserCommand.Parameters.AddWithValue("@Username", username);
                    int userCount = (int)checkUserCommand.ExecuteScalar();

                    if (userCount > 0)
                    {
                        // Atualizar a senha do usuário
                        string updateQuery = "UPDATE usuarios SET senha = @Password WHERE username = @Username";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@Username", username);
                        updateCommand.Parameters.AddWithValue("@Password", senhaCriptografada);

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Senha alterada com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao alterar senha.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado no banco de dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar senha no banco de dados: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExportarBanco()
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
                    saveFileDialog.FileName = "Banco de dados-" + Util.UserID + "-" + Util.UserName;

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

        public static void ImportarDadosDoExcel(string filePath)
        {
            try
            {

                // Obter a conexão com o banco de dados
                string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    connection.Open();

                    // Ler o arquivo Excel usando o EPPlus
                    FileInfo excelFile = new FileInfo(filePath);
                    using (ExcelPackage package = new ExcelPackage(excelFile))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Considerando que os dados estão na primeira planilha

                        int usuarioID = Util.UserID;

                        // Obter o número de linhas e colunas com dados
                        int rowCount = worksheet.Dimension.Rows;
                        int columnCount = worksheet.Dimension.Columns;

                        // Iterar pelas linhas do arquivo Excel (começando da segunda linha, pois a primeira contém os cabeçalhos)
                        for (int row = 2; row <= rowCount; row++)
                        {
                            // Obter os dados de cada coluna da linha atual
                            string nome = worksheet.Cells[row, 1].Value?.ToString();
                            string email = worksheet.Cells[row, 2].Value?.ToString();
                            string endereco = worksheet.Cells[row, 3].Value?.ToString();
                            string documento = worksheet.Cells[row, 4].Value?.ToString();
                            string telefone = worksheet.Cells[row, 5].Value?.ToString();


                            // Verificar se algum campo está em branco
                            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(endereco) ||
                                string.IsNullOrWhiteSpace(documento) || string.IsNullOrWhiteSpace(telefone))
                            {
                                MessageBox.Show("Um ou mais campos estão em branco para o cliente na linha " + row, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }


                            // Telefone
                            if (telefone.Length != 11)
                            {
                                MessageBox.Show("Telefone inválido para o cliente: " + nome, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }

                            // CPF OU CNPJ
                            bool documentoValido = false;

                            if (Util.SomenteNumeros(documento).Length == 14)
                            {
                                documentoValido = ValidarCNPJ(documento);
                            }
                            else if (Util.SomenteNumeros(documento).Length == 11)
                            {
                                documentoValido = ValidarCPF(documento);
                            }
                            if (!documentoValido)
                            {
                                MessageBox.Show("Documento inválido para o cliente: " + nome, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }


                            // Verificar se o cliente já existe para o usuário logado com base no nome ou documento
                            string queryVerificacao = "SELECT COUNT(*) FROM clientes WHERE (nome = @nome OR documento = @documento) AND usuarioID = @usuarioID ";
                            SqlCommand commandVerificacao = new SqlCommand(queryVerificacao, connection);
                            commandVerificacao.Parameters.AddWithValue("@nome", nome);
                            commandVerificacao.Parameters.AddWithValue("@documento", FormatarDocumento(documento));
                            commandVerificacao.Parameters.AddWithValue("@usuarioID", Util.UserID);

                            int count = (int)commandVerificacao.ExecuteScalar();
                            if (count > 0)
                            {
                                // Cliente já existe, não realizar a inserção
                                MessageBox.Show("Cliente já existe no banco de dados. Verifique os campos NOME ou DOCUMENTO.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }

                            // Inserir os dados no banco de dados associados ao usuário logado
                            string queryInsercao = "INSERT INTO clientes (nome, email, endereco, documento, telefone, usuarioID, IDCliente) VALUES (@nome, @email, @endereco, @documento, @telefone, @usuarioID, @idcliente)";
                            SqlCommand commandInsercao = new SqlCommand(queryInsercao, connection);
                            commandInsercao.Parameters.AddWithValue("@nome", nome);
                            commandInsercao.Parameters.AddWithValue("@email", email);
                            commandInsercao.Parameters.AddWithValue("@endereco", endereco);
                            commandInsercao.Parameters.AddWithValue("@documento", FormatarDocumento(documento));
                            commandInsercao.Parameters.AddWithValue("@telefone", FormatarTelefone(telefone));
                            commandInsercao.Parameters.AddWithValue("@usuarioID", Util.UserID);
                            commandInsercao.Parameters.AddWithValue("@idcliente", ObterProximoIdCliente());
                            commandInsercao.ExecuteNonQuery();

                        }
                    }

                    MessageBox.Show("Dados do Excel importados com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao importar dados do Excel: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string FormatarCPF(string cpf)
        {
            return cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
        }
        public static string FormatarCNPJ(string cnpj)
        {

            return cnpj.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
        }

        public static string FormatarTelefone(string telefone)
        {
            // Remover caracteres não numéricos do número de telefone
            string numeros = new string(telefone.Where(char.IsDigit).ToArray());

            // Verificar se o número de telefone possui os dígitos necessários
            if (numeros.Length != 11)
            {
                // Retornar o número de telefone original se não estiver no formato esperado
                return telefone;
            }

            // Formatar o número de telefone no formato "(99) 99999-9999"
            return string.Format("({0}) {1}-{2}", numeros.Substring(0, 2), numeros.Substring(2, 5), numeros.Substring(7));
        }

        public static string FormatarDocumento(string documento)
        {
            if (Util.SomenteNumeros(documento).Length == 11)
            {
                return FormatarCPF(Util.SomenteNumeros(documento));
            }
            if (Util.SomenteNumeros(documento).Length == 14)
            {
                return FormatarCNPJ(Util.SomenteNumeros(documento));
            }
            else
            {//nunca entra 
                return null;
            }
        }
    }
}

