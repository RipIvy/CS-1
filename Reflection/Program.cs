using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MyLibrary1;

namespace Reflection
{
    class Program
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            //dateTime.DayOfWeek
            Console.WriteLine($"CanRead: {GetPropertyInfo(dateTime, "DayOfWeek").CanRead}");
            Console.WriteLine($"CanWrite: {GetPropertyInfo(dateTime, "DayOfWeek").CanWrite}");
            Console.WriteLine($"Attributes: {GetPropertyInfo(dateTime, "DayOfWeek").Attributes}");
            Console.WriteLine($"CustomAttributes: {GetPropertyInfo(dateTime, "DayOfWeek").CustomAttributes}");
            Console.WriteLine($"DeclaringType: {GetPropertyInfo(dateTime, "DayOfWeek").DeclaringType}");
            Console.WriteLine($"GetMethod: {GetPropertyInfo(dateTime, "DayOfWeek").GetMethod}");
            Console.WriteLine($"IsSpecialName: {GetPropertyInfo(dateTime, "DayOfWeek").IsSpecialName}");
            Console.WriteLine($"MemberType: {GetPropertyInfo(dateTime, "DayOfWeek").MemberType}");
            Console.WriteLine($"MetadataToken: {GetPropertyInfo(dateTime, "DayOfWeek").MetadataToken}");
            Console.WriteLine($"Module: {GetPropertyInfo(dateTime, "DayOfWeek").Module}");
            Console.WriteLine($"Name: {GetPropertyInfo(dateTime, "DayOfWeek").Name}");
            Console.WriteLine($"PropertyType: {GetPropertyInfo(dateTime, "DayOfWeek").PropertyType}");
            Console.WriteLine($"ReflectedType: {GetPropertyInfo(dateTime, "DayOfWeek").ReflectedType}");
            Console.WriteLine($"SetMethod: {GetPropertyInfo(dateTime, "DayOfWeek").SetMethod}");

            Console.WriteLine($"GetValue: {GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null)}");

            Ml.Pause("Нажмите для выхода");
        }
    }
}
