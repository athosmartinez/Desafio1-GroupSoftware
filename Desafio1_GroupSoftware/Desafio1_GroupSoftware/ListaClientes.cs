using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Desafio1_GroupSoftware.Classes;
using Desafio1_GroupSoftware.Funcoes;
using System.Data.SqlClient;
using System.Formats.Asn1;
using CsvHelper;
using CsvHelper.Configuration;

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

        private void dataGrid_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suprimir o som de "beep" ao pressionar Enter
                button_Pesquisa_Click(sender, e); // Chamar o evento de clique do botão de pesquisa
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true; // Suprimir o som de "beep" ao pressionar Enter
                button_Voltar_Click(sender, e); // Chamar o evento de clique do botão de pesquisa
            }
        }

        private void button_Exportar_Click(object sender, EventArgs e)
        {
            try
            {
                // Consultar todos os clientes do usuário logado
                DataTable dataTable = Util.ConsultarDadosClientes();

                // Verificar se existem dados a serem exportados
                if (dataTable.Rows.Count > 0)
                {
                    // Criar o objeto SaveFileDialog
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
                    saveFileDialog.Title = "Salvar Tabela";
                    saveFileDialog.ShowDialog();

                    // Verificar se o usuário selecionou um local e nome de arquivo válido
                    if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                    {
                        // Criar o StreamWriter para escrever no arquivo
                        using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Escrever o cabeçalho no arquivo
                            for (int i = 0; i < dataTable.Columns.Count; i++)
                            {
                                streamWriter.Write(dataTable.Columns[i].ColumnName);
                                if (i < dataTable.Columns.Count - 1)
                                    streamWriter.Write(",");
                            }
                            streamWriter.WriteLine();

                            // Escrever os dados no arquivo
                            foreach (DataRow row in dataTable.Rows)
                            {
                                for (int i = 0; i < dataTable.Columns.Count; i++)
                                {
                                    streamWriter.Write(row[i].ToString());
                                    if (i < dataTable.Columns.Count - 1)
                                        streamWriter.Write(",");
                                }
                                streamWriter.WriteLine();
                            }
                        }
                        MessageBox.Show("Tabela exportada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Não há dados para exportar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar tabela: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            DataTable lista_clientes = Util.ConsultarDadosClientes();
            dataGrid_Clientes.DataSource = lista_clientes;
        }
    }
}
