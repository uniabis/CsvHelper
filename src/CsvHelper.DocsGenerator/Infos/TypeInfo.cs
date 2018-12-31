using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

		public TypeInfo(NamespaceInfo namespaceInfo, Type type, XElement xmlDocs)
		{
			Name = type.Name;

			FullName = type.FullName;

			Namespace = namespaceInfo;

			Summary = ParseSummary($"T:{type.FullName}", xmlDocs);
		}
    }
}
