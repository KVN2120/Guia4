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
    
    public partial class FrmRegistroDocentes : FrmRegistro
    {
        private List<Docente> Docentes = new List<Docente>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgv1.DataSource = null;
            dgv1.DataSource = Docentes;
        }
        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        int pos;

        public FrmRegistroDocentes()
        {
            InitializeComponent();
        }


        private void FrmRegistroDocentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv1.SelectedRows[0];
            int posicion = dgv1.Rows.IndexOf(selected);
            edit_indice = posicion;

            Docente docent = Docentes[posicion];
            textBox1.Text = docent.Nombre;
            textBox2.Text = docent.Usuario;
            textBox3.Text = docent.Codigo;
            textBox4.Text = docent.Materia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Docente docent = new Docente();
            docent.Nombre = textBox1.Text;
            docent.Usuario = textBox2.Text;
            docent.Codigo = textBox3.Text;
            docent.Materia = textBox4.Text;
            if (edit_indice > -1)
            {
                Docentes[edit_indice] = docent;
                edit_indice = -1;
            }
            else
            {
                Docentes.Add(docent);
            }
            actualizarGrid();
            limpiar();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre, usuario, codigo, materia;
         
            nombre = textBox1.Text;
            usuario = textBox2.Text;
            codigo = textBox3.Text;
            materia = textBox4.Text;

            dgv1[0, pos].Value = textBox1.Text;
            dgv1[1, pos].Value = textBox2.Text;
            dgv1[2, pos].Value = textBox3.Text;
            dgv1[3, pos].Value = textBox4.Text;
            limpiar();
            

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dgv1.CurrentRow.Index;
            textBox1.Text = dgv1[0, pos].Value.ToString();
            textBox2.Text = dgv1[1, pos].Value.ToString();
            textBox3.Text = dgv1[2, pos].Value.ToString();
            textBox4.Text = dgv1[3, pos].Value.ToString();
            button2.Enabled = true;
            
        }
    }
}
