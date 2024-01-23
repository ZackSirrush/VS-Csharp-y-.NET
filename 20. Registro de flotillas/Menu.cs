//Universidad Abierta y a Distancia de México
//Desarrollo de software
//Programación Net III
//Unidad 2. Diseño de interfaces mediante .NET
//Evidencia de aprendizaje. Diseño de interfaces mediante .NET
//Angel Isaac Nabor Torres
//ES1921013978
//Docente. Juan Daniel Oliva Vázquez

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DPRN3_U2_A1_ANNT
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void RUbttn_Click(object sender, EventArgs e)
        {
            RegUsuario registrarusuario = new RegUsuario(); //Abre el formulario para registrar usuarios
            registrarusuario.Show();
        }

        private void RVbttn_Click(object sender, EventArgs e)
        {
            
            Rvehiculo registrovehiculos = new Rvehiculo(); //Abre el formulario para registrar vehículos
            registrovehiculos.Show();

        }
    }
}
