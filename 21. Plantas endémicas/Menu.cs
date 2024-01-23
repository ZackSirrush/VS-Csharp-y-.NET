using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRN3_U3_ANNT
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void vtbttn_Click(object sender, EventArgs e) //Al hacer clic en el botón ventas totales
        {
            VtaTotal vtotales = new VtaTotal(); //Abre el formulario que contiene los registros totales de la BD
            vtotales.Show();
        }

        private void vmbttn_Click(object sender, EventArgs e) //Al hacer clic en el botón ventas mensuales
        {
            VtaMensual vmensual = new VtaMensual(); //Se abrirá el formulario que contiene las ventas ordenadas por mes
            vmensual.Show();
        }

        private void button1_Click(object sender, EventArgs e) //Al hacer clic en el botón registrar ventas
        {
            RegVentas rvta = new RegVentas();
            rvta.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
