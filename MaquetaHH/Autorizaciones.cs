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
    public partial class Autorizaciones : Form
    {
        public Autorizaciones()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add("Jose Perez", "HH", "HH", "Pendiente", "Ver");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_Rechazar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[3].Value = "Rechazado";
        }

        private void button_Aprobar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[3].Value = "Aprobado";
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            PmoInicio pmoInicio = new PmoInicio();
            pmoInicio.Show();
            this.Hide();
        }
    }
}
