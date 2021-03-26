using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   View Element. Element represent visual component of view.
    ///</summary>
    public class ElementGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Element>
    {
        public ElementGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Identity of view element. Refer to: Structure: /Identity/v1");
            Field(x => x.Order).Description(@"Order define position for element in view. Elements can have different order from sequence of specification. If order define as 0 it same as sequence number of specification.");
            Field<IdentityGraphType>("Parent", resolve: x => x.Source.Parent, description: @"Reference to parent element. Parent define frame this element included in.");
            Field<EventTypeEnum>("Visibility", resolve: x => x.Source.Visibility, description: @"$Visability property defines if it visual or hidden. Refer to: Enum: EventType/v1");
            Field<ClauseGraphType>("Frame", resolve: x => x.Source.Frame, description: @"$Frame of element. Frame define rectangular view for element visual components. Refer to: Structure: Clause/v1");
            Field<ClauseGraphType>("Style", resolve: x => x.Source.Style, description: @"$Style of element. Style define attributes of element visual components. Refer to: Structure: Clause/v1");
            Field<AttributeGraphType>("Image", resolve: x => x.Source.Image, description: @"$Image of element visual component. Refer to: Structure: Attribute/v1");
            Field(x => x.Text).Description(@"Text of element visual component.");
            Field<EventTypeEnum>("Align", resolve: x => x.Source.Align, description: @"$Alignment of text in element content frame. Refer to: Enum: EventType/v1");
            Field<ClauseGraphType>("Control", resolve: x => x.Source.Control, description: @"$Control of element. Control define configuration for visual compoments. Refer to: Structure: Clause/v1");
            //todo: Field<PeriodGraphType>("Period", resolve: x => x.Source.Period, description: @"$Time period element apply to. If period not close, it is current element. If period closed, it is element relevant for this period. Refer to: Structure: Period/v1");
        }
    }
}

