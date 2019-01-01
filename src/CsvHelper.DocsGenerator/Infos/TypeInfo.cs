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
	public abstract class TypeInfo : Info
    {
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
				.GetConstructors(BindingFlags.Public | BindingFlags.Instance)
				.Select(c => new ConstructorInfo(c, xmlDocs))
				.OrderBy(c => c.Parameters.Count)
				.ToList();

			Attributes = type
				.GetCustomAttributes()
				.Select(a => a.GetType())
				.OrderBy(t => t.Name)
				.ToList();

			Fields = type
				.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly)
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
