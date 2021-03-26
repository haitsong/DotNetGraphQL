using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Schedule for activity base on cron expression.
    ///</summary>
    public class ScheduleGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Schedule>
    {
        public ScheduleGraphType()
        {
            Field(x => x.Expression).Description(@"Cron expression to define time of execution. Expression represent text specification for execution time. ");
            Field<ListGraphType<TimeSpecGraphType>>("Specifications", resolve: x => x.Source.Specifications, description: @"$Specifications for points in time of execution. Refer to: Structure[]: /TimeSpec/v1");
        }
    }
}

