using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PryRiquelme_IEFI
{
    internal class ClsHistorial
    {
        ClsConexion conexion = new ClsConexion();
        public void MostrarHistorial(DataGridView grilla, string usuario, DateTime? fecha)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Debe seleccionar un usuario.");
                return;
            }

            string query = "SELECT Registro_Usuario.Nombre, Detalles.Fecha, Detalles.Uniforme, Detalles.Comentario " +
                           "FROM ((Registro_Usuario INNER JOIN Detalles ON Registro_Usuario.IdUsuario = Detalles.IdUsuario) " +
                           "INNER JOIN Detalle_Reclamos ON Detalles.IdDetalles = Detalle_Reclamos.IdDetalle) " +
                           "INNER JOIN Detalle_Licencia ON Detalles.IdDetalles = Detalle_Licencia.IdDetalle "
                           +
                           "WHERE Registro_Usuario.Nombre = @NombreUsuario";

            //if (fecha.HasValue)
            //{
            //    query += " AND FORMAT(Detalles.Fecha, "DD/MM/yyyy" = @Fecha";
            //}

            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {

                    OleDbCommand command = new OleDbCommand(query, conexion);
                    command.Parameters.AddWithValue("@NombreUsuario", usuario);

                    if (fecha.HasValue)
                        command.Parameters.AddWithValue("@Fecha", fecha.Value.Date);
                        

                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    grilla.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar historial: " + ex.Message);
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
