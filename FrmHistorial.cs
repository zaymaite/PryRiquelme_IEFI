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
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }
        ClsHistorial historial = new ClsHistorial();
        ClsTareas tareas = new ClsTareas();
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string usuario = CmbUsuario.SelectedItem?.ToString();
            DateTime fecha = DtpFecha.Value.Date;
            string tarea = CmbTarea.SelectedItem?.ToString();

            DgvHistorial.Visible = true;
            historial.MostrarHistorial(DgvHistorial, usuario, fecha, tarea);

            CmbTarea.SelectedIndex = -1;
            CmbUsuario.SelectedIndex = -1;
        }

        private void GbHistorial_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            historial.CargarUsuarios(CmbUsuario);
            tareas.MostrarTarea(CmbTarea);

            CmbUsuario.SelectedIndex = -1;
            CmbTarea.SelectedIndex = -1;
        }
    }
    
}
