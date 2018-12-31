using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator.Infos
{
    public class ClassInfo : TypeInfo
    {
		public List<Type> Attributes { get; private set; }
			   
		public List<ConstructorInfo> Constructors { get; private set; }

		public Type BaseType { get; private set; }

		public List<Type> Interfaces { get; private set; }

		public List<PropertyInfo> Properties { get; private set; }

		public List<MethodInfo> Methods { get; private set; }

        public ClassInfo(NamespaceInfo namespaceInfo, Type type, XElement xmlDocs) : base(namespaceInfo, type, xmlDocs)
		{
			BaseType = type.BaseType;

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
