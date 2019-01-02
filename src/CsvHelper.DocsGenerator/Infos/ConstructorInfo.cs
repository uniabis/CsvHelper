using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator.Infos
{
    public class ConstructorInfo : Info
    {
		public List<System.Reflection.ParameterInfo> Parameters { get; private set; }

		public ConstructorInfo(System.Reflection.ConstructorInfo constructorInfo, XElement xmlDocs)
		{
			Name = constructorInfo.DeclaringType.GetName();

			FullName = constructorInfo.DeclaringType.GetFullName();

			Parameters = constructorInfo.GetParameters().ToList();

			var parameters = Parameters.Count > 0 ? $"({string.Join(",", Parameters.Select(p => $"{p.ParameterType.Namespace}.{p.ParameterType.GetTitle()}"))})" : string.Empty;
			Summary = ParseSummary($"M:{constructorInfo.DeclaringType.GetFullName()}.#ctor{parameters}", xmlDocs);
		}
    }
}
