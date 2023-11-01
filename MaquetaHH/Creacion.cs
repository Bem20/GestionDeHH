using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquetaHH
{
    public partial class Creacion : Form
    {
        public Creacion()
        {
            InitializeComponent();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            DesarrolladorInicio desarrolladorInicio = new DesarrolladorInicio();
            desarrolladorInicio.Show();
            this.Hide();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarSolicitud buscarSolicitud = new BuscarSolicitud();
            buscarSolicitud.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
