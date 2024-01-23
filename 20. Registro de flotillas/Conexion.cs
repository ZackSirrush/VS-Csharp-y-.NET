using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    
using System.Data;


namespace DPRN3_U2_A1_ANNT
{
    class Conexion
    {

        private string CadenaConexion = "Data Source=PC-ZACKSIRRUSH\\SQLEXPRESS; Initial Catalog=RegistroVehicular_DPRN3_U2_A1_ANNT; Integrated Security=True";
        
        SqlConnection conexion;

        public SqlConnection EstablecerConexion()
        {
            this.conexion = new SqlConnection(this.CadenaConexion);
            //Establece la conexión al servidor de BD; En este caso, se conecta al servidor local, por lo que es probable
            //que sea necesario cambiar el nombre del servidor para que funcione en otros ordenadores.
            return this.conexion; //Devuelve conexión
        }

        //Método para Insertar en la base de datos  (consulta INSERT)

        public bool EjecutarComando(SqlCommand SQLComando)
        {
            try
            {
                SqlCommand Comando = SQLComando;
                MessageBox.Show("Conectando...");
                Comando.Connection = this.EstablecerConexion(); //Establece y abre la conexióN
                conexion.Open();
                Comando.ExecuteNonQuery(); //Ejecuta la consulta
                conexion.Close(); //Cierra la conexión
                MessageBox.Show("Registro exitoso");
                return true; //Si la conexión es correcta devuelve true
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error "+ex.Message);
                return false; //De lo contrario devuelve false
            }
        }



        //Método para retorno de datos (consulta SELECT)
        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet(); //Crea data set apara adaptar la información
            SqlDataAdapter Adaptador = new SqlDataAdapter(); //Crea el adaptador
             
            try
            {
                SqlCommand Comando = new SqlCommand(); //Crea el comando
                Comando = sqlComando; 
                Comando.Connection = EstablecerConexion(); //Establece conexión a BD
                Adaptador.SelectCommand = Comando; //Utiliza el comando
                conexion.Open(); //Abre conexión
                Adaptador.Fill(DS); //Llenado de adaptador
                conexion.Close(); //Cierra conexión
                return DS; //Devuelve el valor
            }
            catch
            {
                return DS; //Regresa el error
            }
        }
    }
}
