using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Persona
    {
        //Atributos
        private string codigo;
        private string apellidos;
        private string nombres;
        private DateTime fechaNac;
        private string lugarNac;
        private string domicilio;
        private string correo;

        //Propiedades
        public string Codigo { get => codigo; set => codigo = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string LugarNac { get => lugarNac; set => lugarNac = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Correo { get => correo; set => correo = value; }

        //Métodos
        public string Existir()
        {
            return "El método Existir no ha sido implementado aún";
        }
        public string Asistir()
        {
            return "El método Asistir no ha sido implementado aún";
        }
    }
}
