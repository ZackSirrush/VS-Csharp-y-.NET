using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geolocation;//Utiliza la biblioteca Geolocation
using System.Data;

namespace DPRN3_U1_EA_ANNT
{
    class Viaje //Clase Viaje
    {

        private int usuario;//ATRIBUTOS PRIVADOS
        private double latori, longori, latdest, longdest, distance, distanciakm, tiempor, costo; 
        private string fechaviaje;
        private DateTime horainicio,horafin;
        private string direccioncardinal;

        public double Latori {get { return latori; }}//GETTERS DE CLASE
        public double Longori {get { return longori; }}
        public double Latdest {get { return latdest; }}
        public double Longdest {get { return longdest; }}
        public int Usuario{get { return usuario; }}
        public string Fechaviaje {get { return fechaviaje; }}
        public DateTime Horainicio {get { return horainicio; }}
        public DateTime Horafin {get { return horafin; }}
        public double Distance {get { return distance; }}
        public double Distanciakm {get { return distanciakm; }}
        public double Tiempor {get { return tiempor; }}
        public string Direccioncardinal {get { return direccioncardinal; }}
        public double Costo {get { return costo; }}

        public void IngresarDatosViaje() //Método Ingresar datos
        {
            //Solicita los datos principales para el cálculo de lo solicitado
            Console.WriteLine("Ingresa el usuario que realizadará el viaje");
            Console.WriteLine("1. Isaac Nabor");
            Console.WriteLine("2. Manuel Gómez González");
            Console.WriteLine("3. Héctor Aguilar Llanos");
            usuario = int.Parse(Console.ReadLine()); //Solicita uno de los usuarios precargados en la base de datos
            Console.WriteLine("Ingrese sus coordenadas de origen"); //Solicita coordenadas de origen y destino
            Console.WriteLine("Latitud: ");
            latori = double.Parse(Console.ReadLine());
            Console.WriteLine("Longitud: ");
            longori = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese sus coordenadas destino");
            Console.WriteLine("Latitud: ");
            latdest = double.Parse(Console.ReadLine());
            Console.WriteLine("Longitud: ");
            longdest = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su fecha de salida (DD/MM/AAAA): "); //Solicita fecha de salida en el formato indicado
            fechaviaje = Console.ReadLine();
            Console.WriteLine("Ingrese su hora de salida (00:00:00): "); //Solicita hora de salida en el formato indicado
            horainicio = DateTime.Parse(Console.ReadLine());


        }

        public void CalcularDistancia() //Método para calcular distancia
        {

            Coordinate origin = new Coordinate(Latori, Longori); //Se indica el origen y destino solicitados por la biblioteca
            Coordinate destination = new Coordinate(Latdest, Longdest);

            distance = GeoCalculator.GetDistance(origin, destination, 1); //Determina la distancia en millas

            distanciakm = distance * 1.609; //Se multiplican las millas por los kilómetros; en promedio, una milla equivale a 1 km

            Console.WriteLine("La distancia del trayecto es: " + distance + " millas, "); //muestra resultado en pantalla
            Console.WriteLine("lo que equivale a: " +distanciakm+" kilómetros.");

        }

        public void CalcularDireccionCardinal() //Método para determinar la dirección cardinal
        {
            Coordinate origin = new Coordinate(Latori, Longori);//Se indica el origen y destino solicitados por la biblioteca
            Coordinate destination = new Coordinate(Latdest, Longdest);

            direccioncardinal = GeoCalculator.GetDirection(origin,destination); //Usa la biblioteca para obtener la direccion predefinida

            Console.WriteLine("Se realiza con dirección cardinal al: "+direccioncardinal); //Muestra la dirección cardinal

        }

        public void CalcularTiempoRecorrido() //Método para calcular el tiempo de recorrido
        {

            const double velocidad = 50; //A una velocidad de 50 km/h
            double tiemporec = distanciakm / velocidad; //divide la distancia en km entre la velocidad, obteniendo el tiempo en horas
            tiempor = (tiemporec * 60) / 1;//Se determina el equivalente del tiempo en minutos
            TimeSpan timeSpan = TimeSpan.FromHours(tiemporec); //Convierte el tiempo a horas

            horafin = horainicio.Add(timeSpan); //se añade el tiempo de recorrido a la hora de inicio

            Console.WriteLine("El tiempo de duración de recorrido será de: " + tiempor+" minutos"); //Muestra los resultados obtenidos
            Console.WriteLine("La hora estimada de llegada será a las: "+horafin);

        }
        public void CalcularCosto() //Método para calcular costo del viaje
        {
            const double p = 50; //Determina que el precio serán $50
            const double r = 2; //Por cada 2km recorridos
            costo = (distanciakm * p) / r;//el costo es igual a la distancia recorrida * precio / km

            Console.WriteLine("El costo de su viaje será de: $"+costo); // muestra el costo
        }

        public void AñadirRegistro() //Añade registro a la base de datos
        {

            string cadena = "Data Source=PC-ZACKSIRRUSH\\SQLEXPRESS;Initial Catalog=ViajesUbar; Integrated Security=True"; //Establece la conexión al servidor de BD
            //En este caso, se conecta al servidor local, por lo que es probable que sea necesario cambiar el nombre del servidor
            //para que funcione en otros ordenadores.
            
            SqlConnection conectarbd = new SqlConnection(@cadena); //Establece la conexión

            try //Clausula Try-Catch para evitar errores de conexión
            {
                
                string query = "INSERT INTO Viaje (LatOrigen,LongOrigen,LatDestino,LongDestino,FechaViaje,HoraInicio,Distancia,DireccionCardinal,TiempoViaje,HoraLlegada,Costo,IDUsuario2)" +
                " Values (@LatOrigen,@LongOrigen,@LatDestino,@LongDestino,@FechaViaje,@HoraInicio,@Distancia,@DireccionCardinal,@TiempoViaje,@HoraLlegada,@Costo,@IDUsuario2)";
                conectarbd.Open(); //Consulta SQL y conexión abierta
                SqlCommand comando = new SqlCommand(query, conectarbd); //Indicación para leer comandos ingresados


                comando.Parameters.AddWithValue("@LatOrigen", latori); //Se ingresa cada parámetro a la tabla seleccionada
                comando.Parameters.AddWithValue("@LongOrigen", longori);
                comando.Parameters.AddWithValue("@LatDestino", latdest);
                comando.Parameters.AddWithValue("@LongDestino", longdest);
                comando.Parameters.AddWithValue("@FechaViaje", fechaviaje);
                comando.Parameters.AddWithValue("@HoraInicio", horainicio);
                comando.Parameters.AddWithValue("@Distancia", distanciakm);
                comando.Parameters.AddWithValue("@DireccionCardinal", direccioncardinal);
                comando.Parameters.AddWithValue("@TiempoViaje", tiempor);
                comando.Parameters.AddWithValue("@HoraLlegada", horafin);
                comando.Parameters.AddWithValue("@Costo", costo);
                comando.Parameters.AddWithValue("@IDUsuario2", usuario);            
                comando.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("Se han registrado los datos de su viaje"); //Registro exitoso

            }
            catch (SqlException e) //Muestra error en la conexión
            {
                Console.WriteLine("Error generado. Detalles: " + e.ToString());
            }
            finally
            {
                conectarbd.Close(); //Cierra la conexión
            }
        }
    }
}
