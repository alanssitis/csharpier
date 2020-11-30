import { PrintMethod } from "../PrintMethod";
import { printValue, HasValue, SyntaxTreeNode } from "../SyntaxTreeNode";
import { concat, group, hardline, indent, join, softline, line, doubleHardline } from "../Builders";

export interface ArrowExpressionClauseNode extends SyntaxTreeNode<"ArrowExpressionClause"> {
    arrowToken: HasValue;
    expression: SyntaxTreeNode;
}

export const print: PrintMethod<ArrowExpressionClauseNode> = (path, options, print) => {
    const node = path.getValue();
    return concat([printValue(node.arrowToken), " ", path.call(print, "expression")])
};