namespace PryRiquelme_IEFI
{
    partial class FrmGestionarDatos
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
            this.TabDatos = new System.Windows.Forms.TabControl();
            this.TpTareas = new System.Windows.Forms.TabPage();
            this.CmbTarea = new System.Windows.Forms.ComboBox();
            this.LblTareas = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtTarea = new System.Windows.Forms.TextBox();
            this.LblTarea = new System.Windows.Forms.Label();
            this.TpLugar = new System.Windows.Forms.TabPage();
            this.CmbLugar = new System.Windows.Forms.ComboBox();
            this.LblLugares = new System.Windows.Forms.Label();
            this.BtnModificarLugar = new System.Windows.Forms.Button();
            this.BtnEliminarLugar = new System.Windows.Forms.Button();
            this.BtnAgregarLugar = new System.Windows.Forms.Button();
            this.TxtLugar = new System.Windows.Forms.TextBox();
            this.LblLugar = new System.Windows.Forms.Label();
            this.TabDatos.SuspendLayout();
            this.TpTareas.SuspendLayout();
            this.TpLugar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabDatos
            // 
            this.TabDatos.Controls.Add(this.TpTareas);
            this.TabDatos.Controls.Add(this.TpLugar);
            this.TabDatos.Location = new System.Drawing.Point(44, 22);
            this.TabDatos.Name = "TabDatos";
            this.TabDatos.SelectedIndex = 0;
            this.TabDatos.Size = new System.Drawing.Size(560, 177);
            this.TabDatos.TabIndex = 1;
            // 
            // TpTareas
            // 
            this.TpTareas.Controls.Add(this.CmbTarea);
            this.TpTareas.Controls.Add(this.LblTareas);
            this.TpTareas.Controls.Add(this.BtnModificar);
            this.TpTareas.Controls.Add(this.BtnEliminar);
            this.TpTareas.Controls.Add(this.BtnAgregar);
            this.TpTareas.Controls.Add(this.TxtTarea);
            this.TpTareas.Controls.Add(this.LblTarea);
            this.TpTareas.Location = new System.Drawing.Point(4, 22);
            this.TpTareas.Name = "TpTareas";
            this.TpTareas.Padding = new System.Windows.Forms.Padding(3);
            this.TpTareas.Size = new System.Drawing.Size(552, 151);
            this.TpTareas.TabIndex = 0;
            this.TpTareas.Text = "Tareas";
            this.TpTareas.UseVisualStyleBackColor = true;
            // 
            // CmbTarea
            // 
            this.CmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTarea.FormattingEnabled = true;
            this.CmbTarea.Location = new System.Drawing.Point(91, 93);
            this.CmbTarea.Name = "CmbTarea";
            this.CmbTarea.Size = new System.Drawing.Size(190, 21);
            this.CmbTarea.TabIndex = 8;
            this.CmbTarea.SelectedIndexChanged += new System.EventHandler(this.CmbTarea_SelectedIndexChanged);
            // 
            // LblTareas
            // 
            this.LblTareas.AutoSize = true;
            this.LblTareas.Location = new System.Drawing.Point(19, 93);
            this.LblTareas.Name = "LblTareas";
            this.LblTareas.Size = new System.Drawing.Size(66, 26);
            this.LblTareas.TabIndex = 7;
            this.LblTareas.Text = "Seleccionar \r\nTarea";
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Location = new System.Drawing.Point(287, 93);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(101, 26);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(394, 93);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(107, 26);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(287, 31);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(101, 24);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtTarea
            // 
            this.TxtTarea.Location = new System.Drawing.Point(64, 31);
            this.TxtTarea.Name = "TxtTarea";
            this.TxtTarea.Size = new System.Drawing.Size(217, 20);
            this.TxtTarea.TabIndex = 1;
            // 
            // LblTarea
            // 
            this.LblTarea.AutoSize = true;
            this.LblTarea.Location = new System.Drawing.Point(19, 34);
            this.LblTarea.Name = "LblTarea";
            this.LblTarea.Size = new System.Drawing.Size(35, 13);
            this.LblTarea.TabIndex = 0;
            this.LblTarea.Text = "Tarea";
            // 
            // TpLugar
            // 
            this.TpLugar.Controls.Add(this.CmbLugar);
            this.TpLugar.Controls.Add(this.LblLugares);
            this.TpLugar.Controls.Add(this.BtnModificarLugar);
            this.TpLugar.Controls.Add(this.BtnEliminarLugar);
            this.TpLugar.Controls.Add(this.BtnAgregarLugar);
            this.TpLugar.Controls.Add(this.TxtLugar);
            this.TpLugar.Controls.Add(this.LblLugar);
            this.TpLugar.Location = new System.Drawing.Point(4, 22);
            this.TpLugar.Name = "TpLugar";
            this.TpLugar.Padding = new System.Windows.Forms.Padding(3);
            this.TpLugar.Size = new System.Drawing.Size(552, 151);
            this.TpLugar.TabIndex = 1;
            this.TpLugar.Text = "Lugar";
            this.TpLugar.UseVisualStyleBackColor = true;
            // 
            // CmbLugar
            // 
            this.CmbLugar.FormattingEnabled = true;
            this.CmbLugar.Location = new System.Drawing.Point(93, 98);
            this.CmbLugar.Name = "CmbLugar";
            this.CmbLugar.Size = new System.Drawing.Size(190, 21);
            this.CmbLugar.TabIndex = 16;
            this.CmbLugar.SelectedIndexChanged += new System.EventHandler(this.CmbLugar_SelectedIndexChanged);
            // 
            // LblLugares
            // 
            this.LblLugares.AutoSize = true;
            this.LblLugares.Location = new System.Drawing.Point(21, 98);
            this.LblLugares.Name = "LblLugares";
            this.LblLugares.Size = new System.Drawing.Size(66, 26);
            this.LblLugares.TabIndex = 15;
            this.LblLugares.Text = "Seleccionar \r\nLugar";
            // 
            // BtnModificarLugar
            // 
            this.BtnModificarLugar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnModificarLugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarLugar.Location = new System.Drawing.Point(302, 98);
            this.BtnModificarLugar.Name = "BtnModificarLugar";
            this.BtnModificarLugar.Size = new System.Drawing.Size(102, 27);
            this.BtnModificarLugar.TabIndex = 14;
            this.BtnModificarLugar.Text = "Modificar";
            this.BtnModificarLugar.UseVisualStyleBackColor = false;
            this.BtnModificarLugar.Click += new System.EventHandler(this.BtnModificarLugar_Click);
            // 
            // BtnEliminarLugar
            // 
            this.BtnEliminarLugar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnEliminarLugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarLugar.Location = new System.Drawing.Point(418, 97);
            this.BtnEliminarLugar.Name = "BtnEliminarLugar";
            this.BtnEliminarLugar.Size = new System.Drawing.Size(97, 28);
            this.BtnEliminarLugar.TabIndex = 13;
            this.BtnEliminarLugar.Text = "Eliminar";
            this.BtnEliminarLugar.UseVisualStyleBackColor = false;
            this.BtnEliminarLugar.Click += new System.EventHandler(this.BtnEliminarLugar_Click);
            // 
            // BtnAgregarLugar
            // 
            this.BtnAgregarLugar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnAgregarLugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarLugar.Location = new System.Drawing.Point(302, 32);
            this.BtnAgregarLugar.Name = "BtnAgregarLugar";
            this.BtnAgregarLugar.Size = new System.Drawing.Size(86, 26);
            this.BtnAgregarLugar.TabIndex = 12;
            this.BtnAgregarLugar.Text = "Agregar";
            this.BtnAgregarLugar.UseVisualStyleBackColor = false;
            this.BtnAgregarLugar.Click += new System.EventHandler(this.BtnAgregarLugar_Click);
            // 
            // TxtLugar
            // 
            this.TxtLugar.Location = new System.Drawing.Point(66, 38);
            this.TxtLugar.Name = "TxtLugar";
            this.TxtLugar.Size = new System.Drawing.Size(217, 20);
            this.TxtLugar.TabIndex = 11;
            // 
            // LblLugar
            // 
            this.LblLugar.AutoSize = true;
            this.LblLugar.Location = new System.Drawing.Point(21, 41);
            this.LblLugar.Name = "LblLugar";
            this.LblLugar.Size = new System.Drawing.Size(34, 13);
            this.LblLugar.TabIndex = 10;
            this.LblLugar.Text = "Lugar";
            // 
            // FrmGestionarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 268);
            this.Controls.Add(this.TabDatos);
            this.Name = "FrmGestionarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Datos";
            this.Load += new System.EventHandler(this.FrmGestionarDatos_Load);
            this.TabDatos.ResumeLayout(false);
            this.TpTareas.ResumeLayout(false);
            this.TpTareas.PerformLayout();
            this.TpLugar.ResumeLayout(false);
            this.TpLugar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabDatos;
        private System.Windows.Forms.TabPage TpTareas;
        private System.Windows.Forms.ComboBox CmbTarea;
        private System.Windows.Forms.Label LblTareas;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtTarea;
        private System.Windows.Forms.Label LblTarea;
        private System.Windows.Forms.TabPage TpLugar;
        private System.Windows.Forms.ComboBox CmbLugar;
        private System.Windows.Forms.Label LblLugares;
        private System.Windows.Forms.Button BtnModificarLugar;
        private System.Windows.Forms.Button BtnEliminarLugar;
        private System.Windows.Forms.Button BtnAgregarLugar;
        private System.Windows.Forms.TextBox TxtLugar;
        private System.Windows.Forms.Label LblLugar;
    }
}