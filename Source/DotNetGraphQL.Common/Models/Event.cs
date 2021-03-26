﻿using DotNetGraphQL.Common.Enums;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Event of the clause. Clause fire events when state controlled by clause changed.
    ///</summary>
    public class Event
    {
        ///$Identity of the event. Refer to: Structure: /Identity
        public Identity Identity { get; } = new Identity();
        ///Position of event in the list of events 
        public uint Ordinal { get; } = 0;
        ///$Type of event Refer to: Enum: EventType/v1
        public EventType Type { get; } = EventType.CUSTOM;
        ///$Event list of attributes. This is attributes event will provide when fired. Refer to: Structure[]: Attribute/v1
        public Attribute[] Attributes { get; } = new Attribute[0];
        ///$List of obligations activated by event. Refer to: Structure[]: ClauseObligation/v1
        public ClauseObligation[] Obligations { get; } = new ClauseObligation[0];
    }
}

