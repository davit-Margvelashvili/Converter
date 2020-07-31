using System;
using Converter.Core.Models;

namespace Converter.Core.Exceptions
{
#pragma warning disable RCS1194 // Implement exception constructors.

    public class InconsistentCategoryException : Exception
    {
        public InconsistentCategoryException(Category from, Category to) : base($"Invalid Conversion from '{from.Name}' to '{to.Name}'")
        {
        }
    }

#pragma warning restore RCS1194 // Implement exception constructors.
}