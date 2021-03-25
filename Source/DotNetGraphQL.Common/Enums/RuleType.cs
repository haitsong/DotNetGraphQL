namespace DotNetGraphQL.Common.Enums
{
    ///Enumerator of validation rule types.///
    public enum RuleType
    {
        ///Left and right limit for value. Expresion validate limits for value or limit size for string. Limit values represented in format of value., 0, min < %value < max
        LIMIT,
        ///Regular expression specification, 1, ([^abc], [^a-z])
        PATTERN,
        ///Custom rule represented by structure with usage Rule. Rule defined by filling specification in this structure., 3, 
        CUSTOM
    }


}
