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
        public Sistema sistema;
        public Form1()
        {
            InitializeComponent();
            sistema = new Sistema();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sistema.AgregarReceta(string nombre, List<IngredienteReceta>Ingrediente);
            Refrescar();
        }

        private void AgregarI_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
