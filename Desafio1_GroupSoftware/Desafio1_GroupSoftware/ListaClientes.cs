using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desafio1_GroupSoftware;
using System.Globalization;

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
        Util.RemoverAcentos(cliente.Endereco.ToLower()).Contains(termoPesquisa) ||
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
    }
}
