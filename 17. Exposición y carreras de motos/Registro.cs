using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class Registro //Clase padre abstracta
{
    private string nombre,ciudad,club; //Atributos protegidos
    private int edad;

    public string Nombre //Getters
    {
        get { return nombre; }
    }
    
    public int Edad
    {
        get { return edad; }
    }

    public string Ciudad
    {
        get { return ciudad; }
    }

    public string Club
    {
        get { return club; }
    }

    public Registro (string nombre, int edad, string ciudad, string club) //Constructor
    {
        this.nombre = nombre;
        this.edad = edad;
        this.ciudad = ciudad;
        this.club = club;
    }
}