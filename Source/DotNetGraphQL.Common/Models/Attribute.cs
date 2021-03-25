using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Attribute of the schema
    ///</summary>
    public class Attribute
    {
        ///$Identity of the attribute. Refer to: Structure: /Identity
        public Identity Identity { get; } = new Identity();
        ///Position of attribute  in the list. 
        public int Ordinal { get; } = 0;
        ///Number of value for attribute. By default it is one, it means attribute is single value. When count set to 0, it is array of values of undefined size. All other numbers defines fixed size for array.
        public uint Count { get; } = 0;
        ///$Type of attributes. Let's use system types for now. Refer to: Enum: /Type/v1
        public String Type { get; } = string.Empty;
        ///Reference is URI of other schema.
        public ClauseSchema Reference { get; } = new ClauseSchema();
        ///Default value for attribute.
        public String Default { get; } = string.Empty;
        ///Format for attribute value. Default value must be presented in specified format.
        public String Format { get; } = string.Empty;
    }
}


