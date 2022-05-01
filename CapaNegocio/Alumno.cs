using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno : Persona
    {
        private bool seguro;
        private string escuela;
        private string metodoEstu;

        public bool Seguro { get => seguro; set => seguro = value; }
        public string Escuela { get => escuela; set => escuela = value; }
        public string MetodoEstu { get => metodoEstu; set => metodoEstu = value; }

        public string Estudiar()
        {
            return "El método implementar no ha sido implementado aún";
        }
    }
}
