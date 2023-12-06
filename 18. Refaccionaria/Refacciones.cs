using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN2_U3_A4_ANNT
{
    class Refacciones
    {
        private string nombre, marca; //Atributos privados

        Dictionary<string, string> refac = new Dictionary<string, string>(); //Declaración del diccionario

        public string Nombre //Getters de la clase
        {
            get { return nombre; }
        }
        public string Marca
        {
            get { return marca; }
        }

        public void AgregarRefaccion() //Método para agregar refacciones al diccionario
        {
            try //Control de errores al insertar elementos
            {
                Console.WriteLine("Ingresa el nombre de la refacción");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la marca de la refacción");
                marca = Console.ReadLine();

                refac.Add(nombre, marca); //Almacena los valores como parte del diccionario
            }
            catch (ArgumentException) //Excepción de tipo argumental
            {
                Console.WriteLine("Ya existe un elemento con este nombre\n"); //Mensaje al cometer error
            }
        }

        public void MostrarRefacciones() //Método para mostrar las refacciones del diccionario 
        {
            Console.WriteLine("*****Listado de refacciones registradas*****");
            Console.WriteLine("Las refacciones registradas son:");
            Console.WriteLine("Nombre, Marca");
            foreach(string llave in refac.Keys) //Imprime las refacciones almacenadas, nombre y marca
            {
                Console.WriteLine(llave+", "+refac[llave]);
            }
            Console.ReadLine(); //Detiene el sistema hasta que el usuario presione una tecla
        }

        public void BuscarRefaccion()//Método para buscar las refacciones en el diccionario
        {
            Console.WriteLine("*****Buscar refacción*****");
            Console.WriteLine("Ingrese el nombre de la refacción que desea buscar: ");
            string buscar = Console.ReadLine(); //Ingresa el valor buscado

            if (refac.ContainsKey(buscar)) //Compara si existe el valor en el diccionario
            {
                Console.WriteLine("La refacción "+buscar+" existe"); //Sí existe, muestra los datos
                Console.WriteLine("Su información es: ");
                Console.WriteLine("Nombre: " + buscar);
                Console.WriteLine("Marca: " + refac[buscar]);
            }
            else
            {
                Console.WriteLine("Refacción no registrada, no existe en el catálogo"); //Si no, indica su inexistencia
            }
            Console.ReadLine();//Detiene el sistema hasta que el usuario presione una tecla

        }

        public void OrdenarRefacciones() //Método para ordenar las refacciones del diccionario
        {
            var ordenar = refac.Keys.ToList(); //Recupera las llaves del diccionario
            ordenar.Sort();//Ordena las llaves
            Console.WriteLine("*****Refacciones ordenadas por nombre*****");
            Console.WriteLine("Nombre, Marca");
            foreach (string llave in ordenar) //Imp´rime las llaves ordenadas
            {
                Console.WriteLine(llave + ", " + refac[llave]);
            }
            Console.ReadLine();//Detiene el sistema hasta que el usuario presione una tecla
        }
    }
}
