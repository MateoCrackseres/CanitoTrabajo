using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.dominio
{
    internal interface IEjemplar
    {
        void agregarEjemplar(ejemplares _ejemplar);
        void eliminarEjemplar(int _id_ejemplar);
        void modificarEjemplar(ejemplares _ejemplar);
        List<ejemplares> listarEjemplar();
        ejemplares buscarEjemplarXId(string _id_ejemplar);
        ejemplares buscarEjemplarXidLibro(string _id_ejemplar);
    }
}
