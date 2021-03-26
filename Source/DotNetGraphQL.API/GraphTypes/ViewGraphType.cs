using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Event of the clause. Clause fire events when state controlled by clause changed.
    ///</summary>
    public class ViewGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.View>
    {
        public ViewGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Identity of the event. Refer to: Structure: /Identity");
            Field(x => x.Ordinal).Description(@"Position of event in the list of events ");
            Field<ViewTypeEnum>("Type", resolve: x => x.Source.Type, description: @"$Type of view. Refer to: Enum: ViewType/v1");
            Field<ViewFormEnum>("Form", resolve: x => x.Source.Form, description: @"$Form factor of view. Refer to: Enum: ViewForm/v1");
            Field<LocaleEnum>("Language", resolve: x => x.Source.Language, description: @"$Type of event Refer to: Enum: /Locale/v1");
            Field<ListGraphType<ElementGraphType>>("Elements", resolve: x => x.Source.Elements, description: @"$View's list of elements. Elements define actual visual components of the view. Refer to: Structure[]: Element/v1");
        }
    }
}

