using System;

namespace DPRN1_U1_A3_ANNT
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato1, dato2, dato3; //Declaración de variables
            double x1, x2, x3, media, varianza, desv;
            dato1 = "";
            dato2 = ""; //Inicialización de variables
            dato3 ="";
            x1 = 0.0000;
            x2 = 0.0000;
            x3 = 0.0000;
            media = 0.0000;
            varianza = 0.0000;
            desv = 0.0000;
            
            Console.WriteLine("Calculadora para media, varianza y desviación estándar. \nBienvenido");
            Console.WriteLine("Autor: Angel Isaac Nabor Torres"); //Datos de inicio
            Console.WriteLine("Matrícula: ES1921013978");
            Console.WriteLine("Actividad 3. Resolver problemas con C#");
            Console.WriteLine("Fecha y hora: "+DateTime.Now); //Permite seleccionar la fecha y hora actual (del sistema)

            Console.WriteLine("\n\n\nIngrese los valores a calcular: "); //Se solicita ingresar los datos a calcular
            Console.WriteLine("Ingrese X1: ");
            dato1 = Console.ReadLine(); //Recibe un dato y lo almacena como string
            x1 = Convert.ToDouble(dato1); //Convierte el string en double y lo almacena en la variable
            Console.WriteLine("Ingrese X2: "); //Realiza el mismo procedimiento en cada variable ingresada
            dato2 = Console.ReadLine();
            x2 = Convert.ToDouble(dato2);
            Console.WriteLine("Ingrese X3: ");
            dato3 = Console.ReadLine();
            x3 = Convert.ToDouble(dato3);

            //Operaciones a realizar con las variables convertidas
            media = (x1 + x2 + x3) / 3;
            varianza = (Math.Pow((x1 - media),2) + Math.Pow((x2 - media),2) + Math.Pow((x3 - media),2)) / 3; //Se utiliza la función para la raíz cuadrada
            //formato debe ser: "Math.Pow(número,potencia)"
            desv = Math.Sqrt(varianza);//Se utiliza la función para calcular la raíz cuadrada

            Console.WriteLine("\n\n\nSe han obtenido los resultados: ");
            Console.WriteLine("Media: "+media); //Imprime los resultados en pantalla
            Console.WriteLine("Varianza: "+varianza);
            Console.WriteLine("Desviación estándar: "+desv);
        }
    }
}
