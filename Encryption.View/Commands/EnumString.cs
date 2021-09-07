using System;

namespace Encryption.View.Commands
{
    [AttributeUsage(AttributeTargets.Field)]
    class EnumStringAttribute : Attribute
    {
        public string Value { get; }

        public EnumStringAttribute(string strValue)
        {
            Value = strValue;
        }
    }
}
