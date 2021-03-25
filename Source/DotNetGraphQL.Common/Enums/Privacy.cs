namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    ///  Level of pravecy for data.#
    /// </summary>
    public enum Privacy
    {
        /// Value have low privacy level. Expose of this value will not affect user privacy.
        LOW,
        /// Value have normal privacy level and expose can affect user pravicy. This data will require retention policies align.
        NORMAL,
        ///Value have high privacy level. Expose will affect user privacy. Data must be encripted, retention must be aligned.
        HIGH
    }


}
