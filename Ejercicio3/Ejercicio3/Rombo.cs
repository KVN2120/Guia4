using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public class Rombo:Figuras
    {
        private double diagonalmayor, diagonalmenor; //atributos

        public Rombo(double A, double LMA, double LMO)
            : base(A)
        {
            diagonalmayor = LMA;
            diagonalmenor = LMO;
        }
        public double DiagonalMayor
        {
            get { return diagonalmayor; }
            set { diagonalmayor = value; }
        }
        public double DiagonalMenor
        {
            get { return diagonalmenor; }
            set { diagonalmenor = value; }
        }
        //Metodo sobreescrito
        public override void CalcularArea(Label LR)
        {
            Area = (DiagonalMayor * DiagonalMenor) / 2;
            LR.Text = "Area: " + Area;
        }
    }
}
