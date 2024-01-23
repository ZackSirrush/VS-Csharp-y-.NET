using MySql.Data.MySqlClient;
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
    public partial class VtaTotal : Form
    {

        MySqlConnection conn;
        public VtaTotal()
        {           
            InitializeComponent();
            Consulta(); // Ejecuta el método consulta
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Conectar() //Método conectar
        {
            try //Try catch
            {
                string server = "127.0.0.1";//Cadena de conexión para ingresar al servidor con la información alojada
                string port = "3306";
                string database = "dprn3u3"; //Nombre de la base de datos en el servidor local
                string user = "root"; //Estos datos pueden variar según el servidor local al que se conecte
                string pass = "";
                string cadenaconexion = "server=" + server + ";port=" + port + ";database=" + database + ";UserID=" + user + ";Password=" + pass;
                conn=new MySqlConnection(cadenaconexion); //Inst5ancia la cadena de conexión
                conn.Open(); //Abre conexión
                MessageBox.Show("Conexión exitosa.");

            }
            catch (Exception error)
            {
                MessageBox.Show(Text, error.Message);
            }
            
        }
        private void Consulta()
        {
            Conectar();
            MessageBox.Show("Se están consultando los registros;\nel proceso puede tardar unos minutos.");
            string consulta = "SELECT * FROM ventas"; //Ejecuta consulta Select
            MySqlCommand comando = new MySqlCommand(consulta, conn);
            comando.CommandTimeout =360;//Tiempo de ejecución del comando
            MySqlDataReader reader; //Almacena la consulta en un datareader
            try
            {
                reader = comando.ExecuteReader(); //Ejecuta el datareader
                if (reader.HasRows)
                {
                    int contador = 0;
                    while (reader.Read()) //Imprime el data reader en la tabla
                    {
                        
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value=reader.GetString(0);
                        dataGridView1.Rows[n].Cells[1].Value = reader.GetString(1);
                        dataGridView1.Rows[n].Cells[2].Value = reader.GetString(2);
                        dataGridView1.Rows[n].Cells[3].Value = reader.GetString(3);
                        contador = contador + 1; //Contador de iteraciones del ciclo while
                        toolStripStatusLabel1.Text = contador.ToString()+" registros"; //Imprime el resultado del contador en el label
                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron ventas"); //Muestra el mensaje si la tabla está vacía
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Text +" "+ e.Message);//Excepción
            }
            conn.Close();          
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void VtaTotal_Load(object sender, EventArgs e)
        {

        }
    }
}
