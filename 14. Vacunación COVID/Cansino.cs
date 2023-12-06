using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN2_U2_EA_ANNT
{
    class Cansino: Vacuna //Clase hija, hereda de vacuna
    {
        
        public Cansino(string nombre, string origen, int efectividad, double costo,int dosis, int aplicacion) : base(nombre, origen, efectividad, costo, dosis, aplicacion)
        {
            nombre = "Cansino";//Datos generales de la vacuna
            origen = "Chino";
            efectividad = 56;
            costo = 4.0;
            dosis = 1;
            aplicacion = 0;
        }

        public override void Informacion()//Imprime información general
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Origen: " + origen);
            Console.WriteLine("Efectividad: " + efectividad + "%");
            Console.WriteLine("Costo: " + costo + " USD");
            Console.WriteLine("Número de dósis: " + dosis);
            Console.WriteLine("Aplicación: Única");
        }

        public override void Inyectar()//Simula el proceso de inyección
        {
            Console.WriteLine("En este momento, la vacuna está entrando a su organismo.");
            Console.WriteLine("La sustancia utiliza un virus inofensivo no relacionado.");
            Console.WriteLine("La vacuna utiliza material genético.");
            Console.WriteLine("Se comienza la producción de proteína reconocida por su sistema inmune.");
            Console.WriteLine("Su sistema inmune activa el uso de la proteina");
            Console.WriteLine("Vacuna concluída.");
            Console.WriteLine("\nEsta vacuna es de aplicación única."); //Aplicación única
            DateTime f1 = DateTime.Now;//Fecha actual o de aplicación
            Console.WriteLine("Fecha de aplicación: " + f1.ToShortDateString());
            Console.WriteLine("Fecha de próxima aplicación: No aplica"); //No calcula fecha próxima aplicación
        }

        public override void EfectosSecundarios() //Menú de efectos secundarios
        {
            string e1, e2, e3, e4, e5, e6, e7,e8,e9,e10,e11,e12;
            e1 = "1. Fatiga";
            e2 = "2. Fiebre";
            e3 = "3. Dolor de cabeza";
            e4 = "4. Dolor muscular o artícular";
            e5 = "5. Pérdida de apetito";
            e6 = "6. Dolor orofaríngeo";
            e7 = "7. Diarrea";
            e8 = "8. Náusea";
            e9 = "9. Comezón";
            e10 = "10. Tos";
            e11 = "11. Vómito";
            e12 = "12. Enrojesimiento";//Efectos investigados de la vacuna
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(e4);
            Console.WriteLine(e5);
            Console.WriteLine(e6);
            Console.WriteLine(e7);
            Console.WriteLine(e8);
            Console.WriteLine(e9);
            Console.WriteLine(e10);
            Console.WriteLine(e11);
            Console.WriteLine(e12);
        }
        public override void Efectividad()//Calcula efectividad de la vacuna
        {
            Random r = new Random();
            int ran = r.Next(0, 101);
            Console.WriteLine("\n\nLa efectividad de la vacuna es de " + efectividad + "%"); //Números aleatorios vs efectividad
            Console.WriteLine("La efectividad real obtenida fue de " + ran + "%");
            if (ran <= efectividad)
            {
                Console.WriteLine("\nPosibles efectos secundarios de la vacuna: ");//Sí ran<efectividad, determina 2 efectos secundarios aleatorios
                Random r2 = new Random();
                int ran2 = r2.Next(1, 13);
                int ran3 = r2.Next(1, 13);
                Console.WriteLine("Efecto secundario: " + ran2);
                Console.WriteLine("Efecto secundario: " + ran3);

            }
            else
            {
                Console.WriteLine("De cualquier forma se contagiará de COVID");//De lo contrario, imprime mensaje
            }

        }
    }
}
