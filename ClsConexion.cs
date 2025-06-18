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
    internal class ClsConexion
    {
       
        private static string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=..\\..\\Base de Datos\\Riquelme_IEFI.mdb;";

        public static OleDbConnection Conexion()
        {
            OleDbConnection conexion = new OleDbConnection(CadenaConexion);
            try
            {
                conexion.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }

            return conexion;
        }
    }
}
