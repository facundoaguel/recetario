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
    public partial class Recetario : Form
    {
        public Recetario()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ingredientesReceta_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void crearreceta_button_Click(object sender, EventArgs e)
        {
            Sistema.AgregarReceta(nombre_textBox.Text);
            RefrescarRecetas();
            vaciartb();
        }
        private void RefrescarRecetas()
        {
            recetas_listBox.Items.Clear();
            foreach (Ingrediente ingrediente in Sistema.Ingredientes)
            {
                recetas_listBox.Items.Add(ingrediente);
            }
        }
        private void RefrescarIngredientes()
        {
            ingredientesReceta_listBox.Items.Clear();
            foreach (Ingrediente ingrediente in Sistema.Ingredientes)
            {
                ingredientesReceta_listBox.Items.Add(ingrediente);
            }
        }

        private void cocinar_button_Click(object sender, EventArgs e)
        {
            Receta recetaSeleccionada = recetas_listBox.SelectedItem as Receta;
            Sistema.CocinarReceta(recetaSeleccionada);
        }

        private void modificar_button_Click(object sender, EventArgs e)
        {
            Receta recetaSeleccionada = recetas_listBox.SelectedItem as Receta;
            Sistema.ModificarReceta(nombre_textBox.Text, recetaSeleccionada);
            RefrescarRecetas();
            vaciartb();
        }
        private void vaciartb()
        {
            nombre_textBox.Text = "";
            cantidadingreceta_textBox.Text = "";
        }
    }
}
