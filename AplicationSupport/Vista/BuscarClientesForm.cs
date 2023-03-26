using DataBase;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class BuscarClientesForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public BuscarClientesForm()
        {
            InitializeComponent();
        }
        ClienteDB clienteDB = new ClienteDB();
        public Cliente cliente = new Cliente();


        //BOTON DE ACEPTAR
        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (ClientesDataGridView.SelectedRows.Count > 0)
            {
                cliente.Identidad = ClientesDataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                cliente.Nombre = ClientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                cliente.Telefono = ClientesDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                cliente.Correo = ClientesDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                cliente.Direccion = ClientesDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                cliente.FechaNacimiento = Convert.ToDateTime(ClientesDataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                cliente.Estado = Convert.ToBoolean(ClientesDataGridView.CurrentRow.Cells["Estado"].Value);
                this.Close();
            }
        }
        //BOTON DE CANCELAR
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        //EVENTO KEYPRESS Y KEYUP
        private void BuscarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void BuscarTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ClientesDataGridView.DataSource = clienteDB.DevolverClientesPorNombre(BuscarTextBox.Text);
        }


        //CONSULTAR CLIENTES
        private void BuscarClientesForm_Load(object sender, EventArgs e)
        {
            TraerClientes();
        }
        private void TraerClientes()
        {
            ClientesDataGridView.DataSource = clienteDB.DevolverClientes();
        }
    }
}
