using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.dominio
{
    internal interface ILibro
    {
        void agregarLibro(libros _libro);
        void eliminarLibro(int _id_Libro);
        void modificarLibro(libros _libro);
        List<libros> listarlibros();
        libros buscarLibro(string _isbn);
        libros buscarLibroXid(string _id_Libro);
    }
}
