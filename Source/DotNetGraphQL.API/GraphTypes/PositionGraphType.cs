using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   The absolute geographic location.
    ///</summary>
    public class PositionGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Position>
    {
        public PositionGraphType()
        {
            Field(x => x.Longitude).Description(@"Longitude with WGS84 datum");
            Field(x => x.Altitude).Description(@"Latitude with WGS84 datum");
            Field(x => x.Latitude).Description(@"Altitude with WGS84 datum");
        }
    }
}

