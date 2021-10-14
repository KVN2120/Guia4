using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public class Circulo:Figuras //Clase heredada de figura
    {
        private double radio;//Atributto

        public Circulo(double A, double R):base(A)//Constructor con parametros
        {
            radio = R;
        }
        public double Radio //propiedad
        {
            get { return radio; }
            set { radio = value; }
        }
        //Metdo sobreescrito
        public override void CalcularArea(Label LR)
        {
            Area = (Math.PI * Math.Pow(Radio, 2));
            LR.Text = "Area: " + Area;
        }

    }
}
