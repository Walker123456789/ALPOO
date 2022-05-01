using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Ingresante : Alumno
    {
        private string horario;
        private int edad;
        private string metodoIngreso;

        public string Horario { get => horario; set => horario = value; }
        public int Edad { get => edad; set => edad = value; }
        public string MetodoIngreso { get => metodoIngreso; set => metodoIngreso = value; }

        public string Aprobar()
        {
            throw new System.NotImplementedException();
        }

        public string Atender()
        {
            throw new System.NotImplementedException();
        }
    }
}