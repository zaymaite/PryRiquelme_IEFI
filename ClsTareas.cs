using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PryRiquelme_IEFI
{
    internal class ClsTareas
    {
        public class TareaItem
        {
            public int ID { get; set; }
            public string Tarea { get; set; }

        }
        
        OleDbDataAdapter adaptador = new OleDbDataAdapter();

        public void AgregarTarea(String Tarea)
        {
            using(OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string verificarQuery = "SELECT COUNT(*) FROM Tareas WHERE [Tarea] = ?";
                    using (OleDbCommand verificarCmd = new OleDbCommand(verificarQuery, conexion))
                    {
                        verificarCmd.Parameters.AddWithValue("?", Tarea);
                        int cantidad = Convert.ToInt32(verificarCmd.ExecuteScalar());

                        if (cantidad > 0)
                        {
                            MessageBox.Show("⚠️ Esa tarea ya existe.");
                            return;
                        }
                    }

                    string query = "INSERT INTO Tareas ([Tarea]) VALUES (?)";
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Parameters.Clear();
                        comando.Connection = conexion;
                        comando.CommandText = query;
                        comando.Parameters.AddWithValue("?", Tarea);
                        comando.ExecuteNonQuery();

                        MessageBox.Show("✅ Tarea agregada correctamente.");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ No se pudo agregar la tarea: " + ex.Message);
                }
            }
        }

        public void MostrarTarea(ComboBox combo)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string query = "SELECT [IdTarea], [Tarea] FROM Tareas";
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    using (OleDbDataReader reader = comando.ExecuteReader())
                    {
                        List<TareaItem> lista = new List<TareaItem>();

                        while (reader.Read())
                        {
                            lista.Add(new TareaItem
                            {
                                ID = Convert.ToInt32(reader["IdTarea"]),
                                Tarea = reader["Tarea"].ToString()
                            });
                        }

                        combo.DataSource = lista;
                        combo.DisplayMember = "Tarea";  // lo que se ve
                        combo.ValueMember = "ID";       // lo que se guarda
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ No se pueden mostrar las tareas: " + ex.Message);
                }
            }

        }

        public void ModificarTarea(int id, String TareaNueva)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string query = "UPDATE Tareas SET [Tarea] = ? WHERE [IdTarea] = ?";
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", TareaNueva);
                        comando.Parameters.AddWithValue("?", id);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("✅ Tarea modificada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("⚠️ No se encontró la tarea a modificar.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al modificar la tarea: " + ex.Message);
                }
            }
        }

        public void EliminarTarea(int id)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string query = "DELETE FROM Tareas WHERE [IdTarea] = ?";
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", id);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("🗑️ Tarea eliminada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("⚠️ No se encontró la tarea a eliminar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al eliminar la tarea: " + ex.Message);
                }
            }
        }
    }
}
