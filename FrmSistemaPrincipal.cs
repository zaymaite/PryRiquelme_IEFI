using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PryRiquelme_IEFI.ClsRegistroUsuario;

namespace PryRiquelme_IEFI
{
    public partial class FrmSistemaPrincipal : Form
    {
        string nombreUsuario;
        UsuarioLogueado usuarioActual;
        DateTime inicioSesion;
        public FrmSistemaPrincipal(UsuarioLogueado usuario, DateTime inicio)
        {
            InitializeComponent();
            usuarioActual = usuario;
            inicioSesion = inicio;
            nombreUsuario = $"{usuario.Nombre} {usuario.Apellido} ({usuario.Usuario})";
        }
        
        private void FrmSistemaPrincipal_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Tiempo_Tick;
            timer.Start();

            StatusLblUsuario.Text = $"👤 Sesión iniciada: {nombreUsuario}";
            administradorToolStripMenuItem.Visible = usuarioActual.Categoria == "Administrador" ;

            ImagenLogo.Left = (this.ClientSize.Width - ImagenLogo.Width) / 2;
            ImagenLogo.Top = (this.ClientSize.Height - ImagenLogo.Height) / 2;
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


        private void FrmSistemaPrincipal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            TimeSpan tiempoUso = DateTime.Now - inicioSesion;
            ClsRegistroUsuario auditoria = new ClsRegistroUsuario();
            auditoria.RegistrarTiempoUso(usuarioActual.IdUsuario, tiempoUso);
        }
    }
}
