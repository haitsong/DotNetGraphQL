using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Structure to maintain value of specific type.
    ///</summary>
    public class Variant
    {
        ///$Type of value variant contains. Refer to: Enum: /Type/v1
        public string Type { get; set; } = string.Empty;
        ///Value of type variant maintained.
        public String Value { get; set; } = string.Empty;
    }
}


