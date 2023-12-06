using System;

namespace DPRN_U2_A3_ANNT
{
    class Program
    {
        static void Main(string[] args){ //Método main

            string cadena1, cadena2, cadena3; //Declaración de variables
            
            Console.WriteLine("Bienvenido"); //Mensaje de bienvenida
            Console.WriteLine("Por favor ingrese 3 cadenas de datos: ");
            Console.WriteLine("Cadena 1: ");
            cadena1 = Console.ReadLine(); //Inicialización de variables
            Console.WriteLine("Cadena 2: ");
            cadena2 = Console.ReadLine();
            Console.WriteLine("Cadena 3: ");
            cadena3 = Console.ReadLine();

            string salida1 = concatenavalores(cadena1, cadena2, cadena3); //Llamado a método 1
            string salida2 = mayusculas(cadena1, cadena2, cadena3); //Llamado a método 2
            string salida3 = minusculas(cadena1, cadena2, cadena3); //Llamado a método 3

            Console.WriteLine("\n\nSalida 1 = "+salida1); //Muestra salida 1
            Console.WriteLine("Salida 2 = " + salida2); //Muestra salida 2
            Console.WriteLine("Salida 3 = " + salida3); //Muestra salida 3

        }

        static string concatenavalores (string c1,string c2,string c3){ //Método 1

            return c1.Substring(0,1).ToUpper()+c1.Substring(1).ToLower()+" "+c2.Substring(0, 1).ToUpper() + c2.Substring(1).ToLower() + " "+c3.Substring(0, 1).ToUpper() + c3.Substring(1).ToLower(); 
            //Regresa la concatenación de valores, donde la primera letra del string es mayúscula y las demás minúsculas, separadas por un espacio
        }

        static string mayusculas (string c1,string c2, string c3){ //Método 2

            return c1.ToUpper() + " " +c2.ToUpper()+" "+c3.ToUpper(); //Devuelve los valores del string convertidos a mayúsculas

        }
        static string minusculas(string c1, string c2, string c3){

            return c1.ToLower() + " " + c2.ToLower() + " " + c3.ToLower(); //Devuelve los valores del string convertidos a minúsculas

        }
    }
}
