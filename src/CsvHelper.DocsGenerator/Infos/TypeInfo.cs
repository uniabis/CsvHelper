using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator.Infos
{
	[DebuggerDisplay("Name = {Name}")]
	public class TypeInfo : Info
    {
		private static LinkGenerator linkGenerator = new LinkGenerator();

		public NamespaceInfo Namespace { get; private set; }

		public Type Type { get; private set; }

		public List<Type> Attributes { get; private set; }

		public List<ConstructorInfo> Constructors { get; private set; }

		public List<Type> Interfaces { get; private set; }

		public List<FieldInfo> Fields { get; private set; }

		public List<PropertyInfo> Properties { get; private set; }

		public List<MethodInfo> Methods { get; private set; }

		public TypeInfo(NamespaceInfo namespaceInfo, Type type, XElement xmlDocs)
		{
			Type = type;

			Name = type.Name;

			FullName = type.FullName;

			Namespace = namespaceInfo;

			Summary = ParseSummary($"T:{type.FullName}", xmlDocs);

			Interfaces = type.GetInterfaces().ToList();

			Constructors = type
				.GetConstructors(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.Select(c => new ConstructorInfo(c, xmlDocs))
				.Where(c => !(c.Parameters.Count == 0 && string.IsNullOrEmpty(c.Summary)))
				.OrderBy(c => c.Parameters.Count)
				.ToList();

			Attributes = type
				.GetCustomAttributes()
				.Select(a => a.GetType())
				.OrderBy(t => t.Name)
				.ToList();

			var fieldsFlags = type.IsEnum
				? BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly
				: BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
			Fields = type
				.GetFields(fieldsFlags)
				.Select(f => new FieldInfo(f, xmlDocs))
				.OrderBy(f => f.Name)
				.ToList();

			Properties = type
				.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly)
				.Select(p => new PropertyInfo(p, xmlDocs))
				.OrderBy(p => p.Name)
				.ToList();

			Methods = type
				.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly)
				.Where(m => !m.IsSpecialName)
				.Select(m => new MethodInfo(m, xmlDocs))
				.OrderBy(m => m.Name)
				.ToList();
		}
	}
}
