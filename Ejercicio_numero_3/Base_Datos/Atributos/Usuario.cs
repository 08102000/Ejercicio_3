using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Datos.Atributos
{
   public class Usuario
    {
        public string CodigoU { get; set; }
        public string Nombre { get; set; }
        public string  Identidad { get; set; }
        public string  RolUsuario { get; set; }
        public string Genero { get; set; }
        public string Contraseña { get; set; }
        public int Edad { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigoU, string nombre, string identidad, string rolUsuario, string genero, string contraseña, int edad)
        {
            CodigoU = codigoU;
            Nombre = nombre;
            Identidad = identidad;
            RolUsuario = rolUsuario;
            Genero = genero;
            Contraseña = contraseña;
            Edad = edad;
        }
    }
}
