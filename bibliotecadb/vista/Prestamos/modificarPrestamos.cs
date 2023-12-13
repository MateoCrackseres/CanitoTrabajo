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

namespace bibliotecadb.vista.Prestamos
{
    public partial class modificarPrestamos : UserControl
    {
        private prestamos prestamo = new prestamos();

        private void Cargartabla()
        {
            PrestamoData  dato = new PrestamoData();

            foreach (prestamos item in dato.listarPrestamos())
            {
                dtgPrestamos.Rows.Add(item.Id_Prestamo,item.Id_lector,item.Id_ejemplar,item.FechaPrestamos,item.FechaEntrega);
            }
        }
        public modificarPrestamos()
        {
            InitializeComponent();
        }


        private void modificarPrestamos_Load(object sender, EventArgs e)
        {
            Cargartabla();

            txtBuscar2.Visible = true;
            btnBuscar2.Visible = true;
            txtIdEjemplar.Visible = false;
            txtIdLector.Visible = false;
            txtFechaEntrega.Visible = false;
            txtFechaPrestamo.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btnModificar.Visible = false;
        }

        private void txtBuscar2_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar2.Clear();
            txtBuscar2.ForeColor = Color.White;
            txtBuscar2.Font = new System.Drawing.Font("Century Gothic", 30);
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            txtBuscar2.Visible = false;
            btnBuscar2.Visible = false;
            txtIdLector.Visible = true;
            txtIdEjemplar.Visible = true;
            txtFechaPrestamo.Visible = true;
            txtFechaEntrega.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            btnModificar.Visible = true;

            string _id = txtBuscar2.Text.Trim();

            PrestamoData datos = new PrestamoData();

            prestamo = datos.buscarPrestamoXid(_id);

            txtIdLector.Text = prestamo.Id_lector.ToString();
            txtIdEjemplar.Text = prestamo.Id_ejemplar.ToString();
            txtFechaPrestamo.Text = prestamo.FechaPrestamos.ToString();
            txtFechaEntrega.Text = prestamo.FechaEntrega.ToString();
            txtBuscar2.Clear();
            txtIdLector.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgPrestamos.Rows.Clear();
            Cargartabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Deseas eliminar el prestamo seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                int id = (int)dtgPrestamos.CurrentRow.Cells[0].Value;
                PrestamoData datitos = new PrestamoData();
                datitos.eliminarPrestamo(id);
                dtgPrestamos.Rows.Clear();
                MessageBox.Show("El prestamo fue borrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cargartabla();
            }
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {

            txtBuscar.Clear();
            txtBuscar.ForeColor = Color.White;
        
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string _id = txtBuscar.Text.Trim();

            PrestamoData datos = new PrestamoData();

            prestamo = datos.buscarPrestamoXid(_id);

            dtgPrestamos.Rows.Clear();
            dtgPrestamos.Rows.Add(prestamo.Id_Prestamo, prestamo.Id_lector, prestamo.Id_ejemplar, prestamo.FechaPrestamos, prestamo.FechaEntrega);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            prestamo.Id_lector = int.Parse(txtIdLector.Text.Trim());
            prestamo.Id_ejemplar = int.Parse(txtIdEjemplar.Text.Trim());
            prestamo.FechaPrestamos = DateTime.Parse( txtFechaPrestamo.Text.Trim());
            prestamo.FechaEntrega = DateTime.Parse(txtFechaEntrega.Text.Trim());

            PrestamoData datos = new PrestamoData();

            datos.modificarPrestamo(prestamo);
            datos = null;
            prestamo = null;
            dtgPrestamos.Rows.Clear();
            Cargartabla();

            MessageBox.Show("Los datos fueron modificados con EXITO", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtIdEjemplar.Clear();
            txtIdLector.Clear();
            txtFechaEntrega.Clear();
            txtFechaPrestamo.Clear();


            txtBuscar2.Visible = true;
            btnBuscar2.Visible = true;
            txtIdEjemplar.Visible= false;
            txtIdLector.Visible=false;
            txtFechaEntrega.Visible = false;
            txtFechaPrestamo.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btnModificar.Visible = false;
        }
    }
}
