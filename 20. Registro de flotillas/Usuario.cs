using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DPRN3_U2_A1_ANNT
{
    class Usuario
    {

        Conexion con; //Invoca clase conexión

        public string Curp { get; set; } //Getters y setters de la clase
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public string Sexo { get; set; }
        public string Tipo { get; set; }
        public string Calle { get; set; }
        public int Noext { get; set; } 
        public int Noint { get; set; }
        public int Cp { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }

        public Usuario()
        {
            con = new Conexion(); 
        }

        public bool AgregarUsuario(Usuario nusuario)
        {
            SqlCommand SQLComando2 = new SqlCommand("INSERT INTO Usuario (CURP, Nombre, APaterno, AMaterno, Sexo, Tipo, Calle, NoExterior, NoInterior, CP, Ciudad, Estado)" +
                "VALUES (@CURP, @Nombre, @APaterno, @AMaterno, @Sexo, @Tipo, @Calle, @NoExterior, @NoInterior, @CP, @Ciudad, @Estado);");

            SQLComando2.Parameters.Add("@CURP", SqlDbType.VarChar).Value = nusuario.Curp; //Selecciona los datos almacenados en los getters y setters
            SQLComando2.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nusuario.Nombre;
            SQLComando2.Parameters.Add("@APaterno", SqlDbType.VarChar).Value = nusuario.Apaterno; //Sustituye los datos por los valores guardados
            SQLComando2.Parameters.Add("@AMaterno", SqlDbType.VarChar).Value = nusuario.Amaterno;
            SQLComando2.Parameters.Add("@Sexo", SqlDbType.VarChar).Value = nusuario.Sexo;
            SQLComando2.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = nusuario.Tipo;
            SQLComando2.Parameters.Add("@Calle", SqlDbType.VarChar).Value = nusuario.Calle;
            SQLComando2.Parameters.Add("@NoExterior", SqlDbType.Int).Value = nusuario.Noext;
            SQLComando2.Parameters.Add("@NoInterior", SqlDbType.Int).Value = nusuario.Noint;
            SQLComando2.Parameters.Add("@CP", SqlDbType.BigInt).Value = nusuario.Cp;
            SQLComando2.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = nusuario.Ciudad;
            SQLComando2.Parameters.Add("@Estado", SqlDbType.VarChar).Value = nusuario.Estado;

            return con.EjecutarComando(SQLComando2); //Devuelve la consulta en sql
        }

        public DataSet Mostrar() //Ejecuta la sentencia para mostrar una consulta SQL
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Usuario"); //Consulta por ejecutar
            return con.EjecutarSentencia(sentencia); //Devuelve la consulta

        }

    }
}
