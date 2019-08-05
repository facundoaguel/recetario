using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recetario
{
    public static class Sistema
    {
        public static List<Receta> Recetas { get; set; }
        public static List<Ingrediente> Ingredientes { get; set; }

        static Sistema()
        {
            Recetas = new List<Receta>();
            Ingredientes = new List<Ingrediente>();
        }
        //se crean e inicializan las listas ingrediente y receta

        public static void AgregarReceta(string nombre, List<IngredienteReceta> ingredienteReceta)
        {
            Receta receta = new Receta()
            {
                Nombre = nombre,
                IngredienteReceta = ingredienteReceta,
            };
            Recetas.Add(receta);

        }

        public static void ModificarReceta(string nombre, List<IngredienteReceta> ingrediente, Receta receta)
        {
            receta.Nombre = nombre;
            receta.IngredienteReceta = ingrediente;

        }

        public static void EliminarReceta(Receta receta)
        {
            Recetas.Remove(receta);
        }

        public static void CocinarReceta(Receta receta)
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

        public static void AgregarIngrediente(string nombre, decimal stock, decimal preciokg, decimal cantidadminima)
        {
            Ingrediente ingrediente = new Ingrediente()
            {
                Nombre = nombre,
                Stock = stock,
                PrecioKG = preciokg,
                CantidadMinima = cantidadminima,
            };
            Ingredientes.Add(ingrediente);
        }
        public static void ModificarIngrediente(string nombre, decimal stock, decimal preciokg, decimal cantidadminima, Ingrediente ingrediente)
        {
            ingrediente.Nombre = nombre;
            ingrediente.Stock = stock;
            ingrediente.PrecioKG = preciokg;
            ingrediente.CantidadMinima = cantidadminima;
        }
        public static void EliminarIngrediente(Ingrediente ingrediente)
        {
            Ingredientes.Remove(ingrediente);
        }
    }


}
