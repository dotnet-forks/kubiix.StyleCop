﻿//-----------------------------------------------------------------------
// <copyright file="SealedToken.cs">
//     MS-PL
// </copyright>
// <license>
//   This source code is subject to terms and conditions of the Microsoft 
//   Public License. A copy of the license can be found in the License.html 
//   file at the root of this distribution. 
//   By using this source code in any fashion, you are agreeing to be bound 
//   by the terms of the Microsoft Public License. You must not remove this 
//   notice, or any other, from this software.
// </license>
//-----------------------------------------------------------------------
namespace StyleCop.CSharp.CodeModel
{
    using System;

    /// <summary>
    /// Describes a sealed keyword.
    /// </summary>
    /// <subcategory>token</subcategory>
    public sealed class SealedToken : SimpleToken
    {
        /// <summary>
        /// Initializes a new instance of the SealedToken class.
        /// </summary>
        /// <param name="document">The parent document.</param>
        internal SealedToken(CsDocument document)
            : base(document, "sealed", TokenType.Sealed)
        {
            Param.AssertNotNull(document, "document");
        }

        /// <summary>
        /// Initializes a new instance of the SealedToken class.
        /// </summary>
        /// <param name="document">The parent document.</param>
        /// <param name="text">The text of the item.</param>
        /// <param name="location">The location of the item.</param>
        /// <param name="generated">Indicates whether the item is generated.</param>
        internal SealedToken(CsDocument document, string text, CodeLocation location, bool generated)
            : base(document, text, TokenType.Sealed, location, generated)
        {
            Param.AssertNotNull(document, "document");
            Param.AssertValidString(text, "text");
            Param.AssertNotNull(location, "location");
            Param.Ignore(generated);
        }
    }
}
