using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace PryRiquelme_IEFI
{
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        ClsHistorial historial = new ClsHistorial();
        
        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            historial.CargarUsuarios(CmbUsuario);
            CmbUsuario.SelectedIndex = -1;

        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string usuario = CmbUsuario.SelectedItem?.ToString();
            DateTime fecha = DtpFecha.Value.Date;
            DateTime? fechaFiltro = fecha;

            DgvHistorial.Visible = true;
            historial.MostrarHistorial(DgvHistorial, usuario, fechaFiltro);

            CmbUsuario.SelectedIndex = -1;
        }

        private void GbHistorial_Enter(object sender, EventArgs e)
        {

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            string usuario = CmbUsuario.SelectedItem?.ToString();
            DateTime? fecha = DtpFecha.Value.Date;

            DgvHistorial.Visible = true;
            historial.MostrarHistorial(DgvHistorial, usuario, fecha);

            CmbUsuario.SelectedIndex = -1;


        }

    }

}
