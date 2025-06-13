using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PryRiquelme_IEFI.ClsLugares;

namespace PryRiquelme_IEFI
{
    internal class ClsLugares
    {
        public class LugaresItem
        {
            public int ID { get; set; }
            public string Lugar { get; set; }

            public override string ToString() => Lugar;
        }
        
        OleDbDataAdapter adaptador = new OleDbDataAdapter();

        public void AgregarLugar(String Lugar)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string verificarQuery = "SELECT COUNT(*) FROM Lugares WHERE [Lugar] = ?";
                    using (OleDbCommand verificarCmd = new OleDbCommand(verificarQuery, conexion))
                    {
                        verificarCmd.Parameters.AddWithValue("?", Lugar);
                        int cantidad = Convert.ToInt32(verificarCmd.ExecuteScalar());

                        if (cantidad > 0)
                        {
                            MessageBox.Show("⚠️ Ese lugar ya existe.");
                            return;
                        }
                    }

                    string query = "INSERT INTO Lugares ([Lugar]) VALUES (?)";
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = query;
                        comando.Parameters.AddWithValue("?", Lugar);
                        comando.ExecuteNonQuery();

                        MessageBox.Show("✅ Lugar agregado correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ No se pudo agregar el lugar: " + ex.Message);
                }
            }
        }

        public void MostrarLugar(ComboBox combo)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string query = "SELECT IdLugar, Lugar FROM Lugares";
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    using (OleDbDataReader reader = comando.ExecuteReader())
                    {
                        List<LugaresItem> lista = new List<LugaresItem>();

                        while (reader.Read())
                        {
                            lista.Add(new LugaresItem
                            {
                                ID = Convert.ToInt32(reader["IdLugar"]),
                                Lugar = reader["Lugar"].ToString()
                            });
                        }

                        combo.DataSource = lista;
                        combo.DisplayMember = "Lugar";
                        combo.ValueMember = "ID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ No se pueden mostrar los lugares: " + ex.Message);
                }
            }
        }

        public void ModificarLugar(int id, String LugarNuevo)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string query = "UPDATE Lugares SET [Lugar] = ? WHERE [IdLugar] = ?";
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Parameters.Clear();
                        comando.Connection = conexion;
                        comando.CommandText = query;
                        comando.Parameters.AddWithValue("?", LugarNuevo);
                        comando.Parameters.AddWithValue("?", id);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("✅ Lugar modificado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("⚠️ No se encontró el lugar a modificar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al modificar el lugar: " + ex.Message);
                }
            }

        }

        public void EliminarLugar(int id)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    string query = "DELETE FROM Lugares WHERE [IdLugar] = ?";
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Parameters.Clear();
                        comando.Connection = conexion;
                        comando.CommandText = query;
                        comando.Parameters.AddWithValue("?", id);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("🗑️ Lugar eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("⚠️ No se encontró el lugar a eliminar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al eliminar el lugar: " + ex.Message);
                }
            }
        }
    }
}
