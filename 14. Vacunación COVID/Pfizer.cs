using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN2_U2_EA_ANNT
{
    class Pfizer : Vacuna //Clase hija
    {

        public Pfizer(string nombre, string origen, int efectividad, double costo, int dosis, int aplicacion) : base(nombre, origen, efectividad, costo,dosis,aplicacion)
        { //Clase hereda de Vacuna
            nombre = "Pfizer"; //Datos de la vacuna
            origen = "Estadounidense-Alemán";
            efectividad = 95;
            costo = 19;
            dosis = 2;
            aplicacion = 21;
        }

        public override void Informacion() //Imprime la información general de la vacuna
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Origen: " + origen);
            Console.WriteLine("Efectividad: " + efectividad + "%");
            Console.WriteLine("Costo: " + costo + " USD");
            Console.WriteLine("Número de dósis: "+dosis);
            Console.WriteLine("Segunda aplicación en "+aplicacion+" días naturales");
        }

        public override void Inyectar() //Método inyectar
        {
            Console.WriteLine("En este momento, la vacuna ingresará a su organismo.");//Simulación del proceso de la vacuna
            Console.WriteLine("La sustancia activa de la vacuna se coloca a través de una molécula de ARN.");//Y su reacción en el cuerpo
            Console.WriteLine("El ARN ingresa a las células");
            Console.WriteLine("Las células comenzarán a fabricar proteínas de la espícula del Coronavirus.");
            Console.WriteLine("Vacuna concluída.");
            Console.WriteLine("\nSu próxima aplicación será en " + aplicacion + " días naturales.");//Indica los días para la próxima aplicación
            DateTime f1 = DateTime.Now;//Indica fecha actual
            Console.WriteLine("Fecha de aplicación: "+f1.ToShortDateString());//Imprime fecha actual, quita formato de horas
            DateTime f2 = f1.AddDays(aplicacion);//Agrega los días determinados a la fecha
            Console.WriteLine("Fecha de próxima aplicación: "+f2.ToShortDateString());//Determina fecha de próxima aplicación
        }

        public override void EfectosSecundarios() //Método efectos secundarios
        {
            string e1, e2, e3, e4, e5, e6, e7, e8;//Imprime los efectos secundarios
            e1 = "1. Dolor de cabeza";
            e2 = "2. Dolor artícular";
            e3 = "3. Dolor muscular";//Enlistados
            e4 = "4. Dolor en la zona de la inyección";
            e5 = "5. Cansancio";
            e6 = "6. Escalofríos";
            e7 = "7. Fiebre";
            e8 = "8. Inflamación en la zona de la inyección";
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(e4);
            Console.WriteLine(e5);
            Console.WriteLine(e6);
            Console.WriteLine(e7);
            Console.WriteLine(e8);
        }
        public override void Efectividad() //Calcula la efectividad de la vacuna
        {
            Random r = new Random();//Determina un número aleatorio
            int ran = r.Next(0, 101); //Guarda el número como int
            Console.WriteLine("\n\nLa efectividad de la vacuna es de "+efectividad+"%"); //Efectividad de la vacuna
            Console.WriteLine("La efectividad real obtenida fue de "+ran+"%"); //VS Efectividad lograda por el paciente
            if (ran <= efectividad) //Si la efectividad real es menor que la efectividad de la vacuna
            {
                Console.WriteLine("\nPosibles efectos secundarios de la vacuna: ");//Se determinan 2 efectos aleatorios
                Random r2 = new Random();
                int ran2 = r2.Next(1, 9); //Se debe guiar con el menú impreso
                int ran3 = r2.Next(1, 9);
                Console.WriteLine("Efecto secundario: "+ran2); //Imprime los efectos aleatorios que tendrá el paciente               
                Console.WriteLine("Efecto secundario: "+ran3);

            } else
            {
                Console.WriteLine("De cualquier forma se contagiará de COVID"); //Si la efectividad real es mayor a la efectividad determinada, MUESTRA EL MENSAJE
            }

        }
    }
}
