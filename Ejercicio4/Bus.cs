using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public class Bus:Vehiculo
    {
        private string marca;
        private string empresa;
        private double ruta;

        public Bus(double A, string M, string E, double R)
            : base(A)
        {
            marca = M;
            empresa = E;
            ruta = R;
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public double Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }
        public override void MarcadeTransporte(Label LR)
        {
            Marca = Marca;
            Empresa = Empresa;
            Ruta=Ruta;
            LR.Text = "Marca: " + Marca + ", Año: " + Año + ", Empresa: " + Empresa + ", Ruta: " + Ruta;

        } 
         
    }
}
