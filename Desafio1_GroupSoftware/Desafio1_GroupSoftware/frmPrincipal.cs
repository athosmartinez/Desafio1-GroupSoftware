using Desafio1_GroupSoftware.Funcoes;

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
        private void button_NovoUsuario_Click(object sender, EventArgs e)
        {
            NovoUsuario novoUsuario = new NovoUsuario();
            novoUsuario.ShowDialog();
        }

        private void label_UserShow_Click(object sender, EventArgs e)
        {

        }

        //DUVIDA QUAL MELHOR EVENTO UTILIZAR
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            int numeroID = Util.UserID;
            string numeroIDString = numeroID.ToString();
            label_UserShow.Text = "Active: " + Util.UserName.ToUpper() + " - " + numeroIDString;
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            int numeroID = Util.UserID;
            string numeroIDString = numeroID.ToString();
            label_UserShow.Text = "Active: " + Util.UserName.ToUpper() + " - " + numeroIDString;
        }

        private void frmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            int numeroID = Util.UserID;
            string numeroIDString = numeroID.ToString();
            label_UserShow.Text = "Active: " + Util.UserName + " - " + numeroIDString;
        }

        private void frmPrincipal_MouseEnter(object sender, EventArgs e)
        {
            int numeroID = Util.UserID;
            string numeroIDString = numeroID.ToString();
            label_UserShow.Text = "Active: " + Util.UserName + " - " + numeroIDString;
        }

        private void frmPrincipal_MouseLeave(object sender, EventArgs e)
        {
            int numeroID = Util.UserID;
            string numeroIDString = numeroID.ToString();
            label_UserShow.Text = "Active: " + Util.UserName.ToUpper() + " - " + numeroIDString;
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            int numeroID = Util.UserID;
            string numeroIDString = numeroID.ToString();
            label_UserShow.Text = "Active: " + Util.UserName.ToUpper() + " - " + numeroIDString;
        }

        private void frmPrincipal_MouseHover(object sender, EventArgs e)
        {
            int numeroID = Util.UserID;
            string numeroIDString = numeroID.ToString();
            label_UserShow.Text = "Active: " + Util.UserName.ToUpper() + " - " + numeroIDString;
        }

        private void frmPrincipal_RegionChanged(object sender, EventArgs e)
        {
            int numeroID = Util.UserID;
            string numeroIDString = numeroID.ToString();
            label_UserShow.Text = "Active: " + Util.UserName.ToUpper() + " - " + numeroIDString;
        }

        private void frmPrincipal_VisibleChanged(object sender, EventArgs e)
        {
            int numeroID = Util.UserID;
            string numeroIDString = numeroID.ToString();
            label_UserShow.Text = "Active: " + Util.UserName.ToUpper() + " - " + numeroIDString;
        }

        private void button_CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
