using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public class Cuadrado:Figuras //Clase hereda de figura
    {
        private double lado; //atributo

        public Cuadrado(double A, double L) : base(A) //Constructor
        {
            lado = L;
        }
        public double Lado //Propiedad
        {
            get { return lado; }
            set { lado = value; }
        }
        //Metodo sobreescrito
        public override void CalcularArea(Label LR)
        {
            Area = (Lado * Lado);
        LR.Text = "Area: " + Area;
        }
    }
}
