using System;
public class DPRN2_U3_A3_ANNT
{
    public static void Main()
    {
        int registro = 1; //Declaración de variables
        int n,n2,m;
        double subtotal, total, costexpo, costcomp, costomoto, iva;
        double impuesto = .16;
        double expositor = 1350.00;
        double competidor = 1850.00; //Precios fijos del evento
        double stand = 800.00;
        double moto = 500.00;
        bool esnumero;

        do //Ciclo do while
        {
            Console.Clear(); //Limpia la pantalla al iniciar cada iteración

            Console.WriteLine("Registro de participantes para Enduro"); //Menú para el registro de participantes
            Console.WriteLine("Por favor, seleccione su tipo de registro:");
            Console.WriteLine("1. Expositor");
            Console.WriteLine("2. Competidor");
            Console.WriteLine("3. Ambas");
            int participante = int.Parse(Console.ReadLine()); //Lee tipo de participante

            switch (participante) //Switch case de participantes para el arreglo
            {
                case 1://Caso 1 registro de expositor
                    
                    Console.WriteLine("\n\nEXPOSITOR, registro:"); //Participante expositor
                    Console.WriteLine("¿Cuántos miembros hay en su equipo?");
                    Console.WriteLine("Se pueden registrar hasta 4 integrantes");
                    Console.WriteLine("Para esta categoría.");
                    n = Convert.ToInt32(Console.ReadLine()); //Lee integrantes y añade al arreglo

                    Expositor[] expo = new Expositor[n]; //Declaración de arreglo que se almacena en la clase Expositor
                    
                    string tmp; //Variable temporal

                    for(int i = 0; i < n; i++) //Repite estructura hasta ingresar todos los miembros del equipo ingresados
                    {
                        
                        Console.WriteLine("Integrante "+(i+1)+" "); //Recibe valores que almacenar en el arreglo
                        Console.WriteLine("Nombre: ");
                        string nombre = Console.ReadLine();
                        do //Mientras tmp no sea un número, repite la pregunta
                        {
                            Console.WriteLine("Edad: ");
                            tmp = Console.ReadLine();
                            esnumero = int.TryParse(tmp, out int valor);
                        } while (!esnumero); //si es un número, temina el proceso

                        int edad = Convert.ToInt16(tmp);//almacena el dato en variable
                        Console.WriteLine("Ciudad y Estado: ");
                        string ciudad = Console.ReadLine();
                        Console.WriteLine("Nombre del club: ");
                        string club = Console.ReadLine();
                        expo[i] = new Expositor(nombre, edad, ciudad,club);//Almacena datos como parte del arreglo
                    }

                    Console.WriteLine("\n\nRegistro de inscripción:\n"); //Imprime datos del arreglo
                    Console.WriteLine("No.\tNombre completo del participante\tEdad\tCiudad y Estado\tClub");

                    for(int i=0; i<n; i++) //Repite proceso hasta imprimir todos los datos
                    {
                        Console.WriteLine(i+1+"\t"+expo[i].Nombre+"\t"+ expo[i].Edad+
                            "\t"+ expo[i].Ciudad+"\t"+ expo[i].Club);
                        Console.WriteLine();
                    }
                    //Cálculo de totales
                    costexpo = n*expositor; //Determina cantidad de miembros del equipo por el costo
                    subtotal = costexpo + stand;//Suma costo del equipo+stand
                    iva = subtotal * impuesto;//Determina el IVA
                    total = subtotal + iva;//TOTAL

                    Console.WriteLine("\nMonto a pagar"); //Imprime totales
                    Console.WriteLine("Costo por miembros del equipo: $"+costexpo);
                    Console.WriteLine("Stand: $"+stand);
                    Console.WriteLine("Subtotal: $"+subtotal);
                    Console.WriteLine("IVA: $"+iva);
                    Console.WriteLine("Total: $"+total+"\n\n");

                    break; //Fin caso 1
                case 2://Caso 2 registro de Competidor
                    Console.WriteLine("\n\nCOMPETIDOR, registro:");
                    Console.WriteLine("¿Cuántos miembros hay en su equipo?");
                    Console.WriteLine("Se pueden registrar hasta 3 integrantes");
                    Console.WriteLine("Para esta categoría.");
                    n = Convert.ToInt32(Console.ReadLine()); //Lee integrantes y añade el número al arreglo

                    Competidor[] cmp = new Competidor[n]; //Declaración del arreglo

                    string tmp2; //variable temporal

                    for (int i = 0; i < n; i++) //Repite hasta repetir los datos de los integrantes ingresados
                    {

                        Console.WriteLine("Integrante " + (i + 1) + " ");
                        Console.WriteLine("Nombre: ");
                        string nombre = Console.ReadLine();
                        do //Mientras tmp2 no sea número, repite la pregunta
                        {
                            Console.WriteLine("Edad: ");
                            tmp2 = Console.ReadLine();
                            esnumero = int.TryParse(tmp2, out int valor);                          
                        } while (!esnumero); //Si es número sale del bucle
                        int edad = Convert.ToInt16(tmp2); //almacena el número en variable
                        Console.WriteLine("Ciudad y Estado: ");
                        string ciudad = Console.ReadLine();
                        Console.WriteLine("Nombre del club: ");
                        string club = Console.ReadLine();
                        do //Mientras no sea número repite la pregunta
                        {
                            Console.WriteLine("Años de experiencia: ");
                            tmp2 = Console.ReadLine();
                            esnumero = int.TryParse(tmp2, out int valor);
                        } while (!esnumero);                       
                        int exper = Convert.ToInt16(tmp2); //almacena el número en variable
                        cmp[i] = new Competidor(nombre, edad, ciudad, club,exper);
                    }

                    Console.WriteLine("¿Cuántas motos desea registrar para la competencia?");
                    m = int.Parse(Console.ReadLine()); //Determina motos del equipo a competir

                    Console.WriteLine("\n\nRegistro de inscripción:\n");
                    Console.WriteLine("No.\tNombre completo del participante\tEdad\tCiudad y Estado\tClub"+
                        "\tExperiencia");

                    for (int i = 0; i < n; i++) //Imprime el arreglo en forma de tabla
                    {
                        Console.WriteLine(i + 1 + "\t" + cmp[i].Nombre + "\t" + cmp[i].Edad +
                            "\t" + cmp[i].Ciudad + "\t" + cmp[i].Club + "\t" + cmp[i].Exper);
                        Console.WriteLine();
                    }
                    //Cálculo de cotsos
                    costomoto = m * moto; //Multiplica las motos registradas por el costo
                    costcomp = n * competidor;//determina el costo equipo
                    subtotal = costcomp + costomoto; //suma costo del equipo + costo de motos
                    iva = subtotal * impuesto; //impuestos
                    total = subtotal + iva;

                    Console.WriteLine("\nMonto a pagar"); //Imprime resumen de compra
                    Console.WriteLine("Costo por miembros del equipo: $" + costcomp);
                    Console.WriteLine("Motos registradas: $" + costomoto);
                    Console.WriteLine("Subtotal: $" + subtotal);
                    Console.WriteLine("IVA: $" + iva);
                    Console.WriteLine("Total: $" + total + "\n");

                    break;
                case 3://Caso 3 registro de ambas categorías
                    Console.WriteLine("\n\nAMBAS CATEGORÍAS, registro:");
                    Console.WriteLine("¿Cuántos miembros habrá en su equipo competidor?");
                    Console.WriteLine("Se pueden registrar hasta 3 integrantes");
                    Console.WriteLine("Para esta categoría.");
                    n = Convert.ToInt32(Console.ReadLine()); //Recibe cantidad de competidores
                    
                    Competidor[] cmp2 = new Competidor[n]; //Declaración del arreglo para competidores

                    string tmp3;

                    for (int i = 0; i < n; i++) //Registro de competidores en arreglo
                    {

                        Console.WriteLine("Integrante " + (i + 1) + " ");
                        Console.WriteLine("Nombre: ");
                        string nombre = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Edad: ");
                            tmp3 = Console.ReadLine();
                            esnumero = int.TryParse(tmp3, out int valor);
                        } while (!esnumero);                     
                        int edad = Convert.ToInt16(tmp3);
                        Console.WriteLine("Ciudad y Estado: ");
                        string ciudad = Console.ReadLine();
                        Console.WriteLine("Nombre del club: ");
                        string club = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Años de experiencia: ");
                            tmp3 = Console.ReadLine();
                            esnumero = int.TryParse(tmp3, out int valor);
                        } while (!esnumero);
                        
                        int exper = Convert.ToInt16(tmp3);
                        cmp2[i] = new Competidor(nombre, edad, ciudad, club, exper);//almacena datos en arreglo
                    }
               
                    Console.WriteLine("¿Cuántos miembros habrá en su equipo expositor?");
                    Console.WriteLine("Se pueden registrar hasta 4 integrantes");
                    Console.WriteLine("Para esta categoría.");
                    n2 = Convert.ToInt32(Console.ReadLine()); //Registro de expositores

                    Expositor[] expo2 = new Expositor[n2]; //Declaración de arreglo que se almacena en la clase Expositor

                    string tmp4;

                    for (int j = 0; j < n2; j++) //repite hasta registrar todos los expositores en arreglo
                    {

                        Console.WriteLine("Integrante " + (j + 1) + " ");
                        Console.WriteLine("Nombre: ");
                        string nombre = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Edad: ");
                            tmp4 = Console.ReadLine();
                            esnumero = int.TryParse(tmp4, out int valor);
                        } while(!esnumero);
                        int edad = Convert.ToInt16(tmp4);
                        Console.WriteLine("Ciudad y Estado: ");
                        string ciudad = Console.ReadLine();
                        Console.WriteLine("Nombre del club: ");
                        string club = Console.ReadLine();
                        expo2[j] = new Expositor(nombre, edad, ciudad, club); //almacena datos en arreglo
                    }

                    Console.WriteLine("¿Cuántas motos desea registrar para la competencia?"); //Motos registradas
                    m = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n\nRegistro de inscripción:\n"); //Imprime datos de inscripción
                    Console.WriteLine("Equipo competidor:\n");
                    Console.WriteLine("No.\tNombre completo del participante\tEdad\tCiudad y Estado\tClub" +
                        "\tExperiencia");

                    for (int i = 0; i < n; i++) //Tabla del equipo competidor
                    {
                        Console.WriteLine(i + 1 + "\t" + cmp2[i].Nombre + "\t" + cmp2[i].Edad +
                            "\t" + cmp2[i].Ciudad + "\t" + cmp2[i].Club + "\t" + cmp2[i].Exper);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Equipo expositor:\n"); //Tabla del equipo expositor
                    Console.WriteLine("No.\tNombre completo del participante\tEdad\tCiudad y Estado\tClub");

                    for (int j = 0; j < n2; j++) //Imprime arreglo
                    {
                        Console.WriteLine(j + 1 + "\t" + expo2[j].Nombre + "\t" + expo2[j].Edad +
                            "\t" + expo2[j].Ciudad + "\t" + expo2[j].Club);
                        Console.WriteLine();
                    }
                    //Determinación de costos
                    costexpo = n2 * expositor;  //Costo equipo expositor
                    costomoto = m * moto; //Costo motos registradas
                    costcomp = n * competidor; //Costo equipo competidor
                    
                    subtotal = costcomp + costomoto+costexpo+stand; //Suma equipo competidor, expositor, motos y stand
                    iva = subtotal * impuesto;
                    total = subtotal + iva;

                    Console.WriteLine("\nMonto a pagar"); //Imprime totales
                    Console.WriteLine("Costo por equipo competidor: $" + costcomp);
                    Console.WriteLine("Motos registradas: $" + costomoto);
                    Console.WriteLine("Costo por equipo expositor: $"+costexpo);
                    Console.WriteLine("Stand: $"+stand);
                    Console.WriteLine("Subtotal: $" + subtotal);
                    Console.WriteLine("IVA: $" + iva);
                    Console.WriteLine("Total: $" + total + "\n");

                    break; //Fin caso 3
                default:
                    Console.WriteLine("Categoría inexistente"); //Cualquier otro número da error
                    break;

            }


            Console.WriteLine("Desea realizar otro registro?"); //Repetición de bucle
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            registro = int.Parse(Console.ReadLine());
        } while (registro == 1); //Mientras registro sea igual a 1, el programa se repite
    }
}
