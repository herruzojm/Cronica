using Microsoft.AspNet.Mvc.Routing;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Cronica.Helpers
{
    public static class EnumHelper
    {
        public static string DisplayName(this Enum value)
        {
            Type enumType = value.GetType();
            var enumValue = Enum.GetName(enumType, value);
            MemberInfo member = enumType.GetMember(enumValue)[0];

            DisplayAttribute[] attrs = (DisplayAttribute[])member.GetCustomAttributes(typeof(DisplayAttribute), false);
            string outString = enumValue;
        
            if (attrs.Length > 0)
            {
                outString = attrs[0].Name;

                if (attrs[0].ResourceType != null)
                {
                    outString = attrs[0].GetName();
                }
            }

            return outString;
        }
    }
}