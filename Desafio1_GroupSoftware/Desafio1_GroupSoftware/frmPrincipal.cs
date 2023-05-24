﻿using System;
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

        private void button_Cadastramento_Click(object sender, EventArgs e)
        {
            CadastramentoClientes cadastramentoClientes = new CadastramentoClientes();
            cadastramentoClientes.ShowDialog();
        }

        private void button_Lista_Click(object sender, EventArgs e)
        {
            ListClientes.CriarObjClientes();
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.ShowDialog();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Close();
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.ShowDialog();

        }
    }
}
