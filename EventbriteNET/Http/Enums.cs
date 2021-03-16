using System;

namespace EventbriteHelper.Http
{
    ///<summary>
    /// Types of parameters that can be added to requests
    ///</summary>
    public enum ParameterType
    {
        GetOrPost,
        UrlSegment,
        QueryString
    }
}
