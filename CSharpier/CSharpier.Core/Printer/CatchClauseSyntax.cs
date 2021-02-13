using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier.Core
{
    public partial class Printer
    {
        // TODO 0 trivia
        private Doc PrintCatchClauseSyntax(CatchClauseSyntax node)
        {
            var parts = new Parts();
            parts.Push(this.PrintSyntaxToken(node.CatchKeyword));
            if (node.Declaration != null)
            {
                parts.Push(Concat(
                    " (",
                    this.Print(node.Declaration.Type),
                    node.Declaration.Identifier.RawKind != 0 ? " " : "",
                    node.Declaration.Identifier.Text,
                    ")"));
            }

            if (node.Filter != null)
            {
                parts.Push(Concat(" when (", this.Print(node.Filter.FilterExpression), ")"));
            }
            
            parts.Push(this.PrintBlockSyntax(node.Block));
            return Concat(parts);
        }
    }
}