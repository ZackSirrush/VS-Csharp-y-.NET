using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DPRN3_U2_A1_ANNT
{
    public partial class RegUsuario : Form
    {

        Usuario nuser;
        public RegUsuario()
        {
            nuser = new Usuario();
            InitializeComponent();
            usuariosdgv.DataSource = nuser.Mostrar().Tables[0]; //Muestra la tabla al inicio del programa
            usuariosdgv.Columns[0].HeaderText = "Clave"; //Títulos de columnas
            usuariosdgv.Columns[1].HeaderText = "CURP";
            usuariosdgv.Columns[2].HeaderText = "Nombre(s)";
            usuariosdgv.Columns[3].HeaderText = "Apellido Paterno";
            usuariosdgv.Columns[4].HeaderText = "Apellido Materno";
            usuariosdgv.Columns[5].HeaderText = "Sexo";
            usuariosdgv.Columns[6].HeaderText = "Tipo persona";
            usuariosdgv.Columns[7].HeaderText = "Calle";
            usuariosdgv.Columns[8].HeaderText = "Número ext";
            usuariosdgv.Columns[9].HeaderText = "Número int";
            usuariosdgv.Columns[10].HeaderText = "CP";
            usuariosdgv.Columns[11].HeaderText = "Ciudad";
            usuariosdgv.Columns[12].HeaderText = "Estado";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nombretb_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void nexttb_TextChanged(object sender, EventArgs e)
        {

        }

        private void nexttb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= 32 && e.KeyChar <= 47)||(e.KeyChar>=58 && e.KeyChar <= 255)) //Evalua si los caracteres son solo números según ASCII
            {
                MessageBox.Show("Solo números", "Alerta. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Si hay caracter no esperado, lanza una alerta
                e.Handled = true;
                return;
            }
        }

        private void ninttb_KeyPress(object sender, KeyPressEventArgs e)
       {


           if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) //Evalua si los caracteres son solo números según ASCII
           {
               MessageBox.Show("Solo números", "Alerta. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Si hay caracter no esperado, lanza una alerta
               e.Handled = true;
               return;
           }

       }

        private void cptb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) //Evalua si los caracteres son solo números según ASCII
            {
                MessageBox.Show("Solo números", "Alerta. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Si hay caracter no esperado, lanza una alerta
                e.Handled = true;
                return;
            }
        }

        private void Frb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mostrarbttn_Click(object sender, EventArgs e)
        {
            usuariosdgv.DataSource = nuser.Mostrar().Tables[0]; //Muestra la tabla al inicio del programa
            usuariosdgv.Columns[0].HeaderText = "Clave"; //Títulos de columnas
            usuariosdgv.Columns[1].HeaderText = "CURP";
            usuariosdgv.Columns[2].HeaderText = "Nombre(s)";
            usuariosdgv.Columns[3].HeaderText = "Apellido Paterno";
            usuariosdgv.Columns[4].HeaderText = "Apellido Materno";
            usuariosdgv.Columns[5].HeaderText = "Sexo";
            usuariosdgv.Columns[6].HeaderText = "Tipo persona";
            usuariosdgv.Columns[7].HeaderText = "Calle";
            usuariosdgv.Columns[8].HeaderText = "Número ext";
            usuariosdgv.Columns[9].HeaderText = "Número int";
            usuariosdgv.Columns[10].HeaderText = "CP";
            usuariosdgv.Columns[11].HeaderText = "Ciudad";
            usuariosdgv.Columns[12].HeaderText = "Estado";
        }

        private void registrarusuariobttn_Click(object sender, EventArgs e)
        {
             
            nuser.AgregarUsuario(RecuperarInformación());
            LimpiarCampos();
            
             //Limpia los datos del TextBox y demás elementos
        }

        private Usuario RecuperarInformación() //Recupera la información ingresada en los campos de la interfaz
        {
            Usuario nusuario = new Usuario(); //Objeto que llama a la clase vehículo

            nusuario.Curp = curptb.Text; //Almacena la información ingresada en los getters y setters
            nusuario.Nombre=nombretb.Text;
            nusuario.Apaterno = apaternotb.Text;
            nusuario.Amaterno = amaternotb.Text;
            if (mascrb.Checked == true)
            {
                nusuario.Sexo=mascrb.Text;
            } else if (femrb.Checked == true)
            {
                nusuario.Sexo=femrb.Text;
            }

            if (pfrb.Checked == true)
            {
                nusuario.Tipo=pfrb.Text;

            } else if (pmrb.Checked == true)
            {
                nusuario.Tipo = pmrb.Text;
            }

            nusuario.Calle = calletb.Text;
            nusuario.Noext = int.Parse(nexttb.Text);
            nusuario.Noint = int.Parse(ninttb.Text);
            nusuario.Cp = int.Parse(cptb.Text);
            nusuario.Ciudad = ciudadtb.Text;
            nusuario.Estado = estadocb.Text;
            
            return nusuario; //Devuelve los datos guardados

        }

        public void LimpiarCampos() //Método para limpiar los elementos del formulario
        {
            curptb.Text = "";
            nombretb.Text = "";
            apaternotb.Text = "";
            amaternotb.Text = "";
            mascrb.Checked = true;
            femrb.Checked = false;
            pfrb.Checked = true;
            pmrb.Checked = false;
            calletb.Text = "";
            nexttb.Text = "";
            ninttb.Text = "";
            cptb.Text = "";
            ciudadtb.Text = "";
            estadocb.Text = "Seleccionar";
        }

        private void pmrb_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
