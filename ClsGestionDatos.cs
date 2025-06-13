using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PryRiquelme_IEFI.ClsRegistroUsuario;

namespace PryRiquelme_IEFI
{
    internal class ClsGestionDatos
    {
        private UsuarioLogueado _usuario;

        public ClsGestionDatos(UsuarioLogueado usuario)
        {
            _usuario = usuario;
        }

        public void GuardarGestion(int idTarea, int idLugar, DateTime fecha)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string query = "INSERT INTO [Gestion Datos] (IdUsuario, IdTarea, Fecha, IdLugar) VALUES (?, ?, ?, ?)";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", _usuario.IdUsuario);
                        comando.Parameters.AddWithValue("?", idTarea);
                        comando.Parameters.AddWithValue("?", fecha.ToShortDateString());
                        comando.Parameters.AddWithValue("?", idLugar);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("✅ Datos guardados correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al guardar los datos: " + ex.Message);
                }
            }
        }

        public void MostrarConsultaLugarTarea(DataGridView grilla)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string query = "SELECT * FROM [Lugar-Tarea]";  // Usá el nombre exacto de la consulta en Access

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(query, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    grilla.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al mostrar los datos desde la consulta 'Lugar-Tarea': " + ex.Message);
                }
            }
        }

        public void GuardarDetalles(string uniforme, string licencia, string reclamo, string comentario)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string query = "INSERT INTO [Detalles] (IdUsuario, Uniforme, Licencia, Reclamo, Comentario) VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", _usuario.IdUsuario);
                        comando.Parameters.AddWithValue("?", uniforme);
                        comando.Parameters.AddWithValue("?", licencia);
                        comando.Parameters.AddWithValue("?", reclamo);
                        comando.Parameters.AddWithValue("?", comentario);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("✅ Detalles guardados correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al guardar los detalles: " + ex.Message);
                }
            }
        }
    }
}
