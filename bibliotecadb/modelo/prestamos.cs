using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.modelo
{
    internal class prestamos
    {
        private int id_Prestamo;
        private int id_lector;
        private int id_ejemplar;
        private DateTime fechaPrestamos;
        private DateTime fechaEntrega;
        private bool estado;

        public prestamos()
        {
        }

        public prestamos(int id_lector, int id_ejemplar, DateTime fechaPrestamos, DateTime fechaEntrega, bool estado)
        {
            this.Id_lector = id_lector;
            this.Id_ejemplar = id_ejemplar;
            this.FechaPrestamos = fechaPrestamos;
            this.FechaEntrega = fechaEntrega;
            this.Estado = estado;
        }

        public prestamos(int id_Prestamo, int id_lector, int id_ejemplar, DateTime fechaPrestamos, DateTime fechaEntrega, bool estado)
        {
            this.Id_Prestamo = id_Prestamo;
            this.Id_lector = id_lector;
            this.Id_ejemplar = id_ejemplar;
            this.FechaPrestamos = fechaPrestamos;
            this.FechaEntrega = fechaEntrega;
            this.Estado = estado;
        }

        public int Id_Prestamo { get => id_Prestamo; set => id_Prestamo = value; }
        public int Id_lector { get => id_lector; set => id_lector = value; }
        public int Id_ejemplar { get => id_ejemplar; set => id_ejemplar = value; }
        public DateTime FechaPrestamos { get => fechaPrestamos; set => fechaPrestamos = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
