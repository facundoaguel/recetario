using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetario
{
    public class Receta
    {
        public string Nombre { get; set; }
        public List<IngredienteReceta> IngredienteReceta { get; set; }
        //una receta esta compuesta por su nombre como ID e ingredientes sacados de la lista
        //inrediente receta 

    }
}
