using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDS326L_RecetarioSQL_Grupo7
{
    internal class recetaVisitor : recetaParserBaseVisitor<string>
    {
        public override string VisitCalorias([NotNull] recetaParserParser.CaloriasContext context)
        {
            return base.VisitCalorias(context);
        }

        public override string VisitElaboracion([NotNull] recetaParserParser.ElaboracionContext context)
        {
            return base.VisitElaboracion(context);
        }

        public override string VisitIngredientes([NotNull] recetaParserParser.IngredientesContext context)
        {
            return base.VisitIngredientes(context);
        }

        public override string VisitPorciones([NotNull] recetaParserParser.PorcionesContext context)
        {
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
            return base.VisitTiempo_coccion(context);
        }

        public override string VisitTiempo_preparacion([NotNull] recetaParserParser.Tiempo_preparacionContext context)
        {
            return base.VisitTiempo_preparacion(context);
        }

        public override string VisitTitulo([NotNull] recetaParserParser.TituloContext context)
        {
            return base.VisitTitulo(context);
        }
    }
}
