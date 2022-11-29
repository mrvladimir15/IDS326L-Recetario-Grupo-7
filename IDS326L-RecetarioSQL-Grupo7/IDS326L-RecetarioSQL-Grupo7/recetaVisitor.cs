using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IDS326L_RecetarioSQL_Grupo7
{
    internal class recetaVisitor : recetaParserBaseVisitor<string>
    {
        public override string VisitCalorias([NotNull] recetaParserParser.CaloriasContext context)
        {
            //Console.WriteLine(context.GetText());
            return base.VisitCalorias(context);
        }

        public override string VisitElaboracion([NotNull] recetaParserParser.ElaboracionContext context)
        {
            Regex regex = new Regex("([0-9][)])");
            var lista = regex.Split(context.GetText());
            
            List<string> pasos = new List<string>();

            lista[0] = lista[0].Replace("- ELABORACION:", "");

            for (int i = 0; i < lista.Length; i += 2)
            {
                //lista[i] = lista[i] + lista[i + 1];
                pasos.Add(lista[i]);
            }

            return base.VisitElaboracion(context);
        }

        public override string VisitIngredientes([NotNull] recetaParserParser.IngredientesContext context)
        {
            var lista = context.GetText().Split(',');
            lista[0] = lista[0].Replace("- INGREDIENTES:", "");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            return base.VisitIngredientes(context);
        }

        public override string VisitPorciones([NotNull] recetaParserParser.PorcionesContext context)
        {
            //Console.WriteLine(context.GetText());
            return base.VisitPorciones(context);
        }

        public override string VisitReceta([NotNull] recetaParserParser.RecetaContext context)
        {
            return base.VisitReceta(context);
        }

        public override string VisitRecetaParser([NotNull] recetaParserParser.RecetaParserContext context)
        {
            return base.VisitRecetaParser(context);
        }

        public override string VisitTiempo_coccion([NotNull] recetaParserParser.Tiempo_coccionContext context)
        {
            if (context.GetText() != null)
                Console.WriteLine("Distinto de nulo");
            else
                Console.WriteLine("Nulo");
            //Console.WriteLine(context.GetText());
            return base.VisitTiempo_coccion(context);
        }

        public override string VisitTiempo_preparacion([NotNull] recetaParserParser.Tiempo_preparacionContext context)
        {
            //Console.WriteLine(context.GetText());
            return base.VisitTiempo_preparacion(context);
        }

        public override string VisitTitulo([NotNull] recetaParserParser.TituloContext context)
        {
            //Console.WriteLine(context.GetText());
            return base.VisitTitulo(context);
        }
    }
}
