using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Encryption.View.Commands;

namespace Encryption.View.Helper
{
    public static class GetAttributeHelper
    {
        public static string GetStrAttribute<T>(this T value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            EnumStringAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(EnumStringAttribute), false) as EnumStringAttribute[];
            return attributes.Length > 0 ? attributes[0].Value : null;
        }
    }
}
