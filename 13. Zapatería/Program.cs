namespace DPRN2_U2_A1_ANNT
{
    class Program
    {
            static void Main(string[] args) //Main
        {
            int clasif, cont, vendedor;
            

            do
            {
                Console.WriteLine("\n¿Quién realiza la venta?: "); //Selección de vendedor
                Console.WriteLine("1. Juan");
                Console.WriteLine("2. Pedro");
                Console.WriteLine("3. Karina");
                Console.WriteLine("4. Vanessa");
                Console.WriteLine("5. Olga");
                vendedor = int.Parse(Console.ReadLine());

                Console.WriteLine("\nIngrese la clasificación de calzado a vender: "); //Menú de opciones de calzado
                Console.WriteLine("1. Dama"); 
                Console.WriteLine("2. Caballero"); 
                Console.WriteLine("3. Niños"); 
                Console.WriteLine("4. Bebés");
                clasif=int.Parse(Console.ReadLine());

                switch (clasif) //Switch case
                {
                    case 1: //Caso 1, zapato de dama
                        Dama dm = new Dama(); //Invoca la clase Dama
                        Console.WriteLine("\n\nResumen de compra: \n");
                        dm.Tipocalzado(); //Invoca el método tipo de calzado de la clase dama
                        Console.WriteLine("");
                        Console.WriteLine("Vendedor: " + vendedor);
                        dm.ventas(); //Invoca método ventas de la clase Dama
                        break;
                    case 2:
                        Caballero cb=new Caballero(); //Caso 2, zapato de caballero invoca la clase caballero
                        Console.WriteLine("\n\nResumen de compra: \n");
                        cb.Tipocalzado();
                        Console.WriteLine(""); //Repite el procedimiento de la clase dama
                        Console.WriteLine("Vendedor: " + vendedor);
                        cb.ventas();
                        break;
                    case 3:
                        Ninos nn = new Ninos();
                        Console.WriteLine("\n\nResumen de compra: \n");
                        nn.Tipocalzado();
                        Console.WriteLine("");
                        Console.WriteLine("Vendedor: " + vendedor); //Procedimiento similar de las clases anteriores
                        nn.ventas();
                        break;
                    case 4:
                        Bebes bb=new Bebes();
                        Console.WriteLine("\n\nResumen de compra: \n"); //Mismo procedimiento diferente comisión
                        bb.Tipocalzado();
                        Console.WriteLine("");
                        Console.WriteLine("Vendedor: " + vendedor);
                        bb.ventas();
                        break;
                    default:
                        Console.WriteLine("Opción no válida"); //Cualquier otra opción es no válida
                        break;
                }


                Console.WriteLine("\n\n¿Desea registrar otra venta?"); //Repite el menú luego de concluir la acción anterior
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");
                cont =int.Parse(Console.ReadLine());
                Console.Clear(); //Limpia la pantalla antes de una nueva ejecución
            } while (cont==1);

            Console.ReadLine(); //Detiene el cierre del programa hasta presionar una tecla
        }
    }
}
