namespace DotNetGraphQL.API
{
    public abstract class StarWarsCharacter
    {
        public StarWarsCharacter() { Id = string.Empty; Name = string.Empty; Friends = new string[0]; AppearsIn = new int[0]; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string[] Friends { get; set; }
        public int[] AppearsIn { get; set; }
    }
}
