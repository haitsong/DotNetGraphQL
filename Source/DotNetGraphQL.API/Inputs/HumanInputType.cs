using GraphQL.Types;

namespace DotNetGraphQL.API
{
    public class HumanInputType : InputObjectGraphType<Human>
    {
        public HumanInputType()
        {
            Name = "HumanInput";
            Description = "Human input type to define creating human";
            Field(x => x.Name).Description("name of the human");
            Field(x => x.HomePlanet, nullable: true).Description("home planet of human");
        }
    }

}
