using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN2_U2_EA_ANNT
{
    class Astrazeneca:Vacuna //Clase hija, hereda de vacuna
    {

        public Astrazeneca(string nombre, string origen, int efectividad, double costo, int dosis,int aplicacion) : base(nombre, origen, efectividad, costo, dosis, aplicacion)
        {
            nombre = "Astrazeneca";
            origen = "Británico-Sueco"; //Datos de la vacuna
            efectividad = 70;
            costo = 2.8;
            dosis = 2;
            aplicacion = 90;
        }
        public override void Informacion() //Imprime la información general
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Origen: " + origen);
            Console.WriteLine("Efectividad: " + efectividad + "%");
            Console.WriteLine("Costo: " + costo + " USD");
            Console.WriteLine("Número de dósis: "+dosis);
            Console.WriteLine("Segunda aplicación en " + aplicacion + " días naturales");
        }

        public override void Inyectar()//Método proceso de vacunación
        {
            Console.WriteLine("En este momento, la vacuna está entrando a su organismo.");
            Console.WriteLine("La sustancia activa de la vacuna ingresa a través de una molécula de ADN."); //Simula el proceso de la vacuna en el organismo
            Console.WriteLine("El ADN ingresa a sus células.");
            Console.WriteLine("El ADN se copia en el núcleo de su ARN.");
            Console.WriteLine("El ARN migra al citoplasma.");
            Console.WriteLine("A partir de su citoplasma se comienzan a producir las proteínas virales.");
            Console.WriteLine("Vacuna concluída.");
            Console.WriteLine("\nSu próxima aplicación será en " + aplicacion + " días naturales.");//Determina fecha de próxima aplicación
            DateTime f1 = DateTime.Now;
            Console.WriteLine("Fecha de aplicación: " + f1.ToShortDateString()); //Imprime la fecha actual
            DateTime f2 = f1.AddDays(aplicacion);//Añade los 90 días a la siguiente aplicación
            Console.WriteLine("Fecha de próxima aplicación: " + f2.ToShortDateString()); //Imprime la fecha siguiente
        }

        public override void EfectosSecundarios()//Menú de efectos secundarios
        {
            string e1, e2, e3, e4, e5, e6, e7; //Sobreescritura del método, con sus propios efectos secundarios
            e1 = "1. Dolor o molestia y palpitación en la zona de la inyección";
            e2 = "2. Dolor de cabeza";
            e3 = "3. Cansancio";
            e4 = "4. Dolor muscular o artícular";
            e5 = "5. Fiebre";
            e6 = "6. Escalofríos";
            e7 = "7. Náuseas";
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(e4);
            Console.WriteLine(e5);
            Console.WriteLine(e6);
            Console.WriteLine(e7);
        }
        public override void Efectividad()//Determina la efectividad de la vacuna
        {
            Random r = new Random();
            int ran = r.Next(0, 101); //Genera número aleatorio y lo almacena en la variable ran
            Console.WriteLine("\n\nLa efectividad de la vacuna es de " + efectividad + "%");
            Console.WriteLine("La efectividad real obtenida fue de " + ran + "%");
            if (ran <= efectividad) //Define si ran es menor que efectividad
            {
                Console.WriteLine("\nPosibles efectos secundarios de la vacuna: "); //Indica 2 efectos secundarios aleatorios.
                Random r2 = new Random();
                int ran2 = r2.Next(1, 8); //efectos secundarios aleatorios
                int ran3 = r2.Next(1, 8);
                Console.WriteLine("Efecto secundario: " + ran2);
                Console.WriteLine("Efecto secundario: " + ran3);

            }
            else
            {
                Console.WriteLine("De cualquier forma se contagiará de COVID");//Imprime mensaje si ran > efectividad
            }

        }
    }
}
