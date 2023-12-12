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
    public partial class LectorEliminar : Form
    {
        public LectorEliminar()
        {
            InitializeComponent();
        }

        private void LectorEliminar_Load(object sender, EventArgs e)
        {
            cargarTabla();
            
        }
        private void cargarTabla()
        {
            LectorData lectorcito = new LectorData();

            foreach (lectores item in lectorcito.listarLectores())
            {
                dtgLectores.Rows.Add(item.IdLector, item.Nombre, item.Apellido, item.Dni, item.Domicilio,item.Telefono);
            }
        }
    }
}
