namespace DPRN2_U1_A1_ANNT
{
    public class Medicamento
    {

        private string nombre, tipoCont, tipoAplic; //Encapsulamiento de variables
        private double contenido, precio; //Usando modificadores de acceso
        private int umbral;

        public string Nombre { get => nombre; set => nombre = value; } //Getters y setters de la variables privadas
        public string TipoCont { get => tipoCont; set => tipoCont = value; }
        public string TipoAplic { get => tipoAplic; set => tipoAplic = value; }
        public double Contenido { get => contenido; set => contenido = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Umbral { get => umbral; set => umbral = value; }

        public void AgregarMedicamento() //Primer método con sobrecarga
        {
            Console.WriteLine("Ingresa el nombre del medicamento: "); //Solicita los atributos principales del medicamento
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa la cantidad de contenido del medicamento: "); //El usuario ingresa los datos indicados
            Contenido = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tipo de contenido del medicamento (ml, tabletas, etc.: ");
            TipoCont = Console.ReadLine();
            Console.WriteLine("Ingresa el precio del medicamento: ");
            Precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tipo de aplicación del medicamento (intramuscular, oral, sublingual): ");
            TipoAplic = Console.ReadLine();
            if (TipoAplic == "intramuscular") //Si el tipo de aplicación es intramuscular, permite ingresar el umbral de dolor
            {
                Console.WriteLine("Ingresa el umbral de dolor por la aplicación del medicamento (en escala del 1 al 10): ");
                Umbral = int.Parse(Console.ReadLine());
            }
            else //En caso contrario, se indica que el medicamento no causa dolor y el umbral se establece en cero
            {
                Umbral = 0;
                Console.WriteLine("El medicamento no causa dolor");
            }

        }

        public void AgregarMedicamento(string nombre) //Sobrecarga del método agregar medicamentos
        {
            Console.WriteLine("Tipo de aplicación (intramuscular, oral, sublingual): "); //solicita el ingreso de diferentes variables 
            TipoAplic = Console.ReadLine(); //Este método se utiliza en la clase RecetaMedica
            Console.WriteLine("Contenido: ");
            Contenido = double.Parse(Console.ReadLine());
            Console.WriteLine("Precio: ");
            Precio = double.Parse(Console.ReadLine());

        }

        public void AplicarMedicamento() //Método con sobrecarga aplicar medicamentos
        {
            if (TipoAplic == "intramuscular") //Según el tipo de aplicación, será el mensaje mostrado
            {
                Console.WriteLine("Preparate para la inyección, el umbral de dolor es: " + Umbral); //Muestra el umbral de dolor
            }
            else if (TipoAplic == "oral")
            {
                Console.WriteLine("Preparate para tomar tu medicamento");
            }
            else if (TipoAplic=="sublingual"){ //Muestran mensajes de advertencia
                Console.WriteLine("Este medicamento se aplica debajo de tu lengua, preparado");
            }
            else
            {
                Console.WriteLine("Tipo de medicamento no encontrado");
            }
            
        }

        public void AplicarMedicamento(string tipoaplic) //Sobrecarga del método
        {
            Console.WriteLine("Prepárate para la inyección, el umbral de dolor es: "+(Umbral+Umbral));//Se suman los umbrales de un mismo tipo de medicamento
        }

    }

}