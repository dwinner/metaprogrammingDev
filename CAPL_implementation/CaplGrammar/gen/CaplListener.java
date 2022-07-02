// Generated from G:/metaproDev/CAPL_implementation/CaplGrammar\Capl.g4 by ANTLR 4.10.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link CaplParser}.
 */
public interface CaplListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link CaplParser#primaryExpression}.
	 * @param ctx the parse tree
	 */
	void enterPrimaryExpression(CaplParser.PrimaryExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#primaryExpression}.
	 * @param ctx the parse tree
	 */
	void exitPrimaryExpression(CaplParser.PrimaryExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#includeSection}.
	 * @param ctx the parse tree
	 */
	void enterIncludeSection(CaplParser.IncludeSectionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#includeSection}.
	 * @param ctx the parse tree
	 */
	void exitIncludeSection(CaplParser.IncludeSectionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#variableSection}.
	 * @param ctx the parse tree
	 */
	void enterVariableSection(CaplParser.VariableSectionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#variableSection}.
	 * @param ctx the parse tree
	 */
	void exitVariableSection(CaplParser.VariableSectionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#caplTypelessSection}.
	 * @param ctx the parse tree
	 */
	void enterCaplTypelessSection(CaplParser.CaplTypelessSectionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#caplTypelessSection}.
	 * @param ctx the parse tree
	 */
	void exitCaplTypelessSection(CaplParser.CaplTypelessSectionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#caplTypeSection}.
	 * @param ctx the parse tree
	 */
	void enterCaplTypeSection(CaplParser.CaplTypeSectionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#caplTypeSection}.
	 * @param ctx the parse tree
	 */
	void exitCaplTypeSection(CaplParser.CaplTypeSectionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#postfixExpression}.
	 * @param ctx the parse tree
	 */
	void enterPostfixExpression(CaplParser.PostfixExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#postfixExpression}.
	 * @param ctx the parse tree
	 */
	void exitPostfixExpression(CaplParser.PostfixExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#argumentExpressionList}.
	 * @param ctx the parse tree
	 */
	void enterArgumentExpressionList(CaplParser.ArgumentExpressionListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#argumentExpressionList}.
	 * @param ctx the parse tree
	 */
	void exitArgumentExpressionList(CaplParser.ArgumentExpressionListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#unaryExpression}.
	 * @param ctx the parse tree
	 */
	void enterUnaryExpression(CaplParser.UnaryExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#unaryExpression}.
	 * @param ctx the parse tree
	 */
	void exitUnaryExpression(CaplParser.UnaryExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#unaryOperator}.
	 * @param ctx the parse tree
	 */
	void enterUnaryOperator(CaplParser.UnaryOperatorContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#unaryOperator}.
	 * @param ctx the parse tree
	 */
	void exitUnaryOperator(CaplParser.UnaryOperatorContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#castExpression}.
	 * @param ctx the parse tree
	 */
	void enterCastExpression(CaplParser.CastExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#castExpression}.
	 * @param ctx the parse tree
	 */
	void exitCastExpression(CaplParser.CastExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#multiplicativeExpression}.
	 * @param ctx the parse tree
	 */
	void enterMultiplicativeExpression(CaplParser.MultiplicativeExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#multiplicativeExpression}.
	 * @param ctx the parse tree
	 */
	void exitMultiplicativeExpression(CaplParser.MultiplicativeExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#additiveExpression}.
	 * @param ctx the parse tree
	 */
	void enterAdditiveExpression(CaplParser.AdditiveExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#additiveExpression}.
	 * @param ctx the parse tree
	 */
	void exitAdditiveExpression(CaplParser.AdditiveExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#shiftExpression}.
	 * @param ctx the parse tree
	 */
	void enterShiftExpression(CaplParser.ShiftExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#shiftExpression}.
	 * @param ctx the parse tree
	 */
	void exitShiftExpression(CaplParser.ShiftExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#relationalExpression}.
	 * @param ctx the parse tree
	 */
	void enterRelationalExpression(CaplParser.RelationalExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#relationalExpression}.
	 * @param ctx the parse tree
	 */
	void exitRelationalExpression(CaplParser.RelationalExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#equalityExpression}.
	 * @param ctx the parse tree
	 */
	void enterEqualityExpression(CaplParser.EqualityExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#equalityExpression}.
	 * @param ctx the parse tree
	 */
	void exitEqualityExpression(CaplParser.EqualityExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#andExpression}.
	 * @param ctx the parse tree
	 */
	void enterAndExpression(CaplParser.AndExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#andExpression}.
	 * @param ctx the parse tree
	 */
	void exitAndExpression(CaplParser.AndExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#exclusiveOrExpression}.
	 * @param ctx the parse tree
	 */
	void enterExclusiveOrExpression(CaplParser.ExclusiveOrExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#exclusiveOrExpression}.
	 * @param ctx the parse tree
	 */
	void exitExclusiveOrExpression(CaplParser.ExclusiveOrExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#inclusiveOrExpression}.
	 * @param ctx the parse tree
	 */
	void enterInclusiveOrExpression(CaplParser.InclusiveOrExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#inclusiveOrExpression}.
	 * @param ctx the parse tree
	 */
	void exitInclusiveOrExpression(CaplParser.InclusiveOrExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#logicalAndExpression}.
	 * @param ctx the parse tree
	 */
	void enterLogicalAndExpression(CaplParser.LogicalAndExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#logicalAndExpression}.
	 * @param ctx the parse tree
	 */
	void exitLogicalAndExpression(CaplParser.LogicalAndExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#logicalOrExpression}.
	 * @param ctx the parse tree
	 */
	void enterLogicalOrExpression(CaplParser.LogicalOrExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#logicalOrExpression}.
	 * @param ctx the parse tree
	 */
	void exitLogicalOrExpression(CaplParser.LogicalOrExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#conditionalExpression}.
	 * @param ctx the parse tree
	 */
	void enterConditionalExpression(CaplParser.ConditionalExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#conditionalExpression}.
	 * @param ctx the parse tree
	 */
	void exitConditionalExpression(CaplParser.ConditionalExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#assignmentExpression}.
	 * @param ctx the parse tree
	 */
	void enterAssignmentExpression(CaplParser.AssignmentExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#assignmentExpression}.
	 * @param ctx the parse tree
	 */
	void exitAssignmentExpression(CaplParser.AssignmentExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#assignmentOperator}.
	 * @param ctx the parse tree
	 */
	void enterAssignmentOperator(CaplParser.AssignmentOperatorContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#assignmentOperator}.
	 * @param ctx the parse tree
	 */
	void exitAssignmentOperator(CaplParser.AssignmentOperatorContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterExpression(CaplParser.ExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitExpression(CaplParser.ExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#constantExpression}.
	 * @param ctx the parse tree
	 */
	void enterConstantExpression(CaplParser.ConstantExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#constantExpression}.
	 * @param ctx the parse tree
	 */
	void exitConstantExpression(CaplParser.ConstantExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#declaration}.
	 * @param ctx the parse tree
	 */
	void enterDeclaration(CaplParser.DeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#declaration}.
	 * @param ctx the parse tree
	 */
	void exitDeclaration(CaplParser.DeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#declarationSpecifiers}.
	 * @param ctx the parse tree
	 */
	void enterDeclarationSpecifiers(CaplParser.DeclarationSpecifiersContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#declarationSpecifiers}.
	 * @param ctx the parse tree
	 */
	void exitDeclarationSpecifiers(CaplParser.DeclarationSpecifiersContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#declarationSpecifiers2}.
	 * @param ctx the parse tree
	 */
	void enterDeclarationSpecifiers2(CaplParser.DeclarationSpecifiers2Context ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#declarationSpecifiers2}.
	 * @param ctx the parse tree
	 */
	void exitDeclarationSpecifiers2(CaplParser.DeclarationSpecifiers2Context ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#typeQualifier}.
	 * @param ctx the parse tree
	 */
	void enterTypeQualifier(CaplParser.TypeQualifierContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#typeQualifier}.
	 * @param ctx the parse tree
	 */
	void exitTypeQualifier(CaplParser.TypeQualifierContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#functionSpecifier}.
	 * @param ctx the parse tree
	 */
	void enterFunctionSpecifier(CaplParser.FunctionSpecifierContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#functionSpecifier}.
	 * @param ctx the parse tree
	 */
	void exitFunctionSpecifier(CaplParser.FunctionSpecifierContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#declarationSpecifier}.
	 * @param ctx the parse tree
	 */
	void enterDeclarationSpecifier(CaplParser.DeclarationSpecifierContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#declarationSpecifier}.
	 * @param ctx the parse tree
	 */
	void exitDeclarationSpecifier(CaplParser.DeclarationSpecifierContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#initDeclaratorList}.
	 * @param ctx the parse tree
	 */
	void enterInitDeclaratorList(CaplParser.InitDeclaratorListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#initDeclaratorList}.
	 * @param ctx the parse tree
	 */
	void exitInitDeclaratorList(CaplParser.InitDeclaratorListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#initDeclarator}.
	 * @param ctx the parse tree
	 */
	void enterInitDeclarator(CaplParser.InitDeclaratorContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#initDeclarator}.
	 * @param ctx the parse tree
	 */
	void exitInitDeclarator(CaplParser.InitDeclaratorContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#typeSpecifier}.
	 * @param ctx the parse tree
	 */
	void enterTypeSpecifier(CaplParser.TypeSpecifierContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#typeSpecifier}.
	 * @param ctx the parse tree
	 */
	void exitTypeSpecifier(CaplParser.TypeSpecifierContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#structSpecifier}.
	 * @param ctx the parse tree
	 */
	void enterStructSpecifier(CaplParser.StructSpecifierContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#structSpecifier}.
	 * @param ctx the parse tree
	 */
	void exitStructSpecifier(CaplParser.StructSpecifierContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#structure}.
	 * @param ctx the parse tree
	 */
	void enterStructure(CaplParser.StructureContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#structure}.
	 * @param ctx the parse tree
	 */
	void exitStructure(CaplParser.StructureContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#structDeclarationList}.
	 * @param ctx the parse tree
	 */
	void enterStructDeclarationList(CaplParser.StructDeclarationListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#structDeclarationList}.
	 * @param ctx the parse tree
	 */
	void exitStructDeclarationList(CaplParser.StructDeclarationListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#structDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterStructDeclaration(CaplParser.StructDeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#structDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitStructDeclaration(CaplParser.StructDeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#specifierQualifierList}.
	 * @param ctx the parse tree
	 */
	void enterSpecifierQualifierList(CaplParser.SpecifierQualifierListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#specifierQualifierList}.
	 * @param ctx the parse tree
	 */
	void exitSpecifierQualifierList(CaplParser.SpecifierQualifierListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#structDeclaratorList}.
	 * @param ctx the parse tree
	 */
	void enterStructDeclaratorList(CaplParser.StructDeclaratorListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#structDeclaratorList}.
	 * @param ctx the parse tree
	 */
	void exitStructDeclaratorList(CaplParser.StructDeclaratorListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#structDeclarator}.
	 * @param ctx the parse tree
	 */
	void enterStructDeclarator(CaplParser.StructDeclaratorContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#structDeclarator}.
	 * @param ctx the parse tree
	 */
	void exitStructDeclarator(CaplParser.StructDeclaratorContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#declarator}.
	 * @param ctx the parse tree
	 */
	void enterDeclarator(CaplParser.DeclaratorContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#declarator}.
	 * @param ctx the parse tree
	 */
	void exitDeclarator(CaplParser.DeclaratorContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#directDeclarator}.
	 * @param ctx the parse tree
	 */
	void enterDirectDeclarator(CaplParser.DirectDeclaratorContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#directDeclarator}.
	 * @param ctx the parse tree
	 */
	void exitDirectDeclarator(CaplParser.DirectDeclaratorContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#nestedParenthesesBlock}.
	 * @param ctx the parse tree
	 */
	void enterNestedParenthesesBlock(CaplParser.NestedParenthesesBlockContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#nestedParenthesesBlock}.
	 * @param ctx the parse tree
	 */
	void exitNestedParenthesesBlock(CaplParser.NestedParenthesesBlockContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#parameterTypeList}.
	 * @param ctx the parse tree
	 */
	void enterParameterTypeList(CaplParser.ParameterTypeListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#parameterTypeList}.
	 * @param ctx the parse tree
	 */
	void exitParameterTypeList(CaplParser.ParameterTypeListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#parameterList}.
	 * @param ctx the parse tree
	 */
	void enterParameterList(CaplParser.ParameterListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#parameterList}.
	 * @param ctx the parse tree
	 */
	void exitParameterList(CaplParser.ParameterListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#parameterDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterParameterDeclaration(CaplParser.ParameterDeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#parameterDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitParameterDeclaration(CaplParser.ParameterDeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#identifierList}.
	 * @param ctx the parse tree
	 */
	void enterIdentifierList(CaplParser.IdentifierListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#identifierList}.
	 * @param ctx the parse tree
	 */
	void exitIdentifierList(CaplParser.IdentifierListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#typeName}.
	 * @param ctx the parse tree
	 */
	void enterTypeName(CaplParser.TypeNameContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#typeName}.
	 * @param ctx the parse tree
	 */
	void exitTypeName(CaplParser.TypeNameContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#abstractDeclarator}.
	 * @param ctx the parse tree
	 */
	void enterAbstractDeclarator(CaplParser.AbstractDeclaratorContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#abstractDeclarator}.
	 * @param ctx the parse tree
	 */
	void exitAbstractDeclarator(CaplParser.AbstractDeclaratorContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#directAbstractDeclarator}.
	 * @param ctx the parse tree
	 */
	void enterDirectAbstractDeclarator(CaplParser.DirectAbstractDeclaratorContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#directAbstractDeclarator}.
	 * @param ctx the parse tree
	 */
	void exitDirectAbstractDeclarator(CaplParser.DirectAbstractDeclaratorContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#initializer}.
	 * @param ctx the parse tree
	 */
	void enterInitializer(CaplParser.InitializerContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#initializer}.
	 * @param ctx the parse tree
	 */
	void exitInitializer(CaplParser.InitializerContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#initializerList}.
	 * @param ctx the parse tree
	 */
	void enterInitializerList(CaplParser.InitializerListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#initializerList}.
	 * @param ctx the parse tree
	 */
	void exitInitializerList(CaplParser.InitializerListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#designation}.
	 * @param ctx the parse tree
	 */
	void enterDesignation(CaplParser.DesignationContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#designation}.
	 * @param ctx the parse tree
	 */
	void exitDesignation(CaplParser.DesignationContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#designatorList}.
	 * @param ctx the parse tree
	 */
	void enterDesignatorList(CaplParser.DesignatorListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#designatorList}.
	 * @param ctx the parse tree
	 */
	void exitDesignatorList(CaplParser.DesignatorListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#designator}.
	 * @param ctx the parse tree
	 */
	void enterDesignator(CaplParser.DesignatorContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#designator}.
	 * @param ctx the parse tree
	 */
	void exitDesignator(CaplParser.DesignatorContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#statement}.
	 * @param ctx the parse tree
	 */
	void enterStatement(CaplParser.StatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#statement}.
	 * @param ctx the parse tree
	 */
	void exitStatement(CaplParser.StatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#labeledStatement}.
	 * @param ctx the parse tree
	 */
	void enterLabeledStatement(CaplParser.LabeledStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#labeledStatement}.
	 * @param ctx the parse tree
	 */
	void exitLabeledStatement(CaplParser.LabeledStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#compoundStatement}.
	 * @param ctx the parse tree
	 */
	void enterCompoundStatement(CaplParser.CompoundStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#compoundStatement}.
	 * @param ctx the parse tree
	 */
	void exitCompoundStatement(CaplParser.CompoundStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#blockItemList}.
	 * @param ctx the parse tree
	 */
	void enterBlockItemList(CaplParser.BlockItemListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#blockItemList}.
	 * @param ctx the parse tree
	 */
	void exitBlockItemList(CaplParser.BlockItemListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#blockItem}.
	 * @param ctx the parse tree
	 */
	void enterBlockItem(CaplParser.BlockItemContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#blockItem}.
	 * @param ctx the parse tree
	 */
	void exitBlockItem(CaplParser.BlockItemContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#expressionStatement}.
	 * @param ctx the parse tree
	 */
	void enterExpressionStatement(CaplParser.ExpressionStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#expressionStatement}.
	 * @param ctx the parse tree
	 */
	void exitExpressionStatement(CaplParser.ExpressionStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#selectionStatement}.
	 * @param ctx the parse tree
	 */
	void enterSelectionStatement(CaplParser.SelectionStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#selectionStatement}.
	 * @param ctx the parse tree
	 */
	void exitSelectionStatement(CaplParser.SelectionStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#iterationStatement}.
	 * @param ctx the parse tree
	 */
	void enterIterationStatement(CaplParser.IterationStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#iterationStatement}.
	 * @param ctx the parse tree
	 */
	void exitIterationStatement(CaplParser.IterationStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#forCondition}.
	 * @param ctx the parse tree
	 */
	void enterForCondition(CaplParser.ForConditionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#forCondition}.
	 * @param ctx the parse tree
	 */
	void exitForCondition(CaplParser.ForConditionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#forDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterForDeclaration(CaplParser.ForDeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#forDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitForDeclaration(CaplParser.ForDeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#forExpression}.
	 * @param ctx the parse tree
	 */
	void enterForExpression(CaplParser.ForExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#forExpression}.
	 * @param ctx the parse tree
	 */
	void exitForExpression(CaplParser.ForExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#jumpStatement}.
	 * @param ctx the parse tree
	 */
	void enterJumpStatement(CaplParser.JumpStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#jumpStatement}.
	 * @param ctx the parse tree
	 */
	void exitJumpStatement(CaplParser.JumpStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#compilationUnit}.
	 * @param ctx the parse tree
	 */
	void enterCompilationUnit(CaplParser.CompilationUnitContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#compilationUnit}.
	 * @param ctx the parse tree
	 */
	void exitCompilationUnit(CaplParser.CompilationUnitContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#translationUnit}.
	 * @param ctx the parse tree
	 */
	void enterTranslationUnit(CaplParser.TranslationUnitContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#translationUnit}.
	 * @param ctx the parse tree
	 */
	void exitTranslationUnit(CaplParser.TranslationUnitContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#externalDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterExternalDeclaration(CaplParser.ExternalDeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#externalDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitExternalDeclaration(CaplParser.ExternalDeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#functionDefinition}.
	 * @param ctx the parse tree
	 */
	void enterFunctionDefinition(CaplParser.FunctionDefinitionContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#functionDefinition}.
	 * @param ctx the parse tree
	 */
	void exitFunctionDefinition(CaplParser.FunctionDefinitionContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#declarationList}.
	 * @param ctx the parse tree
	 */
	void enterDeclarationList(CaplParser.DeclarationListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#declarationList}.
	 * @param ctx the parse tree
	 */
	void exitDeclarationList(CaplParser.DeclarationListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#enumSpecifier}.
	 * @param ctx the parse tree
	 */
	void enterEnumSpecifier(CaplParser.EnumSpecifierContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#enumSpecifier}.
	 * @param ctx the parse tree
	 */
	void exitEnumSpecifier(CaplParser.EnumSpecifierContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#enumeratorList}.
	 * @param ctx the parse tree
	 */
	void enterEnumeratorList(CaplParser.EnumeratorListContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#enumeratorList}.
	 * @param ctx the parse tree
	 */
	void exitEnumeratorList(CaplParser.EnumeratorListContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#enumerator}.
	 * @param ctx the parse tree
	 */
	void enterEnumerator(CaplParser.EnumeratorContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#enumerator}.
	 * @param ctx the parse tree
	 */
	void exitEnumerator(CaplParser.EnumeratorContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#enumerationConstant}.
	 * @param ctx the parse tree
	 */
	void enterEnumerationConstant(CaplParser.EnumerationConstantContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#enumerationConstant}.
	 * @param ctx the parse tree
	 */
	void exitEnumerationConstant(CaplParser.EnumerationConstantContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#timerType}.
	 * @param ctx the parse tree
	 */
	void enterTimerType(CaplParser.TimerTypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#timerType}.
	 * @param ctx the parse tree
	 */
	void exitTimerType(CaplParser.TimerTypeContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#messageType}.
	 * @param ctx the parse tree
	 */
	void enterMessageType(CaplParser.MessageTypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#messageType}.
	 * @param ctx the parse tree
	 */
	void exitMessageType(CaplParser.MessageTypeContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#diagType}.
	 * @param ctx the parse tree
	 */
	void enterDiagType(CaplParser.DiagTypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#diagType}.
	 * @param ctx the parse tree
	 */
	void exitDiagType(CaplParser.DiagTypeContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#signalType}.
	 * @param ctx the parse tree
	 */
	void enterSignalType(CaplParser.SignalTypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#signalType}.
	 * @param ctx the parse tree
	 */
	void exitSignalType(CaplParser.SignalTypeContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#sysvarType}.
	 * @param ctx the parse tree
	 */
	void enterSysvarType(CaplParser.SysvarTypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#sysvarType}.
	 * @param ctx the parse tree
	 */
	void exitSysvarType(CaplParser.SysvarTypeContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#sysvarUpdateType}.
	 * @param ctx the parse tree
	 */
	void enterSysvarUpdateType(CaplParser.SysvarUpdateTypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#sysvarUpdateType}.
	 * @param ctx the parse tree
	 */
	void exitSysvarUpdateType(CaplParser.SysvarUpdateTypeContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#ethernetType}.
	 * @param ctx the parse tree
	 */
	void enterEthernetType(CaplParser.EthernetTypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#ethernetType}.
	 * @param ctx the parse tree
	 */
	void exitEthernetType(CaplParser.EthernetTypeContext ctx);
	/**
	 * Enter a parse tree produced by {@link CaplParser#keyEventType}.
	 * @param ctx the parse tree
	 */
	void enterKeyEventType(CaplParser.KeyEventTypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link CaplParser#keyEventType}.
	 * @param ctx the parse tree
	 */
	void exitKeyEventType(CaplParser.KeyEventTypeContext ctx);
}