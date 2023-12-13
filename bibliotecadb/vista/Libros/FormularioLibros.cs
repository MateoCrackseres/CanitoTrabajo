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
        private bool band = false;
        public FormularioLibros()
        {
            InitializeComponent();
        }

        private void FormularioLibros_Load(object sender, EventArgs e)
        {
            
        }
        private void Cargartabla()
        {
           /* LibroData dato = new LibroData();
            foreach(libros item in dato.listarlibros())
            {
                dataGridlibros.Rows.Add(
                    item.Id_Libro,
                    item.Nombre,
                    item.Isbn,
                    item.Autor);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioNuevo usuarioNuevo = new UsuarioNuevo();
            this.Hide();
            usuarioNuevo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuentaExistente cuentaExistente = new CuentaExistente();
            this.Hide();
            cuentaExistente.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            if (band == false)
            {
                label4.Visible = true;
                band= true;
            }
            else
            {
                label4.Visible = false;
                band = false;
            }
            
        }

        private void modoAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Administrar administrar = new Administrar();
            this.Hide();
            administrar.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide(); menu.Show();
        }
    }
}
