namespace PryRiquelme_IEFI
{
    partial class FrmCambioContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambioContraseña));
            this.GrpUsuario = new System.Windows.Forms.GroupBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.TxtConfiContraseña = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.LblConfirmar = new System.Windows.Forms.Label();
            this.GrpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpUsuario
            // 
            this.GrpUsuario.BackColor = System.Drawing.Color.White;
            this.GrpUsuario.Controls.Add(this.LblCorreo);
            this.GrpUsuario.Controls.Add(this.TxtCorreo);
            this.GrpUsuario.Controls.Add(this.LblUsuario);
            this.GrpUsuario.Controls.Add(this.TxtUsuario);
            this.GrpUsuario.Controls.Add(this.LblContraseña);
            this.GrpUsuario.Controls.Add(this.BtnModificar);
            this.GrpUsuario.Controls.Add(this.TxtConfiContraseña);
            this.GrpUsuario.Controls.Add(this.TxtContraseña);
            this.GrpUsuario.Controls.Add(this.LblConfirmar);
            this.GrpUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpUsuario.Location = new System.Drawing.Point(92, 76);
            this.GrpUsuario.Name = "GrpUsuario";
            this.GrpUsuario.Size = new System.Drawing.Size(418, 264);
            this.GrpUsuario.TabIndex = 35;
            this.GrpUsuario.TabStop = false;
            this.GrpUsuario.Text = "Datos de Usuario";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(24, 88);
            this.LblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(44, 15);
            this.LblCorreo.TabIndex = 34;
            this.LblCorreo.Text = "Correo";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtCorreo.Enabled = false;
            this.TxtCorreo.Location = new System.Drawing.Point(102, 85);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(216, 21);
            this.TxtCorreo.TabIndex = 35;
            this.TxtCorreo.TextChanged += new System.EventHandler(this.TxtCorreo_TextChanged);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(24, 35);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(72, 30);
            this.LblUsuario.TabIndex = 28;
            this.LblUsuario.Text = "Nombre de \r\nUsuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtUsuario.Location = new System.Drawing.Point(102, 35);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(216, 21);
            this.TxtUsuario.TabIndex = 30;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(24, 136);
            this.LblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(73, 30);
            this.LblContraseña.TabIndex = 29;
            this.LblContraseña.Text = "Contraseña \r\nNueva";
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.NavajoWhite;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(257, 233);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(155, 25);
            this.BtnModificar.TabIndex = 24;
            this.BtnModificar.Text = "Cambiar Contraseña";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TxtConfiContraseña
            // 
            this.TxtConfiContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtConfiContraseña.Enabled = false;
            this.TxtConfiContraseña.Location = new System.Drawing.Point(102, 181);
            this.TxtConfiContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtConfiContraseña.Name = "TxtConfiContraseña";
            this.TxtConfiContraseña.Size = new System.Drawing.Size(216, 21);
            this.TxtConfiContraseña.TabIndex = 33;
            this.TxtConfiContraseña.TextChanged += new System.EventHandler(this.TxtConfiContraseña_TextChanged);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtContraseña.Enabled = false;
            this.TxtContraseña.Location = new System.Drawing.Point(102, 133);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(216, 21);
            this.TxtContraseña.TabIndex = 31;
            this.TxtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            // 
            // LblConfirmar
            // 
            this.LblConfirmar.AutoSize = true;
            this.LblConfirmar.Location = new System.Drawing.Point(24, 184);
            this.LblConfirmar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblConfirmar.Name = "LblConfirmar";
            this.LblConfirmar.Size = new System.Drawing.Size(70, 30);
            this.LblConfirmar.TabIndex = 32;
            this.LblConfirmar.Text = "Confirmar \r\nContraseña";
            // 
            // FrmCambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 432);
            this.Controls.Add(this.GrpUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCambioContraseña";
            this.Text = "Cambiar Contraseña";
            this.GrpUsuario.ResumeLayout(false);
            this.GrpUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpUsuario;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox TxtConfiContraseña;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label LblConfirmar;
    }
}