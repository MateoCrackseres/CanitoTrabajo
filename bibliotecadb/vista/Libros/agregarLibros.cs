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

namespace bibliotecadb.vista.Libros
{
    public partial class agregarLibros : UserControl
    {
        private libros libros = new libros();
        public agregarLibros()
        {
            InitializeComponent();
        }
        private void Cargartabla()
        {
          LibroData dato = new LibroData();

          foreach(libros item in dato.listarlibros())
          {
           dtgLibros.Rows.Add(item.Id_Libro,item.Isbn,item.Nombre,item.Tipo,item.Editorial,item.Autor);
          }
        }
        private void agregarLibros_Load(object sender, EventArgs e)
        {
           Cargartabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = txtIsbn.Text.Trim(), nombre = txtNombre.Text.Trim(), tipo = txtTipo.Text.Trim(), editorial = txtEditorial.Text.Trim(), autor = txtAutor.Text.Trim();
           
           libros libros = new libros(isbn,nombre,tipo,editorial,autor,true);

           LibroData dato = new LibroData();

           dato.agregarLibro(libros);
           dato = null;
           dtgLibros.Rows.Clear();
           Cargartabla();

           txtIsbn.Clear();
           txtNombre.Clear();
           txtTipo.Clear();
           txtAutor.Clear();
           txtEditorial.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Deseas eliminar el libro seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                int id = (int)dtgLibros.CurrentRow.Cells[0].Value;
                LibroData datitos = new LibroData();
                datitos.eliminarLibro(id);
                dtgLibros.Rows.Clear();
                MessageBox.Show("El libro fue borrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cargartabla();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string _id = txtBuscar.Text.Trim();

            LibroData datos = new LibroData();

            libros = datos.buscarLibroXid(_id);

            dtgLibros.Rows.Clear();
            dtgLibros.Rows.Add(libros.Id_Libro,libros.Isbn,libros.Nombre,libros.Tipo,libros.Editorial,libros.Autor);
            txtBuscar.Clear();
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.Clear();
            txtBuscar.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgLibros.Rows.Clear();
            Cargartabla();
        }
    }
}
