using bibliotecadb.dominio;
using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotecadb.vista
{
    public partial class AdministrarAgregar : Form
    {
        public AdministrarAgregar()
        {
            InitializeComponent();
        }

        private void AdministrarAgregar_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void cargarTabla()
        {
            LibroData librito = new LibroData();

            foreach (libros item in librito.listarlibros())
            {
                dtgDatos.Rows.Add(item.Id_Libro, item.Isbn, item.Nombre, item.Tipo, item.Editorial, item.Autor);
            }
        }
    }
}
