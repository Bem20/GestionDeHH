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
    public partial class HHCargaMasiva : Form
    {
        public HHCargaMasiva()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitudesHH solicitudesHH = new SolicitudesHH();
            solicitudesHH.Show();
            this.Hide();
        }

        private void cargaMasivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HHCargaMasiva hHCargaMasiva = new HHCargaMasiva();
            hHCargaMasiva.Show();
            this.Hide();
        }

        private void autorizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autorizaciones autorizaciones = new Autorizaciones();
            autorizaciones.Show();
            this.Hide();
        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            PmoInicio pmoInicio = new PmoInicio();
            pmoInicio.Show();
            this.Hide();
        }
    }
}
