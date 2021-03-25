using GraphQL.Types;

namespace DotNetGraphQL.API
{
    public class EpisodeEnum : EnumerationGraphType
    {
        public EpisodeEnum()
        {
            Name = "Episode";
            Description = "One of the films in the Star Wars Trilogy.";
            AddValue("NEWHOPE", "Released in 1977.", 4);
            AddValue("EMPIRE", "Released in 1980.", 5);
            AddValue("JEDI", "Released in 1983.", 6);
        }
    }

    ///<summary>
    /// Access to publication or other object. Access defines expose of object to users of other organizations.
    ///</summary>
    public class  AccessEnum : EnumerationGraphType
    {
        public AccessEnum()
        {
            Name = "AccessEnum";
            Description = @" Access to publication or other object. Access defines expose of object to users of other organizations.";
            AddValue("PRIVATE", "Access only to architects, developers and analysts of current object.", 0);
            AddValue("INTERNAL", "Access only architects, developers and analysts inside parent folder (organization, system or application).", 1);
            AddValue("EXTERNAL", "Access to any user of current organization.", 2);
            AddValue("PUBLIC", "Access for users of other organizations.", 3);
        }
    }


    ///<summary>
    /// Enumerator of objects types supported by DifHub service. Those objects can be access througth API by URI.
    ///</summary>
    public class  ClassEnum : EnumerationGraphType
    {
        public ClassEnum()
        {
            Name = "ClassEnum";
            Description = @" Enumerator of objects types supported by DifHub service. Those objects can be access througth API by URI.";
            AddValue("ORGANIZATION", "0", 0);
            AddValue("SYSTEM", "1", 1);
            AddValue("APPLICATION", "2", 2);
            AddValue("DATASET", "3", 3);
            AddValue("PUBLICATION", "4", 4);
            AddValue("SUBSCRIPTION", "5", 5);
            AddValue("INTERFACE", "6", 6);
            AddValue("PIPELINE", "7", 7);
            AddValue("VIEW", "8", 8);
            AddValue("SETTINGS", "9", 9);
            AddValue("TOPOLOGY", "10", 10);
            AddValue("DEPLOYMENT", "11", 11);
            AddValue("ENVIRONMENT", "12", 12);
        }
    }


    ///<summary>
    /// Enumerator for completion status available in organization. Architect only can add custom status here.
    ///</summary>
    public class  CompletionStatusEnum : EnumerationGraphType
    {
        public CompletionStatusEnum()
        {
            Name = "CompletionStatusEnum";
            Description = @" Enumerator for completion status available in organization. Architect only can add custom status here.";
            AddValue("FINILIZED", "Object changes finilized by developer.", 0);
            AddValue("APPROVED", "Object changes approved by architect.", 1);
            AddValue("SIGNEDOFF", "Object changes signed off by compliance.", 2);
        }
    }


    ///<summary>
    /// List of countries with codes. ISO 3166
    ///</summary>
    public class  CountryEnum : EnumerationGraphType
    {
        public CountryEnum()
        {
            Name = "CountryEnum";
            Description = @" List of countries with codes. ISO 3166";
            AddValue("AFGHANISTAN", "93, AE, AFG, UTC+04", 0);
            AddValue("ALAND_ISLANDS", "35818, AX, ALA, UTC+02", 1);
            AddValue("ALBANIA", "355, AL, ALB, UTC+01", 2);
            AddValue("ALGERIA", "213, DZ, DZA, UTC+01", 3);
            AddValue("AMERICAN_SAMOA", "1684, AS, ASM, UTC+11", 4);
            AddValue("ANDORRA", "376, AD, AND, UTC+01", 5);
            AddValue("ANGOLA", "244, AO, AGO, UTC+00", 6);
            AddValue("ANGUILLA", "1264, AI, AIA, UTC+04", 7);
            AddValue("ANTIGUA_AND_BARBUDA", "1268, AG, ATG, UTC+04", 8);
            AddValue("ARGENTINA", "54, AR, ARG, UTC+03", 9);
            AddValue("ARMENIA", "374, AM, ARM, UTC+04", 10);
            AddValue("ARUBA", "297, AW, ABW, UTC+04", 11);
            AddValue("AUSTRALIA", "61, AU, AUS, UTC+08", 12);
            AddValue("AUSTRIA", "43, AT, AUT, UTC+01", 13);
            AddValue("AZERBAIJAN", "994, AZ, AZE, UTC+04", 14);
            AddValue("BAHAMAS", "1242, BS, BHS, UTC+05", 15);
            AddValue("BAHRAIN", "973, BH, BHR, UTC+03", 16);
            AddValue("BANGLADESH", "880, BD, BGD, UTC+06", 17);
            AddValue("BARBADOS", "1246, BB, BRB, UTC+04", 18);
            AddValue("BELARUS", "375, BY, BLR, UTC+03", 19);
            AddValue("BELGIUM", "32, BE, BEL, UTC+01", 20);
            AddValue("BELIZE", "501, BZ, BLZ, UTC-06", 21);
            AddValue("BENIN", "229, BJ, BEN, UTC+01", 22);
            AddValue("BERMUDA", "1441, BM, BMU, UTC-04", 23);
            AddValue("BHUTAN", "975, BT, BTN, UTC+06", 24);
            AddValue("BOLIVIA__PLURINATIONAL_STATE_OF", "591, BO, BOL, UTC-04", 25);
            AddValue("BONAIRE__SINT_EUSTATIUS_AND_SABA", "5997, BQ, BES, UTC-04", 26);
            AddValue("BOSNIA_AND_HERZEGOVINA", "387, BA, BIH, UTC+01", 27);
            AddValue("BOTSWANA", "267, BW, BWA, UTC+02", 28);
            AddValue("BRAZIL", "55, BR, BRA, UTC-05", 29);
            AddValue("BRITISH_INDIAN_OCEAN_TERRITORY", "246, IO, IOT, UTC+06", 30);
            AddValue("BRUNEI_DARUSSALAM", "673, BN, BRN, UTC+08", 31);
            AddValue("BULGARIA", "359, BG, BGR, UTC+02", 32);
            AddValue("BURKINA_FASO", "226, BF, BFA, UTC+00", 33);
            AddValue("BURUNDI", "257, BI, BDI, UTC+02", 34);
            AddValue("CABO_VERDE", "238, CV, CPV, UTC-01", 35);
            AddValue("CAMBODIA", "855, KH, KHM, UTC+07", 36);
            AddValue("CAMEROON", "237, CM, CMR, UTC+01", 37);
            AddValue("CANADA", "1, CA, CAN, UTC-08", 38);
            AddValue("CAYMAN_ISLANDS", "1345, KY, CYM, UTC-05", 39);
            AddValue("CENTRAL_AFRICAN_REPUBLIC", "236, CF, CAF, UTC+01", 40);
            AddValue("CHAD", "235, TD, TCD, UTC+01", 41);
            AddValue("CHILE", "56, CL, CHL, UTC-06", 42);
            AddValue("CHINA", "86, CN, CHN, UTC+08", 43);
            AddValue("CHRISTMAS_ISLAND", "6189164, CX, CXR, UTC+07", 44);
            AddValue("COCOS_KEELING_ISLANDS", "6189162, CC, CCK, UTC+06", 45);
            AddValue("COLOMBIA", "57, CO, COL, UTC-06", 46);
            AddValue("COMOROS", "269, KM, COM, UTC+03", 47);
            AddValue("CONGO", "242, CG, COG, UTC+01", 48);
            AddValue("CONGO__THE_DEMOCRATIC_REPUBLIC_OF_THE", "243, CD, COD, UTC+01", 49);
            AddValue("COOK_ISLANDS", "682, CK, COK, UTC-10", 50);
            AddValue("COSTA_RICA", "506, CR, CRI, UTC-06", 51);
            AddValue("COTE_D'IVOIRE", "225, CI, CIV, UTC+00", 52);
            AddValue("CROATIA", "385, HR, HRV, UTC+01", 53);
            AddValue("CUBA", "53, CU, CUB, UTC-05", 54);
            AddValue("CURACAO", "5999, CW, CUW, UTC-04", 55);
            AddValue("CYPRUS", "357, CY, CYP, UTC+02", 56);
            AddValue("CZECHIA", "420, CZ, CZE, UTC+01", 57);
            AddValue("DENMARK", "45, DK, DNK, UTC+01", 58);
            AddValue("DJIBOUTI", "253, DJ, DJI, UTC+02", 59);
            AddValue("DOMINICA", "1767, DM, DMA, UTC-04", 60);
            AddValue("DOMINICAN_REPUBLIC", "1809, DO, DOM, UTC-04", 61);
            AddValue("ECUADOR", "593, EC, ECU, UTC-06", 62);
            AddValue("EGYPT", "20, EG, EGY, UTC+02", 63);
            AddValue("EL_SALVADOR", "503, SV, , UTC-06", 64);
            AddValue("EQUATORIAL_GUINEA", "240, GQ, GNQ, UTC+01", 65);
            AddValue("ERITREA", "291, ER, ERI, UTC+03", 66);
            AddValue("ESTONIA", "372, EE, EST, UTC+02", 67);
            AddValue("ETHIOPIA", "251, ET, ETH, UTC+03", 68);
            AddValue("FALKLAND_ISLANDS_MALVINAS", "500, FK, FLK, UTC-03", 69);
            AddValue("FAROE_ISLANDS", "298, , FRO, UTC+00", 70);
            AddValue("FIJI", "679, FJ, FJI, UTC+12", 71);
            AddValue("FINLAND", "358, FI, FIN, UTC+02", 72);
            AddValue("FRANCE", "33, FR, FRA, UTC+01", 73);
            AddValue("FRENCH_GUIANA", "594, GF, GUF, UTC-03", 74);
            AddValue("FRENCH_POLYNESIA", "689, PF, PYF, UTC-10", 75);
            AddValue("FRENCH_SOUTHERN_TERRITORIES", "689, TF, TYF, UTC-10", 76);
            AddValue("GABON", "241, GA, GAB, UTC+01", 77);
            AddValue("GAMBIA", "220, GM, GMB, UTC+00", 78);
            AddValue("GEORGIA", "995, GE, GEO, UTC+04", 79);
            AddValue("GERMANY", "49, DE, DEU, UTC+01", 80);
            AddValue("GHANA", "233, GH, GHA, UTC+00", 81);
            AddValue("GIBRALTAR", "350, GI, GIB, UTC+01", 82);
            AddValue("GREECE", "30, GR, GRC, UTC+02", 83);
            AddValue("GREENLAND", "299, GL, GRL, UTC-04", 84);
            AddValue("GRENADA", "1473, GD, GRD, UTC-04", 85);
            AddValue("GUADELOUPE", "590, GP, GLP, UTC-04", 86);
            AddValue("GUAM", "1671, GU, GUM, UTC+10", 87);
            AddValue("GUATEMALA", "502, GT, GTM, UTC-06", 88);
            AddValue("GUERNSEY", "441481, GG, GGY, UTC+01", 89);
            AddValue("GUINEA", "224, GN, GIN, UTC+00", 90);
            AddValue("GUINEA_BISSAU", "245, GW, GNB, UTC+00", 91);
            AddValue("GUYANA", "592, GY, GUY, UTC+04", 92);
            AddValue("HAITI", "509, HT, HTI, UTC-05", 93);
            AddValue("HEARD_ISLAND_AND_MCDONALD_ISLANDS", "6723, HM, HMD, UTC+05", 94);
            AddValue("HOLY_SEE", "3906698, VA, VAT, UTC+01", 95);
            AddValue("HONDURAS", "504, HN, HND, UTC-06", 96);
            AddValue("HONG_KONG", "852, HK, HKG, UTC+08", 97);
            AddValue("HUNGARY", "36, HU, HUN, UTC+01", 98);
            AddValue("ICELAND", "354, IS, ISL, UTC+00", 99);
        }
    }


    ///<summary>
    /// Enumerator of currencies supported by the system. ISO 4217.
    ///</summary>
    public class  CurrencyEnum : EnumerationGraphType
    {
        public CurrencyEnum()
        {
            Name = "CurrencyEnum";
            Description = @" Enumerator of currencies supported by the system. ISO 4217.";
            AddValue("AED", "United Arab Emirates dirham", 0);
            AddValue("AFN", "Afghan afghani", 1);
            AddValue("ALL", "Albanian lek", 2);
            AddValue("AMD", "Armenian dram", 3);
            AddValue("ANG", "Netherlands Antillean guilder", 4);
            AddValue("AOA", "Angolan kwanza", 5);
            AddValue("ARS", "Argentine peso", 6);
            AddValue("AUD", "Australian dollar", 7);
            AddValue("AWG", "Aruban florin", 8);
            AddValue("AZN", "Azerbaijani manat", 9);
            AddValue("BAM", "Bosnia and Herzegovina convertible mark", 10);
            AddValue("BBD", "Barbados dollar", 11);
            AddValue("BDT", "Bangladeshi taka", 12);
            AddValue("BGN", "Bulgarian lev", 13);
            AddValue("BHD", "Bahraini dinar", 14);
            AddValue("BIF", "Burundian franc", 15);
            AddValue("BMD", "Bermudian dollar", 16);
            AddValue("BND", "Brunei dollar", 17);
            AddValue("BOB", "Boliviano", 18);
            AddValue("BOV", "Bolivian Mvdol", 19);
            AddValue("BRL", "Brazilian real", 20);
            AddValue("BSD", "Bahamian dollar", 21);
            AddValue("BWP", "Botswana pula", 22);
            AddValue("BYN", "Belarusian ruble", 23);
            AddValue("BZD", "Belize dollar", 24);
            AddValue("CAD", "Canadian dollar", 25);
            AddValue("CDF", "Congolese franc", 26);
            AddValue("CHE", "WIR Euro (complementary currency)", 27);
            AddValue("CHF", "Swiss franc", 28);
            AddValue("CHW", "WIR Franc (complementary currency)", 29);
            AddValue("CLF", "Unidad de Fomento (funds code)", 30);
            AddValue("CLP", "Chilean peso", 31);
            AddValue("CNY", "Chinese yuan", 32);
            AddValue("COP", "Colombian peso", 33);
            AddValue("COU", "Unidad de Valor Real (UVR) (funds code)", 34);
            AddValue("CRC", "Costa Rican colon", 35);
            AddValue("CUC", "Cuban convertible peso", 36);
            AddValue("CUP", "Cuban peso", 37);
            AddValue("CVE", "Cape Verde escudo", 38);
            AddValue("CZK", "Czech koruna", 39);
            AddValue("DJF", "Djiboutian franc", 40);
            AddValue("DKK", "Danish krone", 41);
            AddValue("DOP", "Dominican peso", 42);
            AddValue("DZD", "Algerian dinar", 43);
            AddValue("EGP", "Egyptian pound", 44);
            AddValue("ERN", "Eritrean nakfa", 45);
            AddValue("ETB", "Ethiopian birr", 46);
            AddValue("EUR", "Euro", 47);
            AddValue("FJD", "Fiji dollar", 48);
            AddValue("FKP", "Falkland Islands pound", 49);
            AddValue("GBP", "Pound sterling", 50);
            AddValue("GEL", "Georgian lari", 51);
            AddValue("GHS", "Ghanaian cedi", 52);
            AddValue("GIP", "Gibraltar pound", 53);
            AddValue("GMD", "Gambian dalasi", 54);
            AddValue("GNF", "Guinean franc", 55);
            AddValue("GTQ", "Guatemalan quetzal", 56);
            AddValue("GYD", "Guyanese dollar", 57);
            AddValue("HKD", "Hong Kong dollar", 58);
            AddValue("HNL", "Honduran lempira", 59);
            AddValue("HRK", "Croatian kuna", 60);
            AddValue("HTG", "Haitian gourde", 61);
            AddValue("HUF", "Hungarian forint", 62);
            AddValue("IDR", "Indonesian rupiah", 63);
            AddValue("ILS", "Israeli new shekel", 64);
            AddValue("INR", "Indian rupee", 65);
            AddValue("IQD", "Iraqi dinar", 66);
            AddValue("IRR", "Iranian rial", 67);
            AddValue("ISK", "Icelandic kr¢na", 68);
            AddValue("JMD", "Jamaican dollar", 69);
            AddValue("JOD", "Jordanian dinar", 70);
            AddValue("JPY", "Japanese yen", 71);
            AddValue("KES", "Kenyan shilling", 72);
            AddValue("KGS", "Kyrgyzstani som", 73);
            AddValue("KHR", "Cambodian riel", 74);
            AddValue("KMF", "Comoro franc", 75);
            AddValue("KPW", "North Korean won", 76);
            AddValue("KRW", "South Korean won", 77);
            AddValue("KWD", "Kuwaiti dinar", 78);
            AddValue("KYD", "Cayman Islands dollar", 79);
            AddValue("KZT", "Kazakhstani tenge", 80);
            AddValue("LAK", "Lao kip", 81);
            AddValue("LBP", "Lebanese pound", 82);
            AddValue("LKR", "Sri Lankan rupee", 83);
            AddValue("LRD", "Liberian dollar", 84);
            AddValue("LSL", "Lesotho loti", 85);
            AddValue("LYD", "Libyan dinar", 86);
            AddValue("MAD", "Moroccan dirham", 87);
            AddValue("MDL", "Moldovan leu", 88);
            AddValue("MGA", "Malagasy ariary", 89);
            AddValue("MKD", "Macedonian denar", 90);
            AddValue("MMK", "Myanmar kyat", 91);
            AddValue("MNT", "Mongolian t”gr”g", 92);
            AddValue("MOP", "Macanese pataca", 93);
            AddValue("MRO", "Mauritanian ouguiya", 94);
            AddValue("MUR", "Mauritian rupee", 95);
            AddValue("MVR", "Maldivian rufiyaa", 96);
            AddValue("MWK", "Malawian kwacha", 97);
            AddValue("MXN", "Mexican peso", 98);
            AddValue("MXV", "Mexican Unidad de Inversion (UDI) (funds code)", 99);
        }
    }


    ///<summary>
    /// Enumerator of format types. Format type define way format operate and additional format string it can require. 
    ///</summary>
    public class  FormatTypeEnum : EnumerationGraphType
    {
        public FormatTypeEnum()
        {
            Name = "FormatTypeEnum";
            Description = @" Enumerator of format types. Format type define way format operate and additional format string it can require. ";
            AddValue("JSON", "Data will be represented as JSON document., 0, JSON, ", 0);
            AddValue("YEAR", "Year of the date., 2, 1960, ", 1);
            AddValue("DATE", "Date and time  of the date time value., 3, 01/26/2016 16:55.07, ", 2);
            AddValue("TIME", "Time of the date time value., 4, 16:55.07, ", 3);
            AddValue("URI", "String formatted as URL., 5, /aaa/bbb/ccc, ", 4);
            AddValue("PHONE", "International phone number, 6, +1 (555) 111-2222, ", 5);
            AddValue("EMAIL", "Email format of the data, 7, aaa.bbb@ccc.com, ", 6);
        }
    }


    ///<summary>
    /// Enumerator of frequency types can be used to define cycle of execution.
    ///</summary>
    public class  FrequencyEnum : EnumerationGraphType
    {
        public FrequencyEnum()
        {
            Name = "FrequencyEnum";
            Description = @" Enumerator of frequency types can be used to define cycle of execution.";
            AddValue("YEARLY", "Frequency specified based on year period.", 0);
            AddValue("MONTHLY", "Frequency specified based on month period.", 1);
            AddValue("WEEKLY", "Frequency specified based on week period.", 2);
            AddValue("DAILY", "Frequency specified based on day period.", 3);
            AddValue("HOURLY", "Frequency specified based on hour period.", 4);
        }
    }

    ///<summary>
    /// Enumerator of aggregation functions for measures.
    ///</summary>
    public class  FunctionEnum : EnumerationGraphType
    {
        public FunctionEnum()
        {
            Name = "FunctionEnum";
            Description = @" Enumerator of aggregation functions for measures.";
            AddValue("SUM", "Simple summary of values.", 0);
            AddValue("MIN", "Minimum of values.", 1);
            AddValue("MAX", "Maximum of values.", 2);
            AddValue("COUNT", "Count of records with value not equal to null in specific fields of record.", 3);
            AddValue("DISTINCTCOUNT", "Count of distinct values in specific fields of records.", 4);
        }
    }


    ///<summary>
    /// ISO/IEC 5218 Information technology. Codes for the representation of human sexes is an international standard that defines a representation of human sexes through a language-neutral single-digit code. It can be used in information systems such as database applications.
    ///</summary>
    public class  GenderEnum : EnumerationGraphType
    {
        public GenderEnum()
        {
            Name = "GenderEnum";
            Description = @" ISO/IEC 5218 Information technology. Codes for the representation of human sexes is an international standard that defines a representation of human sexes through a language-neutral single-digit code. It can be used in information systems such as database applications.";
            AddValue("NOT_KNOWN", "Gender specification not known., NOT_KNOWN, 0, ", 0);
            AddValue("MALE", "Gander specified as male., MALE, 1, ", 1);
            AddValue("FEMALE", "Gender specified as female., FEMALE, 2, ", 2);
            AddValue("NOT_APPLICABLE", "Gender specification not applicable., NOT_APPLICABLE, 9, ", 3);
        }
    }


    ///<summary>
    /// Enumerator Names of the hours of the day by ISO 8601 and RFC 3339.
    ///</summary>
    public class  HourEnum : EnumerationGraphType
    {
        public HourEnum()
        {
            Name = "HourEnum";
            Description = @" Enumerator Names of the hours of the day by ISO 8601 and RFC 3339.";
            AddValue("00", "Zero hour of the day and same as 24th hour., 0, 12AM", 0);
            AddValue("01", "First hour of the day., 1, 1AM", 1);
            AddValue("02", "Second hour of the day., 2, 2AM", 2);
            AddValue("03", "Third hour of the day., 3, 3AM", 3);
            AddValue("04", "Fourth hour of the day, 4, 4AM", 4);
            AddValue("05", "Fifth hour of the day., 5, 5AM", 5);
            AddValue("06", "Sixth hour of the day., 6, 6AM", 6);
            AddValue("07", "Seventh hour of the day,, 7, 7AM", 7);
            AddValue("08", "Eight hour of the day, 8, 8AM", 8);
            AddValue("09", "Ninth hour of the day. , 9, 9AM", 9);
            AddValue("10", "Tenth hour of the day., 10, 10AM", 10);
            AddValue("11", "Eleventh hour of the day, 11, 11AM", 11);
            AddValue("12", "Twelfth hour of the day, 12, 12PM", 12);
            AddValue("13", "13th hour of the day., 13, 1PM", 13);
            AddValue("14", "14th hour of day., 14, 2PM", 14);
            AddValue("15", "15th hour of the day., 15, 3PM", 15);
            AddValue("16", "16th hour of the day., 16, 4PM", 16);
            AddValue("17", "17th hour of the day., 17, 5PM", 17);
            AddValue("18", "18th hour of the day., 18, 6PM", 18);
            AddValue("19", "19th hour of the day., 19, 7PM", 19);
            AddValue("20", "20th hour of the day, 20, 8PM", 20);
            AddValue("21", "Twenty First hour of the day., 21, 9PM", 21);
            AddValue("22", "Twenty Second hour of the day., 22, 10PM", 22);
            AddValue("23", "Twenty Third hour of the day,, 23, 11PM", 23);
            AddValue("24", "24th hour of the day and same as Zero hour,, 24, 12AM", 24);
        }
    }


    ///<summary>
    /// Enumerator of the issue priorities.
    ///</summary>
    public class  IssuePriorityEnum : EnumerationGraphType
    {
        public IssuePriorityEnum()
        {
            Name = "IssuePriorityEnum";
            Description = @" Enumerator of the issue priorities.";
            AddValue("CRITICAL", "Issue is critical. It is highest priority. Issue requeried immidiate attention and need to be resolved in short time., 0, 1.00:00:00", 0);
            AddValue("URGENT", "Urgent issue, need immidiate attention but have more time to resolve., 1, 7.00:00:00", 1);
            AddValue("NORMAL", "Issue is normal priority and required regular attention., 2, 30.00:00:00", 2);
            AddValue("LOW", "Issue is low priotity compare to regular issues., 3, 90.00:00:00", 3);
            AddValue("MINIMAL", "Issue have minimal priority and can wait for long., 4, 365.00:00:00", 4);
        }
    }


    ///<summary>
    /// Enumerator of the issue resolutions. Issue resolution defines how issue was resolved.
    ///</summary>
    public class  IssueResolutionEnum : EnumerationGraphType
    {
        public IssueResolutionEnum()
        {
            Name = "IssueResolutionEnum";
            Description = @" Enumerator of the issue resolutions. Issue resolution defines how issue was resolved.";
            AddValue("FIXED", "Issue was fixed by developer.", 0);
            AddValue("APROVED", "Issue was resolved as aproval for request.", 1);
            AddValue("DECLINED", "Issue was resolve as rejection of request or sajetion.", 2);
            AddValue("NOT REPRODUCED", "Issue wasn't reproduced in current state of the system.", 3);
            AddValue("BY DESIGN", "Feature was designed this way and it is not an Issue.", 4);
            AddValue("DUPLICATE", "Issue is duplicate of some other issue. Issue it duplicate to will be specified in link.", 5);
            AddValue("POSTPONED", "Issue was postponed to next development cycle.", 6);
        }
    }


    ///<summary>
    /// Enumerator of the issue states.
    ///</summary>
    public class  IssueStatusEnum : EnumerationGraphType
    {
        public IssueStatusEnum()
        {
            Name = "IssueStatusEnum";
            Description = @" Enumerator of the issue states.";
            AddValue("OPENED", "Issue opened but not yet assign to right person., 0, 0", 0);
            AddValue("ASSIGNED", "Issue assigned for investigation., 1, 5", 1);
            AddValue("INVESTIGATED", "Issue investigated and understood., 2, 30", 2);
            AddValue("TRIAGED", "Issue evaluated for resolution and assigned., 3, 5", 3);
            AddValue("RESOLVED", "Issue resolved., 4, 30", 4);
            AddValue("CLOSED", "Issue resolution validated and confirmed., 5, 30", 5);
        }
    }


    ///<summary>
    /// Enumerator of the issue types.
    ///</summary>
    public class  IssueTypeEnum : EnumerationGraphType
    {
        public IssueTypeEnum()
        {
            Name = "IssueTypeEnum";
            Description = @" Enumerator of the issue types.";
            AddValue("INITIATIVE", "Initiative for busness solution., 0, 1.0, ", 0);
            AddValue("FEATURE", "Feature for system or application., 1, 1.0, ", 1);
            AddValue("DISCUSSION", "Discussion about any topic., 2, 1.0, ", 2);
            AddValue("WORK_ITEM", "Work Item for changes in design or code.  Default type for issue., 3, 1.0, ", 3);
            AddValue("SUPPORT_REQUEST", "Request for support from team or organization., 4, 1.0, ", 4);
            AddValue("DESIGN_SUGGESTION", "Suggestion for object design., 5, 1.0, ", 5);
            AddValue("DESIGN_PROBLEM", "Problem in object design., 6, 1.0, ", 6);
            AddValue("CODE_DEFECT", "Problem in implementation., 7, 1.0, ", 7);
        }
    }


    ///<summary>
    /// Enumerator of supported locales.
    ///</summary>
    public class  LocaleEnum : EnumerationGraphType
    {
        public LocaleEnum()
        {
            Name = "LocaleEnum";
            Description = @" Enumerator of supported locales.";
            AddValue("AF", "Afrikaans, 1078, af", 0);
            AddValue("SQ", "Albanian, 1052, sq", 1);
            AddValue("AM", "Amharic, 1118, am", 2);
            AddValue("AR_DZ", "Arabic - Algeria, 5121, ar", 3);
            AddValue("AR_BH", "Arabic - Bahrain, 15361, ar", 4);
            AddValue("AR_EG", "Arabic - Egypt, 3073, ar", 5);
            AddValue("AR_IQ", "Arabic - Iraq, 2049, ar", 6);
            AddValue("AR_JO", "Arabic - Jordan, 11265, ar", 7);
            AddValue("AR_KW", "Arabic - Kuwait, 13313, ar", 8);
            AddValue("AR_LB", "Arabic - Lebanon, 12289, ar", 9);
            AddValue("AR_LY", "Arabic - Libya, 4097, ar", 10);
            AddValue("AR_MA", "Arabic - Morocco, 6145, ar", 11);
            AddValue("AR_OM", "Arabic - Oman, 8193, ar", 12);
            AddValue("AR_QA", "Arabic - Qatar, 16385, ar", 13);
            AddValue("AR_SA", "Arabic - Saudi Arabia, 1025, ar", 14);
            AddValue("AR_SY", "Arabic - Syria, 10241, ar", 15);
            AddValue("AR_TN", "Arabic - Tunisia, 7169, ar", 16);
            AddValue("AR_AE", "Arabic - United Arab Emirates, 9217, ar", 17);
            AddValue("AR_YE", "Arabic - Yemen, 9217, ar", 18);
            AddValue("HY", "Armenian, 1067, hy", 19);
            AddValue("AS", "Assamese, 1101, as", 20);
            AddValue("AZ_AZ", "Azeri - Cyrillic, 2092, az", 21);
            AddValue("AZ_AZ", "Azeri - Latin, 1068, az", 22);
            AddValue("EU", "Basque, 1069, eu", 23);
            AddValue("BE", "Belarusian, 1059, be", 24);
            AddValue("BN", "Bengali - Bangladesh, 2117, bn", 25);
            AddValue("BN", "Bengali - India, 1093, bn", 26);
            AddValue("BS", "Bosnian, 5146, bs", 27);
            AddValue("BG", "Bulgarian, 1026, bg", 28);
            AddValue("MY", "Burmese, 1109, my", 29);
            AddValue("CA", "Catalan, 1027, ca", 30);
            AddValue("ZH_CN", "Chinese - China, 2052, zh", 31);
            AddValue("ZH_HK", "Chinese - Hong Kong SAR, 2052, zh", 32);
            AddValue("ZH_MO", "Chinese - Macau SAR, 5124, zh", 33);
            AddValue("ZH_SG", "Chinese - Singapore, 4100, zh", 34);
            AddValue("ZH_TW", "Chinese - Taiwan, 1028, zh", 35);
            AddValue("CS", "Croatian, 1050, hr", 36);
            AddValue("DA", "Danish, 1030, da", 37);
            AddValue("NL_BE", "Dutch - Belgium, 2067, nl", 38);
            AddValue("NL_NL", "Dutch - Netherlands, 1043, nl", 39);
            AddValue("EN_AU", "English - Australia, 3081, en", 40);
            AddValue("EN_BZ", "English - Belize, 10249, en", 41);
            AddValue("EN_CA", "English - Canada, 4105, en", 42);
            AddValue("EN_CB", "English - Caribbean, 9225, en", 43);
            AddValue("EN_GB", "English - Great Britain, 2057, en", 44);
            AddValue("EN_IN", "English - India, 16393, en", 45);
            AddValue("EN_IE", "English - Ireland, 6153, en", 46);
            AddValue("EN_JM", "English - Jamaica, 8201, en", 47);
            AddValue("EN_NZ", "English - New Zealand, 5129, en", 48);
            AddValue("EN_PH", "English - Phillippines, 13321, en", 49);
            AddValue("EN_ZA", "English - Southern Africa, 7177, en", 50);
            AddValue("EN_TT", "English - Trinidad, 11273, en", 51);
            AddValue("EN_US", "English - United States, 1033, en", 52);
            AddValue("ET", "Estonian, 1061, et", 53);
            AddValue("MK", "FYRO Macedonia, 1071, mk", 54);
            AddValue("FO", "Faroese, 1080, fo", 55);
            AddValue("FA", "Farsi - Persian, 1065, fa", 56);
            AddValue("FI", "Finnish, 1035, fi", 57);
            AddValue("FR_BE", "French - Belgium, 2060, fr", 58);
            AddValue("FR_CA", "French - Canada, 3084, fr", 59);
            AddValue("FR_FR", "French - France, 1036, fr", 60);
            AddValue("FR_LU", "French - Luxembourg, 5132, fr", 61);
            AddValue("FR_CH", "French - Switzerland, 4108, fr", 62);
            AddValue("GD_IE", "Gaelic - Ireland, 2108, gd", 63);
            AddValue("GD", "Gaelic - Scotland, 1084, gd", 64);
            AddValue("KA", "Georgian, 1079, ka", 65);
            AddValue("DE_AT", "German - Austria, 3079, de", 66);
            AddValue("DE_DE", "German - Germany, 1031, de", 67);
            AddValue("DE_LI", "German - Liechtenstein, 5127, de", 68);
            AddValue("DE_LU", "German - Luxembourg, 4103, de", 69);
            AddValue("DE_CH", "German - Switzerland, 2055, de", 70);
            AddValue("EL", "Greek, 1032, el", 71);
            AddValue("GN", "Guarani - Paraguay, 1140, gn", 72);
            AddValue("GU", "Gujarati, 1095, gu", 73);
            AddValue("HE", "Hebrew, 1037, he", 74);
            AddValue("HI", "Hindi, 1081, hi", 75);
            AddValue("HU", "Hungarian, 1038, hu", 76);
            AddValue("IS", "Icelandic, 1039, is", 77);
            AddValue("ID", "Indonesian, 1057, id", 78);
            AddValue("IT_IT", "Italian - Italy, 1040, it", 79);
            AddValue("IT_CH", "Italian - Switzerland, 2064, it", 80);
            AddValue("JA", "Japanese, 1041, ja", 81);
            AddValue("KN", "Kannada, 1099, kn", 82);
            AddValue("KS", "Kashmiri, 1120, ks", 83);
            AddValue("KK", "Kazakh, 1087, kk", 84);
            AddValue("KM", "Khmer, 1107, km", 85);
            AddValue("KO", "Korean, 1042, ko", 86);
        }
    }


    ///<summary>
    /// Enummerator for the message actions.
    ///</summary>
    public class  MessageActionEnum : EnumerationGraphType
    {
        public MessageActionEnum()
        {
            Name = "MessageActionEnum";
            Description = @" Enummerator for the message actions.";
        }
    }


    ///<summary>
    /// Enumerator of the message types. Message type defines message generated for specific type of message.
    ///</summary>
    public class  MessageTypeEnum : EnumerationGraphType
    {
        public MessageTypeEnum()
        {
            Name = "MessageTypeEnum";
            Description = @" Enumerator of the message types. Message type defines message generated for specific type of message.";
        }
    }


    ///<summary>
    /// Enumerator Names of the moths of the year by ISO 8601 and RFC 3339.
    ///</summary>
    public class  MonthEnum : EnumerationGraphType
    {
        public MonthEnum()
        {
            Name = "Month></a><d  <d <d </d </d Month</d <d Enumerator Names of the moths of the year by ISO 8601 and RFC 3339.</d <d <div data-table-path><div  id=Enum";
            Description = @" Enumerator Names of the moths of the year by ISO 8601 and RFC 3339.";
            AddValue("JANUARY", "First month of the year by ISO 8601., 1, 31", 0);
            AddValue("FEBRUARY", "Second month of the year by ISO 8601., 2, 28", 1);
            AddValue("MARCH", "Third month of the year by ISO 8601., 3, 31", 2);
            AddValue("APRIL", "Fourth month of the year by ISO 8601., 4, 30", 3);
            AddValue("MAY", "Fifth month of the year by ISO 8601., 5, 31", 4);
            AddValue("JUNE", "Sixth month of the year by ISO 8601., 6, 30", 5);
            AddValue("JULY", "Seventh month of the year by ISO 8601., 7, 31", 6);
            AddValue("AUGUST", "Eighth month of the year by ISO 8601., 8, 31", 7);
            AddValue("SEPTEMBER", "Ninth month of the year by ISO 8601., 9, 30", 8);
            AddValue("OCTOBER", "Tenth month of the year by ISO 8601., 10, 31", 9);
            AddValue("NOVEMBER", "Eleventh month of the year by ISO 8601., 11, 30", 10);
            AddValue("DECEMBER", "Twelfth month of the year by ISO 8601., 12, 31", 11);
        }
    }


    ///<summary>
    /// Enumerator Names of the days of the month by ISO 8601 and RFC 3339.
    ///</summary>
    public class  MonthDayEnum : EnumerationGraphType
    {
        public MonthDayEnum()
        {
            Name = "MonthDayEnum";
            Description = @" Enumerator Names of the days of the month by ISO 8601 and RFC 3339.";
            AddValue("FIRST", "First day of the month or first week day of the month.", 0);
            AddValue("01", "First day of the month by ISO 8601.", 1);
            AddValue("02", " Day day of the month by ISO 8601.", 2);
            AddValue("03", " Third day of the month by ISO 8601.", 3);
            AddValue("04", " Fourth day of the month by ISO 8601.", 4);
            AddValue("05", "Fifth day of the month by ISO 8601.", 5);
            AddValue("06", "Sixth day of the month by ISO 8601.", 6);
            AddValue("07", "Seventh day of the month by ISO 8601.", 7);
            AddValue("08", "Eigth day of the month by ISO 8601.", 8);
            AddValue("09", "Ninth day of the month by ISO 8601.", 9);
            AddValue("10", "Tenth day of the month by ISO 8601.", 10);
            AddValue("11", "Eleventh day of the month by ISO 8601.", 11);
            AddValue("12", "Twelfth day of the month by ISO 8601.", 12);
            AddValue("13", "13th day of the month by ISO 8601.", 13);
            AddValue("14", "14th day of the month by ISO 8601.", 14);
            AddValue("15", "15th day of the month by ISO 8601.", 15);
            AddValue("16", "16th day of the month by ISO 8601.", 16);
            AddValue("17", "17th day of the month by ISO 8601.", 17);
            AddValue("18", "18th day of the month by ISO 8601.", 18);
            AddValue("19", "18th day of the month by ISO 8601.", 19);
            AddValue("20", "20th day of the month by ISO 8601.", 20);
            AddValue("21", "Twenty First day of the month by ISO 8601.", 21);
            AddValue("22", "Twenty Second day of the month by ISO 8601.", 22);
            AddValue("23", "Twenty Third day of the month by ISO 8601.", 23);
            AddValue("24", "24th day of the month by ISO 8601.", 24);
            AddValue("25", "25th day of the month by ISO 8601.", 25);
            AddValue("26", "26th day of the month by ISO 8601.", 26);
            AddValue("27", "27th day of the month by ISO 8601.", 27);
            AddValue("28", "28th day of the month by ISO 8601.", 28);
            AddValue("29", "29th day of the month by ISO 8601.", 29);
            AddValue("30", "30th day of the month by ISO 8601.", 30);
            AddValue("31", "Thirty First day of the month by ISO 8601.", 31);
            AddValue("LAST", "Last day of the month or last week day of the month.", 32);
        }
    }


    ///<summary>
    /// Define what access users have to the field data: Read, Write or Read and Write. Permissions is a bit-mask and can apply simultaneously.
    ///</summary>
    public class  PermissionEnum : EnumerationGraphType
    {
        public PermissionEnum()
        {
            Name = "PermissionEnum";
            Description = @" Define what access users have to the field data: Read, Write or Read and Write. Permissions is a bit-mask and can apply simultaneously.";
            AddValue("READ", "Users allowed read content.", 0);
            AddValue("WRITE", "User allowed write (change) content.", 1);
            AddValue("EXECUTE", "User allowed execute available commands or scripts.", 2);
        }
    }


    ///<summary>
    /// Enumerator of platforms supported by organization.
    ///</summary>
    public class  PlatformEnum : EnumerationGraphType
    {
        public PlatformEnum()
        {
            Name = "PlatformEnum";
            Description = @" Enumerator of platforms supported by organization.";
        }
    }


    ///<summary>
    /// Level of pravecy for data.
    ///</summary>
    public class  PrivacyEnum : EnumerationGraphType
    {
        public PrivacyEnum()
        {
            Name = "PrivacyEnum";
            Description = @" Level of pravecy for data.";
            AddValue("LOW", "Value have low privacy level. Expose of this value will not affect user privacy.", 0);
            AddValue("NORMAL", "Value have normal privacy level and expose can affect user pravicy. This data will require retention policies align.", 1);
            AddValue("HIGH", "Value have high privacy level. Expose will affect user privacy. Data must be encripted, retention must be aligned.", 2);
        }
    }


    ///<summary>
    /// Enumerator of supported roles for users of the object. Role defines permisions user will have to object properties.
    ///</summary>
    public class  RoleEnum : EnumerationGraphType
    {
        public RoleEnum()
        {
            Name = "RoleEnum";
            Description = @" Enumerator of supported roles for users of the object. Role defines permisions user will have to object properties.";
            AddValue("ARCHITECT", "Team Architect. Architect have full access to objects in his area of responsibility. Architect can approve changes and access to objects under his control., 0, [Read,Write,Approve]", 0);
            AddValue("DEVELOPER", "Team Architect. Architect have full access to objects in his area of responsibility. Architect can approve changes and access to objects under his control., 1, [Read,Write]", 1);
            AddValue("ANALYST", "AAnalyst can review objects he have access to. Analyst can create issue or comment on exiting issues., 2, Read", 2);
            AddValue("PRODUCT", "Analyst can review objects he have access to. Analyst can create issue or comment on exiting issues., 3, [Read, Write,Approve]", 3);
            AddValue("BUSINESS", "Team Business Manager. Business manager have access to object similar to developer, as he can contribute to design and metadata generation.., 4, [Read,Write]", 4);
            AddValue("OPERATIONS", "Team Operation support. Operator can review objects and create/modify issues. Operator have permissions similar to Analyst., 5, [Read]", 5);
        }
    }


    ///<summary>
    /// Define what access role can have to objects: Read, Write or Approve. Permissions is a bit-mask and can apply simultaneously.
    ///</summary>
    public class  RolePermissionEnum : EnumerationGraphType
    {
        public RolePermissionEnum()
        {
            Name = "RolePermissionEnum";
            Description = @" Define what access role can have to objects: Read, Write or Approve. Permissions is a bit-mask and can apply simultaneously.";
            AddValue("READ", "Users allowed read object content.", 0);
            AddValue("WRITE", "User allowed write (update) object content.", 1);
            AddValue("APPROVE", "User allowed approve object changes.", 2);
        }
    }


    ///<summary>
    /// Enumerator of validation rule types.
    ///</summary>
    public class  RuleTypeEnum : EnumerationGraphType
    {
        public RuleTypeEnum()
        {
            Name = "RuleTypeEnum";
            Description = @" Enumerator of validation rule types.";
            AddValue("LIMIT", "Left and right limit for value. Expresion validate limits for value or limit size for string. Limit values represented in format of value., 0, min < %value < max", 0);
            AddValue("PATTERN", "Regular expression specification, 1, ([^abc], [^a-z])", 1);
            AddValue("CUSTOM", "Custom rule represented by structure with usage Rule. Rule defined by filling specification in this structure., 3, ", 2);
        }
    }


    ///<summary>
    /// Severity of the error. Enumerate classification of the error severity in execution path.  
    ///</summary>
    public class  SeverityEnum : EnumerationGraphType
    {
        public SeverityEnum()
        {
            Name = "SeverityEnum";
            Description = @" Severity of the error. Enumerate classification of the error severity in execution path.  ";
            AddValue("FATAL", "A severe error that causes your system to crash, resulting in the loss or corruption of unsaved data.", 0);
            AddValue("ERROR", "A severe error that might cause the loss or corruption of unsaved data. Immediate action must be taken to prevent losing data.", 1);
            AddValue("WARNING", "Action must be taken at some stage to prevent a severe error from occurring in the future.", 2);
            AddValue("INFO", "An informative message, usually describing server activity. No action is necessary.", 3);
        }
    }


    ///<summary>
    /// ISO 3166-2:US. Enumerator of countries states.
    ///</summary>
    public class  StateEnum : EnumerationGraphType
    {
        public StateEnum()
        {
            Name = "StateEnum";
            Description = @" ISO 3166-2:US. Enumerator of countries states.";
            AddValue("ALABAMA", "State. Alabama is a state in the southeastern region of the United States. , US-AL, US", 0);
            AddValue("ALASKA", "State. Alaska is a U.S. state located in the northwest extremity of North America., US-AK, US", 1);
            AddValue("ARIZONA", "State. Arizona is a U.S. state in the southwestern region of the United States., US-AZ, US", 2);
            AddValue("ARKANSAS", "State. Arkansas is a state in the southeastern region of the United States,, US-AR, US", 3);
            AddValue("CALIFORNIA", "State. California is a state in the Pacific Region of the United States of America., US-CA, US", 4);
            AddValue("COLORADO", "State. Colorado is a state of the United States encompassing most of the southern Rocky Mountains as well as the northeastern portion of the Colorado Plateau and the western edge of the Great Plains., US-CO, US", 5);
            AddValue("CONNECTICUT", "State. Connecticut is the southernmost state in the New England region of the northeastern United States., US-CT, US", 6);
            AddValue("DELAWARE", "State. Delaware is one of the 50 states of the United States, in the Mid-Atlantic or Northeastern region., US-DE, US", 7);
            AddValue("FLORIDA", "State. Florida is the southernmost contiguous state in the United States., US-FL, US", 8);
            AddValue("GEORGIA", "State. Georgia is a state in the Southeastern United States., US-GA, US", 9);
            AddValue("HAWAII", "State. Hawaii is the 50th and most recent state to have joined the United States, having received statehood on August 21, 1959., US-HI, US", 10);
            AddValue("IDAHO", "State. Idaho is a state in the northwestern region of the United States., US-ID, US", 11);
            AddValue("ILLINOIS", "State. Illinois is a state in the Midwestern region of the United States., US-IL, US", 12);
            AddValue("INDIANA", "State. Indiana is a U.S. state located in the Midwestern and Great Lakes regions of North America, US-IN, US", 13);
            AddValue("IOWA", "State. Iowa is a U.S. state in the Midwestern United States, bordered by the Mississippi River to the east and the Missouri and Big Sioux rivers to the west., US-IA, US", 14);
        }
    }

    ///<summary>
    /// Enumerator of usages supported by service. Usage define how object used in DifHub service.
    ///</summary>
    public class  UsageEnum : EnumerationGraphType
    {
        public UsageEnum()
        {
            Name = "UsageEnum";
            Description = @" Enumerator of usages supported by service. Usage define how object used in DifHub service.";
            AddValue("GENERIC", "Generic system can contain any types of applications., , System", 0);
            AddValue("DATABASE", "Database system represent relational or multidimensional database and can contain any applications of type schema, dimension or cube., , System", 1);
            AddValue("SERVICE", "Generic service without any limitation on objects inside., , Application", 2);
            AddValue("SCHEMA", "Relational schema, contains tables as datasets., , Application", 3);
            AddValue("DIMENSION", "Dimension for relational datawarehouse or multidimensional cube. Dimension contain tables, attributes and hierarchies as datasets., , Application", 4);
            AddValue("CUBE", "Multidimensional cube, contains facts as datasets., , Application", 5);
            AddValue("PREFERENCES", "User preferences. Maintain and defines set of user preferences as datasets., , Application", 6);
            AddValue("TABLE", "Simple flat column list of relational table. Table can contain only fields of usage column., , Dataset", 7);
            AddValue("EVENT", "Complex structure for event. Event contains list of simple fields and/or other complex structures., , Dataset", 8);
            AddValue("RESOURCE", "Complex structure for REST API resource. Resource similar to event and contains list of simple fields and/or other complex structures., , Dataset", 9);
            AddValue("STRUCTURE", "Simple structure for use inside other types of dataset. Structure contains list of simple fields and/or other complex structures., , Dataset", 10);
            AddValue("UNION", "Structure is a union of fields data. Only one field can be actual value of structure. , , Dataset", 11);
            AddValue("ENUM", "Dataset as enumerator of values. Enumerators represented as simple flat list of fields. Field of usage name is requierd., , Dataset", 12);
            AddValue("ATTRIBUTE", "Attribute contains set of fields required for level of multidimentional hierarchy (key, name, description, properties and translations). Attribute can have one key or multiple key., , Dataset", 13);
            AddValue("HIERARCHY", "Hierarchy contains set of levels of multidimentional hierarchy., , Dataset", 14);
            AddValue("FACT", "Fact of cube, containing keys with reference to attributes and measures. It can contain one or many keys and one or many measures., , Dataset", 15);
            AddValue("SETTINGS", "Set of properties for preferences or any other property sets., , Dataset", 16);
            AddValue("INSTANCE", "Instance of topology. Instance of specific platform to execute applications., , Dataset", 17);
            AddValue("LOCATION", "Location specification for dataset layout on specific platform., , Dataset", 18);
            AddValue("FORMAT", "Format for data in dataset in layout suporting different data formats., , Dataset", 19);
            AddValue("SCHEDULE", "Schedule for data updates of dataset. Schedule present time sequence for data updates and as result punctuation for the data., , Dataset", 20);
            AddValue("POLICY", "Policy for availability of data in dataset. Policy specify rules and requirements for data in dataset., , Dataset", 21);
            AddValue("RULE", "Ruled for data quality validation. Rules defined expressions and dependencies data required to meet., , Dataset", 22);
            AddValue("CONTROL", "Control for visualization of elements in view. Control specify dataset needed to define all property of UI control., , Dataset", 23);
            AddValue("TRANSFORM", "Transform for activities in pipelines. Transform represents type of transformation can be applied to the data inside activity based on specification of inputs and outputs., , Dataset", 24);
            AddValue("RESTFUL_API", "Interface as an RESTfull API., , Interface", 25);
            AddValue("LIBRARY_API", "API for application to reference or import a library of code or of binary functions, and use the functions/routines from that library to perform actions and exchange information., , Interface", 26);
            AddValue("STORE_PROCEDURE", "Relational database store procidure., , Interface", 27);
            AddValue("DATA_FLOW", "Pipeline present data flow with transformations., , Pipeline", 28);
            AddValue("WORK_FLOW", "Pipeline present work flow with API calls., , Pipeline", 29);
            AddValue("SCHEMA", "Publication represent data schema., , Publication", 30);
            AddValue("RESTFUL_API", "Publication represent data from RESTful API service., , Publication", 31);
            AddValue("USER_INTERFACE", "View represents visual user interface., , View", 32);
            AddValue("RESOURCE", "Topology used as resource specification for systems., , Topology", 33);
            AddValue("COLUMN", "Column of relational table., Count, Optional, Value, Format, Field", 34);
            AddValue("PROPERTY", "Property of event or attribute., Count, Optional, Value, Format, Field", 35);
            AddValue("IDENTITY", "Identity of event or attribute., Type=Structure, Reference=/Identity, Keys=false, Optional=false, Field", 36);
            AddValue("KEY", "key for attribute., Count, Optional=false, Format, Field", 37);
            AddValue("NAME", "Name of enum or attribute., Type=String, Optional, Field", 38);
            AddValue("DESCRIPTION", "Description of enum or attribute., Type=String, Optional, Field", 39);
            AddValue("VALUE", "Attribute value., Count, Optional, Value, Format, Field", 40);
            AddValue("VALUE1", "Attribute value additional. Used for enummerators containing multiple values used in different cases. For example 3 latter country identity., Count, Optional, Value, Format, Field", 41);
            AddValue("VALUE2", "Attribute value additional. Used in identifiers, when it have more than two values to identify entity., Count, Optional, Value, Format, Field", 42);
            AddValue("CODE", "Attribute code contains numeric code. Used in enumerators to identify column with numeric code., Count, Optional, Value, Format, Field", 43);
            AddValue("LEVEL", "Level of multidimentional hierarchy., Type=Reference, Value, Field", 44);
            AddValue("TRANSLATION", "Translation for name of enum or attribute., Type=String, Optional, Field", 45);
            AddValue("TRANSLATIONS", "List of translations for identity and values, Count=0,Type=Structure, Reference=/Translation, Keys=false, Optional=true, Field", 46);
            AddValue("MEASURE", "Aggregatable value. Used in multidimensional facts., Count, Optional, Value, Format, Aggregate, Field", 47);
            AddValue("INTERNAL", "Internal usage for list of field attributes., Order, Usage, Type, Access, Privacy, Rules, Properties, Field", 48);
            AddValue("DEPARTMENT", "Generic organization department, , Organization", 49);
            AddValue("COUNTER", "Dataset to configure calculation of counters associated with layout of dataset, , Dataset", 50);
        }
    }


    ///<summary>
    /// Enumerator Names of the weeks of the year by ISO 8601 and RFC 3339.
    ///</summary>
    public class  WeekEnum : EnumerationGraphType
    {
        public WeekEnum()
        {
            Name = "WeekEnum";
            Description = @" Enumerator Names of the weeks of the year by ISO 8601 and RFC 3339.";
            AddValue("W01", "First week of the year.", 0+1);
            AddValue("W02", "Second week of the year.", 1+1);
            AddValue("W03", "Third week of the year.", 2+1);
            AddValue("W04", "4th week of the year.", 3+1);
            AddValue("W05", "5th week of the year.", 4+1);
            AddValue("W06", "6th week of the year.", 5+1);
            AddValue("W07", "7th week of the year.", 6+1);
            AddValue("W08", "8th week of the year.", 7+1);
            AddValue("W09", "9th week of the year.", 8+1);
            AddValue("W10", "10th week of the year.", 9+1);
            AddValue("W11", "Eleven week of the year.", 10+1);
            AddValue("W12", "Twelve week of the year.", 11+1);
            AddValue("W13", "13th week of the year.", 12+1);
            AddValue("W14", "14th week of the year.", 13+1);
            AddValue("W15", "15th week of the year.", 14+1);
            AddValue("W16", "16th week of the year.", 15+1);
            AddValue("W17", "17th week of the year.", 16+1);
            AddValue("W18", "18th week of the year.", 17+1);
            AddValue("W19", "19th week of the year.", 18+1);
            AddValue("W20", "20th week of the year.", 19+1);
            AddValue("W21", "21st week of the year.", 20+1);
            AddValue("W22", "22nd week of the year.", 21+1);
            AddValue("W23", "23rd week of the year.", 22+1);
            AddValue("W24", "24th week of the year.", 23+1);
            AddValue("W25", "25th week of the year.", 24+1);
            AddValue("W26", "26th week of the year.", 25+1);
            AddValue("W27", "27th week of the year.", 26+1);
            AddValue("W28", "28th week of the year.", 27+1);
            AddValue("W29", "29th week of the year.", 28+1);
            AddValue("W30", "30th week of the year.", 29+1);
            AddValue("W31", "31st week of the year.", 30+1);
            AddValue("W32", "32nd week of the year.", 31+1);
            AddValue("W33", "33rd week of the year.", 32+1);
            AddValue("W34", "34th week of the year.", 33+1);
            AddValue("W35", "35th week of the year.", 34+1);
            AddValue("W36", "36th week of the year.", 35+1);
            AddValue("W37", "37th week of the year.", 36+1);
            AddValue("W38", "38th week of the year.", 37+1);
            AddValue("W39", "39th week of the year.", 38+1);
            AddValue("W40", "40th week of the year.", 39+1);
            AddValue("W41", "41st week of the year.", 40+1);
            AddValue("W42", "42nd week of the year.", 41+1);
            AddValue("W43", "43rd week of the year.", 42+1);
            AddValue("W44", "44th week of the year.", 43+1);
            AddValue("W45", "45th week of the year.", 44+1);
            AddValue("W46", "46th week of the year.", 45+1);
            AddValue("W47", "47th week of the year.", 46+1);
            AddValue("W48", "48th week of the year.", 47+1);
            AddValue("W49", "49th week of the year.", 48+1);
            AddValue("W50", "50th week of the year.", 49+1);
            AddValue("W51", "51st week of the year.", 50+1);
            AddValue("W52", "52nd week of the year.", 51+1);
            AddValue("W53", "53rd week of the year.", 52+1);
        }
    }


    ///<summary>
    /// Enumerator Names of the days of the weeks by ISO 8601 and RFC 3339.
    ///</summary>
    public class  WeekDayEnum : EnumerationGraphType
    {
        public WeekDayEnum()
        {
            Name = "WeekDayEnum";
            Description = @" Enumerator Names of the days of the weeks by ISO 8601 and RFC 3339.";
            AddValue("MONDAY", "First day of the week by ISO 8601., MONDAY, 1, ", 1);
            AddValue("TUESDAY", "Second day of the week by ISO 8601., TUESDAT, 2, ", 2);
            AddValue("WEDNESDAY", "Third day of the week by ISO 8601., WEDNESDAY, 3, ", 3);
            AddValue("THURSDAY", "Fourth day of the week by ISO 8601., THURSDAY, 4, ", 4);
            AddValue("FRIDAY", "Fifth day of the week by ISO 8601., FRIDAY, 5, ", 5);
            AddValue("SATURDAY", "Sixth day of the week by ISO 8601., SATURDAY, 6, ", 6);
            AddValue("SUNDAY", "Seventh day of the week by ISO 8601., SUNDAY, 7, ", 7);
        }
    }


    ///  Agreement
    ///  AgreementManager
    ///<summary>
    /// Role of party contact in agreement. It defines role of contact in party for agreement.
    ///</summary>
    public class  ContactRoleEnum : EnumerationGraphType
    {
        public ContactRoleEnum()
        {
            Name = "ContactRoleEnum";
            Description = @" Role of party contact in agreement. It defines role of contact in party for agreement.";
            AddValue("APPROVER", "Contact have role of approver in contact.", 0);
            AddValue("SIGNER", "Signer of agreement for the party.", 1);
        }
    }


    ///<summary>
    /// Type of party contact. It defines role of contact in party organization.
    ///</summary>
    public class  ContactTypeEnum : EnumerationGraphType
    {
        public ContactTypeEnum()
        {
            Name = "ContactTypeEnum";
            Description = @" Type of party contact. It defines role of contact in party organization.";
            AddValue("ATTORNEY", "This is attorney", 0);
        }
    }


    ///  ClauseCatalog
    ///<summary>
    /// Event type define source of event. 
    ///</summary>
    public class  EventTypeEnum : EnumerationGraphType
    {
        public EventTypeEnum()
        {
            Name = "EventTypeEnum";
            Description = @" Event type define source of event. ";
            AddValue("CUSTOM", "Event generated by the clause.", 0);
            AddValue("STARTED", "Agreement started.", 1);
            AddValue("TERMINATED", "Agreement terminated.", 2);
        }
    }


    ///<summary>
    /// Form of view. This is form factor for view to be presented.
    ///</summary>
    public class  ViewFormEnum : EnumerationGraphType
    {
        public ViewFormEnum()
        {
            Name = "ViewFormEnum";
            Description = @" Form of view. This is form factor for view to be presented.";
            AddValue("DESKTOP", "Normal desktop form factor", 0);
            AddValue("PHONE", "Phone form factor. Clause can be presented on phone screen.", 1);
        }
    }


    ///<summary>
    /// Type of view clause can presented in.
    ///</summary>
    public class  ViewTypeEnum : EnumerationGraphType
    {
        public ViewTypeEnum()
        {
            Name = "ViewTypeEnum";
            Description = @" Type of view clause can presented in.";
            AddValue("DOCUMENT", "Clause presentation in document rendering,", 0);
        }
    }


    ///  TemplateCatalog
    ///<summary>
    /// Component type define what entity use as component. 
    ///</summary>
    public class  ComponentTypeEnum : EnumerationGraphType
    {
        public ComponentTypeEnum()
        {
            Name = "ComponentTypeEnum";
            Description = @" Component type define what entity use as component. ";
            AddValue("CLAUSE", "Clause used as component of template or document.", 0);
            AddValue("TEMPLATE", "Template used as component for document or other template.", 1);
        }
    }


    ///  Client
    ///  Common
    ///  Core
    ///<summary>
    /// Binding type represent system we are binding our entity to. 
    ///</summary>
    public class  BindingTypeEnum : EnumerationGraphType
    {
        public BindingTypeEnum()
        {
            Name = "BindingTypeEnum";
            Description = @" Binding type represent system we are binding our entity to. ";
            AddValue("ERP", "Corporate ERP system used in company.", 0);
        }
    }


    ///<summary>
    /// Enumerator of the entity state.
    ///</summary>
    public class  EntityStateEnum : EnumerationGraphType
    {
        public EntityStateEnum()
        {
            Name = "EntityStateEnum";
            Description = @" Enumerator of the entity state.";
            AddValue("DRAFT", "Entity in draft state and not ready yet for approval.", 0);
            AddValue("PENDING", "Entity pending approval and can't be used.", 1);
            AddValue("ACTIVE", "Entity in active state and can be used.", 2);
            AddValue("RETIRED", "Entity retired and cannot be executed any more.", 3);
            AddValue("ERROR", "Entity in have error and can't be used.", 4);
        }
    }


    ///<summary>
    /// Enumerator of entity types. Here listed all resources available in organization.
    ///</summary>
    public class  EntityTypeEnum : EnumerationGraphType
    {
        public EntityTypeEnum()
        {
            Name = "EntityTypeEnum";
            Description = @" Enumerator of entity types. Here listed all resources available in organization.";
            AddValue("USER", "User of the Medical Network.", 0);
            AddValue("CONTACT", "Contact information for organization or other entities.", 1);
            AddValue("PERSON", "Person represented in the system for contact.", 2);
            AddValue("PARTY", "Main component of the network", 3);
            AddValue("ACCOUNT", "Party account for financial transactions.", 4);
            AddValue("LEGALENTITY", "Legal entity information for the party.", 5);
        }
    }


    ///<summary>
    /// An approximate time period during the day, potentially linked to an event of daily living that indicates when the action should occur.

    ///</summary>
    public class  EventTimingEnum : EnumerationGraphType
    {
        public EventTimingEnum()
        {
            Name = "EventTimingEnum";
            Description = @" An approximate time period during the day, potentially linked to an event of daily living that indicates when the action should occur.";
            AddValue("MORN", @"http://hl7.org/fhir/event-timing	, Morning, Event occurs during the morning. The exact time is unspecified and established by institution convention or patient interpretation.", 0);
            AddValue("MORN_EARLY", @"http://hl7.org/fhir/event-timing	, Early Morning, Event occurs during the early morning. The exact time is unspecified and established by institution convention or patient interpretation.", 1);
            AddValue("MORN_LATE", @"http://hl7.org/fhir/event-timing	, Late Morning, Event occurs during the late morning. The exact time is unspecified and established by institution convention or patient interpretation.", 2);
            AddValue("NOON", @"http://hl7.org/fhir/event-timing, Noon, Event occurs around 12:00pm. The exact time is unspecified and established by institution convention or patient interpretation., ", 3);
            AddValue("AFT", "http://hl7.org/fhir/event-timing, Afternoon, Event occurs during the afternoon. The exact time is unspecified and established by institution convention or patient interpretation., ", 4);
            AddValue("AFT_EARLY", "http://hl7.org/fhir/event-timing, Early Afternoon, Event occurs during the early afternoon. The exact time is unspecified and established by institution convention or patient interpretation., ", 5);
            AddValue("AFT_LATE", "http://hl7.org/fhir/event-timing, Late Afternoon, Event occurs during the late afternoon. The exact time is unspecified and established by institution convention or patient interpretation., ", 6);
            AddValue("EVE", "http://hl7.org/fhir/event-timing, Evening, Event occurs during the evening. The exact time is unspecified and established by institution convention or patient interpretation., ", 7);
            AddValue("EVE_EARLY", "http://hl7.org/fhir/event-timing, Early Evening, Event occurs during the early evening. The exact time is unspecified and established by institution convention or patient interpretation., ", 8);
            AddValue("EVE_LATE", "http://hl7.org/fhir/event-timing, Late Evening, Event occurs during the late evening. The exact time is unspecified and established by institution convention or patient interpretation., ", 9);
            AddValue("NIGHT", "http://hl7.org/fhir/event-timing, Night, Event occurs during the night. The exact time is unspecified and established by institution convention or patient interpretation., ", 10);
            AddValue("PHS", "http://hl7.org/fhir/event-timing, After Sleep, Event occurs [offset] after subject goes to sleep. The exact time is unspecified and established by institution convention or patient interpretation., ", 11);
            AddValue("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, HS, Prior to beginning a regular period of extended sleep (this would exclude naps). Note that this might occur at different times of day depending on a person's regular sleep schedule., {}{}", 12);
            AddValue("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, WAKE, Upon waking up from a regular period of sleep, in order to start regular activities (this would exclude waking up from a nap or temporarily waking up during a period of sleep) Usage Notes: e.g. Take pulse rate on waking in management of thyrotoxicosis. Take BP on waking in management of hypertension Take basal body temperature on waking in establishing date of ovulation, {}{}", 13);
            AddValue("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, C, meal (from lat. ante cibus), {}{}", 14);
            AddValue("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, CM, breakfast (from lat. cibus matutinus), {}{}", 15);
            AddValue("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, CD, lunch (from lat. cibus diurnus), {}{}", 16);
            AddValue("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, CV, dinner (from lat. cibus vespertinus), {}{}", 17);
            AddValue("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, AC, before meal (from lat. ante cibus), {}{}", 18);
            AddValue("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, ACM, before breakfast (from lat. ante cibus matutinus), {}{}", 19);
            AddValue("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, ACD, before lunch (from lat. ante cibus diurnus), {}{}", 20);
            AddValue("ACV	", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, ACV	, before dinner (from lat. ante cibus vespertinus), {}{}", 21);
            AddValue("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, PC, after meal (from lat. post cibus), {}{}", 22);
            AddValue("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, PCM, after breakfast (from lat. post cibus matutinus), {}{}", 23);
            AddValue("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, PCD, after lunch (from lat. post cibus diurnus), {}{}", 24);
            AddValue("PCV	", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent, PCV	, after dinner (from lat. post cibus vespertinus), {}{}", 25);
        }
    }


    ///<summary>
    /// Type of the link.
    ///</summary>
    public class  LinkTypeEnum : EnumerationGraphType
    {
        public LinkTypeEnum()
        {
            Name = "LinkTypeEnum";
            Description = @" Type of the link.";
            AddValue("REPLACED-BY", "Replaced-by", 0);
            AddValue("REPLACES", "Replaces", 1);
            AddValue("REFER", "Refer", 2);
            AddValue("SEEALSO", "See also", 3);
        }
    }


    ///<summary>
    /// Comparator  enumerator. Include all codes defined in http://hl7.org/fhir/ValueSet/quantity-comparator
    ///</summary>
    public class  QuantityComparatorEnum : EnumerationGraphType
    {
        public QuantityComparatorEnum()
        {
            Name = "QuantityComparatorEnum";
            Description = @" Comparator  enumerator. Include all codes defined in http://hl7.org/fhir/ValueSet/quantity-comparator";
            AddValue("EQ", "Equal", 0);
            AddValue("LT", "Less than", -1);
            AddValue("LE", "Less or Equal to", -2);
            AddValue("GE", "Greater or Equal to", +1);
            AddValue("GT", "Greater than", +2);
        }
    }


    ///<summary>
    /// Code for a known / defined timing pattern.
    ///</summary>
    public class  TimingAbbreviationEnum : EnumerationGraphType
    {
        public TimingAbbreviationEnum()
        {
            Name = "TimingAbbreviationEnum";
            Description = @" Code for a known / defined timing pattern.";
            AddValue("BID	", "BID	, Two times a day at institution specified time, ", 0);
            AddValue("TID", "TID, Three times a day at institution specified time, ", 1);
            AddValue("QID", "QID, Four times a day at institution specified time, ", 2);
            AddValue("AM", "AM, Every morning at institution specified times, ", 3);
            AddValue("PM", "PM, Every afternoon at institution specified times, ", 4);
            AddValue("QD", "QD, Every Day at institution specified times, ", 5);
            AddValue("QOD", "QOD, Every Other Day at institution specified times, ", 6);
            AddValue("Q1H	", "every hour, Every hour at institution specified times, ", 7);
            AddValue("Q2H	", "every 2 hours, Every 2 hours at institution specified times, ", 8);
            AddValue("Q3H	", "every 3 hours, Every 3 hours at institution specified times, ", 9);
            AddValue("Q4H	", "every 4 hours, Every 4 hours at institution specified times, ", 10);
            AddValue("Q6H	", "every 6 hours, Every 6 hours at institution specified times, ", 11);
            AddValue("Q8H	", "every 8 hours, Every 8 hours at institution specified times, ", 12);
            AddValue("WK", "weekly, Weekly at institution specified time, ", 13);
            AddValue("BED", "at bedtime, At bedtime (institution specified time), ", 14);
            AddValue("WK", "weekly, Weekly at institution specified time, ", 15);
            AddValue("MO", "monthly, Monthly at institution specified time, ", 16);
        }
    }


    ///<summary>
    /// A unit of time (units from UCUM).
    ///</summary>
    public class  UnitsOfTimeEnum : EnumerationGraphType
    {
        public UnitsOfTimeEnum()
        {
            Name = "UnitsOfTimeEnum";
            Description = @" A unit of time (units from UCUM).";
            AddValue("S", "second, second, ", 0);
            AddValue("MIN", "minute, minute, ", 1);
            AddValue("H", "hour, hour, ", 2);
            AddValue("D", "day, day, ", 3);
            AddValue("WK", "week, week , ", 4);
            AddValue("MO", "month, month, ", 5);
            AddValue("A", "year, year, ", 6);
        }
    }


    ///  Test
    ///  example
    ///<summary>
    /// 
    ///</summary>
    public class  PartyTypeEnum : EnumerationGraphType
    {
        public PartyTypeEnum()
        {
            Name = "PartyTypeEnum";
            Description = @" ";
            AddValue("ORGANIZATION", "1", 0);
            AddValue("PERSON", "2", 1);
        }
    }
}
