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
    public partial class SolicitudesHH : Form
    {
        public SolicitudesHH()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add("Jose Perez", "HH", "HH", "Pendiente", "Ver");
            this.dataGridView1.Rows.Add("Jose Joestar", "HH", "HH", "Pendiente", "Ver");
        }



        private void button_Buscar_Click(object sender, EventArgs e)
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

        private void button_Volver_Click(object sender, EventArgs e)
        {
            PmoInicio pmoInicio = new PmoInicio();
            pmoInicio.Show();
            this.Hide();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Buscador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
