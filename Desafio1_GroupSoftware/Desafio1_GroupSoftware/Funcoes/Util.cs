using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using BCryptNet = BCrypt.Net.BCrypt;
using Desafio1_GroupSoftware.Classes;

namespace Desafio1_GroupSoftware.Funcoes
{
    public static class Util
    {
        public static string SomenteNumeros(this string s)
        {
            return string.Join("", System.Text.RegularExpressions.Regex.Split(s, @"[^\d]"));
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

        private static bool TodosDigitosIguaisCnpj(string cnpj)
        {
            for (int i = 1; i < cnpj.Length; i++)
            {
                if (cnpj[i] != cnpj[0])
                    return false;
            }
            return true;
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

        private static bool TodosDigitosIguaisCpf(string cpf)
        {
            for (int i = 1; i < cpf.Length; i++)
            {
                if (cpf[i] != cpf[0])
                    return false;
            }
            return true;
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

    }
}

