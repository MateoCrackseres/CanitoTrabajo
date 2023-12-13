using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using bibliotecadb.datos;
using System.IO;
using System.Windows.Forms;

namespace bibliotecadb.datos
{
    internal class conexion
    {
        private static string servidor = "127.0.0.1";
        private static string usuario = "root";
        private static string password = "";
        private static string BaseDatos = "dbbiblioteca";

        private static string CadenaConexion = "server=" + servidor + ";DataBase=" + BaseDatos + ";Uid=" + usuario + ";Pwd=" + password;

        //private static string CadenaConexion = "Server=127.0.01;DataBase=dbbiblioteca;Uid=root;Pwd=";
        public conexion()
        {

        }
        public MySqlConnection conn;
        public MySqlConnection GetConexion()
        {
            if (conn == null)
            {
                try
                {
                    conn = new MySqlConnection(CadenaConexion);
                    conn.Open();
                }
                catch (MySqlException error)
                {
                    RegistrarErrorEnArchivo(error);
                }

            }
            return conn;
        }
        public void setConexion()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public ConnectionState estadoConexion()
        {
            return (conn.State);
        }
        private void RegistrarErrorEnArchivo(Exception ex)
        {
            string mensajeError = $"Fecha y Hora: {DateTime.Now}\nError: {ex.Message}\n\n";

            try
            {
                using (StreamWriter mensaje = new StreamWriter("ErrorLectorData.txt"))
                {
                    mensaje.WriteLine(mensajeError);
                }

                MessageBox.Show("Error registrado en el archivo: " + "ErrorLectorData.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar registrar el error en el archivo.");
            }
        }
    }
}
    





