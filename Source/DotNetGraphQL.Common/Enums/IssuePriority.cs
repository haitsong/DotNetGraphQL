namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    ///Enumerator of the issue priorities.#
    /// </summary>
    public enum IssuePriority
    {
        ///Issue is critical. It is highest priority. Issue requeried immidiate attention and need to be resolved in short time., 0, 1.00:00:00
        CRITICAL,
        ///Urgent issue, need immidiate attention but have more time to resolve., 1, 7.00:00:00
        URGENT,
        ///Issue is normal priority and required regular attention., 2, 30.00:00:00
        NORMAL,
        ///Issue is low priotity compare to regular issues., 3, 90.00:00:00
        LOW,
        ///Issue have minimal priority and can wait for long., 4, 365.00:00:00
        MINIMAL
    }


}
