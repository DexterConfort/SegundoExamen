namespace Vista
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.backStageView1 = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.backStage1 = new Syncfusion.Windows.Forms.BackStage();
            this.SalirBackStageButton = new Syncfusion.Windows.Forms.BackStageButton();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.UsuariosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx3 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.ClientesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.TicketsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabbedMDIManager1 = new Syncfusion.Windows.Forms.Tools.TabbedMDIManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).BeginInit();
            this.backStage1.SuspendLayout();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.toolStripEx3.SuspendLayout();
            this.toolStripTabItem2.Panel.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.BackColor = System.Drawing.Color.White;
            this.ribbonControlAdv1.BackStageView = this.backStageView1;
            this.ribbonControlAdv1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem2);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.MenuButtonText = "INICIO";
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            this.ribbonControlAdv1.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.LightGray;
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.QuickPanelVisible = false;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2013;
            this.ribbonControlAdv1.SelectedTab = this.toolStripTabItem2;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(1374, 117);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2013";
            this.ribbonControlAdv1.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ribbonControlAdv1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            // 
            // backStageView1
            // 
            this.backStageView1.BackStage = this.backStage1;
            this.backStageView1.HostControl = null;
            this.backStageView1.HostForm = this;
            // 
            // backStage1
            // 
            this.backStage1.AllowDrop = true;
            this.backStage1.BackStagePanelWidth = 130;
            this.backStage1.BeforeTouchSize = new System.Drawing.Size(1384, 736);
            this.backStage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backStage1.ChildItemSize = new System.Drawing.Size(80, 140);
            this.backStage1.Controls.Add(this.SalirBackStageButton);
            this.backStage1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.backStage1.ItemSize = new System.Drawing.Size(130, 40);
            this.backStage1.Location = new System.Drawing.Point(0, 0);
            this.backStage1.MinimumSize = new System.Drawing.Size(100, 20);
            this.backStage1.Name = "backStage1";
            this.backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver;
            this.backStage1.Size = new System.Drawing.Size(1384, 736);
            this.backStage1.TabIndex = 2;
            this.backStage1.ThemeName = "BackStage2013Renderer";
            this.backStage1.Visible = false;
            // 
            // SalirBackStageButton
            // 
            this.SalirBackStageButton.Accelerator = "";
            this.SalirBackStageButton.BackColor = System.Drawing.Color.Transparent;
            this.SalirBackStageButton.Location = new System.Drawing.Point(10, 10);
            this.SalirBackStageButton.Name = "SalirBackStageButton";
            this.SalirBackStageButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.SalirBackStageButton.Size = new System.Drawing.Size(110, 25);
            this.SalirBackStageButton.TabIndex = 3;
            this.SalirBackStageButton.Text = "Salir";
            this.SalirBackStageButton.Click += new System.EventHandler(this.SalirBackStageButton_Click);
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx1);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx3);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 4;
            this.toolStripTabItem1.Panel.Text = "Administración";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(104, 25);
            this.toolStripTabItem1.Tag = "1";
            this.toolStripTabItem1.Text = "Administración";
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosToolStripButton});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripEx1.Size = new System.Drawing.Size(63, 61);
            this.toolStripEx1.TabIndex = 0;
            // 
            // UsuariosToolStripButton
            // 
            this.UsuariosToolStripButton.Image = global::Vista.Properties.Resources.usuario;
            this.UsuariosToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UsuariosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsuariosToolStripButton.Name = "UsuariosToolStripButton";
            this.UsuariosToolStripButton.Size = new System.Drawing.Size(56, 44);
            this.UsuariosToolStripButton.Text = "Usuarios";
            this.UsuariosToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UsuariosToolStripButton.Click += new System.EventHandler(this.UsuariosToolStripButton_Click);
            // 
            // toolStripEx3
            // 
            this.toolStripEx3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx3.Image = null;
            this.toolStripEx3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientesToolStripButton});
            this.toolStripEx3.Location = new System.Drawing.Point(65, 1);
            this.toolStripEx3.Name = "toolStripEx3";
            this.toolStripEx3.Office12Mode = false;
            this.toolStripEx3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripEx3.Size = new System.Drawing.Size(59, 61);
            this.toolStripEx3.TabIndex = 1;
            // 
            // ClientesToolStripButton
            // 
            this.ClientesToolStripButton.Image = global::Vista.Properties.Resources.public_service;
            this.ClientesToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClientesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClientesToolStripButton.Name = "ClientesToolStripButton";
            this.ClientesToolStripButton.Size = new System.Drawing.Size(52, 44);
            this.ClientesToolStripButton.Text = "Clientes";
            this.ClientesToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ClientesToolStripButton.Click += new System.EventHandler(this.ClientesToolStripButton_Click);
            // 
            // toolStripTabItem2
            // 
            this.toolStripTabItem2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItem2.Name = "toolStripTabItem2";
            // 
            // ribbonControlAdv1.ribbonPanel2
            // 
            this.toolStripTabItem2.Panel.BackColor = System.Drawing.Color.White;
            this.toolStripTabItem2.Panel.Controls.Add(this.toolStripEx2);
            this.toolStripTabItem2.Panel.Name = "ribbonPanel2";
            this.toolStripTabItem2.Panel.ScrollPosition = 0;
            this.toolStripTabItem2.Panel.TabIndex = 5;
            this.toolStripTabItem2.Panel.Text = "Solicitudes";
            this.toolStripTabItem2.Position = 1;
            this.toolStripTabItem2.Size = new System.Drawing.Size(83, 25);
            this.toolStripTabItem2.Tag = "2";
            this.toolStripTabItem2.Text = "Solicitudes";
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TicketsToolStripButton});
            this.toolStripEx2.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripEx2.Size = new System.Drawing.Size(53, 61);
            this.toolStripEx2.TabIndex = 0;
            // 
            // TicketsToolStripButton
            // 
            this.TicketsToolStripButton.Image = global::Vista.Properties.Resources.boletos_de_avion;
            this.TicketsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TicketsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TicketsToolStripButton.Name = "TicketsToolStripButton";
            this.TicketsToolStripButton.Size = new System.Drawing.Size(46, 44);
            this.TicketsToolStripButton.Text = "Tickets";
            this.TicketsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TicketsToolStripButton.Click += new System.EventHandler(this.TicketsToolStripButton_Click);
            // 
            // tabbedMDIManager1
            // 
            this.tabbedMDIManager1.AttachedTo = this;
            this.tabbedMDIManager1.CloseButtonBackColor = System.Drawing.Color.White;
            this.tabbedMDIManager1.CloseButtonToolTip = "";
            this.tabbedMDIManager1.DropDownButtonToolTip = "";
            this.tabbedMDIManager1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedMDIManager1.NeedUpdateHostedForm = false;
            this.tabbedMDIManager1.ShowCloseButton = true;
            this.tabbedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2010);
            this.tabbedMDIManager1.ThemeName = "TabRendererOffice2010";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CaptionFont = new System.Drawing.Font("Forte", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(84)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1374, 748);
            this.ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.Controls.Add(this.backStage1);
            this.Controls.Add(this.ribbonControlAdv1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.Name = "MenuForm";
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).EndInit();
            this.backStage1.ResumeLayout(false);
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripTabItem1.Panel.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.toolStripEx3.ResumeLayout(false);
            this.toolStripEx3.PerformLayout();
            this.toolStripTabItem2.Panel.ResumeLayout(false);
            this.toolStripTabItem2.Panel.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx3;
        private System.Windows.Forms.ToolStripButton ClientesToolStripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private System.Windows.Forms.ToolStripButton TicketsToolStripButton;
        private System.Windows.Forms.ToolStripButton UsuariosToolStripButton;
        private Syncfusion.Windows.Forms.Tools.TabbedMDIManager tabbedMDIManager1;
        private Syncfusion.Windows.Forms.BackStage backStage1;
        private Syncfusion.Windows.Forms.BackStageView backStageView1;
        private Syncfusion.Windows.Forms.BackStageButton SalirBackStageButton;
    }
}