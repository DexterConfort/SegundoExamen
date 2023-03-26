using System.Windows.Forms;

namespace Vista
{
    public partial class MenuForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripButton_Click(object sender, System.EventArgs e)
        {
            UsuariosForm usuariosForm = new UsuariosForm();
            usuariosForm.MdiParent = this;
            usuariosForm.Show();
        }

        private void SalirBackStageButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void ClientesToolStripButton_Click(object sender, System.EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.MdiParent = this;
            clientesForm.Show();
        }

        private void TicketsToolStripButton_Click(object sender, System.EventArgs e)
        {
            TicketsForm ticketsForm = new TicketsForm();
            ticketsForm.MdiParent = this;
            ticketsForm.Show();
        }
    }
}
