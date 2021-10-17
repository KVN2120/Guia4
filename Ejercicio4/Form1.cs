using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CO = txtcolor.Text;
            double A = double.Parse(txtaño.Text);
            double C = double.Parse(txtcilindraje.Text);
            string M = txtmarca.Text;
            Moto moto = new Moto(A, C, CO, M);

            moto.MarcadeTransporte(label4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string M = txtmarca2.Text;
            string MO = txtmodelo2.Text;
            double A = double.Parse(txtaño2.Text);
            string C = txtcolor2.Text;
            Carro carro = new Carro(A, M, MO, C);
            carro.MarcadeTransporte(lblrespuesta);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string M = txtmarca3.Text;
            double A = double.Parse(txtaño3.Text);
            string E = txtempresa.Text;
            double R=double.Parse(txtruta.Text);
            Bus bus=new Bus(A,M,E,R);
            bus.MarcadeTransporte(label13);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}