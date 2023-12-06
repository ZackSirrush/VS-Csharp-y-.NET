using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DPRN2_U1_A1_ANNT
{
    class Program
    {
        static void Main (string[] args) //Método main 
        {
            int accion,cont;

            
            Medicamento med1 = new Medicamento(); //Instanciación de objetos y clases
            RecetaMedica receta = new RecetaMedica();

            do
            {
                Console.WriteLine("\n¿Qué acción desea realizar?"); //Menú de opciones a realizar
                Console.WriteLine("1. Añadir medicamento.");
                Console.WriteLine("2. Aplicar Medicamento");
                Console.WriteLine("3. Generar receta médica.");
                accion = int.Parse(Console.ReadLine()); //Lee el dato ingresado por el usuario para el switch
                
                switch (accion) //Swich case
                {
                    case 1: //Caso 1, ingresa datos del medicamento
                        med1.AgregarMedicamento(); //Añade medicamentos manualmente
                        break;
                    case 2://Caso 2, aplica medicamento
                        Console.WriteLine("¿Su medicamento es una inyección compuesta?: ");
                        Console.WriteLine("1. Sí");
                        Console.WriteLine("2. No");
                        int icomp = int.Parse(Console.ReadLine()); //En caso de que el medicamento sea una inyección doble
                        if (icomp == 1) //Cuando el usuario presiona 1
                        {
                            Console.WriteLine("Se aplicarán dos dósis del medicamento "+med1.Nombre); //Se indica el medicamento a aplicar
                            med1.AplicarMedicamento("intramuscular"); // Sobrecarga del método aplicar medicamento con el parámetro indicado
                        }
                        else
                        {
                            med1.AplicarMedicamento(); //Sí el usuario indica que no es inyección compuesta, se aplica la sobrecarga 2
                        } 
                        break;
                    case 3: //Caso 3, genera receta médica
                        receta.DatosReceta(); //Invoca y ejecuta los métodos de la clase Receta Médica
                        receta.ObtenerMontoReceta();
                        break;
                    default:    
                        Console.WriteLine("Opción no válida"); //Cualquier otra opción es no válida
                        break;
                }

                Console.WriteLine("\n\n¿Desea realizar otra acción?"); //Repite el menú luego de concluir la acción anterior
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");
                cont = int.Parse(Console.ReadLine());//recibe la respuesta del usuario

            } while (cont==1);//el bucle se repite mientras cont sea igual a 1
        }
    }
}