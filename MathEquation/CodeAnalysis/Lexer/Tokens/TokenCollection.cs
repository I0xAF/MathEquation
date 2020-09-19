﻿using System.Collections.Generic;
using MathEquation.CodeAnalysis.Lexer.Tokens;

namespace MathEquation.CodeAnalysis.Lexer
{
    public class TokenCollection : List<SyntaxToken>
    {
        public TokenCollection Copy()
        {
            SyntaxToken[] copyarr = new SyntaxToken[] { };
            System.Array.Resize(ref copyarr, Count);
            CopyTo(copyarr);
            TokenCollection copy = new TokenCollection();
            copy.AddRange(copyarr);
            return copy;
        }

        public override string ToString()
        {
            return string.Join("", this);
        }
    }
}
