using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IDS326L_RecetarioSQL_Grupo7
{
    internal class recetaVisitor : recetaParserBaseVisitor<recetario>
    {
        receta receta = new receta();
        recetario recetario = new recetario();

        public override recetario VisitCalorias([NotNull] recetaParserParser.CaloriasContext context)
        {
            receta.calorias = context.GetText().Replace("- CALORIAS: ", "");
            return base.VisitCalorias(context);
        }

        public override recetario VisitElaboracion([NotNull] recetaParserParser.ElaboracionContext context)
        {
            Regex regex = new Regex("([0-9][)])");
            var lista = regex.Split(context.GetText());
            
            List<string> pasos = new List<string>();

            lista[0] = lista[0].Replace("- ELABORACION:", "");

            for (int i = 0; i < lista.Length; i += 2)
            {
                pasos.Add(lista[i].Trim());
            }
            pasos.Remove("");
            receta.elaboracion = pasos.ToList();
            recetario.recetas.Add(receta);

            receta = new receta();
            return base.VisitElaboracion(context);
        }

        public override recetario VisitIngredientes([NotNull] recetaParserParser.IngredientesContext context)
        {
            List<string> lista = context.GetText().Split(',').ToList();
            lista[0] = lista[0].Replace("- INGREDIENTES:", "");

            receta.ingredientes = lista;
            return base.VisitIngredientes(context);
        }

        public override recetario VisitPorciones([NotNull] recetaParserParser.PorcionesContext context)
        {
            receta.porciones = context.GetText().Replace("- PORCIONES: ", "");
            return base.VisitPorciones(context);
        }

        public override recetario VisitReceta([NotNull] recetaParserParser.RecetaContext context)
        {
            return base.VisitReceta(context);
        }

        public override recetario VisitRecetaParser([NotNull] recetaParserParser.RecetaParserContext context)
        {
            base.VisitRecetaParser(context);
            return recetario;
        }

        public override recetario VisitTiempo_coccion([NotNull] recetaParserParser.Tiempo_coccionContext context)
        {
            receta.tiempoCoccion = context.GetText().Replace("- TIEMPO COCCION: ", "");
            return base.VisitTiempo_coccion(context);
        }

        public override recetario VisitTiempo_preparacion([NotNull] recetaParserParser.Tiempo_preparacionContext context)
        {
            receta.tiempoPreparacion = context.GetText().Replace("- TIEMPO PREPARACION: ", "");
            return base.VisitTiempo_preparacion(context);
        }

        public override recetario VisitTitulo([NotNull] recetaParserParser.TituloContext context)
        {
            receta.tituloReceta = context.GetText().Replace("- RECETA: ", "");
            return base.VisitTitulo(context);
        }
    }
}
