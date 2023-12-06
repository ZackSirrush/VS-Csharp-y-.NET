namespace DPRN3_U1_EA_ANNT
{
    public class DPRN3U1EAANNT
    {
        public static void Main(string[] args) //Main
        {

            Viaje viaje = new Viaje();//Inicializa el objeto viaje
            int continuar = 1; //Realiza al menos un registro por cada ejecución del sistema

            do
            {
                Console.Clear(); //Limpia pantalla al inicio de cada iteración

                Console.WriteLine("**********************Ubar**********************"); //Mensaje de bienvenida
                Console.WriteLine("Bienvenido, por favor ingrese los datos solicitados");
                viaje.IngresarDatosViaje(); //Invoca el método de la clase para ingresar los datos inciales
                Console.WriteLine("\n\nLos resultados obtenidos para su viaje son: ");
                viaje.CalcularDistancia(); //Calcula la distancia del viaje
                viaje.CalcularDireccionCardinal(); //Calcula la dirección cardinal
                viaje.CalcularTiempoRecorrido(); //Calcula el tiempo recorrido
                viaje.CalcularCosto(); //Calcula el costo del viaje
                viaje.AñadirRegistro(); //Añade registro en la base de datos

                Console.WriteLine("¿Desea registrar otro viaje?"); //Inicia una nueva iteración
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");
                continuar = int.Parse(Console.ReadLine());

            } while (continuar == 1);

        }
    }

}

