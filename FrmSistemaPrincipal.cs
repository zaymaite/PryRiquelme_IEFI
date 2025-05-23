using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryRiquelme_IEFI
{
    public partial class FrmSistemaPrincipal : Form
    {
        string nombreUsuario;
        public FrmSistemaPrincipal(string nombre, string apellido, string usuario)
        {
            InitializeComponent();
            nombreUsuario = $"{nombre} {apellido} ({usuario})";
        }
        
        private void FrmSistemaPrincipal_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Tiempo_Tick;
            timer.Start();

            StatusLblUsuario.Text = $"👤 Sesión iniciada: {nombreUsuario}";
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            StatusLblTiempo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void auditoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAuditoria auditoria = new FrmAuditoria();
            auditoria.ShowDialog();
        }
    }
}
