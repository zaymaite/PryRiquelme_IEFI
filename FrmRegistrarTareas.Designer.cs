namespace PryRiquelme_IEFI
{
    partial class FrmRegistrarTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarTareas));
            this.LblFecha = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.GbTareas = new System.Windows.Forms.GroupBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAgregarLugar = new System.Windows.Forms.Button();
            this.CmbLugar = new System.Windows.Forms.ComboBox();
            this.LblLugar = new System.Windows.Forms.Label();
            this.DgvTarea = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CmbTarea = new System.Windows.Forms.ComboBox();
            this.LblTarea = new System.Windows.Forms.Label();
            this.GbDetalles = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.GbComentario = new System.Windows.Forms.GroupBox();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.GbReclamo = new System.Windows.Forms.GroupBox();
            this.ChkRecibo = new System.Windows.Forms.CheckBox();
            this.ChkSalario = new System.Windows.Forms.CheckBox();
            this.GbLicencia = new System.Windows.Forms.GroupBox();
            this.ChkVacación = new System.Windows.Forms.CheckBox();
            this.ChkEstudio = new System.Windows.Forms.CheckBox();
            this.GbUniforme = new System.Windows.Forms.GroupBox();
            this.ChkInsumo = new System.Windows.Forms.CheckBox();
            this.BtnHistorial = new System.Windows.Forms.Button();
            this.GbTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarea)).BeginInit();
            this.GbDetalles.SuspendLayout();
            this.GbComentario.SuspendLayout();
            this.GbReclamo.SuspendLayout();
            this.GbLicencia.SuspendLayout();
            this.GbUniforme.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(22, 19);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(54, 20);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(91, 17);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(110, 22);
            this.DtpFecha.TabIndex = 1;
            // 
            // GbTareas
            // 
            this.GbTareas.BackColor = System.Drawing.Color.BurlyWood;
            this.GbTareas.Controls.Add(this.BtnMostrar);
            this.GbTareas.Controls.Add(this.BtnAgregarLugar);
            this.GbTareas.Controls.Add(this.CmbLugar);
            this.GbTareas.Controls.Add(this.LblLugar);
            this.GbTareas.Controls.Add(this.DgvTarea);
            this.GbTareas.Controls.Add(this.BtnAgregar);
            this.GbTareas.Controls.Add(this.CmbTarea);
            this.GbTareas.Controls.Add(this.LblTarea);
            this.GbTareas.Location = new System.Drawing.Point(25, 50);
            this.GbTareas.Name = "GbTareas";
            this.GbTareas.Size = new System.Drawing.Size(787, 249);
            this.GbTareas.TabIndex = 2;
            this.GbTareas.TabStop = false;
            this.GbTareas.Text = "Tareas";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(702, 218);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(79, 25);
            this.BtnMostrar.TabIndex = 11;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAgregarLugar
            // 
            this.BtnAgregarLugar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnAgregarLugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarLugar.Location = new System.Drawing.Point(644, 27);
            this.BtnAgregarLugar.Name = "BtnAgregarLugar";
            this.BtnAgregarLugar.Size = new System.Drawing.Size(128, 33);
            this.BtnAgregarLugar.TabIndex = 8;
            this.BtnAgregarLugar.Text = "Agregar Lugar";
            this.BtnAgregarLugar.UseVisualStyleBackColor = false;
            this.BtnAgregarLugar.Click += new System.EventHandler(this.BtnAgregarLugar_Click);
            // 
            // CmbLugar
            // 
            this.CmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLugar.FormattingEnabled = true;
            this.CmbLugar.Location = new System.Drawing.Point(452, 33);
            this.CmbLugar.Name = "CmbLugar";
            this.CmbLugar.Size = new System.Drawing.Size(186, 23);
            this.CmbLugar.TabIndex = 7;
            // 
            // LblLugar
            // 
            this.LblLugar.AutoSize = true;
            this.LblLugar.Location = new System.Drawing.Point(404, 36);
            this.LblLugar.Name = "LblLugar";
            this.LblLugar.Size = new System.Drawing.Size(42, 15);
            this.LblLugar.TabIndex = 6;
            this.LblLugar.Text = "Lugar:";
            // 
            // DgvTarea
            // 
            this.DgvTarea.BackgroundColor = System.Drawing.Color.Bisque;
            this.DgvTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTarea.Location = new System.Drawing.Point(248, 83);
            this.DgvTarea.Name = "DgvTarea";
            this.DgvTarea.Size = new System.Drawing.Size(375, 144);
            this.DgvTarea.TabIndex = 3;
            this.DgvTarea.Visible = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(258, 27);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(128, 33);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar Tarea";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CmbTarea
            // 
            this.CmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTarea.FormattingEnabled = true;
            this.CmbTarea.Location = new System.Drawing.Point(66, 33);
            this.CmbTarea.Name = "CmbTarea";
            this.CmbTarea.Size = new System.Drawing.Size(186, 23);
            this.CmbTarea.TabIndex = 1;
            this.CmbTarea.SelectedIndexChanged += new System.EventHandler(this.CmbTarea_SelectedIndexChanged);
            // 
            // LblTarea
            // 
            this.LblTarea.AutoSize = true;
            this.LblTarea.Location = new System.Drawing.Point(18, 36);
            this.LblTarea.Name = "LblTarea";
            this.LblTarea.Size = new System.Drawing.Size(42, 15);
            this.LblTarea.TabIndex = 0;
            this.LblTarea.Text = "Tarea:";
            // 
            // GbDetalles
            // 
            this.GbDetalles.BackColor = System.Drawing.Color.BurlyWood;
            this.GbDetalles.Controls.Add(this.BtnCancelar);
            this.GbDetalles.Controls.Add(this.BtnGrabar);
            this.GbDetalles.Controls.Add(this.GbComentario);
            this.GbDetalles.Controls.Add(this.GbReclamo);
            this.GbDetalles.Controls.Add(this.GbLicencia);
            this.GbDetalles.Controls.Add(this.GbUniforme);
            this.GbDetalles.Location = new System.Drawing.Point(25, 305);
            this.GbDetalles.Name = "GbDetalles";
            this.GbDetalles.Size = new System.Drawing.Size(787, 227);
            this.GbDetalles.TabIndex = 9;
            this.GbDetalles.TabStop = false;
            this.GbDetalles.Text = "Detalles";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(644, 183);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(113, 33);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabar.Location = new System.Drawing.Point(510, 183);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(113, 33);
            this.BtnGrabar.TabIndex = 9;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = false;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // GbComentario
            // 
            this.GbComentario.BackColor = System.Drawing.Color.DarkSalmon;
            this.GbComentario.Controls.Add(this.TxtComentario);
            this.GbComentario.Location = new System.Drawing.Point(292, 20);
            this.GbComentario.Name = "GbComentario";
            this.GbComentario.Size = new System.Drawing.Size(464, 152);
            this.GbComentario.TabIndex = 3;
            this.GbComentario.TabStop = false;
            this.GbComentario.Text = "Comentario";
            // 
            // TxtComentario
            // 
            this.TxtComentario.Location = new System.Drawing.Point(21, 28);
            this.TxtComentario.Multiline = true;
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(424, 106);
            this.TxtComentario.TabIndex = 0;
            // 
            // GbReclamo
            // 
            this.GbReclamo.BackColor = System.Drawing.Color.DarkSalmon;
            this.GbReclamo.Controls.Add(this.ChkRecibo);
            this.GbReclamo.Controls.Add(this.ChkSalario);
            this.GbReclamo.Location = new System.Drawing.Point(21, 163);
            this.GbReclamo.Name = "GbReclamo";
            this.GbReclamo.Size = new System.Drawing.Size(220, 58);
            this.GbReclamo.TabIndex = 4;
            this.GbReclamo.TabStop = false;
            this.GbReclamo.Text = "Reclamo";
            // 
            // ChkRecibo
            // 
            this.ChkRecibo.AutoSize = true;
            this.ChkRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkRecibo.Location = new System.Drawing.Point(112, 20);
            this.ChkRecibo.Name = "ChkRecibo";
            this.ChkRecibo.Size = new System.Drawing.Size(70, 20);
            this.ChkRecibo.TabIndex = 2;
            this.ChkRecibo.Text = "Recibo";
            this.ChkRecibo.UseVisualStyleBackColor = true;
            // 
            // ChkSalario
            // 
            this.ChkSalario.AutoSize = true;
            this.ChkSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSalario.Location = new System.Drawing.Point(30, 20);
            this.ChkSalario.Name = "ChkSalario";
            this.ChkSalario.Size = new System.Drawing.Size(69, 20);
            this.ChkSalario.TabIndex = 1;
            this.ChkSalario.Text = "Salario";
            this.ChkSalario.UseVisualStyleBackColor = true;
            // 
            // GbLicencia
            // 
            this.GbLicencia.BackColor = System.Drawing.Color.DarkSalmon;
            this.GbLicencia.Controls.Add(this.ChkVacación);
            this.GbLicencia.Controls.Add(this.ChkEstudio);
            this.GbLicencia.Location = new System.Drawing.Point(21, 89);
            this.GbLicencia.Name = "GbLicencia";
            this.GbLicencia.Size = new System.Drawing.Size(220, 53);
            this.GbLicencia.TabIndex = 3;
            this.GbLicencia.TabStop = false;
            this.GbLicencia.Text = "Licencia";
            // 
            // ChkVacación
            // 
            this.ChkVacación.AutoSize = true;
            this.ChkVacación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkVacación.Location = new System.Drawing.Point(112, 20);
            this.ChkVacación.Name = "ChkVacación";
            this.ChkVacación.Size = new System.Drawing.Size(83, 20);
            this.ChkVacación.TabIndex = 2;
            this.ChkVacación.Text = "Vacación";
            this.ChkVacación.UseVisualStyleBackColor = true;
            // 
            // ChkEstudio
            // 
            this.ChkEstudio.AutoSize = true;
            this.ChkEstudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkEstudio.Location = new System.Drawing.Point(30, 20);
            this.ChkEstudio.Name = "ChkEstudio";
            this.ChkEstudio.Size = new System.Drawing.Size(71, 20);
            this.ChkEstudio.TabIndex = 1;
            this.ChkEstudio.Text = "Estudio";
            this.ChkEstudio.UseVisualStyleBackColor = true;
            // 
            // GbUniforme
            // 
            this.GbUniforme.BackColor = System.Drawing.Color.DarkSalmon;
            this.GbUniforme.Controls.Add(this.ChkInsumo);
            this.GbUniforme.Location = new System.Drawing.Point(21, 20);
            this.GbUniforme.Name = "GbUniforme";
            this.GbUniforme.Size = new System.Drawing.Size(220, 52);
            this.GbUniforme.TabIndex = 2;
            this.GbUniforme.TabStop = false;
            this.GbUniforme.Text = "Uniforme";
            // 
            // ChkInsumo
            // 
            this.ChkInsumo.AutoSize = true;
            this.ChkInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkInsumo.Location = new System.Drawing.Point(30, 20);
            this.ChkInsumo.Name = "ChkInsumo";
            this.ChkInsumo.Size = new System.Drawing.Size(69, 20);
            this.ChkInsumo.TabIndex = 1;
            this.ChkInsumo.Text = "Insumo";
            this.ChkInsumo.UseVisualStyleBackColor = true;
            // 
            // BtnHistorial
            // 
            this.BtnHistorial.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorial.Location = new System.Drawing.Point(727, 12);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Size = new System.Drawing.Size(85, 27);
            this.BtnHistorial.TabIndex = 9;
            this.BtnHistorial.Text = "Ver Historial";
            this.BtnHistorial.UseVisualStyleBackColor = false;
            this.BtnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // FrmRegistrarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 544);
            this.Controls.Add(this.BtnHistorial);
            this.Controls.Add(this.GbDetalles);
            this.Controls.Add(this.GbTareas);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.LblFecha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmRegistrarTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Tareas";
            this.Load += new System.EventHandler(this.FrmRegistrarTareas_Load);
            this.GbTareas.ResumeLayout(false);
            this.GbTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarea)).EndInit();
            this.GbDetalles.ResumeLayout(false);
            this.GbComentario.ResumeLayout(false);
            this.GbComentario.PerformLayout();
            this.GbReclamo.ResumeLayout(false);
            this.GbReclamo.PerformLayout();
            this.GbLicencia.ResumeLayout(false);
            this.GbLicencia.PerformLayout();
            this.GbUniforme.ResumeLayout(false);
            this.GbUniforme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.GroupBox GbTareas;
        private System.Windows.Forms.DataGridView DgvTarea;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox CmbTarea;
        private System.Windows.Forms.Label LblTarea;
        private System.Windows.Forms.Button BtnAgregarLugar;
        private System.Windows.Forms.ComboBox CmbLugar;
        private System.Windows.Forms.Label LblLugar;
        private System.Windows.Forms.GroupBox GbDetalles;
        private System.Windows.Forms.GroupBox GbUniforme;
        private System.Windows.Forms.CheckBox ChkInsumo;
        private System.Windows.Forms.GroupBox GbReclamo;
        private System.Windows.Forms.CheckBox ChkRecibo;
        private System.Windows.Forms.CheckBox ChkSalario;
        private System.Windows.Forms.GroupBox GbLicencia;
        private System.Windows.Forms.CheckBox ChkVacación;
        private System.Windows.Forms.CheckBox ChkEstudio;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.GroupBox GbComentario;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.Button BtnHistorial;
        private System.Windows.Forms.Button BtnMostrar;
    }
}