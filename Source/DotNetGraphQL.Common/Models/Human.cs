namespace DotNetGraphQL.API
{
    public class Human : StarWarsCharacter
    {
        public Human() { HomePlanet = string.Empty;  }
        public string HomePlanet { get; set; } 
    }
}
