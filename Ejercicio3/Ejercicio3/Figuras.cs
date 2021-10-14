using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio3
{
    public abstract class Figuras //clase publica que no permite instancias
    {
        private double area;//atributo
        //constructor
        public Figuras(double A)
        {
            area = A;
        }
        //propiedad
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        //Metodo utilizando virtual 
        public virtual void CalcularArea(Label LR)
        {

        }
    }
}
