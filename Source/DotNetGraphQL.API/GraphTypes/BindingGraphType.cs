using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Binding represents connection of entity to entity in other external systems. It can be system where entity actually originated ond from which it was imported or system where entity exported. 
    ///</summary>
    public class BindingGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Binding>
    {
        public BindingGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Binding identity in system it imported from or exported to. Id is globally unique. Name is unique binding name inside entity only. Refer to: Structure: /Identity");
            Field<BindingTypeEnum>("Type", resolve: x => x.Source.Type, description: @"$Type of binding defines system we bind to. Refer to: Enum: BindingType/v1");
            Field(x => x.Code).Description(@"Code of object in system we bind to if different from id.");
        }
    }
}

