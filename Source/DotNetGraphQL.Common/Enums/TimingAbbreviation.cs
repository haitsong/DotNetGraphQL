namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    /// Code for a known / defined timing pattern. 
    /// </summary>
    public enum TimingAbbreviation
    {
        ///BID	, Two times a day at institution specified time, 
        BID,
        ///TID, Three times a day at institution specified time, 
        TID,
        ///QID, Four times a day at institution specified time, 
        QID,
        ///AM, Every morning at institution specified times, 
        AM,
        ///PM, Every afternoon at institution specified times, 
        PM,
        ///QD, Every Day at institution specified times, 
        QD,
        ///QOD, Every Other Day at institution specified times, 
        QOD,
        ///every hour, Every hour at institution specified times, 
        Q1H,
        ///every 2 hours, Every 2 hours at institution specified times, 
        Q2H,
        ///every 3 hours, Every 3 hours at institution specified times, 
        Q3H,
        ///every 4 hours, Every 4 hours at institution specified times, 
        Q4H,
        ///every 6 hours, Every 6 hours at institution specified times, 
        Q6H,
        ///every 8 hours, Every 8 hours at institution specified times, 
        Q8H,
        ///at bedtime, At bedtime (institution specified time), 
        BED,
        ///weekly, Weekly at institution specified time, 
        WK,
        ///monthly, Monthly at institution specified time, 
        MO
    }


}
