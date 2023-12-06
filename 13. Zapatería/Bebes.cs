using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN2_U2_A1_ANNT
{
    class Bebes : Calzados//Clase dama hereda de calzados
    {
        private double comision;//Atributos de la clase
        private int cantidad;

        public Bebes() : base()//Instancia la clase padre en el constructor
        {
            comision = 0.05;//Establece la comisión por el tipo de calzado
            Calzado();//Invoca la clase padre para realizar el registro de atributos

            if (talla >= 10 & talla <= 14)//Compara si la talla es mayor o igual a 10 y menor o igual a 14
            {
                Console.WriteLine("\nTalla disponible\n");
                Console.WriteLine("Ingrese la cantidad a comprar: "); //Permite ingresar la cantidad a adquirir
                cantidad = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("\n\nTalla no disponible, venta cancelada\n\n");
                precio = 0;
                cantidad = 0;
            }
        }

        public void Tipocalzado()//Muestra la información de la venta
        {
            Informacion();
            Console.WriteLine("La cantidad a comprar son: " + cantidad);
            Console.WriteLine("Comisión por tipo de calzado: " + comision); ;
        }

        public void ventas()//Realiza el cálculo de las ventas
        {
            double venta = precio * cantidad;
            double comVta = venta * comision;

            Console.WriteLine("Tipo de calzado: " + tipo);
            Console.WriteLine("Costo: $" + venta.ToString("N2"));
            Console.WriteLine("La comisión para el vendedor será de: $" + comVta.ToString("N2"));

        }


    }
}
