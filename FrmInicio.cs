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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void LinkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistroUsuario usuario = new FrmRegistroUsuario();
            usuario.ShowDialog();
        }

        ClsRegistroUsuario usuario = new ClsRegistroUsuario();
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            var datosUsuario = usuario.Ingresar(TxtUsuario.Text, TxtContraseña.Text);
            if (datosUsuario != null)
            {
                DateTime inicioSesion = DateTime.Now;
                usuario.RegistrarAuditoria(datosUsuario.IdUsuario, inicioSesion);

                FrmSistemaPrincipal principal = new FrmSistemaPrincipal(datosUsuario, inicioSesion);
                principal.ShowDialog();
                this.Hide();
            }
        }
    }
}
