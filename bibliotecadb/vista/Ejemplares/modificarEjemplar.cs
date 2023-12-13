using bibliotecadb.dominio;
using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotecadb.vista.Ejemplares
{
    public partial class modificarEjemplar : UserControl
    {
        private ejemplares ejemplar = new ejemplares();

        private void Cargartabla()
        {
            EjemplarData dato = new EjemplarData();

            foreach (ejemplares item in dato.listarEjemplar())
            {
                dtgEjemplares.Rows.Add(item.Id_ejemplar, item.Codigo, item.Id_libro, item.Cantidad,item.Estado);
            }
        }
        public modificarEjemplar()
        {
            InitializeComponent();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            txtBuscar2.Visible = false;
            btnBuscar2.Visible = false;
            txtCodigo.Visible = true;
            txtIdLibro.Visible = true;
            txtCantidad.Visible = true;
            txtEstado.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            btnModificarEjemplar.Visible = true;

            string _id = txtBuscar2.Text.Trim();

            EjemplarData datos = new EjemplarData();

            ejemplar = datos.buscarEjemplarXId(_id);

            txtCodigo.Text = ejemplar.Codigo;
            txtIdLibro.Text = ejemplar.Id_libro.ToString();
            txtCantidad.Text = ejemplar.Cantidad.ToString();
            txtEstado.Text = ejemplar.Estado;
            txtBuscar2.Clear();
            txtCodigo.Focus();
        }

        private void moficarEjemplar_Load(object sender, EventArgs e)
        {
            Cargartabla();

            txtBuscar2.Visible = true;
            btnBuscar2.Visible = true;
            txtCodigo.Visible = false;
            txtIdLibro.Visible = false;
            txtCodigo.Visible = false;
            txtEstado.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btnModificarEjemplar.Visible = false;
        }

        private void txtBuscar2_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar2.Clear();
            txtBuscar2.ForeColor = Color.White;
            txtBuscar2.Font = new System.Drawing.Font("Century Gothic", 30);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Deseas eliminar el Ejemplar seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                int id = (int)dtgEjemplares.CurrentRow.Cells[0].Value;
                LibroData datitos = new LibroData();
                datitos.eliminarLibro(id);
                dtgEjemplares.Rows.Clear();
                MessageBox.Show("El libro fue borrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cargartabla();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgEjemplares.Rows.Clear();
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

            EjemplarData datos = new EjemplarData();

            ejemplar = datos.buscarEjemplarXId(_id);

            dtgEjemplares.Rows.Clear();
            dtgEjemplares.Rows.Add(ejemplar.Id_ejemplar,ejemplar.Codigo,ejemplar.Id_libro,ejemplar.Cantidad,ejemplar.Estado);

        }

        private void btnModificarEjemplar_Click(object sender, EventArgs e)
        {
            ejemplar.Codigo = txtCodigo.Text.Trim();
            ejemplar.Id_libro = int.Parse(txtIdLibro.Text.Trim());
            ejemplar.Cantidad = int.Parse(txtCantidad.Text.Trim());
            ejemplar.Estado = txtEstado.Text.Trim();

            EjemplarData datos = new EjemplarData();

            datos.modificarEjemplar(ejemplar);
            datos = null;
            ejemplar = null;
            dtgEjemplares.Rows.Clear();
            Cargartabla();

            MessageBox.Show("Los datos fueron modificados con EXITO", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCodigo.Clear();
            txtIdLibro.Clear();
            txtCantidad.Clear();
            txtEstado.Clear();


            txtBuscar2.Visible = true;
            btnBuscar2.Visible = true;
            txtCodigo.Visible = false;
            txtIdLibro.Visible = false;
            txtCantidad.Visible = false;
            txtEstado.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btnModificarEjemplar.Visible = false;
        }
    }
}
