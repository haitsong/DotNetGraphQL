using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Property of object. Property presented as Name/Value pair.
    ///</summary>
    public class PropertyGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Property>
    {
        public PropertyGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Identity of the property. Refer to: Structure: /Identity");
            Field(x => x.Type).Description(@"$Type of the property data. Refer to: Enum: /Type");
            Field(x => x.Reference).Description(@"Reference to structure for types of structure, field or enum. Reference can be complete and include organization name, system name, application name and dataset name. Reference can be short and contain only dataset name. Version identify structure currently used and if not specified, it means last approved version.");
            Field(x => x.Value).Description(@"Property value.");
        }
    }
}

