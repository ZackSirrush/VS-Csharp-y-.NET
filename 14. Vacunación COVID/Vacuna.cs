using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN2_U2_EA_ANNT
{
    abstract class Vacuna //Clase abstracta/padre vacuna
    {
        protected string nombre,origen;//Atributos encapsulados
        protected int efectividad,dosis,aplicacion;
        protected double costo;

        protected Vacuna(string nombre, string origen, int efectividad, double costo,int dosis,int aplicacion)//Método Constructor
        {
            this.nombre = nombre;
            this.origen = origen;
            this.efectividad = efectividad;
            this.costo = costo;
            this.dosis = dosis;
            this.aplicacion = aplicacion;
        }

        public virtual void Informacion()//Métodos virtuales
        {

        }

        public virtual void Inyectar() //Para sobreescritura
        {

        }
        public virtual void EfectosSecundarios()
        {

        }

        public virtual void Efectividad()
        {

        }
    }
}
