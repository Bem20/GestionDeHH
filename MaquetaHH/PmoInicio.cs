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
    public partial class PmoInicio : Form
    {
        public PmoInicio()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add("Juan Joestar", "Permiso", "dia libre / tt/d a", "Pendiente", "Ver");
            this.dataGridView1.Rows.Add("Jose Joestar", "sabe jefe tengo un cruzero por el mundo entre el 45 de marzo y el 86 de junio asiq ue mediante el presente solicito vaciones", "Vaciones", "Rechazado", "Ver");
        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitudesHH solicitudesHH = new SolicitudesHH();
            solicitudesHH.Show();
            this.Hide();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            permisos.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Autorizaciones autorizaciones = new Autorizaciones();
                autorizaciones.Show();
                this.Hide();
            }
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

        private void cargaManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HHCargaManual hHCargaManual = new HHCargaManual();
            hHCargaManual.Show();
            this.Hide();
        }

        private void teletrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teletrabajo teletrabajo = new Teletrabajo();
            teletrabajo.Show();
            this.Hide();
        }

        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vacaciones vacaciones = new Vacaciones();
            vacaciones.Show();
            this.Hide();
        }
    }
}
