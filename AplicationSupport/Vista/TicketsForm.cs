using DataBase;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class TicketsForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }
        Cliente cliente = null;
        ClienteDB clienteDB = new ClienteDB();
        TicketDB ticketDB = new TicketDB();

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        decimal precio, subTotal, isv, descuento = 0, total;


        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            BuscarClientesForm buscar = new BuscarClientesForm();
            buscar.ShowDialog();

            cliente = new Cliente();
            cliente = buscar.cliente;

            IdentidadClienteTextBox.Text = cliente.Identidad;
            NombreClienteTextBox.Text = cliente.Nombre;

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreClienteTextBox.Text))
            {
                PosibleErrorProvider.SetError(IdentidadClienteTextBox, "Seleccione un Cliente");
                IdentidadClienteTextBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();
            if (SoporteComboBox.Text == "")
            {
                PosibleErrorProvider.SetError(SoporteComboBox, "Seleccione el tipo de soporte");
                SoporteComboBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();
            if (string.IsNullOrEmpty(DescripcionSolicitudTextBox.Text))
            {
                PosibleErrorProvider.SetError(DescripcionSolicitudTextBox, "Describa la solicitud");
                DescripcionSolicitudTextBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();
            if (string.IsNullOrEmpty(DescripcionRespuestaTextBox.Text))
            {
                PosibleErrorProvider.SetError(DescripcionRespuestaTextBox, "Describa la respuesta");
                DescripcionRespuestaTextBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();
            if (string.IsNullOrEmpty(PrecioTextBox.Text))
            {
                PosibleErrorProvider.SetError(PrecioTextBox, "Ingrese el precio");
                PrecioTextBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();
            PosibleErrorProvider.Clear();
            if (string.IsNullOrEmpty(TotalTextBox.Text))
            {
                PosibleErrorProvider.SetError(PrecioTextBox, "Ingrese el precio y de Enter");
                PrecioTextBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();

            Ticket ticket = new Ticket();
            ticket.Fecha = FechaDateTimePicker.Value;
            ticket.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            ticket.IdentidadCliente = cliente.Identidad;
            ticket.Soporte = SoporteComboBox.Text;
            ticket.DescripcionSolicitud = DescripcionSolicitudTextBox.Text;
            ticket.DescripcionRespuesta = DescripcionRespuestaTextBox.Text;
            ticket.Precio = precio;
            ticket.ISV = isv;
            ticket.Descuento = descuento;
            ticket.SubTotal = subTotal;
            ticket.Total = total;

            Boolean inserto = ticketDB.Guardar(ticket);

            if (inserto)
            {
                IdentidadClienteTextBox.Focus();
                MessageBox.Show("Ticket registrado exitosamente");
                LimpiarControles();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el ticket");
            }





        }

        public void LimpiarControles()
        {
            FechaDateTimePicker.Value = DateTime.Now;
            IdentidadClienteTextBox.Clear();
            NombreClienteTextBox.Clear();
            SoporteComboBox.Items.Clear();
            DescripcionSolicitudTextBox.Clear();
            DescripcionRespuestaTextBox.Clear();
            PrecioTextBox.Clear();
            SubTotalTextBox.Clear();
            ISVTextBox.Clear();
            DescuentoTextBox.Clear();
            TotalTextBox.Clear();
            cliente = null;
            precio = 0;
            subTotal = 0;
            isv = 0;
            descuento = 0;
            total = 0;

            SoporteComboBox.Items.Add("Celulares");
            SoporteComboBox.Items.Add("Cómputo");
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            PosibleErrorProvider.Clear();
        }



        //EVENTOS KEY PRESS
        private void IdentidadClienteTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            NombreClienteTextBox.Clear();
            if ((!char.IsNumber(e.KeyChar)) && (e.KeyChar != '\b') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == (char)Keys.Enter) && (!string.IsNullOrEmpty(IdentidadClienteTextBox.Text)))
            {
                cliente = new Cliente();
                cliente = clienteDB.DevolverClientePorIdentidad(IdentidadClienteTextBox.Text);

                if (cliente == null)
                {
                    MessageBox.Show("No se encontro el Cliente en la Base de Datos");
                }
                else
                {
                    NombreClienteTextBox.Text = cliente.Nombre;
                }
            }
            else
            {
                cliente = null;
                NombreClienteTextBox.Clear();
            }
        }
        private void DescuentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (((sender as TextBox).Text.IndexOf('.') > -1) && ((sender as TextBox).Text.Substring((sender as TextBox).Text.IndexOf('.')).Length > 2) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == (char)Keys.Enter) && (!string.IsNullOrEmpty(DescuentoTextBox.Text)))
            {
                descuento = Convert.ToDecimal(DescuentoTextBox.Text);
                total -= descuento;
                TotalTextBox.Text = total.ToString("N2");
                DescuentoTextBox.Clear();
            }
        }
        private void PrecioTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (((sender as TextBox).Text.IndexOf('.') > -1) && ((sender as TextBox).Text.Substring((sender as TextBox).Text.IndexOf('.')).Length > 2) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(PrecioTextBox.Text))
                {
                    precio = 0; subTotal = 0; isv = 0; descuento = 0; total = 0;
                    precio = Convert.ToDecimal(PrecioTextBox.Text);
                    subTotal = precio;
                    isv = subTotal * 0.15M;
                    total = subTotal + isv;

                    SubTotalTextBox.Text = subTotal.ToString("N2");
                    ISVTextBox.Text = isv.ToString("N2");
                    TotalTextBox.Text = total.ToString("N2");
                    DescuentoTextBox.Text = descuento.ToString("N2");
                }
                else
                {
                    SubTotalTextBox.Clear();
                    ISVTextBox.Clear();
                    TotalTextBox.Clear();
                    DescuentoTextBox.Clear();
                }
            }
        }



    }
}
