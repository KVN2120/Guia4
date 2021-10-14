using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Restar:Operacion
    {
        public int operar(int v1, int v2)
        {
            valor1 = v1; //Se puede acceder a los atributos directamente
            valor2 = v2; //Por la relacion de la herencia 
            return resultado = valor1 - valor2;
        }
    }
}
