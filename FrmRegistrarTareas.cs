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
    public partial class FrmRegistrarTareas : Form
    {
        private UsuarioLogueado usuarioActual;
        ClsGestionDatos datos;
        public FrmRegistrarTareas(UsuarioLogueado usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            datos = new ClsGestionDatos(usuarioActual);
        }

        ClsLugares lugares = new ClsLugares();
        ClsTareas tareas = new ClsTareas();
        

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial historial = new FrmHistorial();
            historial.ShowDialog();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmGestionarDatos datos = new FrmGestionarDatos("Tareas");
            datos.ShowDialog();
        }

        private void BtnAgregarLugar_Click(object sender, EventArgs e)
        {
            FrmGestionarDatos datos = new FrmGestionarDatos("Lugar");
            datos.ShowDialog();
        }

        private void FrmRegistrarTareas_Load(object sender, EventArgs e)
        {
            tareas.MostrarTarea(CmbTarea);
            lugares.MostrarLugar(CmbLugar);

            CmbTarea.SelectedIndex = -1;
            CmbLugar.SelectedIndex = -1;
            // Deshabilitar los botones si no es administrador
            bool esAdmin = usuarioActual.Categoria == "Administrador";
            BtnAgregar.Enabled = esAdmin;
            BtnAgregarLugar.Enabled = esAdmin;
        }

        private void CmbTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            int idTarea = Convert.ToInt32(CmbTarea.SelectedValue);
            int idLugar = Convert.ToInt32(CmbLugar.SelectedValue);

            if (CmbTarea.SelectedIndex != -1 && CmbLugar.SelectedIndex != -1)
            {
                datos.GuardarGestion(idTarea, idLugar, DtpFecha.Value);
                DgvTarea.Visible = true;
                datos.MostrarConsultaLugarTarea(DgvTarea);
            }

            CmbLugar.SelectedIndex = -1;
            CmbTarea.SelectedIndex = -1;
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            string uniforme = ChkInsumo.Checked ? "Insumo" : "";

            // Listas de IDs de licencias y reclamos seleccionados
            List<int> licencias = new List<int>();
            if (ChkEstudio.Checked) licencias.Add(1);   // ID 1 para "Estudio"
            if (ChkVacación.Checked) licencias.Add(2);  // ID 2 para "Vacación"

            List<int> reclamos = new List<int>();
            if (ChkSalario.Checked) reclamos.Add(1);    // ID 1 para "Salario"
            if (ChkRecibo.Checked) reclamos.Add(2);     // ID 2 para "Recibo"

            string comentario = TxtComentario.Text;
            DateTime fecha = DateTime.Now; 

            ClsGestionDatos detalles = new ClsGestionDatos(usuarioActual);
            detalles.GuardarDetalles(fecha, uniforme, licencias, reclamos, comentario);

            TxtComentario.Clear();
            ChkEstudio.Checked = false;
            ChkInsumo.Checked = false;
            ChkRecibo.Checked = false;
            ChkSalario.Checked = false;
            ChkVacación.Checked = false;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtComentario.Clear();
            ChkEstudio.Checked = false;
            ChkInsumo.Checked = false;
            ChkRecibo.Checked = false;
            ChkSalario.Checked = false;
            ChkVacación.Checked = false;
        }
    }
}
