    using bibliotecadb.datos;
using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace bibliotecadb.dominio
{
    
    internal class EjemplarData : IEjemplar
    {

        private conexion conn = new conexion();
        private MySqlCommand comando;

        public EjemplarData()
        {

        }

        public void agregarEjemplar(ejemplares _ejemplar)
        {
            string sql = "INSERT INTO ejemplares(codigo,id_libro,cantidad,estado) VALUE (@codigo,@id_libro,@cantidad,@estado);";

            comando = new MySqlCommand(sql, conn.GetConexion());

            comando.Parameters.Add("@codigo",MySqlDbType.VarChar);
            comando.Parameters["@codigo"].Value = _ejemplar.Codigo;
            comando.Parameters.Add("@id_libro", MySqlDbType.VarChar);
            comando.Parameters["@id_libro"].Value = _ejemplar.Id_libro;
            comando.Parameters.Add("@cantidad", MySqlDbType.VarChar);
            comando.Parameters["@cantidad"].Value = _ejemplar.Cantidad;
            comando.Parameters.Add("@estado", MySqlDbType.VarChar);
            comando.Parameters["@estado"].Value = _ejemplar.Estado;

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
                if(conn.estadoConexion() == System.Data.ConnectionState.Open) 
                {
                    conn.setConexion();       
                }
                comando.Dispose();
            }
        }


        public void eliminarEjemplar(int _id_ejemplar)
        {
            string sql = "UPDATE ejemplares SET estado= No disponible WHERE idEjemplar= @_id_ejemplar;";

            comando = new MySqlCommand(sql, conn.GetConexion());

            comando.Parameters.Add("@_id_ejemplar", MySqlDbType.VarChar);
            comando.Parameters["@_id_ejemplar"].Value = _id_ejemplar;
            
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

        public List<ejemplares> listarEjemplar()
        {
            string sql = "SELECT * FROM ejemplares WHERE estado = 'Disponible';";
            List<ejemplares> listaEjemplares = new List<ejemplares>();
            comando = new MySqlCommand(sql, conn.GetConexion());

            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();

                while (puntero.Read())
                {
                    ejemplares ejemplar = new ejemplares();
                    ejemplar.Id_ejemplar = puntero.GetInt16(0);
                    ejemplar.Codigo = puntero.GetString(1);
                    ejemplar.Id_libro = puntero.GetInt32(2);
                    ejemplar.Cantidad = puntero.GetInt32(3);
                    ejemplar.Estado = puntero.GetString(4);

                    listaEjemplares.Add(ejemplar);
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
            return (listaEjemplares);
        }

        public void modificarEjemplar(ejemplares _ejemplar)
        {

            string sql = "UPDATE ejemplares SET codigo=@codigo_,id_libro=@id_libro_,cantidad=@cantidad_,estado=@estado_ WHERE idEjemplar = @id_;";

            comando = new MySqlCommand(sql, conn.GetConexion());

            comando.Parameters.Add("@codigo_", MySqlDbType.VarChar);
            comando.Parameters["@codigo_"].Value = _ejemplar.Codigo;
            comando.Parameters.Add("@id_libro_", MySqlDbType.VarChar);
            comando.Parameters["@id_libro_"].Value = _ejemplar.Id_libro;
            comando.Parameters.Add("@cantidad_", MySqlDbType.VarChar);
            comando.Parameters["@cantidad_"].Value = _ejemplar.Cantidad;
            comando.Parameters.Add("@estado_", MySqlDbType.VarChar);
            comando.Parameters["@estado_"].Value = _ejemplar.Estado;
            comando.Parameters.Add("@id_", MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = _ejemplar.Id_ejemplar;

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

        public ejemplares buscarEjemplarXId(string _id_ejemplar)
        {
            string sql = "SELECT * FROM ejemplares WHERE idEjemplar=@id_ AND estado = 'Disponible';";
            comando = new MySqlCommand(sql, conn.GetConexion());
            ejemplares ejemplar = new ejemplares();

            comando.Parameters.Add("@id_", MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = _id_ejemplar;
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                    ejemplar.Id_ejemplar = puntero.GetInt16(0);
                    ejemplar.Codigo = puntero.GetString(1);
                    ejemplar.Id_libro = puntero.GetInt32(2);
                    ejemplar.Cantidad = puntero.GetInt32(3);
                    ejemplar.Estado = puntero.GetString(4);
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
            return (ejemplar);
        }

        public ejemplares buscarEjemplarXidLibro(string _id_libro)
        {
            string sql = "SELECT * FROM ejemplares WHERE id_libro=@id_ AND estado = 'Disponible';";
            comando = new MySqlCommand(sql, conn.GetConexion());
            ejemplares ejemplar = new ejemplares();

            comando.Parameters.Add("@id_", MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = _id_libro ;
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                    ejemplar.Id_ejemplar = puntero.GetInt16(0);
                    ejemplar.Codigo = puntero.GetString(1);
                    ejemplar.Id_libro = puntero.GetInt32(2);
                    ejemplar.Cantidad = puntero.GetInt32(3);
                    ejemplar.Estado = puntero.GetString(4);
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
            return (ejemplar);
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
