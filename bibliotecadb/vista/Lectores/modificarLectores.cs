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
    public partial class modificarLectores : UserControl
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
        public modificarLectores()
        {
            InitializeComponent();
        }

        private void modificarLectores_Load(object sender, EventArgs e)
        {
            Cargartabla();
            txtBuscar2.Visible = true;
            btnBuscar2.Visible = true;
            txtApellido.Visible = false;
            txtNombre.Visible = false;
            txtDNI.Visible = false;
            txtDomicilio.Visible = false;
            txtTelefono.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btnModificar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lector.Apellido = txtApellido.Text;
            lector.Nombre = txtNombre.Text;
            lector.Dni = txtDNI.Text;
            lector.Domicilio = txtDomicilio.Text;
            lector.Telefono = txtTelefono.Text;

            LectorData datos = new LectorData();

            datos.modificarLector(lector);
            datos = null;
            lector = null;
            dtgLectores.Rows.Clear();
            Cargartabla();

            MessageBox.Show("Los datos fueron modificados con EXITO", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtApellido.Clear();
            txtNombre.Clear();
            txtDNI.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();


            txtBuscar2.Visible = true;
            btnBuscar2.Visible = true;
            txtApellido.Visible = false;
            txtNombre.Visible = false;
            txtDNI.Visible = false;
            txtDomicilio.Visible = false;
            txtTelefono.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btnModificar.Visible = false;
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            txtBuscar2.Visible = false;
            btnBuscar2.Visible = false;
            txtApellido.Visible = true;
            txtNombre.Visible = true;
            txtDNI.Visible = true;
            txtDomicilio.Visible = true;
            txtTelefono.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            btnModificar.Visible = true;

            string _id = txtBuscar2.Text.Trim();

            LectorData datos = new LectorData();

            lector = datos.buscarLectorXid(_id);

            txtApellido.Text = lector.Apellido;
            txtNombre.Text = lector.Nombre;
            txtDNI.Text = lector.Dni;
            txtDomicilio.Text = lector.Domicilio;
            txtTelefono.Text = lector.Telefono;
            txtBuscar2.Clear();
            txtApellido.Focus();
        }

        private void txtBuscar2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Deseas eliminar el libro seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                int id = (int)dtgLectores.CurrentRow.Cells[0].Value;
                LectorData datitos = new LectorData();
                datitos.eliminarLector(id);
                dtgLectores.Rows.Clear();
                MessageBox.Show("El libro fue borrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cargartabla();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgLectores.Rows.Clear();
            Cargartabla();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string _id = txtBuscar.Text.Trim();

            LectorData datos = new LectorData();

            lector = datos.buscarLectorXid(_id);

            dtgLectores.Rows.Clear();
            dtgLectores.Rows.Add(lector.IdLector, lector.Apellido, lector.Nombre, lector.Dni, lector.Domicilio, lector.Telefono);

        }

        private void txtBuscar2_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar2.Clear();
            txtBuscar2.ForeColor = Color.White;
            txtBuscar2.Font = new System.Drawing.Font("Century Gothic", 30);
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.Clear();
            txtBuscar.ForeColor = Color.White;
        }
    }
}
