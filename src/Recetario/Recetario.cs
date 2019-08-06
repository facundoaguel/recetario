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
            IngredienteReceta ingRecSeleccionado = ingredientesReceta_listBox.SelectedItem as IngredienteReceta;
            if (ingRecSeleccionado != null)
            {
                cantidadingreceta_textBox.Text = ingRecSeleccionado.Cantidad.ToString();
            }
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
            foreach (Receta receta in Sistema.Recetas)
            {
                recetas_listBox.Items.Add(receta);
            }
        }
        private void RefrescarIngredientes()
        {
            ingredientesReceta_listBox.Items.Clear();
            Receta receta = recetas_listBox.SelectedItem as Receta;
            foreach (IngredienteReceta ingrediente in receta.IngredienteReceta)
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

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            Receta receta = recetas_listBox.SelectedItem as Receta;
            Sistema.EliminarReceta(receta);
            RefrescarRecetas();
            vaciartb();

        }

        private void Recetas_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Receta receta = recetas_listBox.SelectedItem as Receta;
            if (receta != null)
            {
                nombre_textBox.Text = receta.Nombre;
            }
            RefrescarIngredientes();
        }

        private void Agregaringreceta_button_Click(object sender, EventArgs e)
        {
            Ingrediente ingSeleccionado = ingredientesreceta_comboBox.SelectedItem as Ingrediente;
            Receta receta = recetas_listBox.SelectedItem as Receta;
            Sistema.AgregarIngredienteReceta(receta, ingSeleccionado, decimal.Parse(cantidadingreceta_textBox.Text));
            RefrescarIngredientes();
            vaciartb();
        }
        private void RefrescarComboBox()
        {
            ingredientesreceta_comboBox.Items.Clear();
            foreach (Ingrediente ingrediente in Sistema.Ingredientes)
            {
                ingredientesreceta_comboBox.Items.Add(ingrediente);
            }
        }

        private void Recetario_Load(object sender, EventArgs e)
        {
            RefrescarRecetas();
            RefrescarComboBox();
            RefrescarIngredientes();
 
        }

        private void Modificaringreceta_button_Click(object sender, EventArgs e)
        {
            IngredienteReceta ingRecSeleccionado = ingredientesReceta_listBox.SelectedItem as IngredienteReceta;
            Sistema.ModificarIngredienteReceta(ingRecSeleccionado, decimal.Parse(cantidadingreceta_textBox.Text));
            RefrescarIngredientes();
            vaciartb();
        }

        private void Eliminaringreceta_button_Click(object sender, EventArgs e)
        {
            IngredienteReceta ingRecSeleccionado = ingredientesReceta_listBox.SelectedItem as IngredienteReceta;
            Receta receta = recetas_listBox.SelectedItem as Receta;
            Sistema.EliminarIngredienteReceta(receta, ingRecSeleccionado);
            RefrescarIngredientes();
        }
    }
}
