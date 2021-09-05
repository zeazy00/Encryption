using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
