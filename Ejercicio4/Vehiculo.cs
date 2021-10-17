using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
     public abstract class Vehiculo //clase publica que no permite instancias
    {
         private double año;//atributo
         private string M;
         //constructor
         public Vehiculo(double A)
         {
             año = A;
         }

         public Vehiculo(string M)
         {
             // TODO: Complete member initialization
             this.M = M;
         }
         //propiedad
         public double Año
         {
             get { return año; }
             set { año = value; }
         }
         //Metodo virtual
         public virtual void MarcadeTransporte(Label LR)
         {

         }

    }
}
