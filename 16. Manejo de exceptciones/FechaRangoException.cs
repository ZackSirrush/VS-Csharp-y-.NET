using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

class FechaRangoException:Exception //Hereda de clase Exception
    {
     public FechaRangoException() : base()
     {
        Console.WriteLine("El programa no puede ser ejecutado, se cerrará a continuación.\n\n"); //Mensaje
        Environment.Exit(0); //Cierre de aplicación
    } 
    public FechaRangoException(string mensaje) : base(mensaje)
    {

    }

    public FechaRangoException(string mensaje, Exception anidada) : base(mensaje, anidada)
    {

    }

}
