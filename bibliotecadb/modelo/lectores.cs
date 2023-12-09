using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.modelo
{
    internal class lectores
    {
        private int idLector;
        private string apellido;
        private string nombre;
        private string dni;
        private string domicilio;
        private string telefono;
        private bool estado;

        public lectores()
        {

        }

        public lectores(string apellido, string nombre, string dni, string domicilio, string telefono, bool estado)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Dni = dni;
            this.Domicilio = domicilio;
            this.Telefono = telefono;
            this.Estado = estado;
        }

        public lectores(int idLector, string apellido, string nombre, string dni, string domicilio, string telefono, bool estado)
        {
            this.IdLector = idLector;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Dni = dni;
            this.Domicilio = domicilio;
            this.Telefono = telefono;
            this.Estado = estado;
        }

        public int IdLector { get => idLector; set => idLector = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
