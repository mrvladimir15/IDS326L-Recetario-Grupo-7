﻿using Antlr4.Runtime;
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
- RECETA: Pudin de pan
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

recetaVisitor recetaVisitor= new recetaVisitor();
recetaVisitor.Visit(tree);