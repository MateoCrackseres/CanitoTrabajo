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
    public partial class FormularioLibros : Form
    {
        public FormularioLibros()
        {
            InitializeComponent();
        }

        private void FormularioLibros_Load(object sender, EventArgs e)
        {
            
        }
        private void Cargartabla()
        {
            LibroData dato = new LibroData();
            foreach(libros item in dato.listarlibros())
            {
                dataGridlibros.Rows.Add(
                    item.Id_Libro,
                    item.Nombre,
                    item.Isbn,
                    item.Autor);
            }
        }
    }
}
