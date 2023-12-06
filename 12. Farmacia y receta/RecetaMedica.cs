
namespace DPRN2_U1_A1_ANNT
{
    public class RecetaMedica //Clase receta médica
    {

        private int cant, dias; //Variables con modificadores de acceso
        private double dosis;
        private DateTime finicial, ffinal;
        Medicamento datos = new Medicamento(); //Instancia de objeto

        public int Cant { get => cant; set => cant = value; } //Setters y getters de las variables
        public double Dosis { get => dosis; set => dosis = value; }
        public DateTime Finicial { get => finicial; set => finicial = value; }
        public DateTime Ffinal { get => ffinal; set => ffinal = value; }
        public int Dias { get => dias; set => dias = value; }

        public void DatosReceta() //Método datos receta
        {
            
            Console.WriteLine("Medicamento: "); //Solicita el nombre del medicamento
            string nombre = Console.ReadLine();
            datos.AgregarMedicamento(nombre); //Invoca la clase sobrecargada agregar medicamentos, estableciendo un parámetro de tipo string
            Console.WriteLine("Dosis diaria recetada: ");
            Dosis = int.Parse(Console.ReadLine()); //Solicita la dosis del medicamento
            Console.WriteLine("Fecha de inicio del tratamiento (dd/MM/yyyy): "); //Inserta la fecha en formato string
            string fini = Console.ReadLine(); //Recibe la fecha
                Finicial = DateTime.ParseExact(fini, "dd/MM/yyyy", null); //Convierte la fecha de string a DateTime
            Console.WriteLine("Fecha final del tratamiento (dd/MM/yyyy): ");
            string ffin = Console.ReadLine();
                Ffinal = DateTime.ParseExact(ffin, "dd/MM/yyyy", null);
            
            TimeSpan tSpan = Ffinal-Finicial; //Obtiene la diferencia en días de las fechas dadas
            
            int dias = tSpan.Days; //Convierte la diferencia én la fecha a días
            
            Console.WriteLine("Los días de tratamiento son: "+dias);

            double duracionpaq = (datos.Contenido/Dosis); //Determina la duración de un paquete de medicina, divide el contenido entre la dosis
            int dur = (int)Math.Round(duracionpaq); //convierte la duración del paquete en un entero
            Cant = 1+dias/dur; //Determina la cantidad de paquetes a surtir, dividiendo los días entre la duración del paquete más 1.
                                //(Por el redondeo)
            if(Cant > 0) //Si la cantidad es mayor que 0
            {
                Console.WriteLine("Cantidad de frascos/paquetes a surtir: " +Cant+" pzs"); //Muestra un mensaje en pantalla
            } else
            {
                Cant = 0;
                Console.WriteLine("No se deben surtir paquetes"); //De lo contrario, establece la cantidad en 0
            }

        }

        public void ObtenerMontoReceta() //Método obtener monto
        {
            double monto; //Define la variable monto
            monto = Cant * datos.Precio; //Multiplica la cantidad por el precio
            if(monto > 0)
            {
                Console.WriteLine("El monto de la receta es de $"+monto.ToString("N2")); //Si es mayor que cero, coloca el mensaje, el monto 
            } else                                                                       //Y dos decimales
            {
                monto = 0.0;
                Console.WriteLine("El monto de la receta es de $" + monto.ToString("N1")); //De lo contrarop coloca el monto y un decimal.
            }
        }


    }
}