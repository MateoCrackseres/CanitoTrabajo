using bibliotecadb.datos;
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
    //private libros libinhos;
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            cargarTabla();
            if (textBox1.Text.Length < 1)
            {
                button1.Enabled = false;
            }
        }

        private void cargarTabla()
        {
            int i = 0;
            LibroData librito = new LibroData();
            EjemplarData ejemplarcito = new EjemplarData();

            foreach (libros item in librito.listarlibros())
            {
                dtgDatos.Rows.Add(item.Id_Libro, item.Isbn, item.Nombre, item.Tipo, item.Editorial, item.Autor);
            }
            foreach (ejemplares item in ejemplarcito.listarEjemplar())
            {
                dtgDatos.Rows[i++].Cells[6].Value = item.Cantidad;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*  libros libros = new libros(isbn,nombre,tipo,editorial,autor,true);
              LibroData penaldooo = new LibroData();
              penaldooo.agregarLibro(libros);
              penaldooo = null;
              dtgDatos.Rows.Clear();
              cargarTabla();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Deseas eliminar el libro seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                int id = (int)dtgDatos.CurrentRow.Cells[0].Value;
                LibroData datitos = new LibroData();
                datitos.eliminarLibro(id);
                dtgDatos.Rows.Clear();
                MessageBox.Show("El libro fue borrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /* string id = txtbuscarporid.Text.Trim();

             LibroData libro = new LibroData();

             idcliente = libro.bu*/
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length < 1)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_ = textBox1.Text;
            LibroData librito = new LibroData();
            libros dato = new libros();
            EjemplarData pene = new EjemplarData();
            ejemplares datito = new ejemplares();
            dato = librito.buscarLibroXid(id_);
            datito = pene.buscarEjemplarXid(id_);


            dtgDatos.Rows.Clear();
            dtgDatos.Rows.Add(dato.Id_Libro, dato.Isbn, dato.Nombre, dato.Tipo, dato.Editorial, dato.Autor, datito.Cantidad);
            textBox1.Clear();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dtgDatos.Rows.Clear();
            cargarTabla();
        }
    }
}
