using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Competidor : Registro //Clase hija hereda de clase abstracta
{
        private int exper; //Variable de clase hija

        public int Exper
        {
            get { return exper; } //Getter
        }

        public Competidor(string nombre, int edad, string ciudad, string club,int exper) : base(nombre, edad, ciudad, club)
        {
            this.exper = exper; //Constructor con parámetros de clase hija
        }

        
}
