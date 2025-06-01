namespace PryRiquelme_IEFI
{
    partial class FrmSistemaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSistemaPrincipal));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusUsuario = new System.Windows.Forms.StatusStrip();
            this.StatusLblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLblTiempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.ImagenLogo = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            this.StatusUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(817, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.auditoriasToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios...";
            // 
            // auditoriasToolStripMenuItem
            // 
            this.auditoriasToolStripMenuItem.Name = "auditoriasToolStripMenuItem";
            this.auditoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.auditoriasToolStripMenuItem.Text = "Auditorias...";
            this.auditoriasToolStripMenuItem.Click += new System.EventHandler(this.auditoriasToolStripMenuItem_Click);
            // 
            // StatusUsuario
            // 
            this.StatusUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLblUsuario,
            this.StatusLblTiempo});
            this.StatusUsuario.Location = new System.Drawing.Point(0, 497);
            this.StatusUsuario.Name = "StatusUsuario";
            this.StatusUsuario.Size = new System.Drawing.Size(817, 22);
            this.StatusUsuario.TabIndex = 1;
            this.StatusUsuario.Text = "statusStrip1";
            // 
            // StatusLblUsuario
            // 
            this.StatusLblUsuario.Name = "StatusLblUsuario";
            this.StatusLblUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusLblTiempo
            // 
            this.StatusLblTiempo.Name = "StatusLblTiempo";
            this.StatusLblTiempo.Size = new System.Drawing.Size(802, 17);
            this.StatusLblTiempo.Spring = true;
            this.StatusLblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tiempo
            // 
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // ImagenLogo
            // 
            this.ImagenLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImagenLogo.Image")));
            this.ImagenLogo.Location = new System.Drawing.Point(179, 61);
            this.ImagenLogo.Name = "ImagenLogo";
            this.ImagenLogo.Size = new System.Drawing.Size(484, 422);
            this.ImagenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImagenLogo.TabIndex = 2;
            this.ImagenLogo.TabStop = false;
            // 
            // FrmSistemaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 519);
            this.Controls.Add(this.ImagenLogo);
            this.Controls.Add(this.StatusUsuario);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmSistemaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSistemaPrincipal_FormClosing_1);
            this.Load += new System.EventHandler(this.FrmSistemaPrincipal_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.StatusUsuario.ResumeLayout(false);
            this.StatusUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusUsuario;
        private System.Windows.Forms.ToolStripStatusLabel StatusLblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel StatusLblTiempo;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.PictureBox ImagenLogo;
    }
}