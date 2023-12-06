//Universidad Abierta y a Distancia de México
//Programación NET I
//Unidad 2. Métodos
//Actividad 2. Programa que utiliza métodos que no devuelven parámetros
//Angel Isaac Nabor Torres
//ES1921013978
//Grupo. DS-DPRN1-2102-B1-002
//Docente. Jacobo Diaz Martínez

using System;

namespace DPRN_U2_A2_ANNT
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3; //Variables a utilizar

            Console.WriteLine("Bienvenido");
            Console.WriteLine("Porfavor ingrese 3 números: ");
            Console.WriteLine("Número 1: "); //Usuario ingresa los 3 números que desea permutar y sumar
            n1 = int.Parse(Console.ReadLine()); //Inicializa variable con valor insertado por usuario
            Console.WriteLine("Número 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Número 3: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n\nLas permutaciones que se pueden obtener son: "); //Muestra la primera salida
            combinaciones(n1, n2, n3);//invoca la primera salida desde el método combinaciones
            sumaacumulativa(n1, n2, n3); //Invoca la segunda salida desde el método de suma acumulativa
        }

        static void combinaciones(int n1, int n2, int n3) //Método combinaciones
        {    
            int i, j, k, count; //Declara variables locales para el arreglo de los 3 números
            count = 0; //inicializa variable
            

            int[] num = new int[3];//declaración de arreglo para 3 elementos
            num[0] = n1; //Inserta los valores que insertó el usuario en el arreglo
            num[1] = n2;
            num[2] = n3;

            for (i = 1; i <= 3; i++)//Ciclo for que iterará hasta 3 veces
            {
                for (j = 1; j <= 3; j++)
                {
                    for (k = 1; k <= 3; k++)
                    {
                        if (num[i-1] != num[j-1] && num[i-1] != num[k-1] && num[j-1] != num[k-1]) //Compara que los valores sean diferentes entre sí, de modo que no se repitan.
                        {
                            count = count + 1; //Aumenta uno al contador
                            Console.WriteLine($"Combinación (n{i},n{j},n{k}): "+num[i-1]+" , " + num[j-1]+" , " + num[k-1] + " "); //Escribe en consola la combinación correspondiente
                        }
                    }
                }
            }
        }

        static void sumaacumulativa(int suma1, int suma2, int suma3) //Método suma acumulativa
        {
            suma2 = suma1 + suma2; //suma el valor del primer número con el segundo
            suma3 = suma2 + suma3; //suma el valor del primer numero (que se encuentra almacenado anteriormente) con el tercer número
            Console.WriteLine($"\n\n\nLa suma acumulativa es: {suma1}, {suma2}, {suma3}"); //Muestra el resultado obtenido
        }
    }
}
