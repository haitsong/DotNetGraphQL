namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    /// Enumerator of usages supported by service.Usage define how object used in DifHub service.
    /// </summary>
    public enum Usage
    {
        ///Generic system can contain any types of applications., , System
        GENERIC,
        ///Database system represent relational or multidimensional database and can contain any applications of type schema, dimension or cube., , System
        DATABASE,
        ///Generic service without any limitation on objects inside., , Application
        SERVICE,
        ///Dimension for relational datawarehouse or multidimensional cube. Dimension contain tables, attributes and hierarchies as datasets., , Application
        DIMENSION,
        ///Multidimensional cube, contains facts as datasets., , Application
        CUBE,
        ///User preferences. Maintain and defines set of user preferences as datasets., , Application
        PREFERENCES,
        ///Simple flat column list of relational table. Table can contain only fields of usage column., , Dataset
        TABLE,
        ///Complex structure for event. Event contains list of simple fields and/or other complex structures., , Dataset
        EVENT,
        ///Simple structure for use inside other types of dataset. Structure contains list of simple fields and/or other complex structures., , Dataset
        STRUCTURE,
        ///Structure is a union of fields data. Only one field can be actual value of structure. , , Dataset
        UNION,
        ///Dataset as enumerator of values. Enumerators represented as simple flat list of fields. Field of usage name is requierd., , Dataset
        ENUM,
        ///Attribute contains set of fields required for level of multidimentional hierarchy (key, name, description, properties and translations). Attribute can have one key or multiple key., , Dataset
        ATTRIBUTE,
        ///Hierarchy contains set of levels of multidimentional hierarchy., , Dataset
        HIERARCHY,
        ///Fact of cube, containing keys with reference to attributes and measures. It can contain one or many keys and one or many measures., , Dataset
        FACT,
        ///Set of properties for preferences or any other property sets., , Dataset
        SETTINGS,
        ///Instance of topology. Instance of specific platform to execute applications., , Dataset
        INSTANCE,
        ///Location specification for dataset layout on specific platform., , Dataset
        LOCATION,
        ///Format for data in dataset in layout suporting different data formats., , Dataset
        FORMAT,
        ///Schedule for data updates of dataset. Schedule present time sequence for data updates and as result punctuation for the data., , Dataset
        SCHEDULE,
        ///Policy for availability of data in dataset. Policy specify rules and requirements for data in dataset., , Dataset
        POLICY,
        ///Ruled for data quality validation. Rules defined expressions and dependencies data required to meet., , Dataset
        RULE,
        ///Control for visualization of elements in view. Control specify dataset needed to define all property of UI control., , Dataset
        CONTROL,
        ///Transform for activities in pipelines. Transform represents type of transformation can be applied to the data inside activity based on specification of inputs and outputs., , Dataset
        TRANSFORM,
        ///API for application to reference or import a library of code or of binary functions, and use the functions/routines from that library to perform actions and exchange information., , Interface
        LIBRARY_API,
        ///Relational database store procidure., , Interface
        STORE_PROCEDURE,
        ///Pipeline present data flow with transformations., , Pipeline
        DATA_FLOW,
        ///Pipeline present work flow with API calls., , Pipeline
        WORK_FLOW,
        ///Publication represent data schema., , Publication
        SCHEMA,
        ///Publication represent data from RESTful API service., , Publication
        RESTFUL_API,
        ///View represents visual user interface., , View
        USER_INTERFACE,
        ///Topology used as resource specification for systems., , Topology
        RESOURCE,
        ///Column of relational table., Count, Optional, Value, Format, Fiel
        COLUMN,
        ///Property of event or attribute., Count, Optional, Value, Format, Fiel
        PROPERTY,
        ///Identity of event or attribute., Type=Structure, Reference=/Identity, Keys=false, Optional=false, Fiel

        IDENTITY,
        ///key for attribute., Count, Optional=false, Format, Fiel
        KEY,
        ///Name of enum or attribute., Type=String, Optional, Fiel
        NAME,
        ///Description of enum or attribute., Type=String, Optional, Fiel
        DESCRIPTION,
        ///Attribute value., Count, Optional, Value, Format, Fiel
        VALUE,
        ///Attribute value additional. Used for enummerators containing multiple values used in different cases. For example 3 latter country identity., Count, Optional, Value, Format, Fiel
        VALUE1,
        ///Attribute value additional. Used in identifiers, when it have more than two values to identify entity., Count, Optional, Value, Format, Fiel
        VALUE2,
        ///Attribute code contains numeric code. Used in enumerators to identify column with numeric code., Count, Optional, Value, Format, Fiel
        CODE,
        ///Level of multidimentional hierarchy., Type=Reference, Value, Fiel
        LEVEL,
        ///Translation for name of enum or attribute., Type=String, Optional, Fiel
        TRANSLATION,
        ///List of translations for identity and values, Count=0,Type=Structure, Reference=/Translation, Keys=false, Optional=true, Fiel
        TRANSLATIONS,
        ///Aggregatable value. Used in multidimensional facts., Count, Optional, Value, Format, Aggregate, Fiel
        MEASURE,
        ///Internal usage for list of field attributes., Order, Usage, Type, Access, Privacy, Rules, Properties, Fiel
        INTERNAL,
        ///Generic organization department, , Organization
        DEPARTMENT,
        ///Dataset to configure calculation of counters associated with layout of dataset, , Dataset
        COUNTER
    }
}
