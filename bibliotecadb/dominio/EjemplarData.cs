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
        StreamWriter erroraso = new StreamWriter("errores-Ejemplares.txt");

        private conexion conn = new conexion();
        private MySqlCommand comando;

        public EjemplarData()
        {

        }

        public void agregarEjemplar(ejemplares _ejemplar)
        {
            string sql = "INSERT INTO ejemplares(codigo,id_libro,cantidad,estado) VALUE (@codigo,@id_libro,@cantidad, TRUE);";

            comando = new MySqlCommand(sql, conn.GetConexion());

            comando.Parameters.Add("@codigo",MySqlDbType.VarChar);
            comando.Parameters["@codigo"].Value = _ejemplar.Codigo;
            comando.Parameters.Add("@id_libro", MySqlDbType.VarChar);
            comando.Parameters["@id_libro"].Value = _ejemplar.Id_libro;
            comando.Parameters.Add("@cantidad", MySqlDbType.VarChar);
            comando.Parameters["@cantidad"].Value = _ejemplar.Cantidad;
            comando.Parameters.Add("@estado", MySqlDbType.Int16);
            comando.Parameters["@estado"].Value = _ejemplar.Estado;

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
                if(conn.estadoConexion() == System.Data.ConnectionState.Open) 
                {
                    conn.setConexion();       
                }
                comando.Dispose();
            }
        }


        public void eliminarEjemplar(int _id_ejemplar)
        {
            string sql = "UPDATE ejemplares SET estado= FALSE WHERE idEjemplar= @_id_ejemplar;";

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

        public List<ejemplares> listarEjemplar()
        {
            string sql = "SELECT * FROM ejemplares WHERE estado = TRUE;";
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
                    ejemplar.Estado = true;

                    listaEjemplares.Add(ejemplar);
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
            return (listaEjemplares);
        }

        public void modificarEjemplar(ejemplares _ejemplar)
        {

            string sql = "UPDATE ejemplares SET codigo=@codigo_,id_libro=@id_libro_,cantidad=@cantidad_ WHERE idEjemplar = @id_;";

            comando = new MySqlCommand(sql, conn.GetConexion());

            comando.Parameters.Add("@codigo", MySqlDbType.VarChar);
            comando.Parameters["@codigo"].Value = _ejemplar.Codigo;
            comando.Parameters.Add("@id_libro", MySqlDbType.VarChar);
            comando.Parameters["@id_libro"].Value = _ejemplar.Id_libro;
            comando.Parameters.Add("@cantidad", MySqlDbType.VarChar);
            comando.Parameters["@cantidad"].Value = _ejemplar.Cantidad;
            comando.Parameters.Add("@id_", MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = _ejemplar.Id_ejemplar;

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

        ejemplares IEjemplar.buscarEjemplar(string _codigo)
        {
            string sql = "SELECT * FROM ejemplares WHERE codigo=@codigo_ AND estado = TRUE;";
            comando = new MySqlCommand(sql, conn.GetConexion());
            ejemplares ejemplar = new ejemplares();

            comando.Parameters.Add("@codigo_", MySqlDbType.String);
            comando.Parameters["@codigo_"].Value = _codigo;
            try
            {

                MySqlDataReader puntero = comando.ExecuteReader();

                while (puntero.Read())
                {
                    ejemplar.Id_ejemplar = puntero.GetInt16(0);
                    ejemplar.Codigo = puntero.GetString(1);
                    ejemplar.Id_libro = puntero.GetInt32(2);
                    ejemplar.Cantidad = puntero.GetInt32(3);
                    ejemplar.Estado = true;
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
            return (ejemplar);
        }

        ejemplares IEjemplar.buscarEjemplarXid(string _id_ejemplar)
        {
            string sql = "SELECT * FROM ejemplares WHERE idEjemplar=@id_ AND estado = TRUE;";
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
                    ejemplar.Estado = true;
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
            return (ejemplar);
        }
    }
}
