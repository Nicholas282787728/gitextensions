﻿using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

#if NET5_0_OR_GREATER
#error Remove this class when targeting .NET 5 and update all usages
#endif

namespace GitExtUtils
{
    internal static class Strings
    {
        /// <inheritdoc cref="string.IsNullOrEmpty(string)"/>
        [DebuggerStepThrough]
        public static bool IsNullOrEmpty([NotNullWhen(returnValue: false)] string? s) => string.IsNullOrEmpty(s);

        /// <inheritdoc cref="string.IsNullOrWhiteSpace(string)"/>
        [DebuggerStepThrough]
        public static bool IsNullOrWhiteSpace([NotNullWhen(returnValue: false)] string? s) => string.IsNullOrWhiteSpace(s);
    }
}
