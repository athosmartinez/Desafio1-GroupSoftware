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
                    string queryVerificacao = "SELECT COUNT(*) FROM clientes WHERE nome = @nome OR  telefone = @telefone OR  documento = @documento";
                    SqlCommand commandVerificacao = new SqlCommand(queryVerificacao, connection);
                    commandVerificacao.Parameters.AddWithValue("@nome", nome);
                    commandVerificacao.Parameters.AddWithValue("@telefone", telefone);
                    commandVerificacao.Parameters.AddWithValue("@documento", documento);

                    int count = (int)commandVerificacao.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Cliente já existe no banco de dados. Verifique os campos NOME, DOCUMENTO ou TELEFONE", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Não realizar a inserção se o cliente já existe
                    }
                    // Inserir o cliente caso não exista
                    string queryInsercao = "INSERT INTO clientes (nome, email, endereco, documento, telefone, usuarioID) VALUES (@nome, @email, @endereco, @documento, @telefone, @usuarioID)";
                    SqlCommand commandInsercao = new SqlCommand(queryInsercao, connection);
                    commandInsercao.Parameters.AddWithValue("@nome", nome);
                    commandInsercao.Parameters.AddWithValue("@email", email);
                    commandInsercao.Parameters.AddWithValue("@endereco", endereco);
                    commandInsercao.Parameters.AddWithValue("@documento", documento);
                    commandInsercao.Parameters.AddWithValue("@telefone", telefone);
                    commandInsercao.Parameters.AddWithValue("@usuarioID", usuarioID);
                    commandInsercao.ExecuteNonQuery();
                    MessageBox.Show("Dados do cliente inseridos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados do cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool VerificarClienteExistente(string nome, int usuarioID)
        {
            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            string query = "SELECT COUNT(*) FROM clientes WHERE nome = @Nome AND usuarioID = @UsuarioID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@UsuarioID", usuarioID);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public static void AtualizarDadosCliente(string nome, string email, string endereco, string documento, string telefone, int usuarioID)
        {
            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            string queryVerificarExistencia = "SELECT COUNT(*) FROM clientes WHERE (telefone = @Telefone) AND usuarioID = @UsuarioID";
            string queryAtualizar = "UPDATE clientes SET email = @Email, endereco = @Endereco, documento = @Documento, telefone = @Telefone WHERE nome = @Nome AND usuarioID = @UsuarioID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Verificar a existência de valores duplicados
                    SqlCommand verificarExistenciaCommand = new SqlCommand(queryVerificarExistencia, connection);
                    verificarExistenciaCommand.Parameters.AddWithValue("@Telefone", telefone);
                    verificarExistenciaCommand.Parameters.AddWithValue("@UsuarioID", usuarioID);

                    int duplicadosCount = (int)verificarExistenciaCommand.ExecuteScalar();

                    if (duplicadosCount > 0)
                    {
                        MessageBox.Show("Falha ao atualizar os dados do cliente. Já existe um cliente com o mesmo CPF, telefone ou nome.");
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
    }
}

