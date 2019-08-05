   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetario
{
    public class Ingrediente
    {
        public string Nombre { get; set; }
        public decimal Stock { get; set; }
        public decimal PrecioKG { get; set; }
        public decimal CantidadMinima { get; set; }

        public string MostrarDatos
        {
            get
            {
                return $"{Stock} | {Nombre} | ${PrecioKG}";
            }
        }

    }
}
