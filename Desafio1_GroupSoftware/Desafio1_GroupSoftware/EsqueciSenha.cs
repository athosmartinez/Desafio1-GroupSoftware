using Desafio1_GroupSoftware.Funcoes;
using FluentEmail.Core;
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
    public partial class EsqueciSenha : Form
    {
        public EsqueciSenha()
        {
            InitializeComponent();
        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
            string email = textBox_Email.Text;
            Util.GetUserName(email);
            Util.GerarCodigoVerificacao(email);
            RedefinirSenha redefinirSenha = new RedefinirSenha();
            redefinirSenha.Show();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
