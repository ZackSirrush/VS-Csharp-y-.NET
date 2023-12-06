using System;

namespace ConstructoresDestructores
{
    class Program 
    {
        static void Main(string[] args) //Clase ´programa, método principal
        {
            gatos gato1 = new gatos(); //Instanciación de objetos
            gatos gato2 = new gatos("", "", "");
            gatos gato3 = new gatos("","","",0,0);

            Console.WriteLine(gato1.getGatos());
            Console.WriteLine(gato2.getGatos("Chiquilin","gris","persa")); //Llamada a los métodos
            Console.WriteLine(gato3.getGatos("Balam","pardo","callejero",3,1)); //Se le proporcionan los parámetros para su lectura

            Console.ReadKey(); //Detiene el cierre del sistema hasta presionar una tecla

        }
    }

    class gatos  //Clase gatos
    {

        private string color, nombre, raza; //Atributos privados
        private int patas, cola, orejas;

        public gatos() //Constructor
        {
            color = "Marrón"; //Atributos del gato
            raza = "Siamés";
            patas = 4;
            cola = 1;
            orejas = 2;
        }

        public gatos(string nombre, string color, string raza) //Sobrecarga del constructor gatos
        {
            nombre = nombre; //Atributos del gato 2
            color = color;
            raza = raza;
            patas = 4;
            cola = 1;
            orejas = 2;
        }
        public gatos(string nombre, string color, string raza,int patas, int orejas) //Sobrecarga del constructor
        {
            nombre = nombre; //Atributos del gato 3
            color = color;
            raza = raza; //Este constructor permite ingresar y modificar atributos al invocarse en la clase main
            patas = patas;
            cola = 1;
            orejas = orejas;
        }

        public string getGatos() //Método getGatos
        {
            return "El gato es color " + color + " de raza " + raza + ", tiene " + patas + " patas, " + cola + " cola y " + orejas + " oreja(s).";
        } //Devuelve los datos para el gato 1
        public string getGatos(string nombre,string color, string raza)
        {
            return "El gato se llama "+nombre+" es color " + color + " de raza " + raza + ", tiene " + patas + " patas, " + cola + " cola y " + orejas + " oreja(s).";
        } //Devuelve los datos para el gato 2
        public string getGatos(string nombre, string color, string raza,int patas,int orejas)
        {
            return "El gato se llama " + nombre + " es color " + color + " de raza " + raza + ", tiene " + patas + " patas, " + cola + " cola y " + orejas + " oreja(s).";
        } //Devuelve los datos para el gato 3

        ~gatos() //Destructor
        {
            System.Diagnostics.Trace.WriteLine("Recursos destruidos"); //Muestra en el menú de resultados el mensaje.
        }
    }

}