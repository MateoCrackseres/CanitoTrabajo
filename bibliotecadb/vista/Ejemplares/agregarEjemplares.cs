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

namespace bibliotecadb.vista.Ejemplares
{
    public partial class agregarEjemplares : UserControl
    {
        private ejemplares ejemplar = new ejemplares();
        public agregarEjemplares()
        {
            InitializeComponent();
        }
        private void Cargartabla()
        {
            EjemplarData dato = new EjemplarData();

            foreach (ejemplares item in dato.listarEjemplar())
            {
                dtgEjemplares.Rows.Add(item.Id_ejemplar,item.Codigo,item.Id_libro,item.Cantidad,item.Estado);
            }
        }
        private void agregarEjemplares_Load(object sender, EventArgs e)
        {
            Cargartabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim(); 
            int cantidad = int.Parse(txtCantidad.Text.Trim()), id = int.Parse(txtIdLibro.Text.Trim());

            ejemplares ejemplares = new ejemplares(codigo,id,"Disponible",cantidad);

            EjemplarData dato = new EjemplarData();

            dato.agregarEjemplar(ejemplares);
            dato = null;
            dtgEjemplares.Rows.Clear();
            Cargartabla();

            txtCodigo.Clear();
            txtIdLibro.Clear();
            txtCantidad.Clear();
            txtEstado.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Deseas eliminar el Ejemplar seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                int id = (int)dtgEjemplares.CurrentRow.Cells[0].Value;
                EjemplarData datitos = new EjemplarData();
                datitos.eliminarEjemplar(id);
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

            ejemplar = datos.buscarEjemplarXidLibro(_id);

            dtgEjemplares.Rows.Clear();
            dtgEjemplares.Rows.Add(ejemplar.Id_ejemplar,ejemplar.Codigo,ejemplar.Id_libro,ejemplar.Cantidad,ejemplar.Estado);
            txtBuscar.Clear();
        }
    }
}
