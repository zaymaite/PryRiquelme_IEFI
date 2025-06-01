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
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            TxtApellido.Enabled = !string.IsNullOrWhiteSpace(TxtNombre.Text);
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            TxtCorreo.Enabled = !string.IsNullOrWhiteSpace(TxtApellido.Text);
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            TxtUsuario.Enabled = !string.IsNullOrWhiteSpace(TxtCorreo.Text);
        }

        private void TxtUsuario_TextChanged_1(object sender, EventArgs e)
        {
            TxtContraseña.Enabled = !string.IsNullOrWhiteSpace(TxtUsuario.Text);
        }

        private void TxtContraseña_TextChanged_1(object sender, EventArgs e)
        {
            TxtConfiContraseña.Enabled = !string.IsNullOrWhiteSpace(TxtContraseña.Text);
        }

        ClsRegistroUsuario usuario = new ClsRegistroUsuario(); 
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text != "" && TxtApellido.Text != "" && TxtCorreo.Text != "" && CmbCategoria.SelectedItem != null && TxtUsuario.Text != "" && TxtContraseña.Text != "" && TxtConfiContraseña.Text != "") 
            {
                usuario.RegistrarUsuario(TxtNombre.Text, TxtApellido.Text, TxtCorreo.Text, CmbCategoria.SelectedItem.ToString(), TxtUsuario.Text, TxtContraseña.Text, TxtConfiContraseña.Text);
                FrmInicio inicio = new FrmInicio();
                inicio.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("⚠️ Por favor complete los datos para poder registrarse");
            }
            
        }

        

        private void TxtConfiContraseña_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {
            GrpUsuario.Visible = false;
            this.Size = new Size(433, 454);
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            GrpUsuario.Visible = true;
            GrpUsuario.Location = new Point(GrpPersonal.Right + 20, GrpPersonal.Top);
            this.Size = new Size(821, 454);
        }
    }
}
