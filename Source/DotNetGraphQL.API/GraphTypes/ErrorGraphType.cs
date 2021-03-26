using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Entity encapsulating the details of an error. This allows the recipient to know details about the error and what may have caused the error.

    ///</summary>
    public class ErrorGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Error>
    {
        public ErrorGraphType()
        {
            Field(x => x.Code).Description(@"Error code. ");
            Field<SeverityEnum>("Severity", resolve: x => x.Source.Severity, description: @"$Severity specified how severe error in current execution path.  Refer to: Enum: /Severity/v1");
            Field(x => x.Text).Description(@"Error text. When error return text will be formate, based on text string, properties and language.");
            Field(x => x.Description).Description(@"Error description contains detailed information about error. ");
            Field<ListGraphType<PropertyGraphType>>("Properties", resolve: x => x.Source.Properties, description: @"$Properties allow to parametrize error name. Name can use @number or @name specification to reference different parameters from parameter list by ordinal number or by parameter name. Refer to: Structure[]: /Property/v1");
            Field(x => x.Entity).Description(@"URI to object or entity error associated with.");
            Field(x => x.Field).Description(@"Name of the field error associated with.");
        }
    }
}

