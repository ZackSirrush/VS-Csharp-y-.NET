using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN2_U2_A1_ANNT
{
    class Caballero : Calzados //Hereda de clase padre
    {
        private double comision; //Atributos de la clase
        private int cantidad;

        public Caballero() : base() //Invoca clase padre
        { 
            comision = 0.13; //Indica comisión
            Calzado(); //Método para registro de atributos

            if (talla >= 25 & talla <= 30) //Comparativo if para talla de 25 a 30
            {
                Console.WriteLine("\nTalla disponible\n");
                Console.WriteLine("Ingrese la cantidad a comprar: "); //Permite el ingreso de la cantidad a adquirir
                cantidad = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("\n\nTalla no disponible, venta cancelada\n\n"); //Termina el proceso y cancela venta
                precio = 0;
                cantidad = 0;
            }
        }

        public void Tipocalzado() //Información del calzado
        {
            Informacion();
            Console.WriteLine("La cantidad a comprar son: " + cantidad);
            Console.WriteLine("Comisión por tipo de calzado: "+comision);
            
        }

        public void ventas() //Cálculo de venta y comisión
        {
            double venta = precio * cantidad;
            double comVta = venta * comision;

            Console.WriteLine("Tipo de calzado: " + tipo);
            Console.WriteLine("Costo: $" + venta.ToString("N2"));
            Console.WriteLine("La comisión para el vendedor será de: $" + comVta.ToString("N2"));

        }
    }
}
