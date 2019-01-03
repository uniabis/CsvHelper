using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.DocsGenerator
{
    public static class Extensions
    {
		public static string GetName(this MethodInfo methodInfo)
		{
			return methodInfo.Name;
		}

		public static string GetFullName(this MethodInfo methodInfo)
		{
			return $"{methodInfo.DeclaringType.GetName()}.{methodInfo.GetName()}";
		}

		public static string GetName(this Type type)
		{
			return type.Name;
		}

		public static string GetFullName(this Type type)
		{
			return $"{type.Namespace}.{type.GetName()}";
		}

		public static string GetDisplayName(this Type type, EncodingType encodingType = default, List<Type> genericArguments = null)
		{
			if (!type.IsGenericType)
			{
				if (encodingType == EncodingType.Xml)
				{
					return type.Name.Replace("&", "@");
				}

				return type.Name;
			}

			var name = type.Name.Substring(0, type.Name.IndexOf('`'));
			var parameters = string.Join(",", type.GetGenericArguments().Select(a => a.GetDisplayName(encodingType, genericArguments)));

			switch (encodingType)
			{
				case EncodingType.Code:
					return $"{name}<{parameters}>";
				case EncodingType.Xml:
					return $"{name}{{{parameters}}}";
				case EncodingType.Html:
					return $"{name}&lt;{parameters}&gt;";
				default:
					throw new InvalidOperationException($"Encoding type '{encodingType}' not handled.");
			}
		}
	}
}
