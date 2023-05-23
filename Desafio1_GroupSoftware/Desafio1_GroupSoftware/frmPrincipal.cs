using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_GroupSoftware
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button_cadastramento_Click(object sender, EventArgs e)
        {
            CadastramentoClientes cad = new CadastramentoClientes();
            cad.Show();
        }

        private void button_lista_Click(object sender, EventArgs e)
        {
            CadastramentoClientes cad = new CadastramentoClientes();
            cad.ShowDialog();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
