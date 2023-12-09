using bibliotecadb.datos;
using bibliotecadb.modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.dominio
{
    internal class PrestamoData : IPrestamo
    {

        StreamWriter erroraso = new StreamWriter("errores-Lector.txt");

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
            comando.Parameters.Add("@fechaPrestamo", MySqlDbType.VarChar);
            comando.Parameters["@fechaPrestamo"].Value = _prestamo.FechaPrestamos;
            comando.Parameters.Add("@fechaEntrega", MySqlDbType.VarChar);
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
                erroraso.WriteLine(error.ToString());
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
                erroraso.WriteLine(error.ToString());
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
            string consulta = "SELECT *FROM prestamos WHERE estado = true;";
            comando = new MySqlCommand(consulta, conn.GetConexion());
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                    prestamos _prestamo = new prestamos();
                    _prestamo.Id_Prestamo = puntero.GetInt16(0);
                    _prestamo.Id_lector = puntero.GetInt16(1);
                    _prestamo.Id_ejemplar = puntero.GetInt16(2);
                    _prestamo.FechaPrestamos = puntero.GetDateTime(3);
                    _prestamo.FechaEntrega = puntero.GetDateTime(4);
                    _prestamo.Estado = puntero.GetBoolean(6);

                    listaPrestamos.Add(_prestamo);
                }
            }
            catch (Exception)
            {
                throw;
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
            comando.Parameters.Add("@fechaPrestamo_", MySqlDbType.VarChar);
            comando.Parameters["@fechaPrestamo_"].Value = _prestamo.FechaPrestamos;
            comando.Parameters.Add("@fechaEntrega_", MySqlDbType.VarChar);
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
                erroraso.WriteLine(error.ToString());
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

        prestamos IPrestamo.buscarPrestamo(string _id_ejemplar)
        {
            string sql = "SELECT * FROM prestamos WHERE id_ejemplar=@id_ejemplar_ AND estado = TRUE;";
            comando = new MySqlCommand(sql, conn.GetConexion());
            prestamos prestamo = new prestamos();

            comando.Parameters.Add("@id_ejemplar_", MySqlDbType.String);
            comando.Parameters["@id_ejemplar_"].Value = _id_ejemplar;
            try
            {

                MySqlDataReader puntero = comando.ExecuteReader();

                while (puntero.Read())
                {
                    prestamo.Id_Prestamo = puntero.GetInt16(0);
                    prestamo.Id_lector = puntero.GetInt16(1);
                    prestamo.Id_ejemplar = puntero.GetInt16(2);
                    prestamo.FechaPrestamos = puntero.GetDateTime(3);
                    prestamo.FechaEntrega = puntero.GetDateTime(4);
                    prestamo.Estado = puntero.GetBoolean(6);

                }
                conn.setConexion();
            }
            catch (MySqlException error)
            {
                erroraso.WriteLine(error.ToString());
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

        prestamos IPrestamo.buscarPrestamoXid(string _id_Prestamo)
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
                    prestamo.Id_Prestamo = puntero.GetInt16(0);
                    prestamo.Id_lector = puntero.GetInt16(1);
                    prestamo.Id_ejemplar = puntero.GetInt16(2);
                    prestamo.FechaPrestamos = puntero.GetDateTime(3);
                    prestamo.FechaEntrega = puntero.GetDateTime(4);
                    prestamo.Estado = puntero.GetBoolean(6);
                }
                conn.setConexion();
            }
            catch (MySqlException error)
            {
                erroraso.WriteLine(error.ToString());
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
    }
}
