using bibliotecadb.datos;
using bibliotecadb.modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotecadb.dominio
{
    internal class PrestamoData : IPrestamo
    {



        private conexion conn = new conexion();
        private MySqlCommand comando;

        public PrestamoData()
        {

        }
        public void agregarPrestamo(prestamos _prestamo)
        {
            string consulta = "INSERT INTO prestamos (id_lector,id_ejemplar,fechaPrestamo,fechaEntrega,estado) VALUE (@id_lector,@id_ejemplar,@fechaPrestamo,@fechaEntrega, TRUE);";

            comando = new MySqlCommand(consulta, conn.GetConexion());
            comando.Parameters.Add("@id_lector", MySqlDbType.VarChar);
            comando.Parameters["@id_lector"].Value = _prestamo.Id_lector;
            comando.Parameters.Add("@id_ejemplar", MySqlDbType.VarChar);
            comando.Parameters["@id_ejemplar"].Value = _prestamo.Id_ejemplar;
            comando.Parameters.Add("@fechaPrestamo", MySqlDbType.DateTime);
            comando.Parameters["@fechaPrestamo"].Value = _prestamo.FechaPrestamos;
            comando.Parameters.Add("@fechaEntrega", MySqlDbType.DateTime);
            comando.Parameters["@fechaEntrega"].Value = _prestamo.FechaEntrega;
            comando.Parameters.Add("@estado", MySqlDbType.Int16);
            comando.Parameters["@estado"].Value = _prestamo.Estado;

            try
            {
                int resultado = comando.ExecuteNonQuery();
                conn.setConexion();
            }
            catch (MySqlException error)
            {
                RegistrarErrorEnArchivo(error);
            }

            finally
            {
                if (conn.estadoConexion() == System.Data.ConnectionState.Open)
                {
                    conn.setConexion();
                }
                comando.Dispose();
            }
        }

        public void eliminarPrestamo(int _id_Prestamo)
        {
            string consulta = "UPDATE prestamos SET estado= 0 WHERE idPrestamo= @_id_Prestamo;";
            comando = new MySqlCommand(consulta, conn.GetConexion());

            comando.Parameters.Add("@_id_Prestamo", MySqlDbType.Int16);
            comando.Parameters["@_id_Prestamo"].Value = _id_Prestamo;

            try
            {
                int resultado = comando.ExecuteNonQuery();
                conn.setConexion();
            }
            catch (MySqlException error)
            {
                RegistrarErrorEnArchivo(error);
            }

            finally
            {
                if (conn.estadoConexion() == System.Data.ConnectionState.Open)
                {
                    conn.setConexion();
                }
                comando.Dispose();
            }
        }

        public List<prestamos> listarPrestamos()
        {
            List<prestamos> listaPrestamos = new List<prestamos>();
            string consulta = "SELECT *FROM prestamos WHERE estado = TRUE;";
            comando = new MySqlCommand(consulta, conn.GetConexion());
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                    prestamos _prestamo = new prestamos();
                    _prestamo.Id_Prestamo = puntero.GetInt32(0);
                    _prestamo.Id_lector = puntero.GetInt32(1);
                    _prestamo.Id_ejemplar = puntero.GetInt32(2);
                    _prestamo.FechaPrestamos = puntero.GetDateTime(3);
                    _prestamo.FechaEntrega = puntero.GetDateTime(4);
                    _prestamo.Estado = puntero.GetBoolean(5);

                    listaPrestamos.Add(_prestamo);
                }
            }
            catch (Exception error)
            {
                RegistrarErrorEnArchivo(error);
            }
            return (listaPrestamos);

        }

        public void modificarPrestamo(prestamos _prestamo)
        {

            string sql = "UPDATE prestamos SET id_lector=@id_lector_,id_ejemplar=@id_ejemplar_,fechaPrestamo=@fechaPrestamo_,fechaEntrega=@fechaEntrega_ WHERE idPrestamo = @id_;";

            comando = new MySqlCommand(sql, conn.GetConexion());

            comando.Parameters.Add("@id_lector_", MySqlDbType.VarChar);
            comando.Parameters["@id_lector_"].Value = _prestamo.Id_lector;
            comando.Parameters.Add("@id_ejemplar_", MySqlDbType.VarChar);
            comando.Parameters["@id_ejemplar_"].Value = _prestamo.Id_ejemplar;
            comando.Parameters.Add("@fechaPrestamo_", MySqlDbType.DateTime);
            comando.Parameters["@fechaPrestamo_"].Value = _prestamo.FechaPrestamos;
            comando.Parameters.Add("@fechaEntrega_", MySqlDbType.DateTime);
            comando.Parameters["@fechaEntrega_"].Value = _prestamo.FechaEntrega;
            comando.Parameters.Add("@id_", MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = _prestamo.Id_Prestamo;

            try
            {
                int resutado = comando.ExecuteNonQuery();
                conn.setConexion();
            }
            catch (MySqlException error)
            {
                RegistrarErrorEnArchivo(error);
            }

            finally
            {

                if (conn.estadoConexion() == System.Data.ConnectionState.Open)
                {
                    conn.setConexion();

                }
                comando.Dispose();
            }
        }

        public prestamos buscarPrestamoXidLector(string _id_lector)
        {
            string sql = "SELECT * FROM prestamos WHERE id_lector=@id_lector_ AND estado = TRUE;";
            comando = new MySqlCommand(sql, conn.GetConexion());
            prestamos prestamo = new prestamos();

            comando.Parameters.Add("@id_lector_", MySqlDbType.String);
            comando.Parameters["@id_lector_"].Value = _id_lector;
            try
            {

                MySqlDataReader puntero = comando.ExecuteReader();

                while (puntero.Read())
                {
                    prestamo.Id_Prestamo = puntero.GetInt32(0);
                    prestamo.Id_lector = puntero.GetInt32(1);
                    prestamo.Id_ejemplar = puntero.GetInt32(2);
                    prestamo.FechaPrestamos = puntero.GetDateTime(3);
                    prestamo.FechaEntrega = puntero.GetDateTime(4);
                    prestamo.Estado = puntero.GetBoolean(5);

                }
                conn.setConexion();
            }
            catch (MySqlException error)
            {
                RegistrarErrorEnArchivo(error);
            }

            finally
            {

                if (conn.estadoConexion() == System.Data.ConnectionState.Open)
                {
                    conn.setConexion();

                }
                comando.Dispose();
            }
            return (prestamo);
        }

        public prestamos buscarPrestamoXid(string _id_Prestamo)
        {
            string sql = "SELECT * FROM prestamos WHERE idPrestamo=@id_ AND estado = TRUE;";
            comando = new MySqlCommand(sql, conn.GetConexion());
            prestamos prestamo = new prestamos();

            comando.Parameters.Add("@id_", MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = _id_Prestamo;
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                    prestamo.Id_Prestamo = puntero.GetInt32(0);
                    prestamo.Id_lector = puntero.GetInt32(1);
                    prestamo.Id_ejemplar = puntero.GetInt32(2);
                    prestamo.FechaPrestamos = puntero.GetDateTime(3);
                    prestamo.FechaEntrega = puntero.GetDateTime(4);
                    prestamo.Estado = puntero.GetBoolean(5);
                }
                conn.setConexion();
            }
            catch (MySqlException error)
            {
                RegistrarErrorEnArchivo(error);
            }

            finally
            {

                if (conn.estadoConexion() == System.Data.ConnectionState.Open)
                {
                    conn.setConexion();

                }
                comando.Dispose();
            }
            return (prestamo);
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
