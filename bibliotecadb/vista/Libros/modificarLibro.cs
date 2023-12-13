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
    public partial class modificarLibro : UserControl
    {
        private libros libros = new libros();
        public modificarLibro()
        {
            InitializeComponent();
        }

        private void Cargartabla()
        {
            LibroData dato = new LibroData();

            foreach (libros item in dato.listarlibros())
            {
                dtgLibros.Rows.Add(item.Id_Libro, item.Isbn, item.Nombre, item.Tipo, item.Editorial, item.Autor);
            }
        }

        private void modificarLibro_Load(object sender, EventArgs e)
        {
            Cargartabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            libros.Isbn = txtIsbn.Text;
            libros.Nombre = txtNombre.Text;
            libros.Tipo = txtTipo.Text;
            libros.Editorial = txtEditorial.Text;
            libros.Autor = txtAutor.Text;

            LibroData datos = new LibroData();

            datos.modificarLibro(libros);
            datos = null;
            libros = null;
            dtgLibros.Rows.Clear();
            Cargartabla();

            MessageBox.Show("Los datos fueron modificados con EXITO", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            txtIsbn.Clear();
            txtNombre .Clear();
            txtTipo .Clear();
            txtEditorial .Clear();
            txtAutor .Clear();


            txtBuscar2.Visible = true;
            btnBuscar2.Visible = true;
            txtIsbn.Visible = false;
            txtNombre.Visible = false;
            txtTipo.Visible = false;
            txtEditorial.Visible = false;
            txtAutor.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btnModificar.Visible = false;
        }

        private void txtBuscar2_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar2.Clear();
            txtBuscar2.ForeColor = Color.White;
            txtBuscar2.Font = new System.Drawing.Font("Century Gothic", 30); 
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            txtBuscar2.Visible = false;
            btnBuscar2 .Visible = false;
            txtIsbn.Visible = true;
            txtNombre.Visible = true;
            txtTipo .Visible = true;
            txtEditorial .Visible = true;
            txtAutor .Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            btnModificar.Visible=true;

            string _id = txtBuscar2.Text.Trim();

            LibroData datos = new LibroData();

            libros = datos.buscarLibroXid(_id);

            txtIsbn.Text = libros.Isbn;
            txtNombre.Text = libros.Nombre;
            txtTipo.Text = libros.Tipo;
            txtEditorial.Text = libros.Editorial;
            txtAutor.Text = libros.Autor;
            txtBuscar2.Clear();
            txtIsbn.Focus();
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

        private void button2_Click(object sender, EventArgs e)
        {
            dtgLibros.Rows.Clear();
            Cargartabla();
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.Clear();
            txtBuscar.ForeColor = Color.White;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string _id = txtBuscar.Text.Trim();

            LibroData datos = new LibroData();

            libros = datos.buscarLibroXid(_id);

            dtgLibros.Rows.Clear();
            dtgLibros.Rows.Add(libros.Id_Libro, libros.Isbn, libros.Nombre, libros.Tipo, libros.Editorial, libros.Autor);

        }
    }
}
