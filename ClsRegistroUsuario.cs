using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace PryRiquelme_IEFI
{
    public class ClsRegistroUsuario
    {

        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        public void RegistrarUsuario(string nombre, string apellido, string correo, string categoria, string usuario, string contraseña, string confiContraseña)
        {

            if (contraseña != confiContraseña)
            {
                MessageBox.Show("❗ Las contraseñas no coinciden.");
                return;
            }
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {

                try
                {
                    string checkQuery = "SELECT COUNT(*) FROM Registro_Usuario WHERE [Nombre de usuario] = ?";
                    comando = new OleDbCommand(checkQuery, conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("?", usuario);

                    int contador = (int)comando.ExecuteScalar();
                    if (contador > 0)
                    {
                        MessageBox.Show("⚠️ El nombre de usuario ya está registrado.");
                        return;
                    }

                    string query = "INSERT INTO Registro_Usuario([Nombre], [Apellido], [Correo Electrónico], [Categoria], [Nombre de usuario], [Contraseña], [Confirmar Contraseña])" +
                                   "VALUES (?, ?, ?, ?, ?, ?, ?)";

                    comando.Connection = conexion;
                    comando.CommandText = query;
                    comando.Parameters.Clear(); //Siempre limpiar antes de usar
                    comando.Parameters.AddWithValue("?", nombre);
                    comando.Parameters.AddWithValue("?", apellido);
                    comando.Parameters.AddWithValue("?", correo);
                    comando.Parameters.AddWithValue("?", categoria);
                    comando.Parameters.AddWithValue("?", usuario);
                    comando.Parameters.AddWithValue("?", contraseña);
                    comando.Parameters.AddWithValue("?", confiContraseña);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("✅ Ya tienes una cuenta registrada.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ No se pudo registrar el usuario: " + ex.Message);
                }
            }
        }

        public class UsuarioLogueado
        {
            public int IdUsuario { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Usuario { get; set; }
        }

        public UsuarioLogueado Ingresar(string Usuario, string contraseña)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                string query = "SELECT * FROM Registro_Usuario WHERE [Nombre de usuario] = ? AND [Contraseña] = ?";
                comando.Connection = conexion;
                comando.CommandText = query;
                comando.Parameters.AddWithValue("?", Usuario);
                comando.Parameters.AddWithValue("?", contraseña);

                OleDbDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    return new UsuarioLogueado
                    {
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Usuario = reader["Nombre de usuario"].ToString(),
                    };
                }
                else
                {
                    MessageBox.Show("❌ Usuario o contraseña incorrectos.");
                    return null;
                }
            }
        }

        public void RegistrarAuditoria(int idUsuario, DateTime FechaHora)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                string query = "INSERT INTO Auditoria (IdUsuario, [Fecha_Hora]) VALUES (?, ?)"; //obliga a Access a interpretar los parámetros como número y fecha
                using (OleDbCommand comando = new OleDbCommand(query, conexion))
                {
                    comando.Parameters.Add("?", OleDbType.Integer).Value = idUsuario;
                    comando.Parameters.Add("?", OleDbType.Date).Value = FechaHora;
                    comando.ExecuteNonQuery();
                }

            }
        }
        public void RegistrarTiempoUso(int idUsuario, TimeSpan tiempoUso)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                string query = "UPDATE Auditoria SET [Tiempo de Uso] = ? WHERE IdUsuario = ? AND [Tiempo de Uso] IS NULL";
                using (OleDbCommand comando = new OleDbCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("?", tiempoUso.ToString(@"hh\:mm\:ss"));
                    comando.Parameters.AddWithValue("?", idUsuario);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Mostrar(DataGridView grilla)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.TableDirect;
                    comando.CommandText = "Auditoria";

                    DataSet DS = new DataSet();
                    adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(DS, "Auditoria");

                    grilla.DataSource = null;
                    grilla.DataSource = DS.Tables["Auditoria"];

                }
                catch (Exception ex)
                {
                    conexion.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
