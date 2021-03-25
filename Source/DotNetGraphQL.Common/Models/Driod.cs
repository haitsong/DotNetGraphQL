namespace DotNetGraphQL.API
{
    public class Droid : StarWarsCharacter
    {
        public Droid() { PrimaryFunction = string.Empty; }
        public string PrimaryFunction { get; set; }
    }
}
