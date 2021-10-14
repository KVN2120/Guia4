using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2._0
{
    public partial class Menu : FrmBase
    {
       
        public Menu()
        {
            InitializeComponent();
        }

        private void btnestudiantes_Click(object sender, EventArgs e)
        {
            FrmEstudiantes estudiante = new FrmEstudiantes();
            this.Hide();
            estudiante.Show();
        }

        private void btndocentes_Click(object sender, EventArgs e)
        {
            FrmRegistroDocentes Docente = new FrmRegistroDocentes ();
            this.Hide();
            Docente.Show();
        }
    }
}
