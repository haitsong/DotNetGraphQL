﻿using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Translation for object identity to specific language. Translation can contains information for value of object specific to language it represents.
    ///</summary>
    public class Translation
    {
        ///$Locale for language translation defined for. Refer to: Enum: /Locale/v1
        public Locale Locale { get; } = Locale.EN_US;
        ///Translation for object name.
        public String Name { get; } = string.Empty;
        ///Translation for object description.
        public String Description { get; } = string.Empty;
        ///Value specific to translation locale for objects with value.
        public String Value { get; } = string.Empty;
    }
}

