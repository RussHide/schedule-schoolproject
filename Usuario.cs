using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaVisual
{
    class Usuario
    {
        private string nombre;
        private string user;
        private string password;

        public string Nombre { get => nombre; set => nombre = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
    }
}
