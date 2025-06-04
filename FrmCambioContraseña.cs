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
    public partial class FrmCambioContraseña : Form
    {
        public FrmCambioContraseña()
        {
            InitializeComponent();
        }

        ClsRegistroUsuario usuario = new ClsRegistroUsuario();

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            usuario.CambiarContraseña(TxtUsuario.Text, TxtCorreo.Text, TxtContraseña.Text, TxtConfiContraseña.Text);
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            TxtCorreo.Enabled = !string.IsNullOrWhiteSpace(TxtUsuario.Text);
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            TxtContraseña.Enabled = !string.IsNullOrWhiteSpace(TxtCorreo.Text);
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            TxtConfiContraseña.Enabled = !string.IsNullOrWhiteSpace(TxtContraseña.Text);
        }

        private void TxtConfiContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
