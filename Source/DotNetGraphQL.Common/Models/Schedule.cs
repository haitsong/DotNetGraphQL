using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Schedule for activity base on cron expression.
    ///</summary>
    public class Schedule
    {
        ///Cron expression to define time of execution. Expression represent text specification for execution time. 
        public String Expression { get; set; } = string.Empty;
        ///$Specifications for points in time of execution. Refer to: Structure[]: /TimeSpec/v1
        public TimeSpec[] Specifications { get; set; } = new TimeSpec[0];
    }
}


