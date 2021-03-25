using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Obligation for one of clause's party. Obligation will be activated on event and provide information associated with it. 
    ///</summary>
    public class ClauseObligation
    {
        ///Identity of obligation inside clause event..
        public Guid Id { get; } = Guid.Empty;
        ///$Management information for clause obligation Refer to: Structure: Element/v1
        public Element Header { get; } = new Element();
        ///Name of clause party associated with obligation.
        public String Party { get; } = string.Empty;
        ///Reference to obligation defined in catalog.
        public Obligation Obligations { get; } = new Obligation();
    }
}


