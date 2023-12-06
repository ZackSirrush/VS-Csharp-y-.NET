namespace DPRN2_U2_EA_ANNT
{
    class Program
    {
        static void Main(string[] args)//Main
        {
            int ran,salir,terminos,vac; //Variables para las estructuras de control
            string selec;

            do //Ciclo do-while
            {
                Console.WriteLine("Vacunación COVID"); //Mensaje de bienvenida
                Console.WriteLine("Por favor seleccione una opción del menú: "); //Menú de opciones
                Console.WriteLine("a. Mi vacuna e inyectar");
                Console.WriteLine("b. Efectos secundarios");
                selec=Console.ReadLine(); //Recibe respuesta del usuario
                switch (selec) //Swich case
                {
                    case "a" or "A": //Caso A o a
                        Random r=new Random(); //Inicia con el cálculo aleatorio de entre 1 a 3
                        ran=r.Next(1,4); //almacena el valor determinado
                        Console.WriteLine("El número de vacuna que le toca es: "+ran); //Indica el número de vacuna
                        switch (ran)//Swich case según el valor aleatorio
                        {
                            case 1://Caso 1
                                Pfizer v1 = new Pfizer("Pfizer-Biontech", "Estadounidense-Alemán", 95, 19.0,2,21); //Inicializa objeto pfizer
                                Console.WriteLine("\nInformación general de su vacuna"); //Muestra la información de la vacuna
                                v1.Informacion();//Invoca el método polimórfico
                                Console.WriteLine("\nEfectos secundarios de la vacuna"); //Muestra el menú de efectos secundarios
                                v1.EfectosSecundarios();
                                Console.WriteLine("\n¿Acepta la aplicación de la vacuna, así como los términos y condiciones?"); //Solicita aceptar la aplicación
                                Console.WriteLine("1. Sí");
                                Console.WriteLine("2. No");
                                terminos=int.Parse(Console.ReadLine());//recibe la respuesta del usuario
                                if (terminos == 1) //Sí usuario acepta
                                {
                                    Console.WriteLine("\nSe procederá con la aplicación de su vacuna"); //Continúa proceso de vacunación
                                    v1.Inyectar(); //Método polimórfico inyectar
                                }
                                else //Si no
                                {
                                    Console.WriteLine("\nTérminos y condiciones rechazados.");//Se concluye la vacuna, regresa al menú principal
                                    Console.WriteLine("Vacuna no aplicada.");
                                }
                                break;
                            case 2:
                                Astrazeneca v2 = new Astrazeneca("Astrazeneca", "Británico-Sueco", 70, 2.8,2,90); //Inicializa objeto Astrazeneca
                                Console.WriteLine("\nInformación general de su vacuna");
                                v2.Informacion(); //Invoca método para la información de la vacuna
                                Console.WriteLine("\nEfectos secundarios de la vacuna");
                                v2.EfectosSecundarios(); //Muestra efectos secundarios
                                Console.WriteLine("\n¿Acepta la aplicación de la vacuna, así como los términos y condiciones?");
                                Console.WriteLine("1. Sí");
                                Console.WriteLine("2. No");
                                terminos = int.Parse(Console.ReadLine());//Solicita aceptación de aplicación
                                if (terminos == 1)
                                {
                                    Console.WriteLine("\nSe procederá con la aplicación de su vacuna");
                                    v2.Inyectar(); //Invoca método inyectar
                                }
                                else
                                {
                                    Console.WriteLine("\nTérminos y condiciones rechazados.");//Vacunación rechazada
                                    Console.WriteLine("Vacuna no aplicada.");
                                }
                                break;
                            case 3:
                                Cansino v3 = new Cansino("Cansino", "Chino", 56, 4.0,1,0);//Objeto Cansino
                                Console.WriteLine("\nInformación general de su vacuna");
                                v3.Informacion();//Información de vacuna
                                Console.WriteLine("\nEfectos secundarios de la vacuna");
                                v3.EfectosSecundarios();//Menú de efectos secundarios
                                Console.WriteLine("\n¿Acepta la aplicación de la vacuna, así como los términos y condiciones?");
                                Console.WriteLine("1. Sí");
                                Console.WriteLine("2. No");
                                terminos = int.Parse(Console.ReadLine()); //Aplicación de vacuna
                                if (terminos == 1)
                                {
                                    Console.WriteLine("\nSe procederá con la aplicación de su vacuna"); //Sí acepta, se aplica
                                    v3.Inyectar();
                                }
                                else
                                {
                                    Console.WriteLine("\nTérminos y condiciones rechazados."); //De lo contrario se cancela el proceso
                                    Console.WriteLine("Vacuna no aplicada.");
                                }
                                break;
                        }
                        break;
                    case "b" or "B"://Caso B o b, caso de uso 2 efectos secundarios
                        Console.WriteLine("¿Qué vacuna desea comparar?"); //Selecciona la vacuna que se aplicó el paciente
                        Console.WriteLine("1. Pfizer Biontech");
                        Console.WriteLine("2. Astrazeneca");
                        Console.WriteLine("3. Cansino");
                        vac = int.Parse(Console.ReadLine());//Lee valor ingresado por usuario
                        switch (vac)
                        {
                            case 1://Pfizer
                                Pfizer v1 = new Pfizer("Pfizer-Biontech", "Estadounidense-Alemán", 95, 19.0, 2, 21); //Objeto pfizer
                                Console.WriteLine("\nMenú de efectos secundarios: ");
                                v1.EfectosSecundarios();//Muestra efectos secundarios
                                v1.Efectividad();//Determina efectividad de vacuna
                                break;
                            case 2:
                                Astrazeneca v2 = new Astrazeneca("Astrazeneca", "Británico-Sueco", 70, 2.8, 2, 90); //Objeto Astrazeneca
                                Console.WriteLine("\nMenú de efectos secundarios: ");
                                v2.EfectosSecundarios();
                                v2.Efectividad();//Determina efectividad
                                break;
                            case 3:
                                Cansino v3 = new Cansino("Cansino", "Chino", 56, 4.0, 1, 0);//Objeto cansino
                                Console.WriteLine("\nMenú de efectos secundarios: ");
                                v3.EfectosSecundarios();
                                v3.Efectividad();//Determina efectividad
                                break;
                            default:
                                Console.WriteLine("Vacuna inexistente");//Vacuna no existente
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida");//Dato erróneo
                        break;
                }

                Console.WriteLine("\n\n¿Desea realizar otra acción?"); //Repite el menú luego de concluir la acción anterior
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");               
                salir = int.Parse(Console.ReadLine());
                Console.Clear(); //Limpia la pantalla antes de una nueva ejecución
            } while (salir < 2); //Repite el proceso siempre que salir no sea mayor a 2
            Console.ReadLine(); //Detiene el cierre del programa hasta presionar una tecla
        }
    }
}
