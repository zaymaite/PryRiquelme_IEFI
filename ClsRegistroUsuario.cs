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
    internal class ClsRegistroUsuario
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

        public void Mostrar(DataGridView grilla)
        {
            using (OleDbConnection conexion = ClsConexion.Conexion())
            {
                try
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.TableDirect;
                    comando.CommandText = "Registro_Usuario";

                    DataSet DS = new DataSet();
                    adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(DS, "Registro_Usuario");

                    grilla.DataSource = null;
                    grilla.DataSource = DS.Tables["Registro_Usuario"];

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
