using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miapp_2.entidades
{
    public class persona
    {
        private string documento;
        private string apellido;
        private string nombre;

        public persona(string doc, string ape, string nom)
        {
            // NombreUsu = nombreUsuario;
            // this.NombreUsu = nombreUsuario;
            //Pass = password;
            // this.Pass = password;
            documento = doc;
            apellido = ape;
            nombre = nom;

        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public string Documento
        {
            get => documento;
            set => documento = value;
        }
    }
}
