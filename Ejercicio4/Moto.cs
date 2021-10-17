using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public class Moto:Vehiculo //clase heredad de figura
    {
        private string color;
        private string marca;
        private double cilindraje;
        

        public Moto(double A,double C,string M,string CO):base(A)
        {
            
            cilindraje = C;
            marca = M;
            color =CO ;
           
        }
        
        
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public double Cilindraje
        {
            get { return cilindraje; }
            set { cilindraje = value; }
        }
        public string Color{
            get { return color; }
            set { color = value; }
        }
        
        public override void MarcadeTransporte(Label LR)
        {
            Año = Año;
            Cilindraje = Cilindraje;
            Color = Color;
            Marca = Marca;
            LR.Text = "Color: " + Marca +", Año: "+ Año +", Cilindraje: " + Cilindraje +", Marca: " + Color;
        }
            
        
    }

}
