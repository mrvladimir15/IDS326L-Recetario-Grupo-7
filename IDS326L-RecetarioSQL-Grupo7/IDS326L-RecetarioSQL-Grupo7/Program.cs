using Antlr4.Runtime;

Console.WriteLine("Escriba su receta: ");

string receta = "";

var inputStream = CharStreams.fromString(receta);
var lexer = new recetaParserLexer(inputStream);
var tokenStream = new CommonTokenStream(lexer);
var parser = new recetaParserParser(tokenStream);
var tree = parser.recetaParser();