//Universidad Abierta y a Distancia de México
//Desarrollo de software
//Programación Net III
//Unidad 3. Manipulación de datos mediante .NET
//Actividad 2: Mysql.Data.Adapter
//Angel Isaac Nabor Torres
//ES1921013978
//Docente. Juan Daniel Oliva Vázquez

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
    public partial class VtaMensual : Form
    {
        public VtaMensual()
        {
            InitializeComponent();
            ConsultaRemota(); //Ejecuta el procedimiento para la consulta en base de datos remota
            ConsultaLocal(); //Ejecuta el procedimiento para la consulta en base de datos local
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private static MySqlConnection ConexionRemota() //Método conectar para establecer la conexión local
        {
            string server = "127.0.0.1";//Cadena de conexión para ingresar al servidor con la información alojada
            string port = "3306";
            string database = "dprn3u3"; //Nombre de la base de datos en el servidor local
            string user = "root"; //Estos datos pueden variar según el servidor local al que se conecte
            string pass = "";
            string cadenaconexion = "server=" + server + ";port=" + port + ";database=" + database + ";UserID=" + user + ";Password=" + pass + "";

            try //Try catch
            {
                MySqlConnection conexionBDr = new MySqlConnection(cadenaconexion); //Recibe la cadena de conexión
                MessageBox.Show("Conexión a bases de datos exitosa.");
                return conexionBDr;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Conexión a base de datos remota fallida.\n " + e.Message);
                return null;
            }

        }
        private void ConsultaRemota() //Realiza la consulta al servidor remoto
        {
            
            string consulta = "SELECT Planta, date_format(Fecha,'%Y-%m-01') as Fecha, SUM(Cantidad) as Cantidad, SUM(Total) as Total FROM ventas GROUP BY Planta,date_format(Fecha,'%Y-%m-01') ORDER BY Planta"; //Ejecuta consulta Select
            MySqlConnection conexionBDr = ConexionRemota(); //Se establece límite de 1 para que encuentre solo 1 resultado
            conexionBDr.Open(); //Abre la conexión

            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conexionBDr);
                comando.CommandTimeout = 360;//Tiempo de ejecución del comando
                MySqlDataReader reader; //Almacena la consulta en un datareader
                reader = comando.ExecuteReader(); //Ejecuta el datareader
                if (reader.HasRows)
                {
                    this.dgvbdremota.DataSource = null; //limpia el data grid view
                    this.dgvbdremota.Rows.Clear();
                    int contador = 0;
                    while (reader.Read()) //Imprime el data reader en la tabla indicada
                    {

                        int n = dgvbdremota.Rows.Add();
                        dgvbdremota.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgvbdremota.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgvbdremota.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgvbdremota.Rows[n].Cells[3].Value = reader.GetString(3);
                        contador = contador +1; //Contador de iteraciones del ciclo while
                        toolStripStatusLabel1.Text = contador.ToString() + " registros en BD Remota"; //Imprime el resultado del contador en el label
                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron ventas"); //Muestra el mensaje si la tabla está vacía
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Text + " " + e.Message);//Excepción
            }
            finally
            {
                conexionBDr.Close();
            }
        }

        private static MySqlConnection ConexionLocal() //Método conectar para establecer la conexión local
        {
            string server = "127.0.0.1";//Cadena de conexión para ingresar al servidor con la información alojada
            string port = "3306";
            string database = "dprn3u3"; //Nombre de la base de datos en el servidor local
            string user = "root"; //Estos datos pueden variar según el servidor local al que se conecte
            string pass = "root";
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

        private void ConsultaLocal() //Realiza la consulta en la base de datos local
        {
            string consulta = "SELECT Planta,Date_Format(Fecha,'%Y-%m-%d') AS Fecha,Cantidad,Total FROM ventas ORDER BY Planta"; //Ejecuta consulta Select
            MySqlConnection conexionBD = ConexionLocal(); //Se establece límite de 1 para que encuentre solo 1 resultado
            conexionBD.Open(); //Abre la conexión

            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.CommandTimeout = 360;//Tiempo de ejecución del comando
                MySqlDataReader reader; //Almacena la consulta en un datareader
                reader = comando.ExecuteReader(); //Ejecuta el datareader
                if (reader.HasRows)
                {
                    this.dgvbdlocal.DataSource = null;
                    this.dgvbdlocal.Rows.Clear();
                    int contador = 0;
                    while (reader.Read()) //Imprime el data reader en la tabla indicada
                    {

                        int n = dgvbdlocal.Rows.Add();
                        dgvbdlocal.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgvbdlocal.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgvbdlocal.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgvbdlocal.Rows[n].Cells[3].Value = reader.GetString(3);
                        contador = contador + 1; //Contador de iteraciones del ciclo while
                        toolStripStatusLabel2.Text = contador.ToString() + " registros en BD Remota"; //Imprime el resultado del contador en el label
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron ventas"); //Muestra el mensaje si la tabla está vacía
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Text + " " + e.Message);//Excepción
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void buscarbttn_Click(object sender, EventArgs e) //Botón buscar
        {
            BuscarLocal(); //Instancia el método de búsqueda local y remota
            BuscarRemoto();
        }

        private void dgvbdlocal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BuscarLocal()
        {
            string buscar = buscartb.Text;

            string consulta = "SELECT Planta,Date_Format(Fecha,'%Y-%m-%d') AS Fecha,Cantidad,Total " +
                "FROM ventas WHERE Planta LIKE '" + buscar + "' OR Fecha LIKE '" + buscar + "' OR " +
                "Cantidad LIKE '" + buscar + "' OR Total LIKE '" + buscar + "' ORDER BY Planta"; //Ejecuta consulta Select
            MySqlConnection conexionBD = ConexionLocal(); //Instancia la conexión
            conexionBD.Open(); //Abre la conexión

            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.CommandTimeout = 360;//Tiempo de ejecución del comando
                MySqlDataReader reader2; //Almacena la consulta en un datareader
                reader2 = comando.ExecuteReader(); //Ejecuta el datareader
                if (reader2.HasRows)
                {
                    this.dgvbdlocal.DataSource = null;
                    this.dgvbdlocal.Rows.Clear();
                    int contador = 0;
                    while (reader2.Read()) //Imprime el data reader en la tabla indicada
                    {

                        int m = dgvbdlocal.Rows.Add();
                        dgvbdlocal.Rows[m].Cells[0].Value = reader2.GetString(0);
                        dgvbdlocal.Rows[m].Cells[1].Value = reader2.GetString(1);
                        dgvbdlocal.Rows[m].Cells[2].Value = reader2.GetString(2);
                        dgvbdlocal.Rows[m].Cells[3].Value = reader2.GetString(3);
                        contador = contador + 1; //Contador de iteraciones del ciclo while
                        toolStripStatusLabel2.Text = contador.ToString() + " registros en BD local"; //Imprime el resultado del contador en el label
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron ventas"); //Muestra el mensaje si la tabla está vacía
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error, " + ex.Message);//Excepción
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión
            }
        }

        private void BuscarRemoto()
        {
            string buscar = buscartb.Text;

            string consulta = "SELECT Planta,date_format(Fecha,'%Y-%m-01') AS Fecha,SUM(Cantidad) as Cantidad, SUM(Total) as Total " +
                "FROM ventas WHERE Planta LIKE '" + buscar + "' OR date_format(Fecha,'%Y-%m-01') LIKE '" + buscar + "' OR " +
                "Cantidad LIKE '" + buscar + "' OR Total LIKE '" + buscar + "' GROUP BY Planta,date_format(Fecha,'%Y-%m-01') ORDER BY Planta"; //Ejecuta consulta Select
            MySqlConnection conexionBDr = ConexionRemota(); //Instancia la conexión
            conexionBDr.Open(); //Abre la conexión

            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conexionBDr);
                comando.CommandTimeout = 360;//Tiempo de ejecución del comando
                MySqlDataReader reader; //Almacena la consulta en un datareader
                reader = comando.ExecuteReader(); //Ejecuta el datareader
                if (reader.HasRows)
                {
                    this.dgvbdremota.DataSource = null; //limpia el data grid view
                    this.dgvbdremota.Rows.Clear(); 
                    int contador = 0;
                    while (reader.Read()) //Imprime el data reader en la tabla indicada
                    {

                        int m = dgvbdremota.Rows.Add();
                        dgvbdremota.Rows[m].Cells[0].Value = reader.GetString(0);
                        dgvbdremota.Rows[m].Cells[1].Value = reader.GetString(1);
                        dgvbdremota.Rows[m].Cells[2].Value = reader.GetString(2);
                        dgvbdremota.Rows[m].Cells[3].Value = reader.GetString(3);
                        contador = contador + 1; //Contador de iteraciones del ciclo while
                        toolStripStatusLabel1.Text = contador.ToString() + " registros en BD remota"; //Imprime el resultado del contador en el label
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros"); //Muestra el mensaje si la tabla está vacía
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error, " + ex.Message);//Excepción
            }
            finally
            {
                conexionBDr.Close(); //Cierra la conexión
            }
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e) //Al seleccionar una tupla del data grid view remoto
        {
            try { 
            int indice = e.RowIndex; //determina un índice
            plantartb.Text = dgvbdremota.Rows[indice].Cells[0].Value.ToString(); //Coloca los valores de la tupla
            fechartb.Text = dgvbdremota.Rows[indice].Cells[1].Value.ToString(); //según su índice
            cantidadrtb.Text = dgvbdremota.Rows[indice].Cells[2].Value.ToString(); //en los textbox deshabilitads
            totalrtb.Text = dgvbdremota.Rows[indice].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, se ha seleccionado una tupla vacía.\n"+ ex.Message,"Tupla vacía",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void SelectLocal(object sender, DataGridViewCellMouseEventArgs e) //Al seleccionar una tupla del data grid view remoto
        {
            try { 
            int indice2 = e.RowIndex; //Determina un índice
            plantaltb.Text = dgvbdlocal.Rows[indice2].Cells[0].Value.ToString(); //Y coloca los valores de la tupla
            fechaltb.Text = dgvbdlocal.Rows[indice2].Cells[1].Value.ToString(); //según su índice
            cantidadltb.Text = dgvbdlocal.Rows[indice2].Cells[2].Value.ToString(); //en los textbox dehabilitados
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, se ha seleccionado una tupla vacía.\n"+ ex.Message,"Tupla vacía", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //A excepción del textbox cantidad, para que el usuario pueda cambiar el valor.
            //Tampoco se obtiene el valor del total, ya que eso se calcula al cambiar el valor de la cantidad para obtener el valor correcto
            //Según la planta seleccionada
        }

        private void reestablecerbttn_Click(object sender, EventArgs e)
        {
            
            buscartb.Text = ""; //Limpia el textbox
            ConsultaLocal(); //Reinicia la consulta local
            ConsultaRemota(); //Reinicia la consulta remota
        }

        private void actualizarbttn_Click(object sender, EventArgs e)
        {
            Actualizar(); //Instancia el método actualizar
            ConsultaLocal(); //Reinicia la busqueda
            ConsultaRemota();
            buscartb.Text = ""; //Limpia el textbox
            plantaltb.Text = ""; //Limpia los datos de los textbox en el formulario.
            fechaltb.Text = "";
            cantidadltb.Text = "0";
            totalltb.Text = "0";
        }

        private void Actualizar() //Método actualizar
        {
            string planta = plantaltb.Text; //Retoma los datos ingresados en el formulario.
            string fecha = fechaltb.Text;
            int cant = int.Parse(cantidadltb.Text);
            int tot = int.Parse(totalltb.Text);
            string insert = "UPDATE ventas SET Cantidad='" + cant + "',Total='" + tot + "' WHERE Planta='" + planta + "' AND Fecha='" + fecha + "'"; //Ejecuta actualización de datos
            //Recibe la consulta "update" donde cambia las cantidades y total del registro seleccionado con la planta y la fecha indicada
            MySqlConnection conexionBD = ConexionLocal();
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

        private void cantidadltb_TextChanged(object sender, EventArgs e) //Al detectar que cambia el texto del textbox cantidad realiza lo siguiente.
        {
            try //Evita que se cierre el programa
            {
                int cant = Convert.ToInt32(cantidadltb.Text); //Obtiene el valor del textbox y lo convierte a int
                int total; //Declara la variabnle total
                string planta = plantaltb.Text; //Obtiene el valor capturado en el textbox

                if (planta == "Agave") //Compara el valor del textbox y con base en ello, realiza la multiplicación adecuada
                {
                    total = cant * 52;
                    totalltb.Text = total.ToString();
                }
                else if (planta == "Biznaga") //Multiplicando el costo de la planta, por la cantidad ingresada
                {
                    total = cant * 97;
                    totalltb.Text = total.ToString();
                }
                else if (planta == "Cempasuchil") //Y devuelve el total en un textbox que se encuentra deshabilitado
                {
                    total = cant * 16;
                    totalltb.Text = total.ToString(); //para evitar que el usuario haga cambios malintencionados en los registros de fecha y planta
                }
                else if (planta == "Dalia") //Ingresando plantas no registradas
                {
                    total = cant * 21;
                    totalltb.Text = total.ToString();
                }
                else if (planta == "Magnolia Pacifica")
                {
                    total = cant * 25;
                    totalltb.Text = total.ToString();
                }
                else if (planta == "Nochebuena")
                {
                    total = cant * 40;
                    totalltb.Text = total.ToString();
                }
                else if (planta == "Nopal Cardon")
                {
                    total = cant * 9;
                    totalltb.Text = total.ToString();
                }
                else if (planta == "Orquidea Pelicano")
                {
                    total = cant * 19;
                    totalltb.Text = total.ToString();
                }
                else if (planta == "Peyote")
                {
                    total = cant * 30;
                    totalltb.Text = total.ToString();
                }
                else if (planta == "Peyotillo")
                {
                    total = cant * 36;
                    totalltb.Text = total.ToString();
                }
                else if (planta == "Zapatilla de Venus")
                {
                    total = cant * 14;
                    totalltb.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato de datos incorrecto. "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); //Muestra mensaje de error
            } //Ya que el programa se cerraba al presionar la tecla suprimir o borrar, ahora solo muestra una advertencia para que el usuario corrija el valor


        }

        private void cantidadltb_KeyPress(object sender, KeyPressEventArgs e)//Limita el textbox para recibir solo números
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) //Elige un parámetro según el código ASCII donde hay números
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Muestra un mensaje de alerta
                e.Handled = true;
                return;
            }
        }

        private void eliminarbttn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de que desea eliminar el registro actual?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Eliminar();//Método eliminar
                BuscarLocal();
                plantaltb.Text = ""; //Limpia los datos de los textbox en el formulario.
                fechaltb.Text = "";
                cantidadltb.Text = "0";
                totalltb.Text = "0";
            }
            else
            {
                MessageBox.Show("No se ha eliminado nada", "Proceso cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                plantaltb.Text = ""; //Limpia los datos de los textbox en el formulario.
                fechaltb.Text = "";
                cantidadltb.Text = "0";
                totalltb.Text = "0";
            }
            
        }

        public void Eliminar()
        {
            string planta = plantaltb.Text; //Retoma los datos ingresados en el formulario.
            string fecha = fechaltb.Text;
            int cant = int.Parse(cantidadltb.Text);
            int tot = int.Parse(totalltb.Text);
            int flag = 0;

            string consulta = "DELETE FROM ventas WHERE Planta LIKE '" + planta + "' AND Fecha LIKE '" + fecha + "' AND " +
                "Cantidad LIKE '" + cant + "' AND Total LIKE '" + tot + "'"; //Ejecuta consulta Select
            MySqlConnection conexionBD = ConexionLocal(); //Instancia la conexión
            conexionBD.Open(); //Abre la conexión
            MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
            comando.CommandTimeout = 360;//Tiempo de ejecución del comando
            flag = comando.ExecuteNonQuery();

            if(flag == 1)
            {
                MessageBox.Show("Registro eliminado correctamente","Registro eliminado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No existen registros con esos datos.","Registro no eliminado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            } 
            conexionBD.Close(); //Cierra la conexión

        }

        private void VtaMensual_Load(object sender, EventArgs e)
        {

        }
    }
}
