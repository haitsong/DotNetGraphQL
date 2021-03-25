namespace DotNetGraphQL.Common.Enums
{
    ///Enumerator of the issue states.#
    public enum IssueStatus
    {
        ///Issue opened but not yet assign to right person., 0, 0
        OPENED,
        ///Issue assigned for investigation., 1, 5
        ASSIGNED,
        ///Issue investigated and understood., 2, 30
        INVESTIGATED,
        ///Issue evaluated for resolution and assigned., 3, 5
        TRIAGED,
        ///Issue resolved., 4, 30
        RESOLVED,
        ///Issue resolution validated and confirmed., 5, 30
        CLOSED
    }


}
