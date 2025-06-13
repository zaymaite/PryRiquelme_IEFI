using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryRiquelme_IEFI
{
    internal class ClsHistorial
    {
        public void MostrarHistorial(DataGridView grilla, string usuario, DateTime? fecha, string tarea)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    // Base query
                    string query = "SELECT * FROM (SELECT Nombre, Tarea, Fecha, Uniforme, Licencia, Reclamo, Comentario FROM Detalles) AS Historial";
                    List<string> condiciones = new List<string>();
                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = conexion;

                    // Filtros opcionales
                    if (!string.IsNullOrEmpty(usuario))
                    {
                        condiciones.Add("Nombre = ?");
                        comando.Parameters.AddWithValue("?", usuario);
                    }

                    if (fecha.HasValue)
                    {
                        condiciones.Add("Fecha = ?");
                        comando.Parameters.AddWithValue("?", fecha.Value.Date);
                    }

                    if (!string.IsNullOrEmpty(tarea))
                    {
                        condiciones.Add("Tarea = ?");
                        comando.Parameters.AddWithValue("?", tarea);
                    }

                    if (condiciones.Count > 0)
                    {
                        query += " WHERE " + string.Join(" AND ", condiciones);
                    }
                    comando.CommandText = query;

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    grilla.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al mostrar historial: " + ex.Message);
                }
            }
        }

        public void CargarUsuarios(ComboBox combo)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string query = "SELECT Nombre FROM Registro_Usuario ORDER BY Nombre";
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    using (OleDbDataReader reader = comando.ExecuteReader())
                    {
                        combo.Items.Clear();

                        while (reader.Read())
                        {
                            combo.Items.Add(reader["Nombre"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al cargar usuarios: " + ex.Message);
                }
            }
        }
    }
}
