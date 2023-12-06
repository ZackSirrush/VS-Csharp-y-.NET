using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN2_U2_A1_ANNT
{
    abstract class Calzados //Clase abstracta
    {
        protected string color, tipo; //Atributos protegidos
        protected double precio;
        public int talla;

        public void Calzado() //No devuelve valores
        {
            Console.WriteLine("Ingrese un tipo de calzado (Sandalia, Bota, Mocasín o Tenis): "); //Solicita el ingreso de los valores
            tipo = Console.ReadLine();
            Console.WriteLine("Ingrese un color: "); //No los ingresa en la propia clase, si no en las heredadas
            color = Console.ReadLine();
            Console.WriteLine("Ingrese el precio unitario: ");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la talla: ");
            talla = int.Parse(Console.ReadLine());
        }

        public void Informacion() //Muestra la información de los atributos guardados
        {
            Console.WriteLine("Tipo de calzado: " + tipo);
            Console.WriteLine("Color: "+color);
            Console.WriteLine("Precio unitario: " + precio);
            Console.WriteLine("Talla: " + talla);
        }

    }
}
