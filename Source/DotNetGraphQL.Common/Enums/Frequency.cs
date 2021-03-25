namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    ///  Enumerator of frequency types can be used to define cycle of execution.
    /// </summary>
    public enum Frequency
    {
        ///Frequency specified based on year period.
        YEARLY,
        ///Frequency specified based on month period.
        MONTHLY,
        ///Frequency specified based on week period.
        WEEKLY,
        ///Frequency specified based on day period.
        DAILY,
        ///Frequency specified based on hour period.
        HOURLY
    }
}
