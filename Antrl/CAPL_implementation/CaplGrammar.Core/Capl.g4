/** 
 CAPL grammar implementation.
 */

grammar Capl;

// The root parser node
primaryExpression:
	Identifier
	| AccessToSignalIdentifier
	| SysvarIdentifier
	| Constant
	| StringLiteral+
	| LeftParen expression RightParen
	| LeftParen compoundStatement RightParen
	| (
		includeSection
		| variableSection
		| keyEventSection
		| timerSection
		| errorFrameSection
		| errorActiveSection
		| errorPassiveSection
		| envSection
		| functionDefinition
		| enumSpecifier
		| structSpecifier
		| startSection
		| busOnSection
		| busOffSection
		| preStartSection
		| preStopSection
		| messageSection
		| onAnySection
		| stopMeasurementSection
		| diagSection
		| signalSection
		| sysvarSection
		| sysvarUpdateSection
		| ethernetSection
		| externalDeclaration
	)+;

/* Top CAPL's sections */
includeSection
    : Includes LeftBrace IncludeDirective* RightBrace
    ;

startSection
    : On Start LeftBrace blockItemList? RightBrace
    ;

busOnSection
    : On BusOn LeftBrace blockItemList? RightBrace
    ;

busOffSection
    : On BusOff LeftBrace blockItemList? RightBrace
    ;

preStartSection
    : On PreStart LeftBrace blockItemList? RightBrace
    ;

preStopSection
    : On PreStop LeftBrace blockItemList? RightBrace
    ;

variableSection
    : Variables LeftBrace blockItemList? RightBrace
    ;

keyEventSection
    : On keyEventType LeftBrace blockItemList? RightBrace
    ;

timerSection:
	On timerType (
		LeftParen (
			typeQualifier? typeSpecifier Identifier (
				Comma typeQualifier? typeSpecifier Identifier
			)*
		) RightParen
	)? LeftBrace blockItemList? RightBrace;

errorFrameSection
    : On ErrorFrame LeftBrace blockItemList? RightBrace
    ;

errorActiveSection
    : On ErrorActive LeftBrace blockItemList? RightBrace
    ;

errorPassiveSection
    : On ErrorPassive LeftBrace blockItemList? RightBrace
    ;

messageSection
    : On messageType LeftBrace blockItemList? RightBrace
    ;

onAnySection
    : On Identifier LeftBrace blockItemList? RightBrace
    ;

diagSection
    : On diagType LeftBrace blockItemList? RightBrace
    ;

signalSection
    : On signalType LeftBrace blockItemList? RightBrace
    ;

sysvarSection
    : On Sysvar2 sysvarType LeftBrace blockItemList? RightBrace
    ;
Sysvar2: [sS][yY][sS][vV][aA][rR];  // #SPIKE

sysvarUpdateSection
    : On SysvarUpdate sysvarUpdateType LeftBrace blockItemList? RightBrace
    ;

ethernetSection
    : On ethernetType LeftBrace blockItemList? RightBrace
    ;

stopMeasurementSection
    : On StopMeasurement LeftBrace blockItemList? RightBrace
    ;

envSection
    : On EnvVar Identifier LeftBrace blockItemList? RightBrace
	| On EnvVar LeftParen Identifier RightParen LeftBrace blockItemList? RightBrace
	;

/* Parser's syntax rules */
postfixExpression: (
		primaryExpression
		| LeftParen typeName RightParen LeftBrace initializerList Comma? RightBrace
	) (
		LeftBracket expression RightBracket
		| LeftParen argumentExpressionList? RightParen
		| (Dot | Arrow) Identifier
		| (PlusPlus | MinusMinus)
	)*;

argumentExpressionList: assignmentExpression (Comma assignmentExpression)*;

unaryExpression: (PlusPlus | MinusMinus)* (
		postfixExpression
		| unaryOperator castExpression
	);

unaryOperator: Plus | Minus | Tilde | Not;

castExpression:
	LeftParen typeName RightParen castExpression
	| unaryExpression
	| DigitSequence
	;

multiplicativeExpression: castExpression ((Star | Div | Mod) castExpression)*;

additiveExpression:
	multiplicativeExpression (
		(Plus | Minus) multiplicativeExpression
	)*;

shiftExpression:
	additiveExpression (
		(LeftShift | RightShift) additiveExpression
	)*;

relationalExpression:
	shiftExpression (
		(Less | Greater | LessEqual | GreaterEqual) shiftExpression
	)*;

equalityExpression:
	relationalExpression (
		(Equal | NotEqual) relationalExpression
	)*;

andExpression: equalityExpression ( And equalityExpression)*;

exclusiveOrExpression: andExpression (Caret andExpression)*;

inclusiveOrExpression: exclusiveOrExpression (Or exclusiveOrExpression)*;

logicalAndExpression: inclusiveOrExpression (AndAnd inclusiveOrExpression)*;

logicalOrExpression: logicalAndExpression (OrOr logicalAndExpression)*;

conditionalExpression:
	logicalOrExpression (
		Question expression Colon conditionalExpression
	)?;

assignmentExpression
    : conditionalExpression
	| unaryExpression assignmentOperator assignmentExpression
	| DigitSequence
	;

assignmentOperator
    : Assign
	| StarAssign
	| DivAssign
	| ModAssign
	| PlusAssign
	| MinusAssign
	| LeftShiftAssign
	| RightShiftAssign
	| AndAssign
	| XorAssign
	| OrAssign
	;

expression: assignmentExpression (Comma assignmentExpression)*;

constantExpression: conditionalExpression;

declaration: declarationSpecifiers initDeclaratorList? Semi;

declarationSpecifiers: declarationSpecifier+;

declarationSpecifiers2: declarationSpecifier+;

typeQualifier: Const;

functionSpecifier
    : (Testfunction)
    | ((Export)? Testcase)
    ;

declarationSpecifier
    : typeSpecifier
	| typeQualifier
	| functionSpecifier
	;

initDeclaratorList: initDeclarator (Comma initDeclarator)*;

initDeclarator: declarator (Assign initializer)?;

typeSpecifier: (
		Void
		| Char And?
		| Byte And?
		| Int And?
		| Long And?
		| Int64 And?
		| Float And?
		| Double And?
		| Word And?
		| Dword And?
		| Qword And?
		| Timer
		| MsTimer
		| structSpecifier And?
		| enumSpecifier And?
		| messageType
		| diagType
		| signalType
		| ethernetType);

structSpecifier
    : (Align0
	    | Align1
		| Align2
		| Align3
		| Align4
		| Align5
		| Align6
		| Align7
		| Align8
	)? (structure Identifier? LeftBrace structDeclarationList RightBrace
	    | structure Identifier);

structure: Struct;

structDeclarationList: structDeclaration+;

structDeclaration: specifierQualifierList structDeclaratorList? Semi;

specifierQualifierList: (typeSpecifier | typeQualifier) specifierQualifierList?;

structDeclaratorList: structDeclarator (Comma structDeclarator)*;

structDeclarator
    : declarator
	| declarator? Colon constantExpression;

declarator: directDeclarator;

directDeclarator
    : Identifier
	| LeftParen declarator RightParen
	| directDeclarator LeftBracket assignmentExpression? RightBracket
	| directDeclarator LeftParen parameterTypeList RightParen
	| directDeclarator LeftParen identifierList? RightParen
	;

nestedParenthesesBlock: (
		~(LeftParen | RightParen)
		| LeftParen nestedParenthesesBlock RightParen
	)*;

parameterTypeList: parameterList (Comma Ellipsis)?;

parameterList: parameterDeclaration (Comma parameterDeclaration)*;

parameterDeclaration
    : declarationSpecifiers declarator
	| declarationSpecifiers2 abstractDeclarator?;

identifierList: Identifier (Comma Identifier)*;

typeName: specifierQualifierList abstractDeclarator?;

abstractDeclarator: directAbstractDeclarator;

directAbstractDeclarator
    : LeftParen abstractDeclarator RightParen
	| LeftBracket assignmentExpression? RightBracket
	| LeftBracket Star RightBracket
	| LeftParen parameterTypeList? RightParen
	| directAbstractDeclarator LeftBracket assignmentExpression? RightBracket
	| directAbstractDeclarator LeftBracket Star RightBracket
	| directAbstractDeclarator LeftParen parameterTypeList? RightParen
	;

initializer
    : assignmentExpression
	| LeftBrace initializerList Comma? RightBrace;

initializerList: designation? initializer (Comma designation? initializer)*;

designation: designatorList Assign;

designatorList: designator+;

designator: LeftBracket constantExpression RightBracket;

statement
    : labeledStatement
	| compoundStatement
	| expressionStatement
	| selectionStatement
	| iterationStatement
	| jumpStatement;

labeledStatement
    : Identifier Colon statement
	| Case (constantExpression | KeyConstants) Colon statement
	| Default Colon statement;

compoundStatement: LeftBrace blockItemList? RightBrace;

blockItemList: blockItem+;

blockItem: statement | declaration;

expressionStatement: expression? Semi;

selectionStatement
    : If LeftParen expression RightParen statement (Else statement)?
	| Switch LeftParen expression RightParen statement
	;

iterationStatement
    : While LeftParen expression RightParen statement
	| Do statement While LeftParen expression RightParen Semi
	| For LeftParen forCondition RightParen statement
	;

forCondition: (forDeclaration | expression?) Semi forExpression? Semi forExpression?;

forDeclaration: declarationSpecifiers initDeclaratorList?;

forExpression: assignmentExpression (Comma assignmentExpression)*;

jumpStatement: ((Continue | Break) | Return expression?) Semi;

externalDeclaration
    : functionDefinition
    | declaration
    | Semi
    ;

functionDefinition: declarationSpecifiers? declarator declarationList? compoundStatement;

declarationList: declaration+;

/* Capl lexer and misc rules */

// Keywords
Export: [eE][xX][pP][oO][rR][tT];
Testcase: [tT][eE][sS][tT][cC][aA][sS][eE];
Testfunction: [tT][eE][sS][tT][fF][uU][nN][cC][tT][iI][oO][nN];
Includes: [iI][nN][cC][lL][uU][dD][eE][sS];
Const: [cC][oO][nN][sS][tT];
StopMeasurement: [sS][tT][oO][pP][mM][eE][aA][sS][uU][rR][eE][mM][eE][nN][tT];
SysvarUpdate: [sS][yY][sS][vV][aA][rR][_][uU][pP][dD][aA][tT][eE];
EthernetPacket: [eE][tT][hH][eE][rR][nN][eE][tT][pP][aA][cC][kK][eE][tT];
EthernetStatus: [eE][tT][hH][eE][rR][nN][eE][tT][sS][tT][aA][tT][uU][sS];
MostAmsMessage: [mM][oO][sS][tT][aA][mM][sS][mM][eE][sS][sS][aA][gG][eE];
MostMessage: [mM][oO][sS][tT][mM][eE][sS][sS][aA][gG][eE];
Start: [sS][tT][aA][rR][tT];
BusOn: [bB][uU][sS][oO][nN];
BusOff: [bB][uU][sS][oO][fF][fF];
PreStart: [pP][rR][eE][sS][tT][aA][rR][tT];
PreStop: [pP][rR][eE][sS][tT][oO][pP];
ErrorFrame: [eE][rR][rR][oO][rR][fF][rR][aA][mM][eE];
ErrorActive: [eE][rR][rR][oO][rR][aA][cC][tT][iI][vV][eE];
ErrorPassive: [eE][rR][rR][oO][rR][pP][aA][sS][sS][iI][vV][eE];
On: [oO][nN];
Variables: [vV][aA][rR][iI][aA][bB][lL][eE][sS];
Break: [bB][rR][eE][aA][kK];
Case: [cC][aA][sS][eE];
Char: [cC][hH][aA][rR];
Byte: [bB][yY][tT][eE];
Continue: [cC][oO][nN][tT][iI][nN][uU][eE];
Default: [dD][eE][fF][aA][uU][lL][tT];
Do: [dD][oO];
Double: [dD][oO][uU][bB][lL][eE];
Else: [eE][lL][sS][eE];
Float: [fF][lL][oO][aA][tT];
For: [fF][oO][rR];
If: [iI][fF];
Int: [iI][nN][tT];
Word: [wW][oO][rR][dD];
Dword: [dD][wW][oO][rR][dD];
Qword: [qQ][wW][oO][rR][dD];
EnvVar: [eE][nN][vV][vV][aA][rR];
MsTimer: [mM][sS][tT][iI][mM][eE][rR];
Long: [lL][oO][nN][gG];
Int64: [iI][nN][tT][6][4];
Return: [rR][eE][tT][uU][rR][nN];
Switch: [sS][wW][iI][tT][cC][hH];
Void: [vV][oO][iI][dD];
While: [wW][hH][iI][lL][eE];
Struct: [sS][tT][rR][uU][cC][tT];

enumSpecifier
    : Enum Identifier? LeftBrace enumeratorList Comma? RightBrace Semi?
	| Enum Identifier
	;
Enum: [eE][nN][uU][mM];

enumeratorList: enumerator (Comma enumerator)*;

enumerator: enumerationConstant (Assign constantExpression)?;

enumerationConstant: Identifier;

timerType: Timer Identifier (Dot (Identifier | Star))?;
Timer: [Tt][iI][mM][eE][rR];

messageType
    : (Message
        | MultiplexedMessage
        | MostMessage
        | MostAmsMessage)
    (Identifier (Dot (Identifier | Star))? (Comma Identifier (Dot (Identifier | Star))?)*
        | Star
        | Constant
        | Identifier (Minus | DoubleColon)? Identifier
        | MessageHexConst (Minus MessageHexConst)?
        | Constant (Minus Constant)?
        | Identifier Minus Whitespace? Constant)
	;
Message: [mM][eE][sS][sS][aA][gG][eE];
MultiplexedMessage: [mM][uU][lL][tT][iI][pP][lL][eE][xX][eE][dD][_][mM][eE][sS][sS][aA][gG][eE];

diagType
    : (DiagRequest
        | DiagResponse)
	(Identifier ((Dot | DoubleColon) (Identifier | Star))?
	    | Star
	    | Constant
	    | Identifier Minus Identifier)
	;
DiagRequest: [dD][iI][aA][gG][rR][eE][qQ][uU][eE][sS][tT];
DiagResponse: [dD][iI][aA][gG][rR][eE][sS][pP][oO][nN][sS][eE];

signalType
    : Signal
    (
        Identifier ((Dot | DoubleColon) (Identifier | Star))?
        | Star
        | Constant
        | Identifier Minus Identifier
    )
    ;
Signal: [sS][iI][gG][nN][aA][lL];

sysvarType
    : (Sysvar DoubleColon)?
       Identifier (DoubleColon Identifier)*
    ;

sysvarUpdateType
    : (Sysvar Whitespace? DoubleColon)?
       Identifier (DoubleColon Identifier)*
    ;

ethernetType
    : (EthernetPacket
        | EthernetStatus)
    (Identifier (Dot (Identifier | Star))?
        | Star
        | Constant
        | Identifier (Minus | DoubleColon)? Identifier)
    ;

keyEventType: Key (Constant | KeyConstants | Star);

KeyConstants: (
		F1Key
		| F2Key
		| F3Key
		| F4Key
		| F5Key
		| F6Key
		| F7Key
		| F8Key
		| F9Key
		| F10Key
		| F11Key
		| F12Key
		| CtrlF1Key
		| CtrlF2Key
		| CtrlF3Key
		| CtrlF4Key
		| CtrlF5Key
		| CtrlF6Key
		| CtrlF7Key
		| CtrlF8Key
		| CtrlF9Key
		| CtrlF10Key
		| CtrlF11Key
		| CtrlF12Key
		| PageUpKey
		| PageDownKey
		| HomeKey
		| EndKey
		| CursorUp
		| CursorDown
		| CursorRight
		| CursorLeft
		| CtrlCursorUp
		| CtrlCursorDown
		| CtrlCursorRight
		| CtrlCursorLeft
	);
Key: [kK][eE][yY];
F1Key: [fF][1];
F2Key: [fF][2];
F3Key: [fF][3];
F4Key: [fF][4];
F5Key: [fF][5];
F6Key: [fF][6];
F7Key: [fF][7];
F8Key: [fF][8];
F9Key: [fF][9];
F10Key: [fF][1][0];
F11Key: [fF][1][1];
F12Key: [fF][1][2];
CtrlF1Key: [cC][tT][rR][lL][fF][1];
CtrlF2Key: [cC][tT][rR][lL][fF][2];
CtrlF3Key: [cC][tT][rR][lL][fF][3];
CtrlF4Key: [cC][tT][rR][lL][fF][4];
CtrlF5Key: [cC][tT][rR][lL][fF][5];
CtrlF6Key: [cC][tT][rR][lL][fF][6];
CtrlF7Key: [cC][tT][rR][lL][fF][7];
CtrlF8Key: [cC][tT][rR][lL][fF][8];
CtrlF9Key: [cC][tT][rR][lL][fF][9];
CtrlF10Key: [cC][tT][rR][lL][fF][1][0];
CtrlF11Key: [cC][tT][rR][lL][fF][1][1];
CtrlF12Key: [cC][tT][rR][lL][fF][1][2];
PageUpKey: [pP][aA][gG][eE][uU][pP];
PageDownKey: [pP][aA][gG][eE][dD][oO][wW][nN];
HomeKey: [hH][oO][mM][eE];
EndKey: ('End') | ([eN][nN][dD]);   // #SPIKE
CursorLeft: [cC][uU][rR][sS][oO][rR][lL][eE][fF][tT];
CursorRight: [cC][uU][rR][sS][oO][rR][rR][iI][gG][hH][tT];
CursorDown: [cC][uU][rR][sS][oO][rR][dD][oO][wW][nN];
CursorUp: [cC][uU][rR][sS][oO][rR][uU][pP];
CtrlCursorLeft: [cC][tT][rR][lL][cC][uU][rR][sS][oO][rR][lL][eE][fF][tT];
CtrlCursorDown: [cC][tT][rR][lL][cC][uU][rR][sS][oO][rR][dD][oO][wW][nN];
CtrlCursorUp: [cC][tT][rR][lL][cC][uU][rR][sS][oO][rR][uU][pP];
CtrlCursorRight: [cC][tT][rR][lL][cC][uU][rR][sS][oO][rR][rR][iI][gG][hH][tT];
Align8: [_][aA][lL][iI][gG][nN][(][8][)];
Align7: [_][aA][lL][iI][gG][nN][(][7][)];
Align6: [_][aA][lL][iI][gG][nN][(][6][)];
Align5: [_][aA][lL][iI][gG][nN][(][5][)];
Align4: [_][aA][lL][iI][gG][nN][(][4][)];
Align3: [_][aA][lL][iI][gG][nN][(][3][)];
Align2: [_][aA][lL][iI][gG][nN][(][2][)];
Align1: [_][aA][lL][iI][gG][nN][(][1][)];
Align0: [_][aA][lL][iI][gG][nN][(][0][)];

Identifier
    : (SimpleId
	| DotThisId
	| DotConstId
	| DoubleColonId
	| SysVarId
	| ArrayAccessId
	| ByteAccessIndexerId);

ByteAccessIndexerId: Byte LeftParen DigitSequence RightParen;

ArrayAccessId: (SimpleId | SysvarIdentifier) Whitespace? (
		LeftBracket Whitespace? (
			SimpleId
			| DigitSequence
			| SysvarIdentifier
		) Whitespace? RightBracket
	)+ (
		Whitespace? Dot Whitespace? (SimpleId | SysvarIdentifier)
	)*;

DoubleColonId: (IdentifierNondigit (IdentifierNondigit | Digit)*) (
		DoubleColon (
			IdentifierNondigit (IdentifierNondigit | Digit)*
		)
	)*;

DotConstId: IdentifierNondigit (IdentifierNondigit | Digit)* Dot Constant;

DotThisId: (
		(This | IdentifierNondigit) (IdentifierNondigit | Digit)*
	) Whitespace? Dot Whitespace? Identifier (Dot (Identifier))*;

SimpleId: IdentifierNondigit (IdentifierNondigit | Digit)*;

SysVarId:
	Sysvar (
		DoubleColon IdentifierNondigit (
			IdentifierNondigit
			| Digit
		)*
	)+;

AccessToSignalIdentifier:
	Dollar Whitespace? Identifier (
		Phys
		| Raw
		| Raw64
		| Rx
		| TxRequest
	)?;

SysvarIdentifier
    : AtSign Whitespace? Sysvar? Whitespace? ( DoubleColon Whitespace? Identifier)*
	| AtSign Whitespace? Identifier Whitespace? (DoubleColon Whitespace? Identifier
	)*;

fragment IdentifierNondigit: Nondigit | UniversalCharacterName;

fragment Nondigit: [a-zA-Z_];

fragment Digit: [0-9];

fragment UniversalCharacterName:
	'\\u' HexQuad
	| '\\U' HexQuad HexQuad;

fragment HexQuad:
	HexadecimalDigit HexadecimalDigit HexadecimalDigit HexadecimalDigit;

Constant
    : IntegerConstant
	| FloatingConstant
	| CharacterConstant
	| MessageHexConst
	;

MessageHexConst: HexadecimalPrefix HexadecimalDigitSequence ([xX])?;

fragment IntegerConstant
    : DecimalConstant IntegerSuffix?
	| OctalConstant IntegerSuffix?
	| HexadecimalConstant IntegerSuffix?
	| BinaryConstant
	;

fragment BinaryConstant: '0' [bB] [0-1]+;

fragment DecimalConstant: NonzeroDigit Digit*;

fragment OctalConstant: '0' OctalDigit*;

fragment HexadecimalConstant: HexadecimalPrefix HexadecimalDigit+;

fragment HexadecimalPrefix: '0' [xX];

fragment NonzeroDigit: [1-9];

fragment OctalDigit: [0-7];

fragment HexadecimalDigit: [0-9a-fA-F];

fragment IntegerSuffix: LongSuffix | LongLongSuffix;

fragment LongSuffix: [lL];

fragment LongLongSuffix: 'll' | 'LL';

fragment FloatingConstant:
	DecimalFloatingConstant
	| HexadecimalFloatingConstant;

fragment DecimalFloatingConstant:
	FractionalConstant ExponentPart? FloatingSuffix?
	| DigitSequence ExponentPart FloatingSuffix?;

fragment HexadecimalFloatingConstant:
	HexadecimalPrefix (
		HexadecimalFractionalConstant
		| HexadecimalDigitSequence
	) BinaryExponentPart FloatingSuffix?;

fragment FractionalConstant:
	DigitSequence? Dot DigitSequence
	| DigitSequence Dot;

fragment ExponentPart: [eE] Sign? DigitSequence;

fragment Sign: [+-];

DigitSequence: Digit+;

fragment HexadecimalFractionalConstant:
	HexadecimalDigitSequence? Dot HexadecimalDigitSequence
	| HexadecimalDigitSequence Dot;

fragment BinaryExponentPart: [pP] Sign? DigitSequence;

fragment HexadecimalDigitSequence: HexadecimalDigit+;

fragment FloatingSuffix: [flFL];

fragment CharacterConstant:
	'\'' CCharSequence '\''
	| 'L\'' CCharSequence '\''
	| 'u\'' CCharSequence '\''
	| 'U\'' CCharSequence '\'';

fragment CCharSequence: CChar+;

fragment CChar: ~['\\\r\n] | EscapeSequence;

fragment EscapeSequence:
	SimpleEscapeSequence
	| OctalEscapeSequence
	| HexadecimalEscapeSequence
	| UniversalCharacterName;

fragment SimpleEscapeSequence: '\\' ['"?abfnrtv\\];

fragment OctalEscapeSequence:
	'\\' OctalDigit OctalDigit? OctalDigit?;

fragment HexadecimalEscapeSequence: '\\x' HexadecimalDigit+;

StringLiteral: EncodingPrefix? '"' SCharSequence? '"';

fragment EncodingPrefix: 'u8' | 'u' | 'U' | 'L';

fragment SCharSequence: SChar+;

fragment SChar:
	~["\\\r\n]
	| EscapeSequence
	| '\\\n' // Added line
	| '\\\r\n' ; // Added line

/* Directives go to hidden channel */
IncludeDirective:
	Hash Whitespace? Include Whitespace? (
		('"' ~[\r\n]* '"')
		| (Less ~[\r\n]* Greater)
	) Whitespace? Newline -> channel(HIDDEN);

Directive: Hash ~ [\n]* -> channel (HIDDEN);

/* Tokens */
Less: '<';
Greater: '>';
Hash: '#';
Arrow: '->';
Dot: '.';
DoubleColon: '::';
AtSign: '@';
Or: '|';
Dollar: '$';
And: '&';
LeftParen: '(';
RightParen: ')';
LessEqual: '<=';
GreaterEqual: '>=';
LeftShift: '<<';
RightShift: '>>';
Plus: '+';
PlusPlus: '++';
MinusMinus: '--';
Div: '/';
Mod: '%';
AndAnd: '&&';
OrOr: '||';
Caret: '^';
Not: '!';
Tilde: '~';
Question: '?';
Colon: ':';
StarAssign: '*=';
DivAssign: '/=';
ModAssign: '%=';
PlusAssign: '+=';
MinusAssign: '-=';
LeftShiftAssign: '<<=';
RightShiftAssign: '>>=';
AndAssign: '&=';
XorAssign: '^=';
OrAssign: '|=';
Equal: '==';
NotEqual: '!=';
Ellipsis: '...';
LeftBrace: '{';
RightBrace: '}';
Semi: ';';
Assign: '=';
Comma: ',';
Minus: '-';
Star: '*';
LeftBracket: '[';
RightBracket: ']';

/* Other keywords */
Include: [iI][nN][cC][lL][uU][dD][eE];
This: [tT][hH][iI][sS];
Sysvar: [sS][yY][sS][vV][aA][rR];
Phys: [pP][hH][yY][sS];
Raw: [rR][aA][wW];
Raw64: [rR][aA][wW][6][4];
Rx: [rR][xX];
TxRequest: [tT][xX][rR][qQ];

/* Skip whitespaces */
Whitespace: [ \t]+ -> skip;
Newline: ( '\r' '\n'? | '\n') -> skip;
BlockComment: '/*' .*? '*/' -> skip;
LineComment: '//' ~[\r\n]* -> skip;