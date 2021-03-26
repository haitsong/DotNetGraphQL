using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   A time period defined by number of time units. 

    ///</summary>
    public class DurationSpecGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.DurationSpec>
    {
        public DurationSpecGraphType()
        {
            Field(x => x.Value).Description(@"Number of time units used for period.");
            Field<UnitsOfTimeEnum>("Units", resolve: x => x.Source.Units, description: @"$Time units to define duration. Refer to: Enum: UnitsOfTime/v1");
        }
    }
}

