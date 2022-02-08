//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:/Projects/metaproDev/CAPL_implementation/CaplGrammar\Capl.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace CaplGrammar.Core {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="CaplParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface ICaplVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimaryExpression([NotNull] CaplParser.PrimaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.topLevelSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTopLevelSection([NotNull] CaplParser.TopLevelSectionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.includeSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIncludeSection([NotNull] CaplParser.IncludeSectionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.variableSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableSection([NotNull] CaplParser.VariableSectionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.caplTypelessSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaplTypelessSection([NotNull] CaplParser.CaplTypelessSectionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.caplTypeSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaplTypeSection([NotNull] CaplParser.CaplTypeSectionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPostfixExpression([NotNull] CaplParser.PostfixExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.argumentExpressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgumentExpressionList([NotNull] CaplParser.ArgumentExpressionListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpression([NotNull] CaplParser.UnaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.unaryOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryOperator([NotNull] CaplParser.UnaryOperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.castExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCastExpression([NotNull] CaplParser.CastExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpression([NotNull] CaplParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpression([NotNull] CaplParser.AdditiveExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.shiftExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShiftExpression([NotNull] CaplParser.ShiftExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelationalExpression([NotNull] CaplParser.RelationalExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEqualityExpression([NotNull] CaplParser.EqualityExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndExpression([NotNull] CaplParser.AndExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.exclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExclusiveOrExpression([NotNull] CaplParser.ExclusiveOrExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.inclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInclusiveOrExpression([NotNull] CaplParser.InclusiveOrExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.logicalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalAndExpression([NotNull] CaplParser.LogicalAndExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.logicalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalOrExpression([NotNull] CaplParser.LogicalOrExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.conditionalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionalExpression([NotNull] CaplParser.ConditionalExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentExpression([NotNull] CaplParser.AssignmentExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentOperator([NotNull] CaplParser.AssignmentOperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] CaplParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.constantExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantExpression([NotNull] CaplParser.ConstantExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaration([NotNull] CaplParser.DeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.declarationSpecifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclarationSpecifiers([NotNull] CaplParser.DeclarationSpecifiersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.declarationSpecifiers2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclarationSpecifiers2([NotNull] CaplParser.DeclarationSpecifiers2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.typeQualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeQualifier([NotNull] CaplParser.TypeQualifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.functionSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionSpecifier([NotNull] CaplParser.FunctionSpecifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.declarationSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclarationSpecifier([NotNull] CaplParser.DeclarationSpecifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.initDeclaratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInitDeclaratorList([NotNull] CaplParser.InitDeclaratorListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.initDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInitDeclarator([NotNull] CaplParser.InitDeclaratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.typeSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeSpecifier([NotNull] CaplParser.TypeSpecifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.structSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructSpecifier([NotNull] CaplParser.StructSpecifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.structure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructure([NotNull] CaplParser.StructureContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.structDeclarationList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructDeclarationList([NotNull] CaplParser.StructDeclarationListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.structDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructDeclaration([NotNull] CaplParser.StructDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.specifierQualifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpecifierQualifierList([NotNull] CaplParser.SpecifierQualifierListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.structDeclaratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructDeclaratorList([NotNull] CaplParser.StructDeclaratorListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.structDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructDeclarator([NotNull] CaplParser.StructDeclaratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclarator([NotNull] CaplParser.DeclaratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.directDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirectDeclarator([NotNull] CaplParser.DirectDeclaratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.nestedParenthesesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNestedParenthesesBlock([NotNull] CaplParser.NestedParenthesesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.parameterTypeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterTypeList([NotNull] CaplParser.ParameterTypeListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] CaplParser.ParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.parameterDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterDeclaration([NotNull] CaplParser.ParameterDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.identifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierList([NotNull] CaplParser.IdentifierListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeName([NotNull] CaplParser.TypeNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.abstractDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAbstractDeclarator([NotNull] CaplParser.AbstractDeclaratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.directAbstractDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirectAbstractDeclarator([NotNull] CaplParser.DirectAbstractDeclaratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInitializer([NotNull] CaplParser.InitializerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.initializerList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInitializerList([NotNull] CaplParser.InitializerListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.designation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDesignation([NotNull] CaplParser.DesignationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.designatorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDesignatorList([NotNull] CaplParser.DesignatorListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.designator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDesignator([NotNull] CaplParser.DesignatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] CaplParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.labeledStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabeledStatement([NotNull] CaplParser.LabeledStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompoundStatement([NotNull] CaplParser.CompoundStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.blockItemList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockItemList([NotNull] CaplParser.BlockItemListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.blockItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockItem([NotNull] CaplParser.BlockItemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionStatement([NotNull] CaplParser.ExpressionStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.selectionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelectionStatement([NotNull] CaplParser.SelectionStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIterationStatement([NotNull] CaplParser.IterationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.forCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForCondition([NotNull] CaplParser.ForConditionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.forDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForDeclaration([NotNull] CaplParser.ForDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.forExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForExpression([NotNull] CaplParser.ForExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.jumpStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJumpStatement([NotNull] CaplParser.JumpStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.externalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExternalDeclaration([NotNull] CaplParser.ExternalDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDefinition([NotNull] CaplParser.FunctionDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.declarationList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclarationList([NotNull] CaplParser.DeclarationListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.enumSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumSpecifier([NotNull] CaplParser.EnumSpecifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.enumeratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumeratorList([NotNull] CaplParser.EnumeratorListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.enumerator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumerator([NotNull] CaplParser.EnumeratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.enumerationConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumerationConstant([NotNull] CaplParser.EnumerationConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.timerType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTimerType([NotNull] CaplParser.TimerTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.messageType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMessageType([NotNull] CaplParser.MessageTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.diagType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDiagType([NotNull] CaplParser.DiagTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.signalType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSignalType([NotNull] CaplParser.SignalTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.sysvarType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSysvarType([NotNull] CaplParser.SysvarTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.sysvarUpdateType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSysvarUpdateType([NotNull] CaplParser.SysvarUpdateTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.ethernetType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEthernetType([NotNull] CaplParser.EthernetTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CaplParser.keyEventType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyEventType([NotNull] CaplParser.KeyEventTypeContext context);
}
} // namespace CaplGrammar.Core
