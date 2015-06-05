using System;
using System.Linq;
using WebApiProxy.Core;

namespace WebApiProxy
{
    public static class TypeExtensions
    {
        public static bool IsExcluded(this Type type)
        {
            return type.GetCustomAttributes(true).OfType<ExcludeProxy>().Any();
        }

        public static string GetControllerNameForProxyIfExists(this Type type)
        {
            NameForProxy attr = type.GetCustomAttributes(typeof(NameForProxy), true).Cast<NameForProxy>().SingleOrDefault();
            return attr == null ? null : attr.Name;
        }
    }
}
