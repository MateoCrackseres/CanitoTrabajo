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
    internal class LibroData : ILibro
    {
        StreamWriter erroraso = new StreamWriter("errores-Lector.txt");

        private conexion conn = new conexion();
        private MySqlCommand comando;

        public LibroData()
        {

        }

        public void agregarLibro(libros _libro)
        {
            string consulta = "INSERT INTO libros (isbn,nombre,tipo,editorial,autor,estado) VALUE (@isbn,@nombre,@tipo,@editorial,@autor, TRUE);";

            comando = new MySqlCommand(consulta, conn.GetConexion());
            comando.Parameters.Add("@isbn", MySqlDbType.VarChar);
            comando.Parameters["@isbn"].Value = _libro.Isbn;
            comando.Parameters.Add("@nombre", MySqlDbType.VarChar);
            comando.Parameters["@nombre"].Value = _libro.Nombre;
            comando.Parameters.Add("@tipo", MySqlDbType.VarChar);
            comando.Parameters["@tipo"].Value = _libro.Tipo;
            comando.Parameters.Add("@editorial", MySqlDbType.VarChar);
            comando.Parameters["@editorial"].Value = _libro.Editorial;
            comando.Parameters.Add("@autor", MySqlDbType.VarChar);
            comando.Parameters["@autor"].Value = _libro.Autor;
            comando.Parameters.Add("@estado", MySqlDbType.Int16);
            comando.Parameters["@estado"].Value = _libro.Estado;

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

        public void eliminarLibro(int _id_Libro)
        {
            string consulta = "UPDATE libros SET estado= 0 WHERE id_Libro= @_id_Libro;";
            comando = new MySqlCommand(consulta, conn.GetConexion());

            comando.Parameters.Add("@_id_Libro", MySqlDbType.Int16);
            comando.Parameters["@_id_Libro"].Value = _id_Libro;

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

        public List<libros> listarlibros()
        {
            List<libros> listaLibros = new List<libros>();
            string consulta = "SELECT *FROM libros WHERE estado = TRUE;";
            comando = new MySqlCommand(consulta, conn.GetConexion());
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                    libros _libro = new libros();
                    _libro.Id_Libro = puntero.GetInt16(0);
                    _libro.Isbn = puntero.GetString(1);
                    _libro.Nombre = puntero.GetString(2);
                    _libro.Tipo = puntero.GetString(3);
                    _libro.Editorial = puntero.GetString(4);
                    _libro.Autor = puntero.GetString(5);
                    _libro.Estado = puntero.GetBoolean(6);

                    listaLibros.Add(_libro);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return (listaLibros);

        }

        public void modificarLibro(libros _libro)
        {

            string sql = "UPDATE libros SET isbn=@isbn_,nombre=@nombre_,tipo=@tipo_,editorial=@editorial_,autor=@autor_ WHERE id_Libro = @id_;";

            comando = new MySqlCommand(sql, conn.GetConexion());

            comando.Parameters.Add("@isbn_", MySqlDbType.VarChar);
            comando.Parameters["@isbn_"].Value = _libro.Isbn;
            comando.Parameters.Add("@nombre_", MySqlDbType.VarChar);
            comando.Parameters["@nombre_"].Value = _libro.Nombre;
            comando.Parameters.Add("@tipo_", MySqlDbType.VarChar);
            comando.Parameters["@tipo_"].Value = _libro.Tipo;
            comando.Parameters.Add("@editorial_", MySqlDbType.VarChar);
            comando.Parameters["@editorial_"].Value = _libro.Editorial;
            comando.Parameters.Add("@autor_", MySqlDbType.VarChar);
            comando.Parameters["@autor_"].Value = _libro.Autor;
            comando.Parameters.Add("@id_", MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = _libro.Id_Libro;

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

        libros ILibro.buscarLibro(string _isbn)
        {

            string sql = "SELECT * FROM libros WHERE isbn=@isbn_ AND estado = TRUE;";
            comando = new MySqlCommand(sql, conn.GetConexion());
            libros libro = new libros();

            comando.Parameters.Add("@isbn_", MySqlDbType.String);
            comando.Parameters["@isbn_"].Value = _isbn;
            try
            {

                MySqlDataReader puntero = comando.ExecuteReader();

                while (puntero.Read())
                {
                    libro.Id_Libro = puntero.GetInt16(0);
                    libro.Isbn = puntero.GetString(1);
                    libro.Nombre= puntero.GetString(2);
                    libro.Tipo = puntero.GetString(3);
                    libro.Editorial = puntero.GetString(4);
                    libro.Autor = puntero.GetString(5);
                    libro.Estado = true;
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
            return (libro);
        }

        libros ILibro.buscarLibroXid(string _id_Libro)
        {
            string sql = "SELECT * FROM libros WHERE id_Libro=@id_ AND estado = TRUE;";
            comando = new MySqlCommand(sql, conn.GetConexion());
            libros libro = new libros();

            comando.Parameters.Add("@id_", MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = _id_Libro;
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                    libro.Id_Libro = puntero.GetInt16(0);
                    libro.Isbn = puntero.GetString(1);
                    libro.Nombre = puntero.GetString(2);
                    libro.Tipo = puntero.GetString(3);
                    libro.Editorial = puntero.GetString(4);
                    libro.Editorial = puntero.GetString(5);
                    libro.Estado = true;
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
            return (libro);
        }
    }
}
