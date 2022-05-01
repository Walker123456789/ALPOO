using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Administrativo : Persona, IMantenimiento
    {
        private string puesto;
        private string ganancia;

        public string Puesto { get => puesto; set => puesto = value; }
        public string Ganancia { get => ganancia; set => ganancia = value; }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public string Buscar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public string Listar()
        {
            throw new NotImplementedException();
        }
    }
}