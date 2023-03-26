namespace Vista
{
    partial class TicketsForm
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
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BuscarClienteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.ISVTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IdentidadClienteTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SoporteComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DescripcionSolicitudTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionRespuestaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PosibleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PosibleErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(12, 43);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(224, 20);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(1200, 83);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.FechaDateTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1127, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha:";
            // 
            // BuscarClienteButton
            // 
            this.BuscarClienteButton.BackColor = System.Drawing.Color.White;
            this.BuscarClienteButton.Location = new System.Drawing.Point(664, 134);
            this.BuscarClienteButton.Name = "BuscarClienteButton";
            this.BuscarClienteButton.Size = new System.Drawing.Size(25, 23);
            this.BuscarClienteButton.TabIndex = 3;
            this.BuscarClienteButton.Text = "...";
            this.BuscarClienteButton.UseVisualStyleBackColor = false;
            this.BuscarClienteButton.Click += new System.EventHandler(this.BuscarClienteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Identidad:";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(695, 135);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.ReadOnly = true;
            this.NombreClienteTextBox.Size = new System.Drawing.Size(382, 20);
            this.NombreClienteTextBox.TabIndex = 4;
            // 
            // ISVTextBox
            // 
            this.ISVTextBox.Location = new System.Drawing.Point(1200, 335);
            this.ISVTextBox.Name = "ISVTextBox";
            this.ISVTextBox.ReadOnly = true;
            this.ISVTextBox.Size = new System.Drawing.Size(132, 20);
            this.ISVTextBox.TabIndex = 18;
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(1200, 372);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(132, 20);
            this.DescuentoTextBox.TabIndex = 20;
            this.DescuentoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentoTextBox_KeyPress);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(1200, 412);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(132, 20);
            this.TotalTextBox.TabIndex = 22;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(1200, 294);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(132, 20);
            this.SubTotalTextBox.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1127, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1127, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Descuento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1127, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Sub Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1127, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ISV:";
            // 
            // IdentidadClienteTextBox
            // 
            this.IdentidadClienteTextBox.Location = new System.Drawing.Point(400, 135);
            this.IdentidadClienteTextBox.Name = "IdentidadClienteTextBox";
            this.IdentidadClienteTextBox.Size = new System.Drawing.Size(258, 20);
            this.IdentidadClienteTextBox.TabIndex = 2;
            this.IdentidadClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadClienteTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo de Soporte:";
            // 
            // SoporteComboBox
            // 
            this.SoporteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SoporteComboBox.FormattingEnabled = true;
            this.SoporteComboBox.Items.AddRange(new object[] {
            "Celulares",
            "Cómputo"});
            this.SoporteComboBox.Location = new System.Drawing.Point(400, 187);
            this.SoporteComboBox.Name = "SoporteComboBox";
            this.SoporteComboBox.Size = new System.Drawing.Size(258, 21);
            this.SoporteComboBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descripción Respuesta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Descripción Solicitud:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(710, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 18);
            this.label12.TabIndex = 37;
            this.label12.Text = "NUEVO TICKET";
            // 
            // DescripcionSolicitudTextBox
            // 
            this.DescripcionSolicitudTextBox.Location = new System.Drawing.Point(442, 235);
            this.DescripcionSolicitudTextBox.Name = "DescripcionSolicitudTextBox";
            this.DescripcionSolicitudTextBox.Size = new System.Drawing.Size(635, 20);
            this.DescripcionSolicitudTextBox.TabIndex = 10;
            // 
            // DescripcionRespuestaTextBox
            // 
            this.DescripcionRespuestaTextBox.Location = new System.Drawing.Point(442, 276);
            this.DescripcionRespuestaTextBox.Name = "DescripcionRespuestaTextBox";
            this.DescripcionRespuestaTextBox.Size = new System.Drawing.Size(635, 20);
            this.DescripcionRespuestaTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1127, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Precio:";
            // 
            // PosibleErrorProvider
            // 
            this.PosibleErrorProvider.ContainerControl = this;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(1200, 230);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(132, 20);
            this.PrecioTextBox.TabIndex = 14;
            this.PrecioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTextBox_KeyPress_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UsuarioTextBox);
            this.panel1.Controls.Add(this.CancelarButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 555);
            this.panel1.TabIndex = 0;
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.White;
            this.CancelarButton.Image = global::Vista.Properties.Resources.cancelar_ticket;
            this.CancelarButton.Location = new System.Drawing.Point(65, 487);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(119, 56);
            this.CancelarButton.TabIndex = 2;
            this.CancelarButton.Text = "CANCELAR";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.Color.White;
            this.GuardarButton.Image = global::Vista.Properties.Resources.salvar;
            this.GuardarButton.Location = new System.Drawing.Point(1165, 487);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(119, 56);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "GUARDAR";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1363, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.DescripcionRespuestaTextBox);
            this.Controls.Add(this.DescripcionSolicitudTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SoporteComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdentidadClienteTextBox);
            this.Controls.Add(this.ISVTextBox);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BuscarClienteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombreClienteTextBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label3);
            this.Name = "TicketsForm";
            this.Text = "TICKETS";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PosibleErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuscarClienteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.TextBox ISVTextBox;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox IdentidadClienteTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SoporteComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DescripcionSolicitudTextBox;
        private System.Windows.Forms.TextBox DescripcionRespuestaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider PosibleErrorProvider;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Panel panel1;
    }
}