namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    ///  An approximate time period during the day, potentially linked to an event of daily living that indicates when the action should occur.
    /// </summary>
    public enum EventTiming
    {
        /// http://hl7.org/fhir/event-timing	, Morning, Event occurs during the morning. The exact time is unspecified and established by institution convention or patient interpretation.
        MORN,
        ///http://hl7.org/fhir/event-timing	, Early Morning, Event occurs during the early morning. The exact time is unspecified and established by institution convention or patient interpretation.
        MORN_EARLY,
        ///http://hl7.org/fhir/event-timing	, Late Morning, Event occurs during the late morning. The exact time is unspecified and established by institution convention or patient interpretation.
        MORN_LATE,
        ///http://hl7.org/fhir/event-timing, Noon, Event occurs around 12:00pm. The exact time is unspecified and established by institution convention or patient interpretation., 
        NOON,
        ///http://hl7.org/fhir/event-timing, Afternoon, Event occurs during the afternoon. The exact time is unspecified and established by institution convention or patient interpretation., 
        AFT,
        ///http://hl7.org/fhir/event-timing, Early Afternoon, Event occurs during the early afternoon. The exact time is unspecified and established by institution convention or patient interpretation., 
        AFT_EARLY,
        ///http://hl7.org/fhir/event-timing, Late Afternoon, Event occurs during the late afternoon. The exact time is unspecified and established by institution convention or patient interpretation., 
        AFT_LATE,
        ///http://hl7.org/fhir/event-timing, Evening, Event occurs during the evening. The exact time is unspecified and established by institution convention or patient interpretation., 
        EVE,
        ///http://hl7.org/fhir/event-timing, Early Evening, Event occurs during the early evening. The exact time is unspecified and established by institution convention or patient interpretation., 
        EVE_EARLY,
        ///http://hl7.org/fhir/event-timing, Late Evening, Event occurs during the late evening. The exact time is unspecified and established by institution convention or patient interpretation., 
        EVE_LATE,
        ///http://hl7.org/fhir/event-timing, Night, Event occurs during the night. The exact time is unspecified and established by institution convention or patient interpretation., 
        NIGHT,
        ///http://hl7.org/fhir/event-timing, After Sleep, Event occurs [offset] after subject goes to sleep. The exact time is unspecified and established by institution convention or patient interpretation., 
        PHS,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, HS, Prior to beginning a regular period of extended sleep (this would exclude naps). Note that this might occur at different times of day depending on a person's regular sleep schedule., 
        HS,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, WAKE, Upon waking up from a regular period of sleep, in order to start regular activities (this would exclude waking up from a nap or temporarily waking up during a period of sleep) Usage Notes: e.g. Take pulse rate on waking in management of thyrotoxicosis. Take BP on waking in management of hypertension Take basal body temperature on waking in establishing date of ovulation
        WAKE,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, C, meal (from lat. ante cibus), 
        C,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, CM, breakfast (from lat. cibus matutinus)
        CM,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, CD, lunch (from lat. cibus diurnus)
        CD,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, CV, dinner (from lat. cibus vespertinus), 
        CV,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, AC, before meal (from lat. ante cibus), 
        AC,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, ACM, before breakfast (from lat. ante cibus matutinus), 
        ACM,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, ACD, before lunch (from lat. ante cibus diurnus), 
        ACD,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, ACV	, before dinner (from lat. ante cibus vespertinus), 
        ACV,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, PC, after meal (from lat. post cibus), 
        PC,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, PCM, after breakfast (from lat. post cibus matutinus), 
        PCM,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, PCD, after lunch (from lat. post cibus diurnus), 
        PCD,
        ///http://terminology.hl7.org/CodeSystem/v3-TimingEvent, PCV	, after dinner (from lat. post cibus vespertinus), 
        PCV
    }


}
