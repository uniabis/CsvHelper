using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator.Infos
{
    public class PropertyInfo : Info
    {
		public List<System.Reflection.ParameterInfo> IndexParameters { get; private set; }

		public PropertyInfo(System.Reflection.PropertyInfo propertyInfo, XElement xmlDocs)
		{
			IndexParameters = propertyInfo.GetIndexParameters().ToList();

			Name = propertyInfo.Name;

			FullName = $"{propertyInfo.DeclaringType.FullName}.{Name}";

			if (IndexParameters.Count > 0)
			{
				var parameters = string.Join(",", IndexParameters.Select(p => p.ParameterType.FullName));
				Summary = ParseSummary($"P:{FullName}({parameters})", xmlDocs);
			}
			else
			{
				Summary = ParseSummary($"P:{FullName}", xmlDocs);
			}
		}
    }
}
