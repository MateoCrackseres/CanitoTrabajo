using bibliotecadb.dominio;
using bibliotecadb.modelo;
using bibliotecadb.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bibliotecadb;

namespace bibliotecadb
{
    public partial class Form1 : Form
    {
        private bool ventana = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitle.Visible = false;
            btnNuser.Visible = false;
            btnYuser.Visible = false;

            UsuarioNuevo formulario = new UsuarioNuevo();
            formulario.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EjemplarData dataejemplar = new EjemplarData();
            ejemplares lol = new ejemplares();
          /*  lol.Codigo = "1222323480";
            lol.Id_libro = 1;
            lol.Cantidad = 2;
            lol.Estado = true;
            dataejemplar.agregarEjemplar(lol);*/
            dataejemplar.eliminarEjemplar(1);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {


                MessageBox.Show("Pingo");
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioLibros form = new FormularioLibros();
            form.MdiParent = this;
            if (ventana == false)
            {


                form.Show();
                ventana = true;
            }
            
        }
    }
}
