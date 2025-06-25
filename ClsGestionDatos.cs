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
                    string query = "SELECT * FROM [Lugar-Tarea]";  // Nombre exacto de la consulta en Access

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

       

        public void GuardarDetalles(DateTime fecha, string uniforme, List<int> licencias, List<int> reclamos, string comentario)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                OleDbTransaction transaccion = null;

                try
                {

                    transaccion = conexion.BeginTransaction();
                    string query = "INSERT INTO Detalles (IdUsuario, [Fecha], Uniforme, Comentario) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conexion, transaccion))
                    {
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = _usuario.IdUsuario;   
                        cmd.Parameters.Add("?", OleDbType.Date).Value = fecha;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = uniforme;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comentario;
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Obtener el último IdDetalle insertado
                    int idDetalle;
                    using (OleDbCommand cmdId = new OleDbCommand("SELECT @@IDENTITY", conexion, transaccion))
                    {
                        cmdId.Parameters.Clear();
                        idDetalle = Convert.ToInt32(cmdId.ExecuteScalar());
                    }

                    // 3. Insertar en tabla intermedia Detalle_Licencia
                    foreach (int idLicencia in licencias)
                    {
                        string queryLicencia = "INSERT INTO Detalle_Licencia (IdDetalle, IdLicencia) VALUES (?, ?)";
                        using (OleDbCommand cmdLic = new OleDbCommand(queryLicencia, conexion, transaccion))
                        {
                            cmdLic.Parameters.Clear();
                            cmdLic.Parameters.AddWithValue("?", idDetalle);
                            cmdLic.Parameters.AddWithValue("?", idLicencia);
                            cmdLic.ExecuteNonQuery();
                        }
                    }

                    // 4. Insertar en tabla intermedia Detalle_Reclamos
                    foreach (int idReclamo in reclamos)
                    {
                        string queryReclamo = "INSERT INTO Detalle_Reclamos (IdDetalle, IdReclamos) VALUES (?, ?)";
                        using (OleDbCommand cmdRec = new OleDbCommand(queryReclamo, conexion, transaccion))
                        {
                            cmdRec.Parameters.Clear();
                            cmdRec.Parameters.AddWithValue("?", idDetalle);
                            cmdRec.Parameters.AddWithValue("?", idReclamo);
                            cmdRec.ExecuteNonQuery();
                        }
                    }

                    // 5. Confirmar transacción
                    transaccion.Commit();
                    MessageBox.Show("✅ Detalles guardados correctamente.");
                }
                catch (Exception ex)
                {
                    transaccion?.Rollback();
                    MessageBox.Show("❌ Error al guardar los detalles: " + ex.Message);
                }
            }
        }
    }
}
