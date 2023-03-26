using DataBase;
using Entidades;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            UsuarioTextBox.Focus();
        }

        private void AceptarButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(UsuarioTextBox.Text))
            {
                PosibleErrorProvider.SetError(UsuarioTextBox, "Ingrese un Usuario");
                UsuarioTextBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();
            if (string.IsNullOrEmpty(ContrasenaTextBox.Text))
            {
                PosibleErrorProvider.SetError(ContrasenaTextBox, "Ingrese una Contraseña");
                ContrasenaTextBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();

            Login login = new Login();
            login.Usuario = UsuarioTextBox.Text;
            login.Contrasena = ContrasenaTextBox.Text;

            UsuarioDB usuarioDB = new UsuarioDB();
            Usuario usuario = new Usuario();

            usuario = usuarioDB.Autenticacion(login);


            if (usuario != null)
            {
                if (usuario.Estado)
                {
                    System.Security.Principal.GenericIdentity identidad = new System.Security.Principal.GenericIdentity(UsuarioTextBox.Text);
                    System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(identidad, new string[] { usuario.Rol });
                    System.Threading.Thread.CurrentPrincipal = principal;

                    MenuForm menu = new MenuForm();
                    Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("El usuario NO esta activo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else { MessageBox.Show("Datos de usuaio Incorrectos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Question); }
        }

        private void MostrarPasswordButton_Click(object sender, System.EventArgs e)
        {
            if (ContrasenaTextBox.PasswordChar == '*')
            {
                ContrasenaTextBox.PasswordChar = '\0';
            }
            else
            {
                ContrasenaTextBox.PasswordChar = '*';
            }
        }
    }
}
