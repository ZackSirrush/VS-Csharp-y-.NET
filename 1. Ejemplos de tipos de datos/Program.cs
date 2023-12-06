using System;

namespace DPRN_U1_A2_Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables y tipos de datos
            int edad, prize;
            float calificacion;
            double precio;
            bool seleccion;
            String nombre;

            edad = 25;
            calificacion = 80.30F;
            precio = 23.50;
            seleccion = true;
            nombre = "Angel Isaac Nabor Torres";


            //Ejemplos de operadores
            Console.WriteLine("Ejemplos de tipos de datos");
            Console.WriteLine("La edad es: " + edad);
            Console.WriteLine("Su calificación es: " + calificacion);
            Console.WriteLine("El precio es: " + precio);
            Console.WriteLine("El valor seleccionado es: " + seleccion);
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            Console.WriteLine("Ejemplos de operadores");
            Console.WriteLine("Operadores aritméticos: ");
            Console.WriteLine("Suma de 8+5: " + (8 + 5)); //Operadores aritméticos
            Console.WriteLine("Resta de 8-5: " + (8 - 5));
            Console.WriteLine("Multiplicación de 8*5: " + (8 * 5));
            Console.WriteLine("División de 8/5: " + (8.0 / 5.0));
            Console.WriteLine("Residuo de 8%5: " + (8.0 % 5.0));
            Console.WriteLine(" ");


            Console.WriteLine("Operadores relacionales: "); //Operadores relacionales
            int edadP1, edadP2, edadP3, edadP4;
            edadP1 = 15;
            edadP2 = 20;
            edadP3 = 30;
            edadP4 = 50;

            Console.WriteLine($"Cuatro personas tienen las siguientes edades: {edadP1},{edadP2},{edadP3},{edadP4}");
            if (edadP1 > edadP2)
            {
                Console.WriteLine("La persona 1 es mayor que la persona 2"); //Operadores mayor y menor que
            }
            else
            {
                Console.WriteLine("La persona 1 es menor que la persona 2");
            }
            if (edadP3 < edadP4)
            {
                Console.WriteLine("La persona 3 es menor que la persona 4");
            }
            else
            {
                Console.WriteLine("La persona 3 es mayor que la persona 4");
            }
            Console.WriteLine("");


            Console.WriteLine("Operadores lógicos: ");
            Console.WriteLine(!seleccion); //Convierte el valor a falso
            Console.WriteLine(!false); //Convierte el valor a verdadero
            Console.WriteLine(" ");

            bool prueba = false & seleccion;
            Console.WriteLine(prueba); //Operador AND
            Console.WriteLine(" ");

            bool prueba2 = true | seleccion;
            Console.WriteLine(prueba2); //Operador OR
            Console.WriteLine(" ");

            Console.WriteLine("Ejemplos de conversiones");

            prize = (int)precio; //Conversión explicita
            Console.WriteLine("El precio sin decimales es: " + prize);

            Console.WriteLine(" ");

            //Conversión implícita

            int habitantes = 100000000;
            long habitantesciudad = habitantes;

            double calific = calificacion;

            Console.WriteLine(habitantes);
            Console.WriteLine(calific);


        }
    }
}
