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
    public partial class VistaIngredientes : Form
    {
        public VistaIngredientes()
        {
            InitializeComponent();
            Sistema.Cargar();
        }

        private void VistaRecetas_Load(object sender, EventArgs e)
        {
            Refrescar();

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void agregaringrediente_button_Click(object sender, EventArgs e)
        {
            Sistema.AgregarIngrediente(nombre_textBox.Text, decimal.Parse(cantidad_textBox.Text), decimal.Parse(precio_textBox.Text), decimal.Parse(cantidadminima_textBox.Text));
            Refrescar();
            vaciartb();
        }

        private void Refrescar()
        {
            stockingredientes_listBox.Items.Clear();
            foreach(Ingrediente ingrediente in Sistema.Ingredientes)
            {
                stockingredientes_listBox.Items.Add(ingrediente);
            }
        }

        private void modificaring_button_Click(object sender, EventArgs e)
        {
            Ingrediente ingredienteSeleccionado = stockingredientes_listBox.SelectedItem as Ingrediente;
            Sistema.ModificarIngrediente(nombre_textBox.Text, decimal.Parse(cantidad_textBox.Text), decimal.Parse(precio_textBox.Text), decimal.Parse(cantidadminima_textBox.Text), ingredienteSeleccionado);
            Refrescar();
            vaciartb();
        }

        private void eliminaring_button_Click(object sender, EventArgs e)
        {
            Ingrediente ingredienteSeleccionado = stockingredientes_listBox.SelectedItem as Ingrediente;
            Sistema.EliminarIngrediente(ingredienteSeleccionado);
            Refrescar();
            vaciartb();
        }
        private void vaciartb()
        {
            nombre_textBox.Text = "";
            cantidadminima_textBox.Text = "";
            cantidad_textBox.Text = "";
            precio_textBox.Text = "";
        }

        private void stockingredientes_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ingrediente ingrediente = stockingredientes_listBox.SelectedItem as Ingrediente;
            if(ingrediente != null)
            {
                nombre_textBox.Text = ingrediente.Nombre;
                cantidadminima_textBox.Text = ingrediente.CantidadMinima.ToString();
                cantidad_textBox.Text = ingrediente.Stock.ToString();
                precio_textBox.Text = ingrediente.PrecioKG.ToString();
            }
        }
    }
}
