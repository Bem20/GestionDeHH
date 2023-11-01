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
    public partial class DesarrolladorInicio : Form
    {
        public DesarrolladorInicio()
        {
            InitializeComponent();
        }

        private void autorizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creacion creacion = new Creacion();
            creacion.Show();
            this.Hide();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarSolicitud buscarSolicitud = new BuscarSolicitud();
            buscarSolicitud.Show();
            this.Hide();
        }
    }
}
