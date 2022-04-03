using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaVisual
{
    class Direccion
    {
        private string calle;
        private string numCasa;
        private string colonia;
        private int codigoPostal;
        private string ciudad;
        private string estado;

        public string Calle { get => calle; set => calle = value; }
        public string NumCasa { get => numCasa; set => numCasa = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public int CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
