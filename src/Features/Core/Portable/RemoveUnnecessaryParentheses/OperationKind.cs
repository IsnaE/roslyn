﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.RemoveUnnecessaryParentheses
{
    internal enum PrecedenceKind
    {
        Cast,
        Arithmetic,
        Shift,
        Relational,
        Equality,
        Bitwise,
        Logical,
        Coalesce,
        Assignment,
        Other
    }
}
