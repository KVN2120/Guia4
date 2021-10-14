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
   
    public partial class FrmEstudiantes : FrmRegistro
    {
        private List<Alumno> Alumnos = new List<Alumno>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgv2.DataSource = null;
            dgv2.DataSource = Alumnos;
        }
        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }
        int posi;
        public FrmEstudiantes()
        {
            InitializeComponent();
        }
        int pos;
        private void FrmEstudiantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgv2_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv2.SelectedRows[0];
            int posicion = dgv2.Rows.IndexOf(selected);
            edit_indice = posicion;

            Alumno alum = Alumnos[posicion];
            textBox1.Text = alum.Nombre;
            textBox2.Text = alum.Usuario;
            textBox3.Text = alum.Codigo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno alum = new Alumno();
            alum.Nombre = textBox1.Text;
            alum.Usuario = textBox2.Text;
            alum.Codigo = textBox3.Text;
            
            if (edit_indice > -1)
            {
                Alumnos[edit_indice] = alum;
                edit_indice = -1;
            }
            else
            {
                Alumnos.Add(alum);
            }
            actualizarGrid();
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posi = dgv2.CurrentRow.Index;
            textBox1.Text = dgv2[0, pos].Value.ToString();
            textBox2.Text = dgv2[1, pos].Value.ToString();
            textBox3.Text = dgv2[2, pos].Value.ToString();
            
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre, usuario, codigo;

            nombre = textBox1.Text;
            usuario = textBox2.Text;
            codigo = textBox3.Text;
            
            dgv2[0, posi].Value = textBox1.Text;
            dgv2[1, posi].Value = textBox2.Text;
            dgv2[2, posi].Value = textBox3.Text;
            
            limpiar();
        }
    }
}
