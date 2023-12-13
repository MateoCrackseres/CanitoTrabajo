using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bibliotecadb.dominio;
using bibliotecadb.modelo;
using MySql.Data.MySqlClient;

namespace bibliotecadb.vista
{
    public partial class UsuarioNuevo : Form
    {

        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private string dni;

        private bool nband = false;
        private bool aband = false;
        private bool dband = false;
        private bool tband = false;
        private bool dniband = false;


        public UsuarioNuevo()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nband == true && aband == true && dband == true && tband == true && dniband == true)
            {
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                domicilio = txtDomicilio.Text;
                telefono = txtTelefono.Text;
                dni = txtDni.Text;

                LectorData lectornuevo = new LectorData();
                lectores lector = new lectores();
                lector.Dni = dni;
                lector.Nombre = nombre;
                lector.Apellido = apellido;
                lector.Domicilio = domicilio;
                lector.Telefono = telefono;
                lector.Estado = true;
                lectornuevo.agregarLector(lector);

                MessageBox.Show("Usuario creado con exito! Ya puedes disfrutar del catalogo", "Usuario nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormularioLibros formularioLibros = new FormularioLibros();
                this.Hide();
                formularioLibros.Show();
            }
            else
            {
                MessageBox.Show("Por favor, rellena todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength > 0)
            {
                nband = true;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.TextLength > 0)
            {
                aband = true;
            }
        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            if (txtDomicilio.TextLength > 0)
            {
                dband = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.TextLength > 0)
            {
                tband = true;
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength > 0)
            {
                dniband = true;
            }
        }

        private void UsuarioNuevo_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
