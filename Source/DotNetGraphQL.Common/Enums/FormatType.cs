namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    /// Enumerator of format types.Format type define way format operate and additional format string it can require. 
    /// </summary>
    public enum FormatType
    {
        ///Data will be represented as JSON document., 0, JSON, 
        JSON,
        ///Year of the date., 2, 1960, 
        YEAR,
        ///Date and time  of the date time value., 3, 01/26/2016 16:55.07, 
        DATE,
        ///Time of the date time value., 4, 16:55.07, 
        TIME,
        ///String formatted as URL., 5, /aaa/bbb/ccc, 
        URI,
        ///International phone number, 6, +1 (555) 111-2222, 
        PHONE,
        ///Email format of the data, 7, aaa.bbb@ccc.com, 
        EMAIL
    }


}
