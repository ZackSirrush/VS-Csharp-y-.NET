using System;

namespace DPRN1_U1_EA_ANNT
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre, eciv; //Declaración de variables y tipo de datos
            Char sexo, disc;
            int edad;
            double sueldo, banual, mbanual, msueldo, hextra;
            DateTime fnac, fing, hentrada, hsalida, faument, hmax;

            banual = 0; //Inicialización de variables

            //Mensaje de bienvenida
            Console.WriteLine("Sistema de registro de empleados. Bienvenido");
            Console.WriteLine("\n\n\nRegistro de empleados: ");
            Console.WriteLine("Ingrese la información solicitada: "); //Ingreso de datos
            Console.WriteLine("Nombre del empleado: ");
            nombre = Console.ReadLine(); //Almacena el dato ingresado en la variable indicada esta línea es String
            Console.WriteLine("Edad: ");
            edad = int.Parse(Console.ReadLine()); //Almacena dato tipo int
            Console.WriteLine("Sexo (M o F): ");
            sexo = char.Parse(Console.ReadLine()); //Almacena dato tipo char
            Console.WriteLine("Fecha de nacimiento (dd/mm/aaaa): ");
            fnac = DateTime.Parse(Console.ReadLine()); //Almacena dato tipo fecha y hora
            Console.WriteLine("Fecha de ingreso (dd/mm/aaaa): ");
            fing = DateTime.Parse(Console.ReadLine()); //Almacena dato tipo fecha y hora
            Console.WriteLine("Sueldo mensual: ");
            sueldo = double.Parse(Console.ReadLine()); //Almacena dato tipo double
            Console.WriteLine("Hora de entrada (24:00:00 hrs): "); 
            hentrada = DateTime.Parse(Console.ReadLine()); //Almacena dato tipo fecha y hora
            Console.WriteLine("Hora de salida (24:00:00 hrs): ");
            hsalida = DateTime.Parse(Console.ReadLine()); //Almacena dato tipo fecha y hora
            Console.WriteLine("Estado civil: ");
            eciv = Console.ReadLine(); //Almacena dato tipo String
            Console.WriteLine("¿Posee alguna discapacidad? (S/N): ");
            disc = char.Parse(Console.ReadLine()); //Almacena dato tipo caracter

            //Condicional if que evalua el sueldo ingresado
            if (sueldo > 20000) { //si es mayor a 20 mil
                banual = 0.08; //la bonificación será del 8%
            } else {
                if (sueldo > 5000 && sueldo <= 20000) { //si se encuentra en el rango de 5mil a 20 mil
                    banual = 0.05;  //la bonificación será del 5%
                } else {
                    if (sueldo > 1000 && sueldo <= 5000) {
                        banual = 0.03;
                    } else {
                        if (sueldo <= 1000) {
                            banual = 0;
                        }
                    } //Se tomó como referencia la tabla de la planeación para esta condicional.
                }
            }

            mbanual = sueldo * banual; //Calcula el monto de la bonificación anual, multiplica el sueldo por la bonificación
            faument = fing.AddMonths(3); //Incrementa tres meses a la fecha de ingreso, para definir cuando se pagará el aumento

            msueldo = sueldo * 1.02; //Calcula el incremento del 2% al sueldo

            hmax = hsalida.AddHours(3); //Incrementa 3 horas a la hora de salida
            //Define la hora de salida máxima con horas extra

            TimeSpan trabajo = hsalida.Subtract(hentrada); //Selecciona la hora de salida y determina las horas de diferencia
            var htrabajo = trabajo.TotalHours; //Almacena la diferencia de horas trabajadas

            hextra = ((sueldo / 30) / (htrabajo)) * 1.01; //Determina el pago de horas extra, para ello se divide el sueldo/30 días por mes,
            //el resultado se divide nuevamente entre el número de horas trabajadas, posteriormente se multiplica y aumenta el 1% por cada hora extra trabajada


            Console.WriteLine("\n\n\n\nLa información del empleado obtenida es: "); //Muestra los resultados en consola
            Console.WriteLine("Nombre del empleado: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Fecha de nacimiento: " + fnac.ToShortDateString()); //acorta la fecha y hora, mostrando solo la fecha
            Console.WriteLine("Fecha de ingreso a la empresa: "+fing.ToShortDateString());
            Console.WriteLine("Sueldo: $" + sueldo);
            Console.WriteLine("Hora de entrada: " + hentrada.ToShortTimeString());//acorta la fecha y hora, mostrando solo las horas
            Console.WriteLine("Hora de salida: " + hsalida.ToShortTimeString());
            Console.WriteLine("Estado civil: " + eciv);
            Console.WriteLine("¿Posee alguna discapacidad? (S/N): " + disc);
            Console.WriteLine("Bonificación anual: " + banual);
            Console.WriteLine("Monto de bonificación anual: $"+mbanual);
            Console.WriteLine("Su aumento de sueldo se verá reflejado en el día: "+faument.ToShortDateString());
            Console.WriteLine("Monto del sueldo luego del periodo de prueba: $"+msueldo);
            Console.WriteLine("Usted trabaja un total de: " + (htrabajo) + " hrs");
            Console.WriteLine("Su horario máximo de salida con horas extra es: "+hmax.ToShortTimeString());
            Console.WriteLine("Usted obtendrá un monto de $"+ hextra + " por cada hora trabajada");
            Console.WriteLine("Usted podrá ganar un máximo de $"+ (hextra*3) + " por trabajar 3 horas extras al día");//multiplica la ganancia por hora, por las tres horas extras diarias

        }
    }
}
