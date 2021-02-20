using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier.Core
{
    public partial class Printer
    {
        private Doc PrintTypePatternSyntax(TypePatternSyntax node)
        {
            return this.Print(node.Type);
        }
    }
}