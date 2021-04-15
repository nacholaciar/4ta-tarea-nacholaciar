using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miapp_2.entidades
{
    public class usuario
    {
        private string NombreUsu;
        private string Pass;
        public usuario(string nombreUsuario, string password)
        {
            //NombreUsu = nombreUsuario;
            this.NombreUsu = nombreUsuario;
            //Pass = password;
            this.Pass = password;
        }

        public string NombreDeUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;
        }

        public string Passw
        {
            get => Pass;
            set => Pass = value;
        }
    }
}
