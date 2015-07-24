using System;

namespace WebApiProxy.Core
{
    /// <summary>
    /// Use this attribute on Models that may not be a parameter or response of an action 
    /// but should be include in the generated proxy.
    /// </summary>
    public class IncludeProxy : Attribute
    {
    }
}
