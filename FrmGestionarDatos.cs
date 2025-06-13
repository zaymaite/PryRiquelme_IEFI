using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PryRiquelme_IEFI.ClsLugares;
using static PryRiquelme_IEFI.ClsTareas;

namespace PryRiquelme_IEFI
{
    public partial class FrmGestionarDatos : Form
    {
        private string _pestañaInicial;

        public FrmGestionarDatos(string pestañaInicial)
        {
            InitializeComponent();
            _pestañaInicial = pestañaInicial;
            
        }

        ClsTareas tareas = new ClsTareas();
        ClsLugares lugares = new ClsLugares();

        
        private void FrmGestionarDatos_Load(object sender, EventArgs e)
        {
            if (_pestañaInicial == "tarea")
            {
                TpLugar.Parent = null;
                TabDatos.TabPages.Remove(TpLugar);
                TabDatos.SelectedTab = TpTareas;
            }
            if (_pestañaInicial == "lugar")
            {
                TpTareas.Parent = null;
                TabDatos.TabPages.Remove(TpTareas);
                TabDatos.SelectedTab = TpLugar;
            }
            tareas.MostrarTarea(CmbTarea);
            lugares.MostrarLugar(CmbLugar);

            CmbTarea.SelectedIndex = -1;
            CmbLugar.SelectedIndex = -1;
        }
        #region Tarea
        private void CmbTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbTarea.SelectedItem != null)
            {
                TxtTarea.Text = CmbTarea.SelectedItem.ToString();
            }

        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (CmbTarea.SelectedItem != null && CmbTarea.SelectedItem is TareaItem tareaSeleccionada)
            {
                tareas.EliminarTarea(tareaSeleccionada.ID);
                tareas.MostrarTarea(CmbTarea);
                TxtTarea.Clear();
            }
            else
            {
                MessageBox.Show("⚠️ Selecciona una tarea para eliminar.");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (CmbTarea.SelectedItem != null && CmbTarea.SelectedItem is TareaItem tareaSeleccionada)
            {
                string tareaNueva = TxtTarea.Text.Trim();

                if (!string.IsNullOrWhiteSpace(tareaNueva))
                {
                    tareas.ModificarTarea(tareaSeleccionada.ID, tareaNueva);
                    tareas.MostrarTarea(CmbTarea);
                    TxtTarea.Clear();
                }
                else
                {
                    MessageBox.Show("⚠️ Ingresa un nuevo nombre para la tarea.");
                }
            }
            else
            {
                MessageBox.Show("⚠️ Selecciona una tarea para modificar.");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            tareas.AgregarTarea(TxtTarea.Text.Trim());
            tareas.MostrarTarea(CmbTarea); 
            TxtTarea.Clear();
        }
        #endregion

        #region Lugar
        private void BtnAgregarLugar_Click(object sender, EventArgs e)
        {
            lugares.AgregarLugar(TxtLugar.Text.Trim());
            lugares.MostrarLugar(CmbLugar);
            TxtLugar.Clear();
        }

        private void CmbLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbLugar.SelectedItem != null)
            {
                TxtLugar.Text = CmbLugar.SelectedItem.ToString();
            }

            CmbLugar.SelectedItem = -1;
        }

        private void BtnModificarLugar_Click(object sender, EventArgs e)
        {
            if (CmbLugar.SelectedItem != null && CmbLugar.SelectedItem is LugaresItem lugarSeleccionado)
            {
                string lugarNuevo = TxtLugar.Text.Trim();

                if (!string.IsNullOrWhiteSpace(lugarNuevo))
                {
                    lugares.ModificarLugar(lugarSeleccionado.ID, lugarNuevo);
                    lugares.MostrarLugar(CmbLugar);
                    TxtLugar.Clear();
                }
                else
                {
                    MessageBox.Show("⚠️ Ingresa un nuevo nombre para el lugar.");
                }
            }
            else
            {
                MessageBox.Show("⚠️ Selecciona un lugar para modificar.");
            }
        }

        private void BtnEliminarLugar_Click(object sender, EventArgs e)
        {
            if (CmbLugar.SelectedItem != null && CmbLugar.SelectedItem is LugaresItem lugarSeleccionado)
            {
                lugares.EliminarLugar(lugarSeleccionado.ID);
                lugares.MostrarLugar(CmbLugar);
                TxtLugar.Clear();
            }
            else
            {
                MessageBox.Show("⚠️ Selecciona un lugar para eliminar.");
            }
        }
        #endregion
    }
}
