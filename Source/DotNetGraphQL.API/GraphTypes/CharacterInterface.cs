using GraphQL.Types;

namespace DotNetGraphQL.API
{
    public class CharacterInterface : InterfaceGraphType<StarWarsCharacter>
    {
        public CharacterInterface()
        {
            Name = "Character";
            Description = "Character of the movie star war";
            Field(d => d.Id).Description("The id of the character.");
            Field(d => d.Name, nullable: true).Description("The name of the character.");
            Field<ListGraphType<CharacterInterface>>("friends", description: "friends of the character");
            Field<ListGraphType<EpisodeEnum>>("appearsIn", "Which movie they appear in.");
        }
    }
}
