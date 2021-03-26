using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Event of the clause. Clause fire events when state controlled by clause changed.
    ///</summary>
    public class EventGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Event>
    {
        public EventGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Identity of the event. Refer to: Structure: /Identity");
            Field(x => x.Ordinal).Description(@"Position of event in the list of events ");
            Field<EventTypeEnum>("Type", resolve: x => x.Source.Type, description: @"$Type of event Refer to: Enum: EventType/v1");
            Field<ListGraphType<AttributeGraphType>>("Attributes", resolve: x => x.Source.Attributes, description: @"$Event list of attributes. This is attributes event will provide when fired. Refer to: Structure[]: Attribute/v1");
            Field<ListGraphType<ClauseObligationGraphType>>("Obligations", resolve: x => x.Source.Obligations, description: @"$List of obligations activated by event. Refer to: Structure[]: ClauseObligation/v1");
        }
    }
}

