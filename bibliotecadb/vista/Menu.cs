using bibliotecadb.vista.Ejemplares;
using bibliotecadb.vista.Lectores;
using bibliotecadb.vista.Libros;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void cambiarventana(UserControl ventana)
        {
            ventana.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(ventana);
            ventana.BringToFront();
        }
        private void btnLibros_Click(object sender, EventArgs e)
        {
            subMenuLibro.Visible = true;
            btnEjemplares.Visible = false;
            pnEjemplares.Visible = false;
            btnLectores.Visible = false;
            pnLectores.Visible = false;
            btnPrestamos.Visible = false;
            pnPrestamos.Visible= false;
            subMenuLibro.BringToFront();
            
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            subMenuLibro.Visible=false;
            btnEjemplares.Visible = true;
            pnEjemplares.Visible = true;
            btnLectores.Visible = true;
            pnLectores.Visible = true;
            btnPrestamos.Visible = true;
            pnPrestamos.Visible = true;
            agregarLibros agregarLibros = new agregarLibros();
            cambiarventana(agregarLibros);
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            subMenuLibro.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnModificarLibro_Click_1(object sender, EventArgs e)
        {
            subMenuLibro.Visible = false;
            btnEjemplares.Visible = true;
            pnEjemplares.Visible = true;
            btnLectores.Visible = true;
            pnLectores.Visible = true;
            btnPrestamos.Visible = true;
            pnPrestamos.Visible = true;
            subMenuLibro.BringToFront();
            modificarLibro modificarLibro = new modificarLibro();
            cambiarventana(modificarLibro);
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            subMenuEjemplares.Visible = true;
            btnEjemplares.Visible = true;
            pnEjemplares.Visible = true;
            btnLectores.Visible = false;
            pnLectores.Visible = false;
            btnPrestamos.Visible = false;
            pnPrestamos.Visible = false;
            subMenuEjemplares.BringToFront();
        }

        private void btnLectores_Click(object sender, EventArgs e)
        {
            subMenuLectores.Visible = true;
            btnEjemplares.Visible = true;
            pnEjemplares.Visible = true;
            btnLectores.Visible = true;
            pnLectores.Visible = true;
            btnPrestamos.Visible = false;
            pnPrestamos.Visible = false;
            subMenuLectores.BringToFront();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            subMenuPrestamos.Visible = true;
            btnEjemplares.Visible = true;
            pnEjemplares.Visible = true;
            btnLectores.Visible = true;
            pnLectores.Visible = true;
            btnPrestamos.Visible = true;
            pnPrestamos.Visible = true;
            subMenuPrestamos.BringToFront();
        }

        private void btnAgregarEjemplares_Click(object sender, EventArgs e)
        {
            subMenuEjemplares.Visible = false;
            btnEjemplares.Visible = true;
            pnEjemplares.Visible = true;
            btnLectores.Visible = true;
            pnLectores.Visible = true;
            btnPrestamos.Visible = true;
            pnPrestamos.Visible = true;
            subMenuPrestamos.BringToFront();
            agregarEjemplares agregarEjemplar = new agregarEjemplares();
            cambiarventana(agregarEjemplar);
        }

        private void btnModificarEjemplares_Click(object sender, EventArgs e)
        {
            subMenuEjemplares.Visible = false;
            btnEjemplares.Visible = true;
            pnEjemplares.Visible = true;
            btnLectores.Visible = true;
            pnLectores.Visible = true;
            btnPrestamos.Visible = true;
            pnPrestamos.Visible = true;
            subMenuEjemplares.BringToFront();
            modificarEjemplar modificarEjemplar = new modificarEjemplar();
            cambiarventana(modificarEjemplar);
        }

        private void btnAgregarLectores_Click(object sender, EventArgs e)
        {
            subMenuLectores.Visible = false;
            btnEjemplares.Visible = true;
            pnEjemplares.Visible = true;
            btnLectores.Visible = true;
            pnLectores.Visible = true;
            btnPrestamos.Visible = true;
            pnPrestamos.Visible = true;
            subMenuLectores.BringToFront();
            agregarLectores agregarLector = new agregarLectores();
            cambiarventana(agregarLector);
        }

        private void btnModificarLectores_Click(object sender, EventArgs e)
        {
            subMenuLectores.Visible = false;
            btnEjemplares.Visible = true;
            pnEjemplares.Visible = true;
            btnLectores.Visible = true;
            pnLectores.Visible = true;
            btnPrestamos.Visible = true;
            pnPrestamos.Visible = true;
            subMenuLectores.BringToFront();
            modificarLectores modificarLector = new modificarLectores();
            cambiarventana(modificarLector);
        }

        private void btnAgregarPrestamos_Click(object sender, EventArgs e)
        {
            subMenuPrestamos.Visible = false;
            btnEjemplares.Visible = true;
            pnEjemplares.Visible = true;
            btnLectores.Visible = true;
            pnLectores.Visible = true;
            btnPrestamos.Visible = true;
            pnPrestamos.Visible = true;
            subMenuPrestamos.BringToFront();
            //agregarLibros agregarLibros = new agregarLibros();
            //cambiarventana(agregarLibros);
        }

        private void btnModificarPrestamos_Click(object sender, EventArgs e)
        {
            subMenuPrestamos.Visible = false;
            btnEjemplares.Visible = true;
            pnEjemplares.Visible = true;
            btnLectores.Visible = true;
            pnLectores.Visible = true;
            btnPrestamos.Visible = true;
            pnPrestamos.Visible = true;
            subMenuPrestamos.BringToFront();
            //agregarLibros agregarLibros = new agregarLibros();
            //cambiarventana(agregarLibros);
        }
    }
}
