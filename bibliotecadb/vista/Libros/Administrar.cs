using bibliotecadb.vista.Lectores;
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
    
    public partial class Administrar : Form
    {
        public Administrar()
        {
            InitializeComponent();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ventanaexistente = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is AdministrarAgregar)
                {
                    ventanaexistente = true;
                    frm.Activate();
                    break;


                }
            }
            if (!ventanaexistente)
            {
                AdministrarAgregar ventanaDetalle = new AdministrarAgregar();
                ventanaDetalle.MdiParent = this;
                ventanaDetalle.Show();

            }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ventanaexistente = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is AdministrarEliminarXID)
                {
                    ventanaexistente = true;
                    frm.Activate();
                    break;


                }
            }
            if (!ventanaexistente)
            {
                AdministrarEliminarXID ventanaDetalle = new AdministrarEliminarXID();
                ventanaDetalle.MdiParent = this;
                ventanaDetalle.Show();

            }

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ventanaexistente = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is AdministrarModificar)
                {
                    ventanaexistente = true;
                    frm.Activate();
                    break;


                }
            }
            if (!ventanaexistente)
            {
                AdministrarModificar ventanaDetalle = new AdministrarModificar();
                ventanaDetalle.MdiParent = this;
                ventanaDetalle.Show();

            }

        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool ventanaexistente = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is LectorEliminar)
                {
                    ventanaexistente = true;
                    frm.Activate();
                    break;


                }
            }
            if (!ventanaexistente)
            {
                LectorEliminar ventanaDetalle = new LectorEliminar();
                ventanaDetalle.MdiParent = this;
                ventanaDetalle.Show();

            }
        }
    }
}
