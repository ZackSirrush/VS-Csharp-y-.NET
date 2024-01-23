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
    public partial class RegVentas : Form
    {
        public RegVentas()
        {
            InitializeComponent();
        }



        private void cantidadtb_KeyPress(object sender, KeyPressEventArgs e) //Limita el textbox para recibir solo números
        {
            if ((e.KeyChar>=32 && e.KeyChar<=47) || (e.KeyChar>=58 && e.KeyChar<=255)) //Elige un parámetro según el código ASCII donde hay números
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Muestra un mensaje de alerta
                e.Handled=true;
                return; 
            }
        }

        private void calcularbttn_Click(object sender, EventArgs e)
        {
            

        } //Método no utilizado

        private void totaltb_TextChanged(object sender, EventArgs e)
        {

        }//Método no utilizado

        private void cantidadtb_TextChanged(object sender, EventArgs e) //Al cambiar el valor en el textbox de consultar
        {

            try //Evita que se cierre el programa
            {
                int cant = Convert.ToInt32(cantidadtb.Text); //Obtiene el valor del textbox y lo convierte a int
                int total; //Declara la variabnle total
                string planta = plantacb.Text; //Obtiene el valor del item seleccionado en el combobox

                if (planta == "Agave") //Compara el valor del combobox y con base en ello, realiza la multiplicación adecuada
                {
                    total = cant * 52;
                    totaltb.Text = total.ToString();
                }
                else if (planta == "Biznaga") //Multiplicando el costo de la planta, por la cantidad ingresada
                {
                    total = cant * 97;
                    totaltb.Text = total.ToString();
                }
                else if (planta == "Cempasuchil") //Y devuelve el total en un textbox que se encuentra deshabilitado
                {
                    total = cant * 16;
                    totaltb.Text = total.ToString();
                }
                else if (planta == "Dalia")
                {
                    total = cant * 21;
                    totaltb.Text = total.ToString();
                }
                else if (planta == "Magnolia Pacifica")
                {
                    total = cant * 25;
                    totaltb.Text = total.ToString();
                }
                else if (planta == "Nochebuena")
                {
                    total = cant * 40;
                    totaltb.Text = total.ToString();
                }
                else if (planta == "Nopal Cardon")
                {
                    total = cant * 9;
                    totaltb.Text = total.ToString();
                }
                else if (planta == "Orquidea Pelicano")
                {
                    total = cant * 19;
                    totaltb.Text = total.ToString();
                }
                else if (planta == "Peyote")
                {
                    total = cant * 30;
                    totaltb.Text = total.ToString();
                }
                else if (planta == "Peyotillo")
                {
                    total = cant * 36;
                    totaltb.Text = total.ToString();
                }
                else if (planta == "Zapatilla de Venus")
                {
                    total = cant * 14;
                    totaltb.Text = total.ToString();
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Formato de datos incorrecto"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Information); //Muestra mensaje de error
            } //Ya que el programa se cerraba al presionar la tecla suprimir o borrar, ahora solo muestra una advertencia para que el usuario corrija el valor
            

        }

        private void plantacb_TextChanged(object sender, EventArgs e) //Al cambiar el valor de la planta seleccionada en el combobox
        {
            cantidadtb.Text = "0"; //Reinicia los valores en el formulario
            totaltb.Text = "0";
            fvtadtp.Text = "2022/01/01";
        }

        private void validarbttn_Click(object sender, EventArgs e)
        {
            Validar(); //Ejecuta el método para validar
        }

        private void registrarbttn_Click(object sender, EventArgs e)
        {
            Registrar(); //Ejecuta el método para registrar
        }

        private static MySqlConnection Conexion() //Método conectar para establecer la conexión local
        {
            string server = "127.0.0.1";//Cadena de conexión para ingresar al servidor con la información alojada
            string port = "3306";
            string database = "dprn3u3"; //Nombre de la base de datos en el servidor local
            string user = "root"; //Estos datos pueden variar según el servidor local al que se conecte
            string pass = "";
            string cadenaconexion = "server=" + server + ";port=" + port + ";database=" + database + ";UserID=" + user + ";Password=" + pass + "";

            try //Try catch
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaconexion); //Recibe la cadena de conexión
                return conexionBD;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Conexión a base de datos local fallida.\n " + e.Message);
                return null;
            }

        }

        private void Registrar() //Realiza la consulta en la base de datos local
        {
            
            string planta = plantacb.Text; //Retoma los valores de los textbox, combobox y datetimepickers
            string fecha = fvtadtp.Text;
            int cant = int.Parse(cantidadtb.Text);
            int tot = int.Parse(totaltb.Text);
            string insert = "INSERT INTO ventas (Planta, Fecha, Cantidad, Total) VALUES ('"+planta+ "','" + fecha + "','" + cant + "','" + tot + "')"; //Ejecuta inserción de datos

            MySqlConnection conexionBD = Conexion(); //Conecta base de datos
            conexionBD.Open(); //Abre la conexión sql

            try
            {
                MySqlCommand comando = new MySqlCommand(insert, conexionBD);
                comando.ExecuteNonQuery(); //Ejecuta la consulta
                MessageBox.Show("Registro guardado."); //Muestra el mensaje de registro guardado
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error al guardar.\n" + ex.Message); //Muestra mensaje de error
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión
            }

        }

        private void Validar() //Busca la planta y la fecha 
        {
            string planta = plantacb.Text; //Retoma los valores del formulario
            string fecha = fvtadtp.Text;
            MySqlDataReader reader = null; //Inicializa el data reader

            string select = "SELECT Planta,Fecha,Cantidad,Total FROM ventas WHERE Planta LIKE '"+planta+"' AND Fecha LIKE '"+fecha+"' LIMIT 1"; //Consulta para búsqueda de datos
            MySqlConnection conexionBD = Conexion(); //Se establece límite de 1 para que encuentre solo 1 resultado
            conexionBD.Open(); //Abre la conexión

            try
            {
                MySqlCommand comando = new MySqlCommand(select, conexionBD); 
                reader = comando.ExecuteReader();//Ejecuta el comando
                if (reader.HasRows) //Sí el comando encontró resultados
                {
                    actualizarbttn.Enabled = true; //Habilita el botón de actualizar
                    registrarbttn.Enabled = false; //Deshabilita el botón de nuevo registrar
                    while (reader.Read()) //Mientras tenga datos
                    {
                        plantacb.Text = reader.GetString(0); //Imprime los datos en los textbox, combobox y datetimepicker
                        fvtadtp.Text = reader.GetString(1);
                        cantidadtb.Text = reader.GetString(2);
                        totaltb.Text = reader.GetString(3);
                    }

                } else //Si no tiene datos
                {
                    MessageBox.Show("No se encontraron registros en la fecha\n seleccionada de la planta indicada.");
                    cantidadtb.Text = "0"; //Al no encontrar registros, devuelve el valor de los dos textbox a 0
                    totaltb.Text = "0";
                    actualizarbttn.Enabled = false; //Deshabilita el botón actualizar para que no sea posible utilizarlo
                    registrarbttn.Enabled = true; //Habilita el botón de nuevo registro, para almacenar un registro nuevo.
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar.\n" + ex.Message); //Lanza excepción
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión
            }

        }

        private void actualizarbttn_Click(object sender, EventArgs e)
        {
            Actualizar(); //Inicializa el método actualizar
        }

        private void Actualizar() //Método actualizar
        {
            string planta = plantacb.Text; //Retoma los datos ingresados en el formulario.
            string fecha = fvtadtp.Text;
            int cant = int.Parse(cantidadtb.Text);
            int tot = int.Parse(totaltb.Text);
            string insert = "UPDATE ventas SET Cantidad='"+cant+"',Total='"+tot+"' WHERE Planta='"+planta+"' AND Fecha='"+fecha+"'"; //Ejecuta actualización de datos
            //Recibe la consulta "update" donde cambia las cantidades y total del registro seleccionado con la planta y la fecha indicada
            MySqlConnection conexionBD = Conexion(); 
            conexionBD.Open(); //Abre la conexión

            try
            {
                MySqlCommand comando = new MySqlCommand(insert, conexionBD);
                comando.ExecuteNonQuery(); //Ejecuta la consulta
                MessageBox.Show("Registro actualizado."); //Muestra mensaje
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar registro.\n" + ex.Message); //Excepción controlada
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión
            }
        }

        private void RegVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
