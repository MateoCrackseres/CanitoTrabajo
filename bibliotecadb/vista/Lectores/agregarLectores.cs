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

namespace bibliotecadb.vista.Lectores
{
    public partial class agregarLectores : UserControl
    {
        private lectores lector = new lectores();
        private void Cargartabla()
        {
            LectorData dato = new LectorData();

            foreach (lectores item in dato.listarLectores())
            {
                dtgLectores.Rows.Add(item.IdLector, item.Apellido, item.Nombre, item.Dni, item.Domicilio, item.Telefono);
            }
        }
        public agregarLectores()
        {
            InitializeComponent();
        }

        private void agregarLectores_Load(object sender, EventArgs e)
        {
            Cargartabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text, nombre = txtNombre.Text, dni = txtDNI.Text, domicilio = txtDomicilio.Text, telefono = txtTelefono.Text;

            lectores lector = new lectores(apellido,nombre,dni,domicilio,telefono, true);

            LectorData dato = new LectorData();

            dato.agregarLector(lector);
            dato = null;
            dtgLectores.Rows.Clear();
            Cargartabla();

            txtApellido.Clear();
            txtNombre.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtDomicilio.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Deseas eliminar el lector seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                int id = (int)dtgLectores.CurrentRow.Cells[0].Value;
                LibroData datitos = new LibroData();
                datitos.eliminarLibro(id);
                dtgLectores.Rows.Clear();
                MessageBox.Show("El lector fue borrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cargartabla();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgLectores.Rows.Clear();
            Cargartabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string _id = txtBuscar.Text.Trim();

            LectorData datos = new LectorData();

            lector = datos.buscarLectorXid(_id);

            dtgLectores.Rows.Clear();
            dtgLectores.Rows.Add(lector.IdLector,lector.Apellido, lector.Nombre, lector.Dni, lector.Domicilio,lector.Telefono);
            txtBuscar.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            txtBuscar.Clear();
            txtBuscar.ForeColor = Color.White;
        }
    }
}
