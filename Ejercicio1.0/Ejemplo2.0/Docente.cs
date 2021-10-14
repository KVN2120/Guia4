using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2._0
{
    class Docente
    {
        private string nombre;
        private string usuario;
        private string codigo;
        private string materia;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
    }
}
