using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  The absolute geographic location.
    ///</summary>
    public class Position
    {
        ///Longitude with WGS84 datum
        public Double Longitude { get; set; } = 0;
        ///Latitude with WGS84 datum
        public Double Altitude { get; set; } = 0;
        ///Altitude with WGS84 datum
        public Double Latitude { get; set; } = 0;
    }
}


