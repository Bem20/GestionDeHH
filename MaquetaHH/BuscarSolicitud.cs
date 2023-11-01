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
    public partial class BuscarSolicitud : Form
    {
        public BuscarSolicitud()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add("sol123", "sabe jefe tengo un cruzero por el mundo entre el 45 de marzo y el 86 de junio asiq ue mediante el presente solicito vaciones", "Vacaciones");
            this.dataGridView1.Rows.Add("hh25", "jefe hice horas extras el 33 por 15 minutos favor agregar", "HH");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_Buscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void autorizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creacion creacion = new Creacion();
            creacion.Show();
            this.Hide();
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            DesarrolladorInicio desarrolladorInicio = new DesarrolladorInicio();
            desarrolladorInicio.Show();
            this.Hide();
        }
    }
}
