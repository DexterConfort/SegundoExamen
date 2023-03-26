using DataBase;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        string tipoOperacion;
        DataTable dt = new DataTable();
        UsuarioDB usuarioBD = new UsuarioDB();
        Usuario user = null;

        DateTime tiempo = DateTime.Now;


        //NUEVO
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CodigoTextBox.ReadOnly = false;
            RolComboBox.Items.Add("Administrador");
            RolComboBox.Items.Add("Usuario");

            HabilitarControles();
            CodigoTextBox.Focus();
            tipoOperacion = "Nuevo";
        }
        //MODIFICAR
        private void ModificarButton_Click_1(object sender, EventArgs e)
        {
            RolComboBox.Items.Add("Administrador");
            RolComboBox.Items.Add("Usuario");
            tipoOperacion = "Modificar";
            CodigoTextBox.ReadOnly = true;

            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                NombreTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                ContraseñaTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Contrasena"].Value.ToString();
                CorreoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                RolComboBox.Text = UsuariosDataGridView.CurrentRow.Cells["Rol"].Value.ToString();
                EstaActivoCheckBox.Checked = Convert.ToBoolean(UsuariosDataGridView.CurrentRow.Cells["Estado"].Value);
                byte[] miFoto = usuarioBD.DevolverFoto(UsuariosDataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString());
                if (miFoto.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(miFoto);
                    FotoPictureBox.Image = System.Drawing.Bitmap.FromStream(ms);
                }
                HabilitarControles();
            }
            else
            {
                MessageBox.Show("Seleccione un Usuario");
            }
        }
        //GUARDAR
        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodigoTextBox.Text))
            {
                PosibleErrorProvider.SetError(CodigoTextBox, "Ingrese un código");
                CodigoTextBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                PosibleErrorProvider.SetError(NombreTextBox, "Ingrese un nombre");
                NombreTextBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();
            if (string.IsNullOrEmpty(ContraseñaTextBox.Text))
            {
                PosibleErrorProvider.SetError(ContraseñaTextBox, "Ingrese una contraseña");
                ContraseñaTextBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();
            if (string.IsNullOrEmpty(RolComboBox.Text))
            {
                PosibleErrorProvider.SetError(RolComboBox, "Seleccione un Rol");
                RolComboBox.Focus();
                return;
            }
            PosibleErrorProvider.Clear();

            if (tipoOperacion == "Nuevo")
            {
                user = new Usuario();
                user.CodigoUsuario = CodigoTextBox.Text;
                user.Nombre = NombreTextBox.Text;
                user.Contrasena = ContraseñaTextBox.Text;
                user.Rol = RolComboBox.Text;
                user.Correo = CorreoTextBox.Text;
                user.Estado = EstaActivoCheckBox.Checked;
                user.FechaCreacion = tiempo;
                if (FotoPictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    FotoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.Foto = ms.GetBuffer();
                }

                //Insertar en la BD 


                bool inserto = usuarioBD.Insertar(user);
                if (inserto == true)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerUsuarios();
                    MessageBox.Show("Registro Guardado");
                }
                else { MessageBox.Show("No se pudo guardar el registro"); }
            }
            else if (tipoOperacion == "Modificar")
            {
                user = new Usuario();
                user.CodigoUsuario = CodigoTextBox.Text;
                user.Nombre = NombreTextBox.Text;
                user.Contrasena = ContraseñaTextBox.Text;
                user.Rol = RolComboBox.Text;
                user.Correo = CorreoTextBox.Text;
                user.Estado = EstaActivoCheckBox.Checked;
                if (FotoPictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    FotoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.Foto = ms.GetBuffer();
                }

                Boolean modifico = usuarioBD.Editar(user);
                if (modifico)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerUsuarios();
                    MessageBox.Show("Registro Actualizado Correctamente");
                }
                else { MessageBox.Show("No se pudo Actualizar el Registro"); }

            }
        }
        //ELIMINAR
        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro", "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = usuarioBD.Eliminar(UsuariosDataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString());
                    if (elimino)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        TraerUsuarios();

                        MessageBox.Show("Registro Eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }

            }
            else { MessageBox.Show("Seleccione un Registro"); }
        }
        //CANCELAR
        private void CancelarButton_Click_1(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
            PosibleErrorProvider.Clear();
        }
        //FOTO
        private void AdjuntarFotoButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                FotoPictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }


        //HABILITAR; DESHABILITAR; LIMPIAR
        public void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            ContraseñaTextBox.Enabled = true;
            CorreoTextBox.Enabled = true;
            RolComboBox.Enabled = true;
            EstaActivoCheckBox.Enabled = true;
            AdjuntarFotoButton.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
            ModificarButton.Enabled = false;
        }
        public void DeshabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            ContraseñaTextBox.Enabled = false;
            CorreoTextBox.Enabled = false;
            RolComboBox.Enabled = false;
            EstaActivoCheckBox.Enabled = false;
            AdjuntarFotoButton.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
            ModificarButton.Enabled = true;
            tipoOperacion = null;
        }
        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            NombreTextBox.Clear();
            ContraseñaTextBox.Clear();
            CorreoTextBox.Clear();
            RolComboBox.Items.Clear();
            EstaActivoCheckBox.Checked = false;
            FotoPictureBox.Image = null;
            user = null;
        }


        //OTROS METODOS
        private void UsuariosForm_Load_1(object sender, EventArgs e)
        {
            TraerUsuarios();
        }
        private void TraerUsuarios()
        {
            dt = usuarioBD.DevolverUsuarios();
            UsuariosDataGridView.DataSource = dt;
        }
    }
}
