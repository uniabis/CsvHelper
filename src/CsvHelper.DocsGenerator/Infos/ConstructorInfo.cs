using System;
using System.Collections.Generic;
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
			Name = constructorInfo.DeclaringType.Name;

			FullName = $"{constructorInfo.DeclaringType.FullName}";

			Parameters = constructorInfo.GetParameters().ToList();

			Summary = ParseSummary($"M:{FullName}.#ctor({string.Join(",", Parameters.Select(p => p.ParameterType.FullName))})", xmlDocs);
		}
    }
}
