using GraphQL.Types;
using DotNetGraphQL.Common.Models;

namespace DotNetGraphQL.API
{
    public class PersonInputType : InputObjectGraphType<Person>
    {
        public PersonInputType()
        {
            Name = "PersonInput";
            Description = "Person input type";
            Field(x => x.FirstName, nullable: true).Description("first name");
            Field(x => x.LastName).Description("last name");
        }
    }

}
