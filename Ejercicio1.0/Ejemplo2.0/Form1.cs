using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Ejemplo2._0
{
    public partial class FrmBase : Form //el formulario ya hereda de form por defecto
    {
        
        public FrmBase()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        
        }

       
    }
}
