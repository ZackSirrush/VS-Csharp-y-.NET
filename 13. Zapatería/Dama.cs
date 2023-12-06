using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN2_U2_A1_ANNT
{
    class Dama:Calzados //Clase dama hereda de calzados
    {
        private double comision; //Atributos de la clase
        private int cantidad;

        public Dama() : base() //Instancia la clase padre en el constructor
        {
            comision = 0.10; //Establece la comisión por el tipo de calzado
            Calzado(); //Invoca la clase padre para realizar el registro de atributos
            
            if (talla>=22&talla<=26) //Compara si la talla es mayor o igual a 22 y menor o igual a 26
            {
                Console.WriteLine("\nTalla disponible\n"); //Indica que es una talla válida
                Console.WriteLine("Ingrese la cantidad a comprar: ");
                cantidad = int.Parse(Console.ReadLine()); //Permite ingresar la cantidad
            }
            else
            {
                Console.WriteLine("\n\nTalla no disponible, venta cancelada\n\n"); //Talla no válida
                precio = 0; //Cancela la compra y establece los valores en 0
                cantidad = 0;
            }
        }

        public void Tipocalzado() //Muestra la información de la venta
        {
            Informacion(); //Invoca el método de la clase padre
            Console.WriteLine("La cantidad a comprar son: "+cantidad);
            Console.WriteLine("Comisión por tipo de calzado: " + comision);
        }

        public void ventas() //Realiza el cálculo de las ventas
        {
            double venta = precio*cantidad; //Toma atributos guardados en la clase padre
            double comVta = venta * comision;

            Console.WriteLine("Tipo de calzado: " + tipo);
            Console.WriteLine("Costo: $" + venta.ToString("N2")); //Muestra el tipo de calzado, el costo t la comisión
            Console.WriteLine("La comisión para el vendedor será de: $" + comVta.ToString("N2")); //Limitando los decimales a 2

        }


    }
}
