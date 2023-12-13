using bibliotecadb.datos;
using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using MySqlX.XDevAPI;
using System.Windows.Forms;

namespace bibliotecadb.dominio
{
    internal class LectorData : ILector
    {
        private conexion conn = new conexion();
        private MySqlCommand comando;

        public LectorData()
        {
        }

        public void agregarLector(lectores _lector)
        {
            string consulta = "INSERT INTO lectores(apellido,nombre,dni,domicilio,telefono,estado) VALUE (@apellido,@nombre,@dni,@domicilio,@telefono, TRUE);";

            comando= new MySqlCommand(consulta,conn.GetConexion());
            comando.Parameters.Add("@apellido",MySqlDbType.VarChar);
            comando.Parameters["@apellido"].Value = _lector.Apellido;
            comando.Parameters.Add("@nombre",MySqlDbType.VarChar);
            comando.Parameters["@nombre"].Value = _lector.Nombre;
            comando.Parameters.Add("@dni", MySqlDbType.VarChar);
            comando.Parameters["@dni"].Value = _lector.Dni;
            comando.Parameters.Add("@domicilio", MySqlDbType.VarChar);
            comando.Parameters["@domicilio"].Value = _lector.Domicilio;
            comando.Parameters.Add("@telefono", MySqlDbType.VarChar);
            comando.Parameters["@telefono"].Value = _lector.Telefono;
            comando.Parameters.Add("@estado", MySqlDbType.Int16);
            comando.Parameters["@estado"].Value = _lector.Estado;

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

        public lectores buscarLector(string _dni)
        {
            string sql = "SELECT * FROM lectores WHERE dni=@dni_ AND estado = TRUE;";
            comando = new MySqlCommand(sql, conn.GetConexion());
            lectores lector = new lectores();

            comando.Parameters.Add("@dni_", MySqlDbType.String);
            comando.Parameters["@dni_"].Value = _dni;
            try
            {

                MySqlDataReader puntero = comando.ExecuteReader();

                while (puntero.Read())
                {
                    lector.IdLector = puntero.GetInt16(0);
                    lector.Apellido = puntero.GetString(1);
                    lector.Nombre = puntero.GetString(2);
                    lector.Domicilio = puntero.GetString(3);
                    lector.Dni = puntero.GetString(4);
                    lector.Telefono = puntero.GetString(5);
                    lector.Estado = true;
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
            return (lector);
        }

        public lectores buscarLectorXid(string _idLector)
        {
            string sql = "SELECT * FROM lectores WHERE idLector=@id_ AND estado = TRUE;";
            comando = new MySqlCommand(sql, conn.GetConexion());
            lectores lector = new lectores();

            comando.Parameters.Add("@id_", MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = _idLector;
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                    lector.IdLector = puntero.GetInt16(0);
                    lector.Apellido = puntero.GetString(1);
                    lector.Nombre = puntero.GetString(2);
                    lector.Dni = puntero.GetString(3);
                    lector.Domicilio = puntero.GetString(4);
                    lector.Telefono = puntero.GetString(5);
                    lector.Estado = true;
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
            return (lector);
        }

        public void eliminarLector(int _idLector)
        {
            string consulta = "UPDATE lectores SET estado= 0 WHERE idLector= @_idLector;";
            comando = new MySqlCommand(consulta, conn.GetConexion());
            
            comando.Parameters.Add("@e_idLector", MySqlDbType.Int16);
            comando.Parameters["@e_idLector"].Value = _idLector;

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

        public List<lectores> listarLectores()
        {
            List<lectores> listaLectores= new List<lectores> ();
            string consulta = "SELECT *FROM lectores WHERE estado = true;";
            comando = new MySqlCommand(consulta,conn.GetConexion());
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                    lectores _lector = new lectores();
                    _lector.IdLector = puntero.GetInt16(0);
                    _lector.Apellido = puntero.GetString(1);
                    _lector.Nombre = puntero.GetString(2);
                    _lector.Dni = puntero.GetString(3);
                    _lector.Domicilio = puntero.GetString(4);
                    _lector.Telefono = puntero.GetString(5);
                    _lector.Estado = puntero.GetBoolean(6);

                    listaLectores.Add(_lector);
                }
            }
            catch (Exception error)
            {
                RegistrarErrorEnArchivo(error);
            }
            return (listaLectores);

        }

        public void modificarLector(lectores _lector)
        {
            string sql = "UPDATE lectores SET apellido=@apellido_,nombre=@nombre_,dni=@dni_,domicilio=@domicilio_,telefono=@telefono_ WHERE idLector = @id_;";

            comando = new MySqlCommand(sql, conn.GetConexion());

            comando.Parameters.Add("@apellido_", MySqlDbType.VarChar);
            comando.Parameters["@apellido_"].Value = _lector.Apellido;
            comando.Parameters.Add("@nombre_", MySqlDbType.VarChar);
            comando.Parameters["@nombre_"].Value = _lector.Nombre;
            comando.Parameters.Add("@dni_", MySqlDbType.VarChar);
            comando.Parameters["@dni_"].Value = _lector.Dni;
            comando.Parameters.Add("@domicilio_", MySqlDbType.VarChar);
            comando.Parameters["@domicilio_"].Value = _lector.Domicilio;
            comando.Parameters.Add("@telefono_", MySqlDbType.VarChar);
            comando.Parameters["@telefono_"].Value = _lector.Telefono;
            comando.Parameters.Add("@id_", MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = _lector.IdLector;

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
