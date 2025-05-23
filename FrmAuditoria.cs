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
    public partial class FrmAuditoria : Form
    {
        public FrmAuditoria()
        {
            InitializeComponent();
        }

        ClsRegistroUsuario usuario = new ClsRegistroUsuario();
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            DgvUsuarios.Visible = true;
            usuario.Mostrar(DgvUsuarios);
        }
    }
}
