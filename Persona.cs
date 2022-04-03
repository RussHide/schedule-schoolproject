using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaVisual
{
    class Persona
    {
        private string nombre;
        private string apePaterno;
        private string apeMaterno;
        private int edad;
        private string sexo;
        private List<Telefono> lstTelefonos;
        private Direccion direccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string ApePaterno { get => apePaterno; set => apePaterno = value; }
        public string ApeMaterno { get => apeMaterno; set => apeMaterno = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        internal List<Telefono> LstTelefonos { get => lstTelefonos; set => lstTelefonos = value; }
        internal Direccion Direccion { get => direccion; set => direccion = value; }
    }
}
