using DPRN2_U3_A4_ANNT;
public class DPRN_U3_A4_ANNT
{
    public static void Main(string [] args) //Main
    {
        int repetir=1; //Declaración de variables
        int menu,n;
        string tmp;
        bool esnumero;

        Refacciones rf = new Refacciones(); //Invoca la clase refacciones

        do //Mientras repetir sea igual a 1, el ciclo se repite
        {

            Console.Clear(); //Limpia la pantalla al iniciar cada iteración           
            do //Previene que un usuario malintencionado ingrese un caractér
            {
                Console.WriteLine("*****Refaccionaria automotríz*****"); //Menú para el registro de participantes
                Console.WriteLine("¿Qué desea realizar?");
                Console.WriteLine("1. Registrar refacciones");
                Console.WriteLine("2. Listar refacciones");
                Console.WriteLine("3. Buscar una refacción específica");
                Console.WriteLine("4. Ordenar refacciones por nombre");
                Console.WriteLine("5. Terminar programa");
                tmp = Console.ReadLine();
                esnumero = int.TryParse(tmp,out int valor);//Compara si el valor almacenado en tmp es numero
                Console.Clear(); //Limpia la pantalla
            } while (!esnumero); //Mientras el valor no sea número, repite el menú
            
            menu = Convert.ToInt16(tmp);//Convierte el número almacenado en tmp a int 

            switch (menu) //Switch case para el menú
            {
                case 1: //Caso 1, registro de refacciones
                    Console.WriteLine("*****Registro de refacciones*****");                  
                    do //Previene que el usuario ingrese letras
                    {
                        Console.WriteLine("¿Cuántas refacciones desea registrar?");
                        tmp = Console.ReadLine();
                        esnumero = int.TryParse(tmp, out int valor); //Compara si el valor ingresado es número
                    } while (!esnumero); //Mientras el valor no sea número, el procedimiento se repite
                    n = Convert.ToInt16(tmp); //Convierte la variable en int
                    
                    for (int i = 0; i < n; i++) //Repite el método según la cantidad de registros a ingresar
                    {
                        rf.AgregarRefaccion(); //Método de la clase refacciones
                    }
                    break;                
                case 2: //Caso 2, Muestra refacciones registradas
                    rf.MostrarRefacciones(); //Método de la clase refacciones
                    break;
                case 3://Caso 3, Busca la refacción
                    rf.BuscarRefaccion(); //Método de la clase refacciones
                    break;
                case 4: //Caso 4, Ordena las refacciones por nombre
                    rf.OrdenarRefacciones();//Método de la clase refacciones
                    break;
                case 5://Caso 5, Termina el programa
                    Console.WriteLine("Finalizando programa");
                    repetir = 2; //Establece el valor de repetir en 2
                    break;
                default: //Opción no válida
                    Console.WriteLine("Error, opción inválida");
                    Console.ReadLine();
                    break;
            }

        } while (repetir == 1); //Mientras repetir sea igual a 1, el programa se repite
    }    
}