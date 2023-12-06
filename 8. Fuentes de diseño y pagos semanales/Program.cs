using System;

namespace DPRN1_U3_A3_ANNT
{
    class Program
    {
        static void Main(string[] args)
        {
            int repetir, opc,alto,ancho,semanas; //Declaración de variables
            char car;
            double monto;
            
            do { //Ciclo do-while que repite hasta que usuario desea salir del sistema

                Console.WriteLine("*******************Bienvenido*******************\n");//Mensaje de bienvenida y menú de
                Console.WriteLine("Programa para uso de diseñador y pagos semanales\n");//Opciones

                Console.WriteLine("Por favor, seleccione una opción del menú: ");
                Console.WriteLine("1. Fuentes para diseñador gráfico");
                Console.WriteLine("2. Pagos semanales de clientes");
                
                opc = int.Parse(Console.ReadLine());//Inicializa variable opc para el switch case

                switch (opc) { //Inicio switch case del menú
                    case 1: //Caso 1 Problema de diseñador
                        Console.WriteLine("**************Opción 1. Fuentes para diseñador gráfico**************\n");
                        Console.WriteLine("Por favor, ingrese el ancho de la fuente (mayor a 3): ");
                        ancho = int.Parse(Console.ReadLine()); //Inicializa variables
                        Console.WriteLine("Por favor, ingrese lo alto de la fuente (mayor a 3): ");
                        alto = int.Parse(Console.ReadLine()); //Pide a usuario ingresar valores
                        Console.WriteLine("Por favor, ingrese el carácter que compondrá la fuente: ");
                        car = char.Parse(Console.ReadLine()); //Ingresa caracter
                        Console.WriteLine("\n\n\n"); //Salto de línea
                        diseno(ancho, alto, car); //Inicia método diseno
                        break;//Fin caso 1
                    case 2: //Caso 2 problema pagos semanales
                        Console.WriteLine("**************Opción 2. Pagos semanales de clientes**************\n");
                        Console.WriteLine("Por favor, ingrese el monto del producto adquirido: ");
                        monto = int.Parse(Console.ReadLine()); //Ingresa variables deseadas
                        Console.WriteLine("¿A cuántas semanas desea pagar el producto?");
                        semanas = int.Parse(Console.ReadLine());
                        Console.WriteLine($"\n\nEl cliente pagará {monto} en {semanas} semanas."); //Muestra mensaje 
                        credito(monto, semanas); //Invoca método credito
                        break;//Fin de caso2
                }
                Console.WriteLine("\n\n\n¿Desea realizar otra operación?");
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No"); //Pregunta a usuario si desea continuar
                repetir = int.Parse(Console.ReadLine());
                Console.Clear(); //Limpia pantalla para una nueva iteración
            } while (repetir == 1); //Repite el programa hasta que usuario presiona un número diferente a 1
        }

        static void diseno(int ancho,int alto, char car) { //Método diseno
            //Solicita parámetros como es ancho, alto y caracter
            if (ancho >= 3){ //Si ancho y alto es mayor a 3 permite realizar el diseño
                if(alto >= 3){                    
                    for(int i = 1; i <= alto; i++) { //Ciclo for para las filas del diseño
                        for(int j = 1; j <= ancho; j++) { //ciclo for para las columnas del diseño
                            if ((i == 1) || (i == alto)) { //Sí i es igual 1 y a alto
                                Console.Write(car); //Escribe en pantalla el caracter seleccionado
                            } else {//segun sus iteraciones; si no, dibujará la columna
                                if ((j == 1) || (j == ancho)) {
                                    Console.Write(car);
                                } else {
                                    Console.Write(" "); //Separa con espacio entre columnas
                                }
                            }
                        }
                        Console.WriteLine();
                    }
                } else {
                    Console.WriteLine("Solicitud no válida"); //Si alto o ancho es menor a 3
                }
            } else { 
                Console.WriteLine("Solicitud no válida"); //No permite realizar el diseño
            }
        }

        static void credito(double monto, int semanas) //Método crédito
        {
            double incremento,monto2,monto3,z; //declaración de variables locales
            int x;
            incremento = 0;//Inicializa variables locales
            z = 0.0;
            x = 1;

            for (int i= 1;i<= semanas; i += 4) {//Mientras i sea menor que las semanas, agrega 4 semanas
                z = 0.02 + z;//En cada iteración z suma 0.02
                incremento = z; //Transfiere el valor de z a incremento                
            }

            Console.WriteLine("El incremento sobre el monto será de: " + incremento); //Escribe el valor del incremento
            //decimal, multiplicado por 100 será porcentual

            while (x <= semanas) { //mientras x sea menor o igual que las semanas
                monto2 = monto + (monto * incremento); //multiplica el monto por el incremento y lo suma al monto
                monto3 = monto2 / semanas; //divide el resultado entre las semanas
                Console.WriteLine($"Pago semana {x}: {monto3}"); //Itera según el número de semanas insertadas
                x = x + 1; //mientras x sea menor que semanas, agrega 1
            }

            Console.WriteLine($"\n\nPrecio original: {monto}"); //Muestra el precio del producto
            Console.WriteLine($"Incremento por crédito: {(monto*incremento)}");//Muestra el incremento por realizar
            Console.WriteLine($"Total a pagar: {(monto+(monto*incremento))}");//Determina el total a pagar
        }
    }
}
