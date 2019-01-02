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

		public static string GetTitle(this MethodInfo methodInfo, EncodingType encodingType = default)
		{
			if (!methodInfo.IsGenericMethod)
			{
				return methodInfo.Name;
			}

			var name = methodInfo.Name; //.Substring(0, methodInfo.Name.IndexOf('`'));
			var parameters = string.Join(",", methodInfo.GetGenericArguments().Select(a => a.GetTitle(encodingType)));

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

		//public static string GetXmlDocName(this MethodInfo methodInfo)
		//{
		//	if (!methodInfo.IsGenericMethod)
		//	{
		//		return $"{methodInfo.DeclaringType.GetXmlDocName()}.{methodInfo.Name}";
		//	}

		//	var name = $"{methodInfo.DeclaringType.GetXmlDocName()}.{methodInfo.Name}";
		//	var parameters = string.Join(",", methodInfo.GetGenericArguments().Select(a => a.Name));
		//	return $"{name}{{{parameters}}}";
		//}

		public static string GetName(this Type type)
		{
			return type.Name;
		}

		public static string GetFullName(this Type type)
		{
			return $"{type.Namespace}.{type.GetName()}";
		}

		//public static string GetXmlDocName(this Type type)
		//{
		//	if (!type.IsGenericType)
		//	{
		//		return $"{type.Namespace}.{type.Name}";
		//	}

		//	var name = $"{type.Namespace}.{type.Name.Substring(0, type.Name.IndexOf('`'))}";
		//	var parameters = string.Join(",", type.GetGenericArguments().Select(a => a.GetXmlDocName()));
		//	return $"{name}{{{parameters}}}";
		//}

		public static string GetTitle(this Type type, EncodingType encodingType = default)
		{
			if (!type.IsGenericType)
			{
				return type.Name;
			}

			var name = type.Name.Substring(0, type.Name.IndexOf('`'));
			var parameters = string.Join(",", type.GetGenericArguments().Select(a => a.GetTitle(encodingType)));

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

// Generic Argument for parameter: System.Nullable{System.Int32}
// Generic Argument for class/method definition: .IHasTypeConverter`2
