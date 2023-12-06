using System;

namespace DPRN2_U3_A1_ANNT_EjemploExceptions
{
    class program
    {
        static void Main(string[] args)
        {
            int n1, n2, r; ;
            System.Console.WriteLine("Dividir dos números");
            try
            {
                
                Console.WriteLine("Digite el primer número: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el segundo número: ");
                n2 = int.Parse(Console.ReadLine());
                r = n1/n2;
                Console.WriteLine("El resultado de: " + n1 + "/" + n2 + " es " + r);
            }
            catch (FormatException sfe) //CONTROLA EXCEPCIONES POR TIPO DE DATO INCORRECTO
            {
                Console.WriteLine("Ingrese un valor entero. \n"+sfe.Message);
            }
            catch (DivideByZeroException exdpc) //CONTROLA EXCEPCIONES POR DIVISIÓN ENTRE CERO
            {
                Console.WriteLine("No se puede dividir entre cero. \n" + exdpc.Message);
            }
            finally
            {
                Console.ReadKey(true); //Evita el cierre abrupto del sistema
            }
            

        }
    }
}


