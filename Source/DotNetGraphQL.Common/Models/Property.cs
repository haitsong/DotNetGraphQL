using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Property of object. Property presented as Name/Value pair.
    ///</summary>
    public class Property
    {
        ///$Identity of the property. Refer to: Structure: /Identity
        public Identity Identity { get; set; } = new Identity();
        ///$Type of the property data. Refer to: Enum: /Type
        public String Type { get; set; } = string.Empty;
        ///Reference to structure for types of structure, field or enum. 
        ///Reference can be complete and include organization name, system name, application name and dataset name. 
        ///Reference can be short and contain only dataset name. Version identify structure currently
        ///used and if not specified, it means last approved version.
        public String Reference { get; set; } = string.Empty;
        ///Property value.
        public String Value { get; set; } = string.Empty;
    }
}


