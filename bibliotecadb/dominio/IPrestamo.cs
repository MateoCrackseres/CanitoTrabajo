using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.dominio
{
    internal interface IPrestamo
    {

        void agregarPrestamo(prestamos _prestamo);
        void eliminarPrestamo(int _id_Prestamo);
        void modificarPrestamo(prestamos _prestamo);
        List<prestamos> listarPrestamos();
        prestamos buscarPrestamo(string _id_ejemplar);
        prestamos buscarPrestamoXid(string _id_Prestamo);
    }
}
