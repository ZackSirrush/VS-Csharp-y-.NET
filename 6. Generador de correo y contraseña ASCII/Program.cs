using System;

namespace DPRN1_U2_EA_ANNT
{
    class Program
    {
        static void Main(string[] args) //Método main
        {
            string nombre, ap, am; //Declaración de variables

            Console.WriteLine("Bienvenido");
            Console.WriteLine("Por favor ingrese su primer nombre");//Inicialización de variables
            nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su apellido paterno");
            ap = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su apellido materno");
            am = Console.ReadLine();

            Console.WriteLine("\n\nMétodo 1. Correo: "); //Llamado al método 1
            string salida1 = correo(nombre, ap, am);
            Console.WriteLine(salida1);

            Console.WriteLine("\n\nMétodo 2. Contraseña: "); //Llamado al método 2
            string salida2 = contrasena(nombre, ap, am);
            Console.WriteLine(salida2);

            Console.WriteLine("\n\nMétodo 3. Resultados: "); //Invocación del método 3
            concatena(nombre, ap, am,salida1);

            static string correo(string nombre, string ap, string am) { //Método 1: correo

                string am2 = am.Substring(0, 1); //Selecciona la primera letra de cada apellido
                string ap2 = ap.Substring(0, 1);
                return nombre.ToLower() + "." + am2.ToLower() + ap2.ToLower() + "@correo.com"; //Devuelve el nombre en minúsculas+.+primera letra de apellido materno y paterno
                                                                                               //+@correo.com

            }
            
            static string contrasena(string nombre, string ap, string am) //Método 2
            {

                string ap2 = ap.Substring(0, 1); //Obtiene la primera letra del apellido paterno
                string ap3 = ap.Substring(ap.Length -1,1); //Obtiene la última letra del apellido paterno
                string nombre2 = nombre.Substring(0, 2); //Selecciona 2 primeras letras del nombre
                string am2 = am.ToLower().Substring(am.Length -1,1); //Selecciona la última letra del apellido materno
                foreach(byte b in am2) //Determina el valor ASCII de la letra anterior
                {
                    Console.WriteLine("Contraseña con ASCII: "+nombre2.ToUpper()+b+ap2.ToLower()+ap3.ToUpper()); //Muestra en pantalla la contraseña con el código ASCII
                   
                }
                return "Contraseña sin ASCII: "+nombre2.ToUpper() + am2 + ap2.ToLower() + ap3.ToUpper(); //Devuelve la contraseña sin ASCII para comprobar la conversión.
            }

            static void concatena(string nombre, string ap, string am, object salida1) //Método 3
            {
                string am2 = am.Substring(0, 1); //Obtiene la primera letra del apellido materno
                string ap2 = ap.Substring(0, 1); //Obtiene la primera letra del apellido paterno


                Console.WriteLine($"Nombre: {nombre} {ap} {am}");//Concatena nombre y apellido
                Console.WriteLine($"Correo: {nombre.ToLower()}.{am2.ToLower()}{ap2.ToLower()}@correo.com");//Calcula nuevamente el correo        
                contrasena(nombre, ap, am);//Obtiene el resultado de la contraseña con ASCII
            }

        }
    }
}
