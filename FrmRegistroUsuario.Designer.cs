namespace PryRiquelme_IEFI
{
    partial class FrmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroUsuario));
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.LblDatos = new System.Windows.Forms.Label();
            this.GrpPersonal = new System.Windows.Forms.GroupBox();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.TxtConfiContraseña = new System.Windows.Forms.TextBox();
            this.LblConfirmar = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.GrpUsuario = new System.Windows.Forms.GroupBox();
            this.GrpPersonal.SuspendLayout();
            this.GrpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(26, 38);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(55, 15);
            this.LblNombre.TabIndex = 18;
            this.LblNombre.Text = "Nombre ";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtNombre.Location = new System.Drawing.Point(88, 35);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(216, 21);
            this.TxtNombre.TabIndex = 19;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtApellido.Enabled = false;
            this.TxtApellido.Location = new System.Drawing.Point(88, 75);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(216, 21);
            this.TxtApellido.TabIndex = 21;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(26, 78);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(51, 15);
            this.LblApellido.TabIndex = 20;
            this.LblApellido.Text = "Apellido";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtCorreo.Enabled = false;
            this.TxtCorreo.Location = new System.Drawing.Point(88, 120);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(216, 21);
            this.TxtCorreo.TabIndex = 23;
            this.TxtCorreo.TextChanged += new System.EventHandler(this.TxtCorreo_TextChanged);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(26, 123);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(44, 15);
            this.LblCorreo.TabIndex = 22;
            this.LblCorreo.Text = "Correo";
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.NavajoWhite;
            this.BtnCrear.FlatAppearance.BorderSize = 0;
            this.BtnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.BtnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Location = new System.Drawing.Point(231, 196);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(119, 33);
            this.BtnCrear.TabIndex = 24;
            this.BtnCrear.Text = "Crear Cuenta";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // LblDatos
            // 
            this.LblDatos.AutoSize = true;
            this.LblDatos.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LblDatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatos.Location = new System.Drawing.Point(144, 21);
            this.LblDatos.Name = "LblDatos";
            this.LblDatos.Size = new System.Drawing.Size(182, 25);
            this.LblDatos.TabIndex = 25;
            this.LblDatos.Text = "Ingrese sus datos";
            // 
            // GrpPersonal
            // 
            this.GrpPersonal.BackColor = System.Drawing.Color.White;
            this.GrpPersonal.Controls.Add(this.BtnContinuar);
            this.GrpPersonal.Controls.Add(this.CmbCategoria);
            this.GrpPersonal.Controls.Add(this.LblCategoria);
            this.GrpPersonal.Controls.Add(this.LblNombre);
            this.GrpPersonal.Controls.Add(this.TxtNombre);
            this.GrpPersonal.Controls.Add(this.LblApellido);
            this.GrpPersonal.Controls.Add(this.TxtApellido);
            this.GrpPersonal.Controls.Add(this.LblCorreo);
            this.GrpPersonal.Controls.Add(this.TxtCorreo);
            this.GrpPersonal.Location = new System.Drawing.Point(12, 86);
            this.GrpPersonal.Name = "GrpPersonal";
            this.GrpPersonal.Size = new System.Drawing.Size(381, 235);
            this.GrpPersonal.TabIndex = 28;
            this.GrpPersonal.TabStop = false;
            this.GrpPersonal.Text = "Datos Personales";
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.Color.NavajoWhite;
            this.BtnContinuar.FlatAppearance.BorderSize = 0;
            this.BtnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.BtnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar.Location = new System.Drawing.Point(277, 196);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(98, 33);
            this.BtnContinuar.TabIndex = 35;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = false;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.CmbCategoria.Location = new System.Drawing.Point(88, 162);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(216, 23);
            this.CmbCategoria.TabIndex = 35;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(26, 165);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(60, 15);
            this.LblCategoria.TabIndex = 34;
            this.LblCategoria.Text = "Categoria";
            // 
            // TxtConfiContraseña
            // 
            this.TxtConfiContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtConfiContraseña.Enabled = false;
            this.TxtConfiContraseña.Location = new System.Drawing.Point(102, 140);
            this.TxtConfiContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtConfiContraseña.Name = "TxtConfiContraseña";
            this.TxtConfiContraseña.Size = new System.Drawing.Size(216, 21);
            this.TxtConfiContraseña.TabIndex = 33;
            this.TxtConfiContraseña.TextChanged += new System.EventHandler(this.TxtConfiContraseña_TextChanged_1);
            // 
            // LblConfirmar
            // 
            this.LblConfirmar.AutoSize = true;
            this.LblConfirmar.Location = new System.Drawing.Point(24, 140);
            this.LblConfirmar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblConfirmar.Name = "LblConfirmar";
            this.LblConfirmar.Size = new System.Drawing.Size(70, 30);
            this.LblConfirmar.TabIndex = 32;
            this.LblConfirmar.Text = "Confirmar \r\nContraseña";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtContraseña.Enabled = false;
            this.TxtContraseña.Location = new System.Drawing.Point(102, 89);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(216, 21);
            this.TxtContraseña.TabIndex = 31;
            this.TxtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged_1);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtUsuario.Enabled = false;
            this.TxtUsuario.Location = new System.Drawing.Point(102, 35);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(216, 21);
            this.TxtUsuario.TabIndex = 30;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged_1);
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(24, 92);
            this.LblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(70, 15);
            this.LblContraseña.TabIndex = 29;
            this.LblContraseña.Text = "Contraseña";
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
            // GrpUsuario
            // 
            this.GrpUsuario.BackColor = System.Drawing.Color.White;
            this.GrpUsuario.Controls.Add(this.LblUsuario);
            this.GrpUsuario.Controls.Add(this.TxtUsuario);
            this.GrpUsuario.Controls.Add(this.LblContraseña);
            this.GrpUsuario.Controls.Add(this.BtnCrear);
            this.GrpUsuario.Controls.Add(this.TxtConfiContraseña);
            this.GrpUsuario.Controls.Add(this.TxtContraseña);
            this.GrpUsuario.Controls.Add(this.LblConfirmar);
            this.GrpUsuario.Location = new System.Drawing.Point(425, 86);
            this.GrpUsuario.Name = "GrpUsuario";
            this.GrpUsuario.Size = new System.Drawing.Size(356, 235);
            this.GrpUsuario.TabIndex = 34;
            this.GrpUsuario.TabStop = false;
            this.GrpUsuario.Text = "Datos de Usuario";
            // 
            // FrmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 415);
            this.Controls.Add(this.GrpUsuario);
            this.Controls.Add(this.GrpPersonal);
            this.Controls.Add(this.LblDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";
            this.Load += new System.EventHandler(this.FrmRegistroUsuario_Load);
            this.GrpPersonal.ResumeLayout(false);
            this.GrpPersonal.PerformLayout();
            this.GrpUsuario.ResumeLayout(false);
            this.GrpUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Label LblDatos;
        private System.Windows.Forms.GroupBox GrpPersonal;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.TextBox TxtConfiContraseña;
        private System.Windows.Forms.Label LblConfirmar;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnContinuar;
        private System.Windows.Forms.GroupBox GrpUsuario;
    }
}