using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Binding represents connection of entity to entity in other external systems. It can be system where entity actually originated ond from which it was imported or system where entity exported. 
    ///</summary>
    public class Binding
    {
        ///$Binding identity in system it imported from or exported to. Id is globally unique. Name is unique binding name inside entity only. Refer to: Structure: /Identity
        public Identity Identity { get; } = new Identity();
        ///$Type of binding defines system we bind to. Refer to: Enum: BindingType/v1
        public BindingType Type { get; } = BindingType.ERP;
        ///Code of object in system we bind to if different from id.
        public String Code { get; } = string.Empty;
    }
}


