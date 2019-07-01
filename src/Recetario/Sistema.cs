using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recetario
{
   public class Sistema
    {
        public List<Receta> Recetas { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public Sistema()
        {
            Recetas = new List<Receta>();
            Ingredientes = new List<Ingrediente>();
        }
        //se crean e inicializan las listas ingrediente y receta

        public void AgregarReceta(string nombre, List<IngredienteReceta> ingredienteReceta )
        {
            Receta receta = new Receta()
            {
                Nombre = nombre,
                IngredienteReceta = ingredienteReceta,
            };
            Recetas.Add(receta);
            
        }

        public void ModificarReceta(string nombre, List<IngredienteReceta> ingrediente,Receta receta)
        {
            receta.Nombre = nombre;
            receta.IngredienteReceta = ingrediente;

        }

        public void EliminarReceta(Receta receta)
        {
            Recetas.Remove(receta);
        }

        public void CocinarReceta(Receta receta)
        {
           foreach (IngredienteReceta ingredienteReceta in receta.IngredienteReceta)
            {
                if (ingredienteReceta.Ingrediente.Stock >= ingredienteReceta.Cantidad)
                {
                    ingredienteReceta.Ingrediente.Stock -= ingredienteReceta.Cantidad;
                }
                else
                {
                    MessageBox.Show($"Faltan {(ingredienteReceta.Cantidad - ingredienteReceta.Ingrediente.Stock) * (-1)}gr de {ingredienteReceta.Ingrediente.Nombre}, pedilo en nuestro botón.");
                }
            }
        }
        // Cuando se cocina una receta hay que restar la cantidad que se usa de cada ingrediente
        // dentro del stock.
    }

}
