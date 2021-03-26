using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Link to a resource that associated with current resource.
    ///</summary>
    public class LinkGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Link>
    {
        public LinkGraphType()
        {
            Field<ElementGraphType>("ElementId", resolve: x => x.Source.ElementId, description: @"$Element data inherited from element structure Refer to: Structure: Element/v1");
            Field(x => x.Target).Description(@" The resource to which this resource is associated.");
            Field<LinkTypeEnum>("Type", resolve: x => x.Source.Type, description: @"$Type of the link. Refer to: Enum: LinkType/v1");
        }
    }
}

