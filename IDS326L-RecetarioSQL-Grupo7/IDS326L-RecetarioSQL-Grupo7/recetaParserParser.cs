//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\Vladimir González\Documents\GitHub\IDS326L-Recetario-Grupo-7\IDS326L-RecetarioSQL-Grupo7\recetaParser.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class recetaParserParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		RECETA=1, PORCIONES=2, TIEMPO_PREPARACION=3, TIEMPO_COCCION=4, INGREDIENTES=5, 
		CALORIAS=6, ELABORACION=7, SEP=8, TEXT=9, WORD=10, NUM=11, ORD=12, COMA=13, 
		SK=14, SK1=15, SK2=16;
	public const int
		RULE_recetaParser = 0, RULE_receta = 1, RULE_titulo = 2, RULE_porciones = 3, 
		RULE_tiempo_preparacion = 4, RULE_tiempo_coccion = 5, RULE_calorias = 6, 
		RULE_ingredientes = 7, RULE_elaboracion = 8;
	public static readonly string[] ruleNames = {
		"recetaParser", "receta", "titulo", "porciones", "tiempo_preparacion", 
		"tiempo_coccion", "calorias", "ingredientes", "elaboracion"
	};

	private static readonly string[] _LiteralNames = {
		null, "'- RECETA:'", "'- PORCIONES:'", "'- TIEMPO PREPARACION:'", "'- TIEMPO COCCION:'", 
		"'- INGREDIENTES:'", "'- CALORIAS:'", "'- ELABORACION:'", null, null, 
		null, null, null, "','", "'\n'", "'\r'", "'\t'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "RECETA", "PORCIONES", "TIEMPO_PREPARACION", "TIEMPO_COCCION", "INGREDIENTES", 
		"CALORIAS", "ELABORACION", "SEP", "TEXT", "WORD", "NUM", "ORD", "COMA", 
		"SK", "SK1", "SK2"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "recetaParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static recetaParserParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public recetaParserParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public recetaParserParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class RecetaParserContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(recetaParserParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public RecetaContext[] receta() {
			return GetRuleContexts<RecetaContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public RecetaContext receta(int i) {
			return GetRuleContext<RecetaContext>(i);
		}
		public RecetaParserContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_recetaParser; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IrecetaParserVisitor<TResult> typedVisitor = visitor as IrecetaParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRecetaParser(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RecetaParserContext recetaParser() {
		RecetaParserContext _localctx = new RecetaParserContext(Context, State);
		EnterRule(_localctx, 0, RULE_recetaParser);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 19;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 18;
				receta();
				}
				}
				State = 21;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==RECETA );
			State = 23;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RecetaContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TituloContext titulo() {
			return GetRuleContext<TituloContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PorcionesContext porciones() {
			return GetRuleContext<PorcionesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CaloriasContext calorias() {
			return GetRuleContext<CaloriasContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IngredientesContext ingredientes() {
			return GetRuleContext<IngredientesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElaboracionContext elaboracion() {
			return GetRuleContext<ElaboracionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Tiempo_preparacionContext tiempo_preparacion() {
			return GetRuleContext<Tiempo_preparacionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Tiempo_coccionContext tiempo_coccion() {
			return GetRuleContext<Tiempo_coccionContext>(0);
		}
		public RecetaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_receta; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IrecetaParserVisitor<TResult> typedVisitor = visitor as IrecetaParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitReceta(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RecetaContext receta() {
		RecetaContext _localctx = new RecetaContext(Context, State);
		EnterRule(_localctx, 2, RULE_receta);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 25;
			titulo();
			State = 26;
			porciones();
			State = 28;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==TIEMPO_PREPARACION) {
				{
				State = 27;
				tiempo_preparacion();
				}
			}

			State = 31;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==TIEMPO_COCCION) {
				{
				State = 30;
				tiempo_coccion();
				}
			}

			State = 33;
			calorias();
			State = 34;
			ingredientes();
			State = 35;
			elaboracion();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TituloContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RECETA() { return GetToken(recetaParserParser.RECETA, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(recetaParserParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(recetaParserParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(recetaParserParser.NUM, 0); }
		public TituloContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_titulo; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IrecetaParserVisitor<TResult> typedVisitor = visitor as IrecetaParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTitulo(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TituloContext titulo() {
		TituloContext _localctx = new TituloContext(Context, State);
		EnterRule(_localctx, 4, RULE_titulo);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 37;
			Match(RECETA);
			State = 38;
			Match(SEP);
			State = 40;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NUM) {
				{
				State = 39;
				Match(NUM);
				}
			}

			State = 42;
			Match(TEXT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PorcionesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PORCIONES() { return GetToken(recetaParserParser.PORCIONES, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEP() { return GetTokens(recetaParserParser.SEP); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP(int i) {
			return GetToken(recetaParserParser.SEP, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(recetaParserParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(recetaParserParser.NUM, 0); }
		public PorcionesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_porciones; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IrecetaParserVisitor<TResult> typedVisitor = visitor as IrecetaParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPorciones(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PorcionesContext porciones() {
		PorcionesContext _localctx = new PorcionesContext(Context, State);
		EnterRule(_localctx, 6, RULE_porciones);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 44;
			Match(PORCIONES);
			State = 45;
			Match(SEP);
			State = 47;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NUM) {
				{
				State = 46;
				Match(NUM);
				}
			}

			State = 49;
			Match(SEP);
			State = 50;
			Match(TEXT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Tiempo_preparacionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TIEMPO_PREPARACION() { return GetToken(recetaParserParser.TIEMPO_PREPARACION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEP() { return GetTokens(recetaParserParser.SEP); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP(int i) {
			return GetToken(recetaParserParser.SEP, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(recetaParserParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(recetaParserParser.NUM, 0); }
		public Tiempo_preparacionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tiempo_preparacion; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IrecetaParserVisitor<TResult> typedVisitor = visitor as IrecetaParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTiempo_preparacion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Tiempo_preparacionContext tiempo_preparacion() {
		Tiempo_preparacionContext _localctx = new Tiempo_preparacionContext(Context, State);
		EnterRule(_localctx, 8, RULE_tiempo_preparacion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 52;
			Match(TIEMPO_PREPARACION);
			State = 53;
			Match(SEP);
			State = 55;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NUM) {
				{
				State = 54;
				Match(NUM);
				}
			}

			State = 57;
			Match(SEP);
			State = 58;
			Match(TEXT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Tiempo_coccionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TIEMPO_COCCION() { return GetToken(recetaParserParser.TIEMPO_COCCION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEP() { return GetTokens(recetaParserParser.SEP); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP(int i) {
			return GetToken(recetaParserParser.SEP, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(recetaParserParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(recetaParserParser.NUM, 0); }
		public Tiempo_coccionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tiempo_coccion; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IrecetaParserVisitor<TResult> typedVisitor = visitor as IrecetaParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTiempo_coccion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Tiempo_coccionContext tiempo_coccion() {
		Tiempo_coccionContext _localctx = new Tiempo_coccionContext(Context, State);
		EnterRule(_localctx, 10, RULE_tiempo_coccion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 60;
			Match(TIEMPO_COCCION);
			State = 61;
			Match(SEP);
			State = 63;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NUM) {
				{
				State = 62;
				Match(NUM);
				}
			}

			State = 65;
			Match(SEP);
			State = 66;
			Match(TEXT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CaloriasContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CALORIAS() { return GetToken(recetaParserParser.CALORIAS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEP() { return GetTokens(recetaParserParser.SEP); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP(int i) {
			return GetToken(recetaParserParser.SEP, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(recetaParserParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(recetaParserParser.NUM, 0); }
		public CaloriasContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_calorias; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IrecetaParserVisitor<TResult> typedVisitor = visitor as IrecetaParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCalorias(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CaloriasContext calorias() {
		CaloriasContext _localctx = new CaloriasContext(Context, State);
		EnterRule(_localctx, 12, RULE_calorias);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 68;
			Match(CALORIAS);
			State = 69;
			Match(SEP);
			State = 71;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NUM) {
				{
				State = 70;
				Match(NUM);
				}
			}

			State = 73;
			Match(SEP);
			State = 74;
			Match(TEXT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IngredientesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INGREDIENTES() { return GetToken(recetaParserParser.INGREDIENTES, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] NUM() { return GetTokens(recetaParserParser.NUM); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM(int i) {
			return GetToken(recetaParserParser.NUM, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEP() { return GetTokens(recetaParserParser.SEP); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP(int i) {
			return GetToken(recetaParserParser.SEP, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] TEXT() { return GetTokens(recetaParserParser.TEXT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT(int i) {
			return GetToken(recetaParserParser.TEXT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMA() { return GetTokens(recetaParserParser.COMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMA(int i) {
			return GetToken(recetaParserParser.COMA, i);
		}
		public IngredientesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ingredientes; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IrecetaParserVisitor<TResult> typedVisitor = visitor as IrecetaParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIngredientes(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IngredientesContext ingredientes() {
		IngredientesContext _localctx = new IngredientesContext(Context, State);
		EnterRule(_localctx, 14, RULE_ingredientes);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 76;
			Match(INGREDIENTES);
			State = 85;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==NUM) {
				{
				{
				State = 77;
				Match(NUM);
				State = 78;
				Match(SEP);
				State = 79;
				Match(TEXT);
				State = 81;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==COMA) {
					{
					State = 80;
					Match(COMA);
					}
				}

				}
				}
				State = 87;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElaboracionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELABORACION() { return GetToken(recetaParserParser.ELABORACION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ORD() { return GetTokens(recetaParserParser.ORD); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ORD(int i) {
			return GetToken(recetaParserParser.ORD, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] TEXT() { return GetTokens(recetaParserParser.TEXT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT(int i) {
			return GetToken(recetaParserParser.TEXT, i);
		}
		public ElaboracionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elaboracion; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IrecetaParserVisitor<TResult> typedVisitor = visitor as IrecetaParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitElaboracion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ElaboracionContext elaboracion() {
		ElaboracionContext _localctx = new ElaboracionContext(Context, State);
		EnterRule(_localctx, 16, RULE_elaboracion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 88;
			Match(ELABORACION);
			State = 93;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==ORD) {
				{
				{
				State = 89;
				Match(ORD);
				State = 90;
				Match(TEXT);
				}
				}
				State = 95;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x12', '\x63', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x3', '\x2', '\x6', 
		'\x2', '\x16', '\n', '\x2', '\r', '\x2', '\xE', '\x2', '\x17', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x5', 
		'\x3', '\x1F', '\n', '\x3', '\x3', '\x3', '\x5', '\x3', '\"', '\n', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '+', '\n', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', 
		'\x32', '\n', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', ':', '\n', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x5', '\a', '\x42', '\n', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', 'J', '\n', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x5', '\t', 'T', '\n', '\t', '\a', '\t', 'V', 
		'\n', '\t', '\f', '\t', '\xE', '\t', 'Y', '\v', '\t', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\a', '\n', '^', '\n', '\n', '\f', '\n', '\xE', '\n', 
		'\x61', '\v', '\n', '\x3', '\n', '\x2', '\x2', '\v', '\x2', '\x4', '\x6', 
		'\b', '\n', '\f', '\xE', '\x10', '\x12', '\x2', '\x2', '\x2', '\x64', 
		'\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x4', '\x1B', '\x3', '\x2', 
		'\x2', '\x2', '\x6', '\'', '\x3', '\x2', '\x2', '\x2', '\b', '.', '\x3', 
		'\x2', '\x2', '\x2', '\n', '\x36', '\x3', '\x2', '\x2', '\x2', '\f', '>', 
		'\x3', '\x2', '\x2', '\x2', '\xE', '\x46', '\x3', '\x2', '\x2', '\x2', 
		'\x10', 'N', '\x3', '\x2', '\x2', '\x2', '\x12', 'Z', '\x3', '\x2', '\x2', 
		'\x2', '\x14', '\x16', '\x5', '\x4', '\x3', '\x2', '\x15', '\x14', '\x3', 
		'\x2', '\x2', '\x2', '\x16', '\x17', '\x3', '\x2', '\x2', '\x2', '\x17', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\x3', '\x2', '\x2', 
		'\x2', '\x18', '\x19', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1A', '\a', 
		'\x2', '\x2', '\x3', '\x1A', '\x3', '\x3', '\x2', '\x2', '\x2', '\x1B', 
		'\x1C', '\x5', '\x6', '\x4', '\x2', '\x1C', '\x1E', '\x5', '\b', '\x5', 
		'\x2', '\x1D', '\x1F', '\x5', '\n', '\x6', '\x2', '\x1E', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x1E', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		'!', '\x3', '\x2', '\x2', '\x2', ' ', '\"', '\x5', '\f', '\a', '\x2', 
		'!', ' ', '\x3', '\x2', '\x2', '\x2', '!', '\"', '\x3', '\x2', '\x2', 
		'\x2', '\"', '#', '\x3', '\x2', '\x2', '\x2', '#', '$', '\x5', '\xE', 
		'\b', '\x2', '$', '%', '\x5', '\x10', '\t', '\x2', '%', '&', '\x5', '\x12', 
		'\n', '\x2', '&', '\x5', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\a', 
		'\x3', '\x2', '\x2', '(', '*', '\a', '\n', '\x2', '\x2', ')', '+', '\a', 
		'\r', '\x2', '\x2', '*', ')', '\x3', '\x2', '\x2', '\x2', '*', '+', '\x3', 
		'\x2', '\x2', '\x2', '+', ',', '\x3', '\x2', '\x2', '\x2', ',', '-', '\a', 
		'\v', '\x2', '\x2', '-', '\a', '\x3', '\x2', '\x2', '\x2', '.', '/', '\a', 
		'\x4', '\x2', '\x2', '/', '\x31', '\a', '\n', '\x2', '\x2', '\x30', '\x32', 
		'\a', '\r', '\x2', '\x2', '\x31', '\x30', '\x3', '\x2', '\x2', '\x2', 
		'\x31', '\x32', '\x3', '\x2', '\x2', '\x2', '\x32', '\x33', '\x3', '\x2', 
		'\x2', '\x2', '\x33', '\x34', '\a', '\n', '\x2', '\x2', '\x34', '\x35', 
		'\a', '\v', '\x2', '\x2', '\x35', '\t', '\x3', '\x2', '\x2', '\x2', '\x36', 
		'\x37', '\a', '\x5', '\x2', '\x2', '\x37', '\x39', '\a', '\n', '\x2', 
		'\x2', '\x38', ':', '\a', '\r', '\x2', '\x2', '\x39', '\x38', '\x3', '\x2', 
		'\x2', '\x2', '\x39', ':', '\x3', '\x2', '\x2', '\x2', ':', ';', '\x3', 
		'\x2', '\x2', '\x2', ';', '<', '\a', '\n', '\x2', '\x2', '<', '=', '\a', 
		'\v', '\x2', '\x2', '=', '\v', '\x3', '\x2', '\x2', '\x2', '>', '?', '\a', 
		'\x6', '\x2', '\x2', '?', '\x41', '\a', '\n', '\x2', '\x2', '@', '\x42', 
		'\a', '\r', '\x2', '\x2', '\x41', '@', '\x3', '\x2', '\x2', '\x2', '\x41', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\x42', '\x43', '\x3', '\x2', '\x2', 
		'\x2', '\x43', '\x44', '\a', '\n', '\x2', '\x2', '\x44', '\x45', '\a', 
		'\v', '\x2', '\x2', '\x45', '\r', '\x3', '\x2', '\x2', '\x2', '\x46', 
		'G', '\a', '\b', '\x2', '\x2', 'G', 'I', '\a', '\n', '\x2', '\x2', 'H', 
		'J', '\a', '\r', '\x2', '\x2', 'I', 'H', '\x3', '\x2', '\x2', '\x2', 'I', 
		'J', '\x3', '\x2', '\x2', '\x2', 'J', 'K', '\x3', '\x2', '\x2', '\x2', 
		'K', 'L', '\a', '\n', '\x2', '\x2', 'L', 'M', '\a', '\v', '\x2', '\x2', 
		'M', '\xF', '\x3', '\x2', '\x2', '\x2', 'N', 'W', '\a', '\a', '\x2', '\x2', 
		'O', 'P', '\a', '\r', '\x2', '\x2', 'P', 'Q', '\a', '\n', '\x2', '\x2', 
		'Q', 'S', '\a', '\v', '\x2', '\x2', 'R', 'T', '\a', '\xF', '\x2', '\x2', 
		'S', 'R', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\x3', '\x2', '\x2', '\x2', 
		'T', 'V', '\x3', '\x2', '\x2', '\x2', 'U', 'O', '\x3', '\x2', '\x2', '\x2', 
		'V', 'Y', '\x3', '\x2', '\x2', '\x2', 'W', 'U', '\x3', '\x2', '\x2', '\x2', 
		'W', 'X', '\x3', '\x2', '\x2', '\x2', 'X', '\x11', '\x3', '\x2', '\x2', 
		'\x2', 'Y', 'W', '\x3', '\x2', '\x2', '\x2', 'Z', '_', '\a', '\t', '\x2', 
		'\x2', '[', '\\', '\a', '\xE', '\x2', '\x2', '\\', '^', '\a', '\v', '\x2', 
		'\x2', ']', '[', '\x3', '\x2', '\x2', '\x2', '^', '\x61', '\x3', '\x2', 
		'\x2', '\x2', '_', ']', '\x3', '\x2', '\x2', '\x2', '_', '`', '\x3', '\x2', 
		'\x2', '\x2', '`', '\x13', '\x3', '\x2', '\x2', '\x2', '\x61', '_', '\x3', 
		'\x2', '\x2', '\x2', '\r', '\x17', '\x1E', '!', '*', '\x31', '\x39', '\x41', 
		'I', 'S', 'W', '_',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}