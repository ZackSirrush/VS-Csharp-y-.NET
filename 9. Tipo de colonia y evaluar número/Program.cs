using System;

namespace DPRN1_U3_EA_ANNT {
    class Program {
        static void Main(string[] args) {
            int salir,opc,n,m; //Declaración de variables
            double num;
            do { //ciclo do while
                Console.WriteLine("************************Bienvenido************************\n");//Mensaje de bienvenida y menú de
                Console.WriteLine("Programa para clasificación de colonias y evaluar números\n");//Opciones

                Console.WriteLine("Por favor, seleccione una opción del menú: ");
                Console.WriteLine("1. Clasificación de colonias para subsidio de impuestos");
                Console.WriteLine("2. Evaluar número positivo");

                opc = int.Parse(Console.ReadLine());//Inicializa variable opc para el switch case

                switch (opc) { //Inicio del switch case
                    case 1: //Caso 1
                        Console.WriteLine("*******Opción 1. Clasificación de colonias para subsidio de impuestos*******\n");
                        Console.WriteLine("Por favor, escribe las filas que tiene la colonia: ");
                        n = int.Parse(Console.ReadLine()); //Pide los valores para las filas y columnas del arreglo
                        Console.WriteLine("Por favor, escribe las columnas que tiene la colonia: ");                  
                        m = int.Parse(Console.ReadLine());
                        Console.WriteLine("Recuerde que los tipos de inmuebles son A,B,C,T y W\n");
                        clasif(n, m);                 //Llamado al método clasif      
                        break;

                    case 2://caso 2
                        Console.WriteLine("**************Opción 2. Evaluar número positivo**************\n");
                        Console.WriteLine("Por favor, ingrese un número mayor o igual a 1: "); //Varible de tipo num para realizar la evaluación.
                        num = double.Parse(Console.ReadLine());
                        evalua(num);
                        break;
                }
                Console.WriteLine("\n\n\n¿Desea realizar otra operación?");
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No"); //Pregunta a usuario si desea continuar
                salir = int.Parse(Console.ReadLine());
                Console.Clear(); //Limpia pantalla para una nueva iteración
            } while (salir == 1); //Repite el ciclo while hasta que usuario desee salir
        }

        static void clasif(int n, int m) { //Método clasif
            int acum1=0, acum2=0, acum3=0, acum4=0, acum5=0,i,j;
            string rel; //Declaración de variables
            string[,] col = new string[n, m]; //Declaración del arreglo

            for (i = 0; i < n; i++) { //Ciclo for para escribir en el arreglo
                for (j = 0; j < m; j++) {
                    Console.WriteLine($"Indique el tipo de inmueble en la ubicación ({i},{j}): "); //Ingresa el dato A,B,C,T o W
                    rel = Console.ReadLine();
                    col[i, j] = rel; //Llena el arreglo en la ubicación indicada hasta llegar a n y m
                    if(rel=="a" || rel=="A") { //acumuladores, si el usuario ingresa A,B,C,T o W
                        acum1 = acum1 + 1;
                    } else {
                        if (rel=="b"||rel=="B") { //Acumula los valores en variables distintas.
                            acum2 = acum2 + 1;
                        } else {
                            if (rel == "c" || rel == "C") {
                                acum3 = acum3 + 1;
                            } else {
                                if (rel == "t" || rel == "T") {
                                    acum4 = acum4 + 1;
                                } else {
                                    if (rel == "w" || rel == "W") {
                                        acum5 = acum5 + 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (i = 0; i < n; i++) { //Ciclo for para imprimir el arreglo
                for (j = 0; j < m; j++) {
                    Console.Write(col[i, j]);
                }
                Console.WriteLine();
            }

            if(acum1>=1 && acum2>=1 && acum5 >= 1) {
                Console.WriteLine("#Colonia_popular"); //Compara, si el acumulador de A y B y W tienen algún valor, pondrá colonia popular
            } else {
                if(acum1>=1 && acum4 >= 1) {
                    Console.WriteLine("#Colonia_en_desarrollo"); //Acumulador de A y T 
                } else { 
                    if(acum2>=1 && acum3>=1 && acum5 >= 1) { //Acumulador de A, C y W
                        Console.WriteLine("#Colonia_residencial");
                    } else {
                        if (acum1 >= 1) {
                            Console.WriteLine("#Colonia_popular"); //Acumulador de A
                        } else {
                            if (acum2 >= 1) { //Acumulador de B
                                Console.WriteLine("#Colonia_popular"); 
                            } else {
                                if (acum5 >= 1) { //Acumulador de W
                                    Console.WriteLine("#Colonia_industrial");
                                }
                            }
                        }
                    }
                }
            }

        }

        static void evalua(double num) { //metodo evaluacion
            int acum = 1; //declaracion de variable acumuladora
            while (num > 1) { //ciclo mientras num sea mayor que 1 se repite
                if (num % 2 == 0) { //Si el residuo de la variable num dividida entre 2
                    Console.WriteLine($"Paso {acum}: {num} es par, entonces n={num}/2"); //muestra iteracion 1 por que es par
                    num = num / 2; //divide la variable num entre 2
                } else { //si no es par, entonces es non
                    Console.WriteLine($"Paso {acum}: {num} es impar, entonces n={num}*3+1");
                    num = num*3+1; //multiplicará la variable num por 3 mas 1
                }
                acum = acum + 1; //agrega uno al acumulador 
            }
        }
    }
}
