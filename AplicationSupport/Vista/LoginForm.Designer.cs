namespace Vista
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.PosibleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MostrarPasswordButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PosibleErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.Location = new System.Drawing.Point(194, 119);
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.PasswordChar = '*';
            this.ContrasenaTextBox.Size = new System.Drawing.Size(292, 20);
            this.ContrasenaTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña: ";
            // 
            // AceptarButton
            // 
            this.AceptarButton.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton.Location = new System.Drawing.Point(335, 174);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(93, 37);
            this.AceptarButton.TabIndex = 5;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(445, 173);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(93, 38);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(194, 64);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(292, 20);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // PosibleErrorProvider
            // 
            this.PosibleErrorProvider.ContainerControl = this;
            // 
            // MostrarPasswordButton
            // 
            this.MostrarPasswordButton.Image = global::Vista.Properties.Resources.ojo;
            this.MostrarPasswordButton.Location = new System.Drawing.Point(505, 120);
            this.MostrarPasswordButton.Name = "MostrarPasswordButton";
            this.MostrarPasswordButton.Size = new System.Drawing.Size(33, 19);
            this.MostrarPasswordButton.TabIndex = 4;
            this.MostrarPasswordButton.UseVisualStyleBackColor = true;
            this.MostrarPasswordButton.Click += new System.EventHandler(this.MostrarPasswordButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ContrasenaTextBox);
            this.panel1.Controls.Add(this.MostrarPasswordButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UsuarioTextBox);
            this.panel1.Controls.Add(this.AceptarButton);
            this.panel1.Controls.Add(this.CancelarButton);
            this.panel1.Location = new System.Drawing.Point(381, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 286);
            this.panel1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.AceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CaptionFont = new System.Drawing.Font("Forte", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1374, 748);
            this.ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PosibleErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ContrasenaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.ErrorProvider PosibleErrorProvider;
        private System.Windows.Forms.Button MostrarPasswordButton;
        private System.Windows.Forms.Panel panel1;
    }
}