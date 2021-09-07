using System.Reflection;

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
