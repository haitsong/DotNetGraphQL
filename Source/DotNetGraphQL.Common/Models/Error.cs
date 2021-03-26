using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Entity encapsulating the details of an error. This allows the recipient to know details about the error and what may have caused the error.
    ///</summary>
    public class Error
    {
        ///Error code. 
        public String Code { get; set; } = string.Empty;
        ///$Severity specified how severe error in current execution path.  Refer to: Enum: /Severity/v1
        public Severity Severity { get; set; } = Severity.ERROR;
        ///Error text. When error return text will be formate, based on text string, properties and language.
        public String Text { get; set; } = string.Empty;
        ///Error description contains detailed information about error. 
        public String Description { get; set; } = string.Empty;
        ///$Properties allow to parametrize error name. Name can use @number or @name specification to reference different parameters from parameter list by ordinal number or by parameter name. Refer to: Structure[]: /Property/v1
        public Property[] Properties { get; set; } = new Property[0];
        ///URI to object or entity error associated with.
        public String Entity { get; set; } = string.Empty;
        ///Name of the field error associated with.
        public String Field { get; set; } = string.Empty;
    }
}


