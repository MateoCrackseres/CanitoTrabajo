using bibliotecadb.datos;
using bibliotecadb.dominio;
using bibliotecadb.modelo;
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
    //private libros libinhos;
    public partial class MenuPrincipal : Form
    {
        private string dni_;
        private int idSeleccionado;
        private string isbnSeleccionado;
        private string nombreSeleccionado;
        private string tipoSeleccionado;
        private string editorialSeleccionado;
        private string autorSeleccionado;
        private int disponibleSeleccionado;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            cargarTabla();
            if (textBox1.Text.Length < 1)
            {
                btnBusqueda.Enabled = false;
            }
        }

        private void cargarTabla()
        {
            int i = 0;
            LibroData librito = new LibroData();
            EjemplarData ejemplarcito = new EjemplarData();




            foreach (libros item in librito.listarlibros())
            {
                dtgDatos.Rows.Add(item.Id_Libro, item.Isbn, item.Nombre, item.Tipo, item.Editorial, item.Autor);
            }
            foreach (ejemplares item in ejemplarcito.listarEjemplar())
            {
                dtgDatos.Rows[i++].Cells[6].Value = item.Cantidad;
            }

        }
        private void cargarTabla2()
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*  libros libros = new libros(isbn,nombre,tipo,editorial,autor,true);
              LibroData penaldooo = new LibroData();
              penaldooo.agregarLibro(libros);
              penaldooo = null;
              dtgDatos.Rows.Clear();
              cargarTabla();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Deseas eliminar el libro seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                int id = (int)dtgDatos.CurrentRow.Cells[0].Value;
                LibroData datitos = new LibroData();
                datitos.eliminarLibro(id);
                dtgDatos.Rows.Clear();
                MessageBox.Show("El libro fue borrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /* string id = txtbuscarporid.Text.Trim();

             LibroData libro = new LibroData();

             idcliente = libro.bu*/
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length < 1)
            {
                btnBusqueda.Enabled = false;
            }
            else
            {
                btnBusqueda.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtgDatos.Visible = false;
            lblCatalogo.Text = "Libros prestados";
            cargarTabla2();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FormularioLibros formito = new FormularioLibros();
            this.Hide();
            formito.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Deseas agregar el libro seleccionado a tus pedidos?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                DateTime fechaactual = DateTime.Now.Date;
                DateTime fechaentrega = fechaactual.AddDays(20);
                string fechaactual2 = fechaactual.ToString("yyyy-MM-dd HH:mm:ss");
                string fechaentrega2 = fechaentrega.ToString("yyyy-MM-dd HH:mm:ss");
                EjemplarData ejemplarData = new EjemplarData();
                ejemplares ejemplarcito = new ejemplares();
                ejemplares ejemplarcito2 = new ejemplares();
                LectorData lectorData = new LectorData();
                lectores lectorcito = new lectores();
                PrestamoData prestamoData = new PrestamoData();
                prestamos prestamitos = new prestamos();


                if (idSeleccionado != 0)
                {

                    lectorcito = lectorData.buscarLector(dni_);
                    ejemplarcito = ejemplarData.buscarEjemplarXidLibro(idSeleccionado.ToString());

                    if (ejemplarcito != null && lectorcito != null)
                    {
                        prestamitos.Estado = true;
                        prestamitos.FechaPrestamos = fechaactual;
                        prestamitos.FechaEntrega = fechaentrega;
                        prestamitos.Id_ejemplar = ejemplarcito.Id_ejemplar;
                        prestamitos.Id_lector = lectorcito.IdLector;

                        prestamoData.agregarPrestamo(prestamitos);
                    }
                    else
                    {
                        MessageBox.Show("Ejemplar o lector no encontrado.");
                    }


                    MessageBox.Show("Se ha añadido el libro con exito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("No se ha añadido ningun libro, comprueba haber seleccionado un libro valido", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            dtgDatos.Rows.Clear();
            cargarTabla();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string id_ = textBox1.Text.Trim();
            LibroData librito = new LibroData();
            libros dato = new libros();
            EjemplarData dataso = new EjemplarData();
            ejemplares datito = new ejemplares();
            dato = librito.buscarLibroXid(id_);
            datito = dataso.buscarEjemplarXidLibro(id_);


            dtgDatos.Rows.Clear();
            dtgDatos.Rows.Add(dato.Id_Libro, dato.Isbn, dato.Nombre, dato.Tipo, dato.Editorial, dato.Autor, datito.Cantidad);
            textBox1.Clear();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            dni_ = textBox2.Text.Trim();
            LectorData lectoraso = new LectorData();
            lectores lectorcito = new lectores();
            lectorcito = lectoraso.buscarLector(dni_);
            string dniverif = lectorcito.Dni;
            if (dniverif == null)
            {
                MessageBox.Show("El DNI no se encontró, asegurate de haber ingresado un DNI válido. Si tu DNI no está registrado, por favor regresa al menu de bienvenida y crea tu usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("DNI acreditado correctamente!", "Aceptado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox1.Enabled = true;
                btnBusqueda.Enabled = true;
                btnReload.Enabled = true;
                dtgDatos.Enabled = true;
                textBox1.Visible = true;
                btnBusqueda.Visible = true;
                btnReload.Visible = true;
                dtgDatos.Visible = true;
                btnPedir.Visible = true;
                textBox2.Clear();
                lblPuntito.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                lblSugerencia.Visible = true;
            }
        }

        private void dtgDatos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnPedir.Enabled = true;
            if (e.RowIndex >= 0)
            {

                idSeleccionado = Convert.ToInt32(dtgDatos.Rows[e.RowIndex].Cells["idlibro"].Value);
                if (idSeleccionado != 0)
                {
                    isbnSeleccionado = dtgDatos.Rows[e.RowIndex].Cells["isbn"].Value.ToString();
                    nombreSeleccionado = dtgDatos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    tipoSeleccionado = dtgDatos.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
                    editorialSeleccionado = dtgDatos.Rows[e.RowIndex].Cells["editorial"].Value.ToString();
                    autorSeleccionado = dtgDatos.Rows[e.RowIndex].Cells["autor"].Value.ToString();
                    disponibleSeleccionado = Convert.ToInt32(dtgDatos.Rows[e.RowIndex].Cells["cantidad"].Value);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila valida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}

