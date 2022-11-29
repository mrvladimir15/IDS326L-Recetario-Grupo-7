using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDS326L_RecetarioSQL_Grupo7
{
    internal class receta
    {
        public string tituloReceta { get; set; }
        public string porciones { get; set; }
        public string? tiempoPreparacion { get; set; } = null;
        public string? tiempoCoccion { get; set; } = null;
        public string calorias { get; set; }
        public List<string> ingredientes { get; set; }
        public List<string> elaboracion { get; set; }
    }

    internal class recetario
    {
        public List<receta> recetas { get; set; } = new List<receta>();
    }
}