namespace PryRiquelme_IEFI
{
    partial class FrmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorial));
            this.GbHistorial = new System.Windows.Forms.GroupBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DgvHistorial = new System.Windows.Forms.DataGridView();
            this.CmbUsuario = new System.Windows.Forms.ComboBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnVer = new System.Windows.Forms.Button();
            this.GbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // GbHistorial
            // 
            this.GbHistorial.BackColor = System.Drawing.Color.BurlyWood;
            this.GbHistorial.Controls.Add(this.BtnVer);
            this.GbHistorial.Controls.Add(this.BtnMostrar);
            this.GbHistorial.Controls.Add(this.DtpFecha);
            this.GbHistorial.Controls.Add(this.LblFecha);
            this.GbHistorial.Controls.Add(this.DgvHistorial);
            this.GbHistorial.Controls.Add(this.CmbUsuario);
            this.GbHistorial.Controls.Add(this.LblUsuario);
            this.GbHistorial.Location = new System.Drawing.Point(22, 21);
            this.GbHistorial.Name = "GbHistorial";
            this.GbHistorial.Size = new System.Drawing.Size(787, 330);
            this.GbHistorial.TabIndex = 9;
            this.GbHistorial.TabStop = false;
            this.GbHistorial.Text = "Filtrar Por:";
            this.GbHistorial.Enter += new System.EventHandler(this.GbHistorial_Enter);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(693, 290);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(79, 25);
            this.BtnMostrar.TabIndex = 16;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(469, 39);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(111, 21);
            this.DtpFecha.TabIndex = 13;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(422, 42);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(41, 15);
            this.LblFecha.TabIndex = 12;
            this.LblFecha.Text = "Fecha";
            // 
            // DgvHistorial
            // 
            this.DgvHistorial.BackgroundColor = System.Drawing.Color.Bisque;
            this.DgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistorial.Location = new System.Drawing.Point(99, 94);
            this.DgvHistorial.Name = "DgvHistorial";
            this.DgvHistorial.Size = new System.Drawing.Size(612, 170);
            this.DgvHistorial.TabIndex = 11;
            this.DgvHistorial.Visible = false;
            // 
            // CmbUsuario
            // 
            this.CmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUsuario.FormattingEnabled = true;
            this.CmbUsuario.Location = new System.Drawing.Point(212, 37);
            this.CmbUsuario.Name = "CmbUsuario";
            this.CmbUsuario.Size = new System.Drawing.Size(177, 23);
            this.CmbUsuario.TabIndex = 10;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(156, 39);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(50, 15);
            this.LblUsuario.TabIndex = 9;
            this.LblUsuario.Text = "Usuario";
            // 
            // BtnVer
            // 
            this.BtnVer.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer.Location = new System.Drawing.Point(572, 290);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(79, 25);
            this.BtnVer.TabIndex = 17;
            this.BtnVer.Text = "Mostrar";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 385);
            this.Controls.Add(this.GbHistorial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            this.GbHistorial.ResumeLayout(false);
            this.GbHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbHistorial;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DataGridView DgvHistorial;
        private System.Windows.Forms.ComboBox CmbUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnVer;
    }
}