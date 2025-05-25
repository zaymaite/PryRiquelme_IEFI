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
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.LblDatos = new System.Windows.Forms.Label();
            this.GrpPersonal = new System.Windows.Forms.GroupBox();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.TxtConfiContraseña = new System.Windows.Forms.TextBox();
            this.LblConfirmar = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.GrpPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(24, 28);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(55, 15);
            this.LblNombre.TabIndex = 18;
            this.LblNombre.Text = "Nombre ";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(86, 25);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(216, 21);
            this.TxtNombre.TabIndex = 19;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Enabled = false;
            this.TxtApellido.Location = new System.Drawing.Point(86, 71);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(216, 21);
            this.TxtApellido.TabIndex = 21;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(24, 74);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(51, 15);
            this.LblApellido.TabIndex = 20;
            this.LblApellido.Text = "Apellido";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Enabled = false;
            this.TxtCorreo.Location = new System.Drawing.Point(86, 117);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(216, 21);
            this.TxtCorreo.TabIndex = 23;
            this.TxtCorreo.TextChanged += new System.EventHandler(this.TxtCorreo_TextChanged);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(24, 120);
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
            this.BtnCrear.Location = new System.Drawing.Point(316, 378);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(145, 36);
            this.BtnCrear.TabIndex = 24;
            this.BtnCrear.Text = "Crear Cuenta";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // LblDatos
            // 
            this.LblDatos.AutoSize = true;
            this.LblDatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatos.Location = new System.Drawing.Point(143, 9);
            this.LblDatos.Name = "LblDatos";
            this.LblDatos.Size = new System.Drawing.Size(182, 25);
            this.LblDatos.TabIndex = 25;
            this.LblDatos.Text = "Ingrese sus datos";
            // 
            // GrpPersonal
            // 
            this.GrpPersonal.BackColor = System.Drawing.Color.BurlyWood;
            this.GrpPersonal.Controls.Add(this.CmbCategoria);
            this.GrpPersonal.Controls.Add(this.LblCategoria);
            this.GrpPersonal.Controls.Add(this.TxtConfiContraseña);
            this.GrpPersonal.Controls.Add(this.LblConfirmar);
            this.GrpPersonal.Controls.Add(this.TxtContraseña);
            this.GrpPersonal.Controls.Add(this.TxtUsuario);
            this.GrpPersonal.Controls.Add(this.LblContraseña);
            this.GrpPersonal.Controls.Add(this.LblUsuario);
            this.GrpPersonal.Controls.Add(this.LblNombre);
            this.GrpPersonal.Controls.Add(this.TxtNombre);
            this.GrpPersonal.Controls.Add(this.LblApellido);
            this.GrpPersonal.Controls.Add(this.TxtApellido);
            this.GrpPersonal.Controls.Add(this.LblCorreo);
            this.GrpPersonal.Controls.Add(this.TxtCorreo);
            this.GrpPersonal.Location = new System.Drawing.Point(12, 51);
            this.GrpPersonal.Name = "GrpPersonal";
            this.GrpPersonal.Size = new System.Drawing.Size(381, 321);
            this.GrpPersonal.TabIndex = 28;
            this.GrpPersonal.TabStop = false;
            this.GrpPersonal.Text = "Datos Personales";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.CmbCategoria.Location = new System.Drawing.Point(102, 152);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(200, 23);
            this.CmbCategoria.TabIndex = 35;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(24, 155);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(60, 15);
            this.LblCategoria.TabIndex = 34;
            this.LblCategoria.Text = "Categoria";
            // 
            // TxtConfiContraseña
            // 
            this.TxtConfiContraseña.Enabled = false;
            this.TxtConfiContraseña.Location = new System.Drawing.Point(154, 279);
            this.TxtConfiContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtConfiContraseña.Name = "TxtConfiContraseña";
            this.TxtConfiContraseña.Size = new System.Drawing.Size(216, 21);
            this.TxtConfiContraseña.TabIndex = 33;
            this.TxtConfiContraseña.TextChanged += new System.EventHandler(this.TxtConfiContraseña_TextChanged_1);
            // 
            // LblConfirmar
            // 
            this.LblConfirmar.AutoSize = true;
            this.LblConfirmar.Location = new System.Drawing.Point(19, 282);
            this.LblConfirmar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblConfirmar.Name = "LblConfirmar";
            this.LblConfirmar.Size = new System.Drawing.Size(127, 15);
            this.LblConfirmar.TabIndex = 32;
            this.LblConfirmar.Text = "Confirmar Contraseña";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Enabled = false;
            this.TxtContraseña.Location = new System.Drawing.Point(97, 238);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(216, 21);
            this.TxtContraseña.TabIndex = 31;
            this.TxtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged_1);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Enabled = false;
            this.TxtUsuario.Location = new System.Drawing.Point(142, 193);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(216, 21);
            this.TxtUsuario.TabIndex = 30;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged_1);
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(19, 241);
            this.LblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(70, 15);
            this.LblContraseña.TabIndex = 29;
            this.LblContraseña.Text = "Contraseña";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(19, 196);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(115, 15);
            this.LblUsuario.TabIndex = 28;
            this.LblUsuario.Text = "Nombre de Usuario";
            // 
            // FrmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(473, 426);
            this.Controls.Add(this.GrpPersonal);
            this.Controls.Add(this.LblDatos);
            this.Controls.Add(this.BtnCrear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";
            this.GrpPersonal.ResumeLayout(false);
            this.GrpPersonal.PerformLayout();
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
    }
}