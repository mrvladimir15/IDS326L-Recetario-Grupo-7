using Antlr4.Runtime;
using IDS326L_RecetarioSQL_Grupo7;

//Console.WriteLine("Escriba su receta: ");

string receta = @"- RECETA: Pudin de pan
- PORCIONES: 3 personas
- TIEMPO PREPARACION: 20 min
- TIEMPO COCCION: 60 min
- CALORIAS: 535 kcal
- INGREDIENTES:
	2.5 tazas leche evaporada,
	2 huevos,
	2 cucharadita extracto de vainilla,
	1 cucharadita canela en polvo,
	0.5 cucharadita jengibre rallado o en polvo,
	0.5 cucharadita clavo dulce en polvo,
	0.25 cucharadita sal,
	0.5 taza azucar morena,
	3 tazas pan viejo en trocitos,
	0.25 taza pasas,
	0.25 taza mantequilla
- ELABORACION:
	1) Buscar una licuadora
	2) Echar todos los liquidos
	3) Echar todos los solidos
	4) Licuar
	5) Beberselo en el vaso de la licuadora
	6) Fin
- RECETA: Pizza
- PORCIONES: 2 jartones
- CALORIAS: 2000 calorias
- INGREDIENTES:
	2 Pizzas Grandes de Pizza Hut
- ELABORACION:
	1) Colocar la Pizza en la mesa
	2) Comersela";

var inputStream = CharStreams.fromString(receta);
var lexer = new recetaParserLexer(inputStream);
var tokenStream = new CommonTokenStream(lexer);
var parser = new recetaParserParser(tokenStream);
var tree = parser.recetaParser();
string script = "";


recetaVisitor recetaVisitor= new recetaVisitor();
recetario recetario =  recetaVisitor.Visit(tree);

Dictionary<string, int> unitIng = new Dictionary<string, int>();
unitIng.Add("cucharadita", 1);
unitIng.Add("cucharada", 2);
unitIng.Add("taza", 3);
unitIng.Add("tazas", 3);

int recipeIndex = 0;
int ingredientsIndex = 1;
int ccoking_stepsIndex = 1;
foreach (receta item in recetario.recetas)
{
	recipeIndex++;
	List<string> porciones = item.porciones.Split(" ").ToList();
	List<string> tiempococc = new List<string>();
	List<string> tiempoprep = new List<string>();
	string cookandprep = "";
	string tiempococcion;
	string tiempopreparacion;
	if (item.tiempoCoccion != null && item.tiempoCoccion != null)
	{
		tiempococc = item.tiempoCoccion.Split(" ").ToList();
		tiempoprep = item.tiempoPreparacion.Split(" ").ToList();
		tiempococcion = $", {tiempococc[0]}, '{tiempococc[1]}', ";
		tiempopreparacion = $"{tiempoprep[0]}, '{tiempoprep[1]}'";
		cookandprep = "prep_time, prep_time_unit, cook_time, cook_time_unit, ";
	}
	else
    {
		tiempococcion = $"";
		tiempopreparacion = "";
	}

	script += @$"
	-- Receta: {item.tituloReceta}
INSERT INTO recipes (id, name, portions, {cookandprep}calories)" +
$"\nVALUES ({recipeIndex}, '{item.tituloReceta}', {porciones[0]}, {tiempopreparacion}{tiempococcion}{item.calorias});\n";
	foreach (string ingrediente in item.ingredientes)
	{
		string IngInfo;
		var ingredientes = ingrediente.Split(" ");
		string unitid;

		if (ingredientes.Contains("tazas") || ingredientes.Contains("taza") || ingredientes.Contains("cucharada") || ingredientes.Contains("cucharadita"))
		{
			unitid = ", unit_id";
			ingredientes = ingrediente.Split(" ", 3);
			IngInfo = $"'{ingredientes[2]}', {ingredientes[0]}, {unitIng[ingredientes[1]]}";
		}
		else
		{
			unitid = "";
			ingredientes = ingrediente.Split(" ", 2);
			IngInfo = $"'{ingredientes[1]}', {ingredientes[0]}";
        }



		script += $"INSERT INTO ingredients (id, recipe_id, name, quantity{unitid}) VALUES ({ingredientsIndex}, {recipeIndex}, {IngInfo});\n";
		ingredientsIndex++;
	}
	//script += "\n";
	int steps = 1;
    foreach (string prep in item.elaboracion)
    {
		script += $"INSERT INTO cooking_steps (id, recipe_id, step_number, description) VALUES({ccoking_stepsIndex}, {recipeIndex}, {steps}, '{prep}');\n";
		steps++;
		ccoking_stepsIndex++;
    }
    Console.WriteLine(script);
	script = "";
}

