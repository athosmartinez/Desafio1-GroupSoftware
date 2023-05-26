using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Desafio1_GroupSoftware
{
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void text_CrieUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_CrieSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_ConfirmeSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
            {
                text_CrieSenha.UseSystemPasswordChar = false;
                text_ConfirmeSenha.UseSystemPasswordChar = false;
            }
            else
            {
                text_CrieSenha.UseSystemPasswordChar = true;
                text_ConfirmeSenha.UseSystemPasswordChar = true;
            }
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            string username = text_CrieUser.Text;
            string senhaCriptografada = BCryptNet.HashPassword(text_CrieSenha.Text);

            string connectionString = "Data Source=group-note02312;Initial Catalog=users;User ID=SA;Password=Admin@123";
            if (text_CrieSenha.Text != text_ConfirmeSenha.Text)
            {
                MessageBox.Show("SENHAS DEVEM SER IGUAIS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string sql = "INSERT INTO usuarios (username, senha) VALUES (@Username, @Password)";
                        SqlCommand command = new SqlCommand(sql, connection);

                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", senhaCriptografada);

                        int rowsAffected = command.ExecuteNonQuery();

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
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir usuário no banco de dados: " + ex.Message);
                }
            }

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
