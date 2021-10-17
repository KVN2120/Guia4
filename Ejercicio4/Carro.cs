using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public class Carro:Vehiculo
    {
        private string marca;
        private string modelo;
       
        private string color;

        public Carro(double A, string M, string MO, string C)
            : base(A)
        {
            marca = M;
            modelo = MO;
            
            color = C;
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
       
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public override void MarcadeTransporte(Label LR)
        {
            
            Modelo = Modelo;
            Color = Color;
            Marca = Marca;
            LR.Text = "Modelo: " + Modelo+ ", Año: " + Año + ", Color: " + Color + ", Marca: " + Marca;
        }
    }
}
