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
    private libros libinhos;
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void cargarTabla()
        {
            LibroData librito = new LibroData();
            
            foreach (libros item in librito.listarlibros())
            {
                dtgDatos.Rows.Add(item.Id_Libro,item.Isbn,item.Nombre,item.Tipo,item.Editorial,item.Autor);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            libros libros = new libros(isbn,nombre,tipo,editorial,autor,true);
            LibroData penaldooo = new LibroData();
            penaldooo.agregarLibro(libros);
            penaldooo = null;
            dtgDatos.Rows.Clear();
            cargarTabla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Deseas eliminar el libro seleccionado?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                int id = (int)dtgDatos.CurrentRow.Cells[0].Value;
                LibroData datitos = new LibroData();
                datitos.eliminarLibro(id);
                dtgDatos.Rows.Clear();
                MessageBox.Show("El libro fue borrado con exito","Exito",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string id = txtbuscarporid.Text.Trim();

            LibroData libro = new LibroData();

            idcliente = libro.bu
        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
