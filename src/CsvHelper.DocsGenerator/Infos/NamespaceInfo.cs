using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator.Infos
{
	[DebuggerDisplay("Name = {Name}")]
	public class NamespaceInfo : Info
    {
		public AssemblyInfo Assembly { get; private set; }

		public List<TypeInfo> Types { get; private set; } = new List<TypeInfo>();

		public List<ClassInfo> Classes { get; private set; } = new List<ClassInfo>();

		public List<InterfaceInfo> Interfaces { get; private set; } = new List<InterfaceInfo>();

		public List<EnumInfo> Enums { get; private set; } = new List<EnumInfo>();

        public NamespaceInfo(AssemblyInfo assemblyInfo, string @namespace, List<Type> types, XElement xmlDocs)
		{
			Assembly = assemblyInfo;

			Name = @namespace;

			foreach (var type in types)
			{
				if (type.IsClass)
				{
					var classInfo = new ClassInfo(this, type, xmlDocs);
					Classes.Add(classInfo);
					Types.Add(classInfo);
				}
				else if (type.IsInterface)
				{
					var interfaceInfo = new InterfaceInfo(this, type, xmlDocs);
					Interfaces.Add(interfaceInfo);
					Types.Add(interfaceInfo);
				}
				else if (type.IsEnum)
				{
					var enumInfo = new EnumInfo(this, type, xmlDocs);
					Enums.Add(enumInfo);
					Types.Add(enumInfo);
				}
				else
				{
					throw new InvalidOperationException($"Type '{type.FullName}' has no info class.");
				}
			}
		}
    }
}
