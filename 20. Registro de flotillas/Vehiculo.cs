using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN3_U2_A1_ANNT
{
    class Vehiculo
    {

        Conexion con; //Invoca la clase conexión

        public string Serie { get; set; } //Getters y setter para los parámetros del formulario
        public string Tipo { get; set; }
        public DateTime FAdq { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime FFabric { get; set; }
        public byte[] Foto { get; set; }
        public string Color { get; set; }
        public string Verif { get; set; }

        public Vehiculo() //Constructor de la clase
        {
            con= new Conexion(); //Establece la conexión SQL
        }

        public bool Agregar(Vehiculo nvehiculo) //Sentencia SQL para agregar datos a la base de datos
        {


            SqlCommand SQLComando = new SqlCommand("INSERT INTO Vehiculo(NoSerie, TipoVehiculo, AnoAdqusicion, Marca, Modelo, AnoFabricacion, Foto, Color, Verificacion)" +
                " VALUES(@NoSerie, @TipoVehiculo, @AnoAdqusicion, @Marca, @Modelo, @AnoFabricacion, @Foto, @Color, @Verificacion);");

            SQLComando.Parameters.Add("@NoSerie", SqlDbType.VarChar).Value=nvehiculo.Serie; //Selecciona los datos almacenados en los getters y setters
            SQLComando.Parameters.Add("@TipoVehiculo", SqlDbType.VarChar).Value = nvehiculo.Tipo; //Sustituye los datos por los valores guardados
            SQLComando.Parameters.Add("@AnoAdqusicion", SqlDbType.Date).Value = nvehiculo.FAdq;
            SQLComando.Parameters.Add("@Marca", SqlDbType.VarChar).Value = nvehiculo.Marca;
            SQLComando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = nvehiculo.Modelo;
            SQLComando.Parameters.Add("@AnoFabricacion", SqlDbType.Date).Value = nvehiculo.FFabric;
            SQLComando.Parameters.Add("@Foto", SqlDbType.Image).Value = nvehiculo.Foto;
            SQLComando.Parameters.Add("@Color", SqlDbType.VarChar).Value = nvehiculo.Color;
            SQLComando.Parameters.Add("@Verificacion", SqlDbType.VarChar).Value = nvehiculo.Verif;

            return con.EjecutarComando(SQLComando); //Devuelve la consulta en sql

        }

        public DataSet Mostrar() //Ejecuta la sentencia para mostrar una consulta SQL
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Vehiculo"); //Consulta por ejecutar
            return con.EjecutarSentencia(sentencia); //Devuelve la consulta

        }


    }
}
