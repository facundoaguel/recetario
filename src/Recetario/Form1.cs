using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recetario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void AgregarI_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Recetas_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
           
        }

        private void stocking_button_Click(object sender, EventArgs e)
        {
            new VistaIngredientes().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Recetario().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Al utilizar este software quedara obligado a ponerle un 10 al creador del mismo. :)", "Términos y condiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
