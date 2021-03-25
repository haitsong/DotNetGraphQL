using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetGraphQL.Common.Enums
{

    /// <summary>
    /// Enumerator of objects types supported by DifHub service.Those objects can be access througth API by URI.
    /// </summary>
    public enum EClass
    {
        ///0
        ORGANIZATION,
        ///1
        SYSTEM,
        ///2
        APPLICATION,
        ///3
        DATASET,
        ///4
        PUBLICATION,
        ///5
        SUBSCRIPTION,
        ///6
        INTERFACE,
        ///7
        PIPELINE,
        ///8
        VIEW,
        ///9
        SETTINGS,
        ///10
        TOPOLOGY,
        ///11
        DEPLOYMENT,
        ///12
        ENVIRONMENT
    }


}
