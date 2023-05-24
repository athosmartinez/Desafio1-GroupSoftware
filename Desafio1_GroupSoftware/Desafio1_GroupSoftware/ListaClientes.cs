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
            if (string.IsNullOrEmpty(txt_Pesquisa.Text))
            {
                dataGrid_Clientes.DataSource = ListClientes.clientes;
            }
            else
            {
                string termoPesquisa = txt_Pesquisa.Text.ToLower(); // Obter o termo de pesquisa em letras minúsculas

                List<Cliente> clientesFiltrados = ListClientes.clientes.Where(cliente =>
        Util.RemoverAcentos(cliente.Nome.ToLower()).Contains(termoPesquisa) ||
        Util.RemoverAcentos(cliente.Endereço.ToLower()).Contains(termoPesquisa) ||
        Util.RemoverAcentos(cliente.Documento.ToLower()).Contains(termoPesquisa) ||
        Util.RemoverAcentos(cliente.Email.ToLower()).Contains(termoPesquisa) ||
        Util.RemoverAcentos(cliente.Telefone.ToLower()).Contains(termoPesquisa))
        .ToList();

                dataGrid_Clientes.DataSource = clientesFiltrados;
            }
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
        }
    }
}
