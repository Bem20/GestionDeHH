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
    public partial class LoginHH : Form
    {
        public LoginHH()
        {
            InitializeComponent();
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (text_Usuario.Text == "pmo" && text_Contraseña.Text == "1234") 
            {
                PmoInicio pmoInicio = new PmoInicio();
                this.Hide();
                pmoInicio.Show();
            } 
            else if(text_Usuario.Text == "dev" && text_Contraseña.Text == "1234")
            {
                DesarrolladorInicio desarrolladorInicio = new DesarrolladorInicio();
                this.Hide();
                desarrolladorInicio.Show();   
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        private void text_Usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
