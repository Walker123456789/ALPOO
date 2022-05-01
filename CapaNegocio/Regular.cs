using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Regular : Alumno
    {
        private int ciclo;
        private int seccion;
        private string sexo;

        public int Ciclo { get => ciclo; set => ciclo = value; }
        public int Seccion { get => seccion; set => seccion = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public string Aprobar()
        {
            throw new System.NotImplementedException();
        }

        public string Convalidar()
        {
            throw new System.NotImplementedException();
        }
    }
}