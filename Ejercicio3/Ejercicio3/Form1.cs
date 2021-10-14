using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double R = double.Parse(txt2.Text);
            double A = 0;
            Circulo circulo = new Circulo(A, R);
            circulo.CalcularArea(lbl4);
        }

        private void btncirculo_Click(object sender, EventArgs e)
        {
            double L = double.Parse(txtlado.Text);
            double A = 0;
            Cuadrado cuadrado = new Cuadrado(A, L);
            cuadrado.CalcularArea(label2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Diagonalmayor = double.Parse(txtmayor.Text);
            double DiagonalMenor = double.Parse(txtmenor.Text);
            double A = 0;
            Rombo rombo = new Rombo(A, Diagonalmayor, DiagonalMenor);
            rombo.CalcularArea(label5);
        }
    }
}
