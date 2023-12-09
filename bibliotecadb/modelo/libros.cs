using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.modelo
{
    internal class libros
    {
        private int id_Libro;
        private string isbn;
        private string nombre;
        private string tipo;
        private string editorial;
        private string autor;
        private bool estado;

        public libros()
        {

        }
        public libros(string isbn, string nombre, string tipo, string editorial, string autor, bool estado)
        {
            this.Isbn = isbn;
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Editorial = editorial;
            this.Autor = autor;
            this.Estado = estado;
        }

        public libros(int id_Libro, string isbn, string nombre, string tipo, string editorial, string autor, bool estado)
        {
            this.Id_Libro = id_Libro;
            this.Isbn = isbn;
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Editorial = editorial;
            this.Autor = autor;
            this.Estado = estado;
        }

        public int Id_Libro { get => id_Libro; set => id_Libro = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string Autor { get => autor; set => autor = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
