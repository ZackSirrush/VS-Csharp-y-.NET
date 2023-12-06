using System;

public class DPRN2_U3_A2_ANNT
{
    public static void Main()
    {

        int fnac;
        var lista = new List<string>();
        List<string> variantesCovid = new List<string>();
        variantesCovid.InsertRange(0, new String[] { "Alfa", "Beta", "Gama", "Delta", "Omicron", "Psi" });

        int[] enteros4 = { 3, 6, 9, 12, 15, 18, 21 };

        int[] enteros5 = new int[6]; //Se debería corregir el número de elementos del arreglo, de 6 a 7
                                     //Al hacer esto, la excepción "System.ArgumentOutOfRangeException: Index was out of range"
                                     //dejaría de mostrarse

        int[] valores = null;   //Se deben declarar los elementos que contendrá el arreglo,
                                //para evitar la excepción "System.NullReferenceException"

        int[] dividendos = { 20, 7, 0 };



        try //FechaRangoException
        {
            Console.WriteLine("Bienvenido, por favor ingrese su año de nacimiento (aaaa): ");//Usuario ingresa un año de nacimiento
            fnac = int.Parse(Console.ReadLine());
            if (fnac >= 1996 || fnac <=1979)
            {
                Console.WriteLine("El programa continuará\n\n");
            }
            else if(fnac >= 1980 || fnac <= 1995) //Si se teclea una fecha entre 1980 y 1995 el programa se cierra
            {
                throw new FechaRangoException();
            }
        }
        catch(FechaRangoException fre) //Exception oersonalizada
        {
            Console.WriteLine(fre.Message);
        }

        try//ArgumentOutOfRangeException
        {

            Console.WriteLine("Número de elementos de lista: {0}", lista.Count);
            //if (lista.Count > 0) <- El código que corrige el error 
            Console.WriteLine("El primer elemento de la lista es: '{0}'", lista[0]);
            //else
            //Console.WriteLine("No hay elementos en la lista\n\n"); <- El código que corrige el error      
        }
        catch (ArgumentOutOfRangeException aore) //
        {
            Console.WriteLine("\nError, no hay elementos en la lista. \n" + aore.Message + "\n");
        }


        try //ArgumentOutOfRangeException
        {
            for (int control = 0; control <= variantesCovid.Count; control++) //Se debe eliminar el "=" para evitar que cuente de más
                Console.WriteLine("Variante: '{0}'    ", variantesCovid[control]); //Enlista variantes hasta llegar a la última
            Console.WriteLine("\n");//Salto de línea para dividir las excepciones
        }
        catch (ArgumentOutOfRangeException aore2) //El for cuenta más elementos de lo que hay en el arreglo.
        {
            Console.WriteLine("\nError, se están contando más elementos de los que son.\n" + aore2.Message + "\n");
        }


        try //IndexOutOfRangeException
        {
            enteros5[enteros4.Length - 1] = enteros4[enteros4.Length - 1];
        }
        catch (IndexOutOfRangeException iore) //El error se corrige cambiando el número de elementos del arreglo a 7
        {
            Console.WriteLine("\nError, arreglo mal declarado.\n" + iore.Message);
        }

        try //NullReferenceException
        {
            for (int i = 0; i < 9; i++) //Indica que el arreglo "valores" debe tener al menos de 9 valores
                valores[i] = i * 2;
            foreach (var value in valores)
                Console.WriteLine(value);
        }
        catch (NullReferenceException nre) //El error es corregible, añadiendo elementos al arreglo
        {
            Console.WriteLine("\nError, el arreglo contiene elementos de tipo null.\n" + nre.Message);
        }

        Console.WriteLine("\n");//Salto de línea

        
        foreach (var value in dividendos)
        {           
            Console.WriteLine("{0} dividido entre 2 es {1}", value, DivideEntreDos(value));
        }


        try //DivideByZeroException
        {
            Console.WriteLine("\nDivisión: 1/0"); //Muestra el mensaje de la división
            Console.WriteLine(Divide(1, 0));
        }
        catch (DivideByZeroException dbz) //Arroja excepción por dividir entre cero
        {
            Console.WriteLine("Error, no se puede dividir entre cero. \n", dbz.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
    
    
    static int DivideEntreDos(int num) //Método para dividir entre cero
    {
        long sobrante = num % 2; //Determina los decimales sobrantes para identificar si es par o non
        try
        {
            if (sobrante == 0) //Si el decimal es 0, el número es par
                return num / 2; //Devuelve la división del número entre 2
            else if (sobrante != 0) //si el número tiene decimales
                throw new ArgumentOutOfRangeException(); //Arroja una excepción de argumento no valido
                return 0; //Devuelve un valor de cero
        }
        catch (ArgumentOutOfRangeException aor) 
        {
            Console.WriteLine("El número {0} no es par, por lo tanto no se puede dividir.",num);//Muestra mensaje de error
            return 0;
        }
    }

    static double Divide(int dividendo, int divisor)
    {
        
        return dividendo / divisor;
    }
}



