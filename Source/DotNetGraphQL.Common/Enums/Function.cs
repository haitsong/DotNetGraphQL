namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    /// Enumerator of aggregation functions for measures.
    /// </summary>
    public enum Function
    {
        ///Simple summary of values.
        SUM,
        ///Minimum of values.
        MIN,
        ///Maximum of values.
        MAX,
        /// Count of records with value not equal to null in specific fields of record.
        COUNT,
        ///Count of distinct values in specific fields of records.
        DISTINCTCOUNT
    }

    public enum QuantityComparator
    {
        EQ,
        LT,
        LE,
        GT,
        GE
    }
}
