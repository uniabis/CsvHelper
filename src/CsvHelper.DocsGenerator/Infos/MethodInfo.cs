using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator.Infos
{
    public class MethodInfo : Info
    {
		public List<System.Reflection.ParameterInfo> Parameters { get; set; }

		public MethodInfo(System.Reflection.MethodInfo methodInfo, XElement xmlDocs)
		{
			Name = methodInfo.Name;

			FullName = $"{methodInfo.DeclaringType.FullName}.{Name}";

			Parameters = methodInfo.GetParameters().ToList();

			if (Parameters.Count > 0)
			{
				var parameters = string.Join(",", Parameters.Select(p => p.ParameterType.FullName));
				Summary = ParseSummary($"M:{FullName}({parameters})", xmlDocs);
			}
			else
			{
				Summary = ParseSummary($"M:{FullName}", xmlDocs);
			}
		}
	}
}
