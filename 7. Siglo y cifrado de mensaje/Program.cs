using System;

namespace DPRN1_U3_A2_ANNT
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc,num,repetir; //Declaración de variables
            string cad;

            do { //Ciclo do-while
                Console.WriteLine("Bienvenido, por favor seleccione una opción del menú: "); //Mensaje de bienvenida
                Console.WriteLine("1. Obtener siglo al que pertenece un año");
                Console.WriteLine("2. Codificar un mensaje"); //Menu de opciones
                opc = int.Parse(Console.ReadLine()); //Inicializa variable de opciones
                switch (opc) //Switch case para los "calculos" posibles
                {
                    case 1: //Caso 1
                        Console.WriteLine("**********Opción 1. Obtener siglo al que pertenece un año**********");
                        Console.WriteLine("Ingrese un número mayor o igual a 1001 y menor a 2021");
                        num = int.Parse(Console.ReadLine()); //Ingresa un número de 4 cifras
                        obtsig(num); //Invocación de método
                        break; //Fin del caso 1
                    case 2: //Caso 2
                        Console.WriteLine("**********Opción 2. Encriptar un mensaje**********");
                        Console.WriteLine("Ingrese el mensaje que desea cifrar: ");
                        cad = Console.ReadLine(); //Usuario ingresa mensaje por cifrar
                        codmsj(cad); //Invoca método para cifrar
                        break;//Fin del caso 2
                }

                Console.WriteLine("¿Desea realizar otra operación?");
                Console.WriteLine("1. Sí"); //Realizar más operaciones
                Console.WriteLine("2. No");
                repetir = int.Parse(Console.ReadLine());
                Console.Clear(); //Limpia la consola
            } while (repetir == 1);    //Repite el ciclo mientras usuario seleccione 1
        }

        static void obtsig(int num) //Metodo año a siglo
        {

            if(num>=1001 && num <= 1100) {
                Console.WriteLine($"El año {num} corresponde al siglo 11");
            } else {
                if (num >= 1101 && num <= 1200) {
                    Console.WriteLine("El año " + num + " corresponde al siglo 12"); //Estructuras if else
                } else {
                    if (num >= 1201 && num <= 1300) {
                        Console.WriteLine("El año " + num + " corresponde al siglo 13");//Determina el año ingresado y con
                    } else {
                        if (num >= 1301 && num <= 1400) { //Base en este selecciona el siglo que le corresponde
                            Console.WriteLine("El año " + num + " corresponde al siglo 14");
                        } else {
                            if (num >= 1401 && num <= 1500) { //Y muestra el mensaje en pantalla
                                Console.WriteLine("El año " + num + " corresponde al siglo 15");
                            } else {
                                if (num >= 1501 && num <= 1600) {
                                    Console.WriteLine("El año " + num + " corresponde al siglo 16");
                                } else {
                                    if (num >= 1601 && num <= 1700) {
                                        Console.WriteLine("El año " + num + " corresponde al siglo 17");
                                    } else {
                                        if (num >= 1701 && num <= 1800) {
                                            Console.WriteLine("El año " + num + " corresponde al siglo 18");
                                        } else {
                                            if (num >= 1801 && num <= 1900) {
                                                Console.WriteLine("El año " + num + " corresponde al siglo 19");
                                            } else {
                                                if (num >= 1901 && num <= 2000) {
                                                    Console.WriteLine("El año " + num + " corresponde al siglo 20");
                                                } else {
                                                    if (num >= 2001 && num <= 2100) {
                                                        Console.WriteLine("El año " + num + " corresponde al siglo 21");
                                                    } else {
                                                        Console.WriteLine("El número ingresado es menor a 1000 o mayor a 2021");
                                                    } //Si se ingresa un número no válido, indica que no es posible dar resultado
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        static void codmsj(string cad) //Método cifrar mensaje
        {

            string cad2,cad3,cad4,cad5,cad6; //Declara cadenas
            cad2 = cad.ToLower().Replace("a", "4"); //Selecciona el valor de la cadena y la convierte en minúsculas
            cad3 = cad2.ToLower().Replace("e", "3"); //Luego remplaza las letras a en la cadena y coloca 4
            cad4 = cad3.ToLower().Replace("i", "1"); //Retoma el resultado de la cadena anterior
            cad5 = cad4.ToLower().Replace("o", "0"); //Y cambia la letra por el número indicado
            cad6 = cad5.ToLower().Replace("s", "5");

            Console.WriteLine(cad6); //Devuelve en consola el resultado de la última cadena

        }
    }
}
