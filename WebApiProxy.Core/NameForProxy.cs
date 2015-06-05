using System;

namespace WebApiProxy.Core
{
    public class NameForProxy : Attribute
    {
        public NameForProxy(string name)
        {
            Name = name;
        }

        public string Name { get; private set;}
    }
}
