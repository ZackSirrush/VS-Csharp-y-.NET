using System;

namespace DPRN2_U1_A1_ANNT
{
    class Program
    {
        static void Main(string[] args)
        {

            int accion, cont; //Variables contador y accion para switch

            pokemon nuevoPokemon = new pokemon(); //Creación del objeto pokemon, iniciación de variable; instanciación

            
            do //Estructura do while
            {
                Console.WriteLine("\n¿Qué acción desea realizar?"); //Menú de opciones a realizar
                Console.WriteLine("1. Agregar nuevo pokemon.");
                Console.WriteLine("2. Alimentar pokemon.");
                Console.WriteLine("3. Realizar ataque básico.");
                Console.WriteLine("4. Realizar ataque especial.");
                accion = int.Parse(Console.ReadLine()); //Lee el dato ingresado por el usuario

                switch (accion) //Swich case
                {
                    case 1: //Caso 1, ingresa datos de pokemon y determina si es o no salvaje
                        nuevoPokemon.AgregarPokemon();
                        nuevoPokemon.esSalvaje();
                        break;
                    case 2:
                        nuevoPokemon.alimenta(); //Caso 2, alimenta al pokemon
                        break;
                    case 3:
                        nuevoPokemon.AtaqueBasico(); //Caso 3, realiza un ataque básico
                        break;
                    case 4:
                        nuevoPokemon.AtaqueEspecial(); //Caso 4, realiza un ataque especial
                        break;
                    default:
                        Console.WriteLine("Opción no válida"); //Cualquier otra opción es no válida
                        break;
                }
                Console.WriteLine("\n\n¿Desea realizar otra acción?"); //Repite el menú luego de concluir la acción anterior
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");
                cont = int.Parse(Console.ReadLine());//recibe la respuesta del usuario

            } while (cont == 1); //el bucle se repite mientras cont sea igual a 1

        }
    }
    class pokemon //Creación de la clase pokemon
    {
        private string nombre, sexo, tipo, ataquebasico, ataqueespecial; //Establece privadas las variables 
        private double altura, peso, experiencia,drealab,drealae;
        private int poderae, poderab, salud;
        private bool salvaje;
        private double motivacion=0;

        public string Nombre { get => nombre; set => nombre = value; } //Setters y Getters de las variables privadas
        public string Sexo { get => sexo; set => sexo = value; }
        public string Tipo { get => tipo; set => tipo = value; } //Se establecen para poder utilizar las variables
        public string Ataquebasico { get => ataquebasico; set => ataquebasico = value; }
        public string Ataqueespecial { get => ataqueespecial; set => ataqueespecial = value; }
        public double Altura { get => altura; set => altura = value; } //encapsulando las variables de la clase
        public double Peso { get => peso; set => peso = value; }
        public int Poderae { get => poderae; set => poderae = value; } //El nombre de la variable cambia, colocando una mayúscula al inicio
        public int Poderab { get => poderab; set => poderab = value; }
        public int Salud { get => salud; set => salud = value; }
        public bool Salvaje { get => salvaje; set => salvaje = value; }
        public double Motivacion { get => motivacion; set => motivacion = value; }
        public double Experiencia { get => experiencia; set => experiencia = value; }
        public double Drealab { get => drealab; set => drealab = value; }
        public double Drealae { get => drealae; set => drealae = value; }

        public void AgregarPokemon() //Método "agregar pokemon"
        {
            Console.WriteLine("Ingresa el nombre del pokemon: "); //Solicita los datos principales del pokemon
            Nombre=Console.ReadLine();
            Console.WriteLine("Ingresa el sexo del pokemon: "); //Entre ellos su nombre, sexo, ps, peso, tipo, altura, ataques
            Sexo = Console.ReadLine();
            Console.WriteLine("Ingresa los puntos de salud del pokemon: "); //Daños de los ataques
            Salud = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el peso del pokemon: ");
            Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tipo del pokemon: ");
            Tipo = Console.ReadLine();
            Console.WriteLine("Ingresa la altura del pokemon: ");
            Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el ataque básico del pokemon: ");
            Ataquebasico = Console.ReadLine();
            Console.WriteLine("Ingresa el daño del ataque básico: ");
            Poderab = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el ataque especial del pokemon: ");
            Ataqueespecial = Console.ReadLine();
            Console.WriteLine("Ingresa el daño del ataque especial: ");
            Poderae = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n\nEl pokemon ingresado es: "); //Muestra un resumen del pokemon ingresado
            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("Sexo: "+Sexo);
            Console.WriteLine("PS: "+Salud);
            Console.WriteLine("Peso: "+Peso+" Kg");
            Console.WriteLine("Tipo: "+Tipo);
            Console.WriteLine("Altura: "+Altura+" m");
            Console.WriteLine("A. Básico: "+Ataquebasico);
            Console.WriteLine("Daño A.B.: "+Poderab);
            Console.WriteLine("A. Especial: "+Ataqueespecial);
            Console.WriteLine("Daño A.E.: "+Poderae);

        }

        public void esSalvaje() //Método "es salvaje"
        {
            int salva; //selecciona si es salvaje el pokemon
            Console.WriteLine("\n¿El pokemon es salvaje?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            salva = int.Parse(Console.ReadLine()); //Lee el valor a ingresar
            if (salva == 1) //Sí es salvaje, la variable se coloca como verdadera
            {
                Salvaje = true;//Establece el valor de la variable en TRUE
                Experiencia = 0.0; //Y la experiencia en 0.0
                Console.WriteLine("\nEl pokemon sí es salvaje");
                Console.WriteLine("Su experiencia se ha establecido en "+Experiencia);
            }
            else //De lo contrario
            {
                Salvaje = false; //La variable será falsa
                Experiencia = 10.0;//Y la experiencia será de 10.0
                Console.WriteLine("\nEl pokemon no es salvaje");
                Console.WriteLine("Su experiencia se ha establecido en " + Experiencia);
            }
        }

        public void alimenta() //Método alimenta
        {
            double pesoAlimentado=Peso;//Establece el contador del peso igual al peso del pokemon
            int contador = 0; //Inicializa el contador para el bucle do-while

            do //Bucle do - while
            {
                Console.WriteLine("\n¿Alimentar pokemon?:"); //Pregunta si se desea alimentar al pokemon
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                int alimenta = int.Parse(Console.ReadLine());
                if (alimenta == 1) //sí: incrementa la motivación, el acumulador de peso y el contador
                {
                    Motivacion = Motivacion + 0.1;
                    pesoAlimentado = pesoAlimentado + 0.2;
                    contador = contador + 1;
                }
                else //si no, se establece el contador en 10
                {
                    contador = 10;
                }
                if (pesoAlimentado >= Peso*2) //Compara, sí el acumulador es mayor o igual al doble del peso
                {
                    Console.WriteLine("\nEl pokemon ahora pesa " + pesoAlimentado + "Kg, es el doble de su peso normal: " + Peso);
                    Console.WriteLine("Ya no se puede alimentar más"); //Deniega alimentar al pokemon
                    contador = 10;
                }
                else //de lo contrario
                {
                    Console.WriteLine("\nEl pokemon ahora pesa " + pesoAlimentado + "Kg, su peso normal es: " + Peso);
                    Console.WriteLine("Aún se puede alimentar más"); //Indica que el pokemon puede comer más
                }
            } while (contador != 10); //Hasta que el contador llegue a 10
        }

        public void AtaqueBasico() //Método ataque básico
        {
            Drealab = (Poderab * (Experiencia * .50)) + Motivacion; //Retoma las variables y aplica la fórmula
            Console.WriteLine("El daño real del ataque básico es: "+Drealab); //Indica el ataque básico
            Experiencia = Experiencia + 0.1; //Incrementa la experiencia en .1
            Console.WriteLine(Nombre+" ahora tiene " + Experiencia+" puntos de experiencia");
        }

        public void AtaqueEspecial() //Método ataque especial
        {
            Drealae = (Poderae * (Experiencia * .50)) + Motivacion;
            Console.WriteLine("El daño real del ataque especial es: " + Drealae); //Realiza lo mismo que el método anterior
            Experiencia = Experiencia + 0.1;
            Console.WriteLine(Nombre + " ahora tiene " + Experiencia + " puntos de experiencia"); //Con las variables para este tipo de ataque
        }

    }
}



    